using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEclinicSystem
{
    class Receptionist : Staff
    {

        private string loginID;
        private string password;

        public string LoginID
        {
            get
            {
                return loginID;
            }

            set
            {
                loginID = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

    }
}
