using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAppMobile.Models
{
    public class Tarea
    {
        public int IDTAREA { get; set; }
        public string NOMBRETAREA { get; set; }
        public DateTime FECHACREACION { get; set; }
        public int ESTADO_TAREA { get; set; }

        public DateTime FECHA_ACTUAL { get; set; }

    }
}
