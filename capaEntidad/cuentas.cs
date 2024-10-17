using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace capaEntidad
{
    public class cuentas
    {
        public int IdCuenta { get; set; }
        public trabajador Otrabajador { get; set; }
        public string nombre { get; set; }
        public int contraseña { get; set; }
    }
}
