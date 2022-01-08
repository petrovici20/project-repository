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
    /// converting class from json to lists 
    /// </summary>
    public class LogList
    {
        // Variables
        private List<Log> logs = new();
        readonly string fileName = AppDomain.CurrentDomain.BaseDirectory + @"..\net5.0\AppData\Logs.json";

        /// <summary>
        /// import the logs from the json file
        /// </summary>
        public LogList()
        {
            logs = ImportJson();
        }

        /// <summary>
        /// returns the log list
        /// </summary>
        public List<Log> Logs { get => logs; private set { } }

        /// <summary>
        /// adding logs method
        /// </summary>
        /// <param name="log"></param>
        public void AddLog(Log log) => logs.Add(log);

        /// <summary>
        /// reads the json file and deserialize it, otherwise throw exeception
        /// </summary>
        /// <returns>a converted list of logs</returns>
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
        /// takes the list and serialize it, otherwise throws exception
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
