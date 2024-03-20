using Proyecto.Models;
using SQLite;

namespace Proyecto.Services
{
    public class TareaService
    {
        private readonly SQLiteConnection _dbConnection;

        public TareaService()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Empleado.db3");
            _dbConnection = new SQLiteConnection(dbPath);
            _dbConnection.CreateTable<Tarea>();
        }

        public List<Tarea> GetAll()
        {
            var res = _dbConnection.Table<Tarea>().ToList();
            return res;
        }

        public int Insert(Tarea tarea)
        {
            return _dbConnection.Insert(tarea);
        }

        public int Update(Tarea tarea)
        {
            return _dbConnection.Update(tarea);
        }

        public int Delete(Tarea tarea)
        {
            return _dbConnection.Delete(tarea);
        }
    }
}
