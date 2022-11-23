using System;
using System.IO;

namespace Eve_Settings_Manager
{
    public sealed class UserFile : SettingsFile
    {
        public const string FilePrefix = "core_user_";

        public override SettingsFileType FileType => SettingsFileType.User;
        

        public UserFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Program.Logger.AppendLine($"Invalid user file was specified: {filePath}");
                return;
            }

            try
            {
                FileData = new FileInfo(filePath);

                string fileName = Path.GetFileNameWithoutExtension(filePath);

                string id = fileName.Replace(FilePrefix, string.Empty)?.Replace(".dat", string.Empty);

                if (string.IsNullOrWhiteSpace(id))
                {
                    Program.Logger.AppendLine($"User ID could not be parsed: {filePath}");
                    return;
                }

                ID = long.Parse(id);
                LastModified = FileData.LastWriteTime;

                Program.Logger.AppendLine("Parsed user file: " + ID);
            }
            catch (Exception ex)
            {
                Program.Logger.AppendLine($"Error initializing user file ({filePath}): {ex.Message}");
            }
        }


        public override string Details
        {
            get
            {
                return $"{ID} - Modified: {LastModified.ToString("MM/dd/yyyy hh:mm:ss")}";
            }
        }
    }
}
