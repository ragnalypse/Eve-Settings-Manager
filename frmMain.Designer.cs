namespace Eve_Settings_Manager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.groupUser = new System.Windows.Forms.GroupBox();
            this.chkUser = new System.Windows.Forms.CheckBox();
            this.groupCharacter = new System.Windows.Forms.GroupBox();
            this.chkCharacter = new System.Windows.Forms.CheckBox();
            this.cmbCharacter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBackup = new System.Windows.Forms.CheckBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupUser.SuspendLayout();
            this.groupCharacter.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopy.Location = new System.Drawing.Point(629, 332);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(101, 84);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy Settings";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttMain.SetToolTip(this.btnCopy, "Click to begin copying the settings files.");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User File to Copy:";
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(20, 73);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(267, 21);
            this.cmbUser.TabIndex = 3;
            this.ttMain.SetToolTip(this.cmbUser, "Select a user account in the list here to serve as the source to copy settings fr" +
        "om.");
            // 
            // groupUser
            // 
            this.groupUser.Controls.Add(this.chkUser);
            this.groupUser.Controls.Add(this.cmbUser);
            this.groupUser.Controls.Add(this.label1);
            this.groupUser.Enabled = false;
            this.groupUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupUser.Location = new System.Drawing.Point(20, 34);
            this.groupUser.Name = "groupUser";
            this.groupUser.Size = new System.Drawing.Size(297, 113);
            this.groupUser.TabIndex = 5;
            this.groupUser.TabStop = false;
            this.groupUser.Text = "Copy User Settings";
            // 
            // chkUser
            // 
            this.chkUser.AutoSize = true;
            this.chkUser.Checked = true;
            this.chkUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUser.Location = new System.Drawing.Point(20, 26);
            this.chkUser.Name = "chkUser";
            this.chkUser.Size = new System.Drawing.Size(241, 17);
            this.chkUser.TabIndex = 6;
            this.chkUser.Text = "Check this box to copy user account settings.";
            this.chkUser.UseVisualStyleBackColor = true;
            this.chkUser.CheckedChanged += new System.EventHandler(this.chkUser_CheckedChanged);
            // 
            // groupCharacter
            // 
            this.groupCharacter.Controls.Add(this.chkCharacter);
            this.groupCharacter.Controls.Add(this.cmbCharacter);
            this.groupCharacter.Controls.Add(this.label2);
            this.groupCharacter.Enabled = false;
            this.groupCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCharacter.Location = new System.Drawing.Point(323, 34);
            this.groupCharacter.Name = "groupCharacter";
            this.groupCharacter.Size = new System.Drawing.Size(389, 113);
            this.groupCharacter.TabIndex = 7;
            this.groupCharacter.TabStop = false;
            this.groupCharacter.Text = "Copy Character Settings";
            // 
            // chkCharacter
            // 
            this.chkCharacter.AutoSize = true;
            this.chkCharacter.Checked = true;
            this.chkCharacter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCharacter.Location = new System.Drawing.Point(20, 26);
            this.chkCharacter.Name = "chkCharacter";
            this.chkCharacter.Size = new System.Drawing.Size(224, 17);
            this.chkCharacter.TabIndex = 6;
            this.chkCharacter.Text = "Check this box to copy character settings.";
            this.chkCharacter.UseVisualStyleBackColor = true;
            this.chkCharacter.CheckedChanged += new System.EventHandler(this.chkCharacter_CheckedChanged);
            // 
            // cmbCharacter
            // 
            this.cmbCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacter.FormattingEnabled = true;
            this.cmbCharacter.Location = new System.Drawing.Point(20, 73);
            this.cmbCharacter.Name = "cmbCharacter";
            this.cmbCharacter.Size = new System.Drawing.Size(361, 21);
            this.cmbCharacter.TabIndex = 3;
            this.ttMain.SetToolTip(this.cmbCharacter, "Select a character in the list here to serve as the source to copy settings from." +
        "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Character File to Copy:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(12, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 84);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttMain.SetToolTip(this.btnExit, "Click to exit this program.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLog);
            this.groupBox3.Controls.Add(this.btnRead);
            this.groupBox3.Controls.Add(this.btnBrowse);
            this.groupBox3.Controls.Add(this.txtDirectory);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(718, 118);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 1: Specify EVE Directory";
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(20, 82);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(87, 24);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read Files";
            this.ttMain.SetToolTip(this.btnRead, "Click to read all valid settings files in the specified directory above.");
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(629, 43);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.ttMain.SetToolTip(this.btnBrowse, "Click to browse to your EVE profile directory.");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.Location = new System.Drawing.Point(20, 45);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(602, 20);
            this.txtDirectory.TabIndex = 2;
            this.ttMain.SetToolTip(this.txtDirectory, "Specify the location of your EVE profile here. You may also drag and drop the dir" +
        "ectory here.");
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter EVE Client Profile Directory:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupUser);
            this.groupBox1.Controls.Add(this.groupCharacter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 160);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2: Select Settings to Copy";
            // 
            // chkBackup
            // 
            this.chkBackup.AutoSize = true;
            this.chkBackup.Checked = true;
            this.chkBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBackup.Location = new System.Drawing.Point(501, 397);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(97, 17);
            this.chkBackup.TabIndex = 10;
            this.chkBackup.Text = "Create Backup";
            this.ttMain.SetToolTip(this.chkBackup, "Check this box to have the utility create a backup of all settings files prior to" +
        " overwritting.");
            this.chkBackup.UseVisualStyleBackColor = true;
            this.chkBackup.CheckedChanged += new System.EventHandler(this.chkBackup_CheckedChanged);
            // 
            // btnLog
            // 
            this.btnLog.Enabled = false;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(113, 82);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(87, 24);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "View Log";
            this.ttMain.SetToolTip(this.btnLog, "Click to view the results of the last read attempt.");
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbout.Location = new System.Drawing.Point(125, 332);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(101, 84);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "Help";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttMain.SetToolTip(this.btnAbout, "Click to exit this program.");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 428);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.chkBackup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Eve Settings Manager";
            this.groupUser.ResumeLayout(false);
            this.groupUser.PerformLayout();
            this.groupCharacter.ResumeLayout(false);
            this.groupCharacter.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.GroupBox groupUser;
        private System.Windows.Forms.CheckBox chkUser;
        private System.Windows.Forms.GroupBox groupCharacter;
        private System.Windows.Forms.CheckBox chkCharacter;
        private System.Windows.Forms.ComboBox cmbCharacter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBackup;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.Button btnAbout;
    }
}

