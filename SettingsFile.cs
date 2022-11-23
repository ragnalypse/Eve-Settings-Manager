using System;
using System.IO;

namespace Eve_Settings_Manager
{
    public abstract class SettingsFile
    {
        public FileInfo FileData { get; protected set; }
        
        public long ID { get; protected set; }

        public abstract SettingsFileType FileType { get; }

        public DateTime LastModified { get; protected set; }

        public abstract string Details { get; }


        public static SettingsFile InitializeFile(string filePath)
        {
            if (filePath.Contains("core_char__.dat")) //filter out known misc files
                return null;
            if (filePath.Contains("core_user__.dat"))
                return null;
            if (filePath.Contains("core_char_('char', None, 'dat').dat"))
                return null;

            if (filePath.Contains(CharacterFile.FilePrefix))
            {
                return new CharacterFile(filePath);
            }

            if (filePath.Contains(UserFile.FilePrefix))
            {
                return new UserFile(filePath);
            }

            Program.Logger.AppendLine($"Invalid file specified: {filePath}");
            return null;
        }
        
    }


    public enum SettingsFileType
    {
        Character,
        User
    }
}
