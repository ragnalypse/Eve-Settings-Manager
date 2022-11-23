using System;
using System.IO;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Eve_Settings_Manager
{
    public sealed class CharacterFile : SettingsFile
    {
        public const string FilePrefix = "core_char_";

        public override SettingsFileType FileType => SettingsFileType.Character;

        public string CharacterName { get; private set; }
        
        

        public CharacterFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Program.Logger.AppendLine($"Invalid character file was specified: {filePath}");
                return;
            }

            try
            {
                FileData = new FileInfo(filePath);

                string fileName = Path.GetFileNameWithoutExtension(filePath);

                string id = fileName.Replace(FilePrefix, string.Empty);

                if (string.IsNullOrWhiteSpace(id))
                {
                    Program.Logger.AppendLine($"Character ID could not be parsed: {filePath}");
                    return;
                }

                ID = long.Parse(id);
                LastModified = FileData.LastWriteTime;

                CharacterName = _getCharacterName();

                Program.Logger.AppendLine("Parsed character file: " + ID);
            }
            catch (Exception ex)
            {
                Program.Logger.AppendLine($"Error initializing character file ({filePath}): {ex.Message}");
            }
        }


        public override string Details
        {
            get
            {
                return $"{CharacterName} ({ID}) - Modified: {LastModified.ToString("MM/dd/yyyy hh:mm:ss")}";
            }
        }

        private string _getCharacterName()
        {
            string resource = $"latest/characters/{ID}?datasource=tranquility";

            try
            {
                RestRequest request = new RestRequest(resource, Method.GET);

                RestClient client = new RestClient("https://esi.evetech.net/");
                
                IRestResponse response = client.Execute(request);

                JObject payload = JObject.Parse(response.Content);

                if (payload is null)
                {
                    Program.Logger.AppendLine($"No response for name request for ({ID})");
                    return "Unknown";
                }

                JToken name = payload.SelectToken("name");

                if (name is null)
                {
                    Program.Logger.AppendLine($"Name not found for ({ID})");
                    return "Unknown";
                }

                return name.ToString();
                
            }
            catch (Exception ex)
            {
                Program.Logger.AppendLine($"Error retrieving name for ({ID}): {ex.Message}");
                return "Unknown";
            }
        }
    }
}
