using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_User
    {
        public BE_User()
        {
        }

        public BE_User(string id_employee, string id_area, string name_user, string language_user, bool blocked_user)
        {
            this.id_employee = id_employee;
            this.id_area = id_area;
            this.name_user = name_user;
            this.language_user = language_user;
            this.blocked_user = blocked_user;
        }

        public BE_User(string id_employee, string id_area, string name_user, string password_user, string language_user, bool blocked_user)
        {
            this.id_employee = id_employee;
            this.id_area = id_area;
            this.name_user = name_user;
            this.password_user = password_user;
            this.language_user = language_user;
            this.blocked_user = blocked_user;
        }

        public  string id_employee { get; set; }
        public  string id_area { get; set; }
        public  string name_user { get; set; }
        public string password_user { get; set; }
        public  string language_user { get; set; }
        public  bool blocked_user { get; set; }
    }
}
