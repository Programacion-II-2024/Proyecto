using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Models
{
        public enum EstadoTareaEnum
    {
        SinIniciar,
        EnProceso,
        Finalizado
    }

    public class Tarea
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public EstadoTareaEnum EstadoTarea { get; set; }

            }
}
