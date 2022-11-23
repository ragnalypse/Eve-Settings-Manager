using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Eve_Settings_Manager
{
    public partial class frmMain : Form
    {
        private List<SettingsFile> _files;

        public frmMain()
        {
            InitializeComponent();
            
            MessageBox.Show("It is STRONGLY recommended to close ALL instances of the EVE client and the EVE Launcher before using this utility!", "Before You Begin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
            txtDirectory.AllowDrop = true;
            txtDirectory.DragEnter += new DragEventHandler(txtDirectory_DragEnter);
            txtDirectory.DragDrop += new DragEventHandler(txtDirectory_DragDrop);
        }


        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            groupUser.Enabled = false;
            groupCharacter.Enabled = false;
            btnCopy.Enabled = false;
            btnLog.Enabled = false;
        }

        private void txtDirectory_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtDirectory_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (fileList.Length < 1)
                return;

            string fileFolderPath = fileList[0];

            if (File.Exists(fileFolderPath)) //dragging a file?
            {
                fileFolderPath = Path.GetDirectoryName(fileFolderPath);
            }

            txtDirectory.Text = fileFolderPath;
        }

        private void chkUser_CheckedChanged(object sender, EventArgs e)
        {
            cmbUser.Enabled = chkUser.Checked;
            btnCopy.Enabled = chkCharacter.Checked || chkUser.Checked;
        }

        private void chkCharacter_CheckedChanged(object sender, EventArgs e)
        {
            cmbCharacter.Enabled = chkCharacter.Checked;
            btnCopy.Enabled = chkCharacter.Checked || chkUser.Checked;
        }

        private void chkBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBackup.Checked)
                MessageBox.Show("It is STRONGLY recommended to create a backup of your settings files when using this utility. Simply re-check this box in order to have a backup created for you.", "Backup Recommended", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            
            string eve = Path.Combine(appData, "CCP\\EVE");
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;

            if (Directory.Exists(eve))
                fbd.SelectedPath = eve;
            else if (Directory.Exists(appData))
                fbd.SelectedPath = appData;

            if (fbd.ShowDialog(this) != DialogResult.OK)
                return;

            txtDirectory.Text = fbd.SelectedPath;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Program.Logger = new System.Text.StringBuilder();

            groupUser.Enabled = false;
            groupCharacter.Enabled = false;
            btnCopy.Enabled = false;
            btnLog.Enabled = false;

            try
            {
                DirectoryInfo workingDirectory = new DirectoryInfo(txtDirectory.Text);

                if (!workingDirectory.Exists)
                {
                    MessageBox.Show("The specified EVE profile directory doesn't appear to be valid. Please enter the full path to your Eve profile directory", "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                Program.Logger.AppendLine("Reading from directory: " + workingDirectory.FullName);

                cmbUser.Items.Clear();
                cmbCharacter.Items.Clear();

                _files = new List<SettingsFile>();

                foreach (FileInfo file in workingDirectory.GetFiles("core_*.dat", SearchOption.TopDirectoryOnly))
                {
                    SettingsFile thisFile = SettingsFile.InitializeFile(file.FullName);

                    if (thisFile is null)
                        continue;

                    _files.Add(thisFile);
                }

                if (_files.Count == 0)
                {
                    MessageBox.Show("No Eve setting files were found in the specified directory. Please ensure you have the proper profile directory specified.", "Settings Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                _files.Sort((f1, f2) => { return f2.LastModified.CompareTo(f1.LastModified); });

                bool foundUser = false;
                bool foundCharacter = false;

                for (int i = 0; i < _files.Count; i++)
                {
                    switch (_files[i].FileType)
                    {
                        case SettingsFileType.Character:
                            cmbCharacter.Items.Add(_files[i].Details);
                            foundCharacter = true;
                            break;
                        case SettingsFileType.User:
                            cmbUser.Items.Add(_files[i].Details);
                            foundUser = true;
                            break;
                    }
                }

                groupUser.Enabled = foundUser;
                groupCharacter.Enabled = foundCharacter;

                if (foundCharacter)
                    cmbCharacter.SelectedIndex = 0;
                if (foundUser)
                    cmbUser.SelectedIndex = 0;

                btnCopy.Enabled = foundCharacter || foundUser;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnLog.Enabled = true;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            frmLogViewer frm = new frmLogViewer();
            frm.ShowDialog(this);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (chkBackup.Checked)
            {
                if (!_createBackup())
                    return;
            }

            int countUser = 0;
            int countChar = 0;
            bool copyUser = false;
            bool copyChar = false;

            if (chkUser.Checked && cmbUser.SelectedIndex >= 0)
            {
                copyUser = true;
                string sourceUser = cmbUser.SelectedItem as string;

                string id = sourceUser.Substring(0, sourceUser.IndexOf("-"));

                long.TryParse(id, out long userID);

                SettingsFile user = _files.Find(u => u.ID == userID && u.FileType == SettingsFileType.User);
                
                countUser =_createCopies(user);

                if (countUser < 0)
                    return;
            }
            
            if (chkCharacter.Checked && cmbCharacter.SelectedIndex >= 0)
            {
                copyChar = true;
                string sourceChar = cmbCharacter.SelectedItem as string;

                int openPar = sourceChar.LastIndexOf("(");
                int closePar = sourceChar.LastIndexOf(")");
                 
                string id = sourceChar.Substring(openPar + 1, closePar - openPar - 1);

                long.TryParse(id, out long charID);

                SettingsFile @char = _files.Find(u => u.ID == charID && u.FileType == SettingsFileType.Character);

                countChar = _createCopies(@char);

                if (countChar < 0)
                    return;
            }

            if (copyUser && copyChar)
                MessageBox.Show($"Copy is complete! Successfully copied {countUser} user file(s) and {countChar} character file(s).", "Copy Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (copyUser)
                MessageBox.Show($"Copy is complete! Successfully copied {countUser} user file(s).", "Copy Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (copyChar)
                MessageBox.Show($"Copy is complete! Successfully copied {countChar} character file(s).", "Copy Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"There were no files selected to be copied.", "Nothing to Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog(this);
        }


        private bool _createBackup()
        {
            string backupDirectory = Path.Combine(txtDirectory.Text, $"Backup {DateTime.Now.ToString("yyyyMMdd hhmmss")}");

            try
            {
                Directory.CreateDirectory(backupDirectory);

                for (int i = 0; i < _files.Count; i++)
                {
                    string destination = Path.Combine(backupDirectory, _files[i].FileData.Name);

                    File.Copy(_files[i].FileData.FullName, destination);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error creating the backup files, the copy process will be aborted: " + ex.Message, "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        private int _createCopies(SettingsFile sourceFile)
        {
            int copyCount = 0;

            string fileType = sourceFile.FileType.ToString();

            if (sourceFile is null)
            {
                MessageBox.Show("There was an error when preparing to copy. Please check your settings and try again. If the problem persists, please try restarting the program.", $"Invalid {fileType} File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return -1;
            }
            
            string sourcePath = sourceFile.FileData.FullName;
            
            if (!File.Exists(sourcePath))
            {
                MessageBox.Show($"The specified {fileType}'s setting file could not be found. Please check your settings and try again. If the problem persists, please try restarting the program.", $"Invalid {fileType} File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return -1;
            }

            for (int i = 0; i < _files.Count; i++)
            {
                try
                {
                    if (_files[i].FileType != sourceFile.FileType)
                        continue;

                    if (_files[i].ID == sourceFile.ID)
                        continue;

                    try
                    {
                        File.Copy(sourcePath, _files[i].FileData.FullName, true);
                        copyCount++;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show("This utility was denied access to a settings file. Please check that this program has valid permissions and try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return -1;
                    }
                    catch (IOException ex)
                    {
                        System.Threading.Thread.Sleep(250);

                        File.Copy(sourcePath, _files[i].FileData.FullName, true);
                        copyCount++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error attempting to copy a file: " + ex.Message, "File Copy Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return -1;
                }
            }

            return copyCount;
        }

        
    }
}
