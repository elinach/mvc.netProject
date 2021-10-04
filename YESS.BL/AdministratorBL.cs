using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YESS.BE;
using YESS.DAL;

namespace YESS.BL
{
    public class AdministratorBL
    {
        public MYUSER AdministratorblAuthentication(string userName, string password)
        {
            AdministratorDAL administratorDAL = new AdministratorDAL();
            return administratorDAL.AdministratorAuthentication(userName, password);
        }


        public bool CheckUserNameAdministrator(string userName)
        {
            AdministratorDAL administratorDAL = new AdministratorDAL();
            return administratorDAL.CheckUserNameAdministrator(userName);
        }
    }
}
