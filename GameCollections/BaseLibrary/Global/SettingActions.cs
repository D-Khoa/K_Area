using Newtonsoft.Json;
using System;
using System.IO;

namespace BaseLibrary.Global
{
    public class SettingActions
    {
        public void SaveSettings(string filePath)
        {
            var folderPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (var sw = File.CreateText(filePath))
            {
                try
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Serialize(sw, GlobalSettings.Options);
                }
                catch (Exception ex)
                {
                    throw new Exception($"{Properties.Settings.Default.E0001}\n{ex.Message}");
                }
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
        }

        public void LoadSettings(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }
            using (var sr = File.OpenText(filePath))
            {
                try
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    GlobalSettings global = (GlobalSettings)jsonSerializer.Deserialize(sr, typeof(GlobalSettings));
                    GlobalSettings.Options.SetOptions(global);
                }
                catch(Exception ex)
                {
                    throw new Exception($"{Properties.Settings.Default.E0002}\n{ex.Message}");
                }
                sr.Close();
                sr.Dispose();
            }
        }
    }
}
