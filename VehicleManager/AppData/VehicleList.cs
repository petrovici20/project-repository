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
    public class VehicleList
    {
        // Variables
        private List<Vehicle> vehicles = new();
        readonly string fileName = AppDomain.CurrentDomain.BaseDirectory + @"..\net5.0\AppData\Vehicles.json";

        /// <summary>
        /// 
        /// </summary>
        public VehicleList()
        {
            vehicles = ImportJson();
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Vehicle> Vehicles { get => vehicles; private set { } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicles"></param>
        public void AddVehicleList(List<Vehicle> vehicles)
        {
            foreach(Vehicle vehicle in vehicles)
            {
                vehicles.Add(vehicle);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        public void AddVehicle(Vehicle vehicle) => vehicles.Add(vehicle);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Vehicle> ImportJson()
        {
            try
            {
                if (!File.Exists(fileName)) File.WriteAllText(fileName, "[]");

                string jsonString = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<List<Vehicle>>(jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicles"></param>
        private void ExportJson(List<Vehicle> vehicles)
        {
            try
            {
                File.Delete(fileName);

                using FileStream createStream = File.OpenWrite(fileName);
                JsonSerializer.SerializeAsync(createStream, vehicles);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
