using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic_Management_System
{
    class CLS_ServerSettings
    {
        public bool TestConnection(string ServerName , string UserName , string Password , bool ISWinAuth)
        {
            Connection conn = new Connection(ServerName , UserName , Password , ISWinAuth);
            bool temp = conn.OpenConnection();
            conn.CloseConnection();
            return temp;
        }
    }
}
