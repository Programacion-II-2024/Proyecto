using Proyecto.Models;
using SQLite;

namespace Proyecto.Services
{
    public class TareaService
    {
        private readonly SQLiteAsyncConnection _dbConnection;

        public TareaService()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tarea.db3");
            _dbConnection = new SQLiteAsyncConnection(dbPath);
            _dbConnection.CreateTableAsync<Tarea>().Wait();
        }

        public async Task<List<Tarea>> GetAllTareasAsync()
        {
            return await _dbConnection.Table<Tarea>().ToListAsync();
        }

        public async Task<int> InsertTareaAsync(Tarea tarea)
        {
            return await _dbConnection.InsertAsync(tarea);
        }

        public async Task<int> UpdateTareaAsync(Tarea tarea)
        {
            return await _dbConnection.UpdateAsync(tarea);
        }

        public async Task<int> DeleteTareaAsync(Tarea tarea)
        {
            return await _dbConnection.DeleteAsync(tarea);
        }
    }
}
