using MAUI_Aeropuertos.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Aeropuertos.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Airport>().Wait();
        }

        public Task<List<Airport>> GetAeropuertosAsync()
        {
            return _database.Table<Airport>().ToListAsync();
        }

        public Task<int> SaveAeropuertoAsync(Airport aeropuerto)
        {
            return _database.InsertAsync(aeropuerto);
        }

        public Task<int> DeleteAeropuertoAsync(Airport aeropuerto)
        {
            return _database.DeleteAsync(aeropuerto);
        }
    }
}
