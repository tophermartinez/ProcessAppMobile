using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAppMobile.Models
{
  public class Empresa
    {
        public int ID { get; set; }
        public int RUT { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO_CONTACTO { get; set; }
        public long TELEFONO_CONTACTO { get; set; }
        public int ESTADO { get; set; }

    }
}
