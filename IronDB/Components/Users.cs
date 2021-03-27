using IronDB.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronDB
{
    class Users
    {

        #region C'tor

        public Users(string username, string passwort, string roles)
        {
            this._username = username;
            this._passwort = passwort;
            _roles = new List<Roles>();
            this._roles.Add(new Roles(roles));
        }

        #endregion

        #region Properties

        private string _username;

        private string _passwort;

        private List<Roles> _roles;

        #endregion

        #region Fields

        public string Username { get { return _username; } set { _username = value; } }

        public string Passwort { get { return _passwort; } set { _passwort = value; } }

        public List<Roles> RolesList { get { return _roles; } 
            set 
            {
                _roles = new List<Roles>(value);
            } 
        }

        #endregion

        #region Methods

        #endregion
    }
}
