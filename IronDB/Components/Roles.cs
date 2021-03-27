using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronDB.Components
{
    public class Roles
    {
        private string _rol;

        public string Rol { get { return _rol; } set { _rol = value; } }

        public Roles(string rol)
        {
            this.Rol = rol;
        }
    }
}
