using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using VehicleManager.Models;

namespace VehicleManager.AppData
{
    /// <summary>
    /// 
    /// </summary>
    public class LogList
    {
        // Variables
        private List<Log> logs = new();
        readonly string fileName = AppDomain.CurrentDomain.BaseDirectory + @"..\net5.0\AppData\Logs.json";

        /// <summary>
        /// 
        /// </summary>
        public LogList()
        {
            logs = ImportJson();
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Log> Logs { get => logs; private set { } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        public void AddLog(Log log) => logs.Add(log);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Log> ImportJson()
        {
            try
            {
                if (!File.Exists(fileName)) File.WriteAllText(fileName, "[]");

                string jsonString = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<List<Log>>(jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logs"></param>
        private void ExportJson(List<Log> logs)
        {
            try
            {
                File.Delete(fileName);

                using FileStream createStream = File.OpenWrite(fileName);
                JsonSerializer.SerializeAsync(createStream, logs);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
