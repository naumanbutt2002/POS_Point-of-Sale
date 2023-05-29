using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale
{
    internal class loginModel
    {
        private string uName;
        public string UserName
        {
            get { return uName; }
            set
            {
                if (value != null)
                    uName = value;
            }
        }

        private string pass;
        public string Password
        {
            get { return pass; }
            set
            {
                if (value != null)
                    pass = value;
            }
        }
       public string hint { get; set; }
       public string Designation { get; set; }
       public int UserID { get; set; }
    }
}
