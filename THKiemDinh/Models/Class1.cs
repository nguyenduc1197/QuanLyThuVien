using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THKiemDinh.Models
{
   public class Class1
    {
        public static string VerifyAccount(string username, string password)
        {
            ACCOUNT acc;
            string message = "";
            using (var db = new Model1())
            {
                acc = db.ACCOUNTs.Where(m => m.username == username)
                    .FirstOrDefault();
                if (acc == null)
                    message = "Account not exists";
                else if (acc != null && acc.password != password)
                    message = "Wrong password";
                else if (acc != null && acc.password == password)
                    message = "Succesfull";
            }
            return message;
        }
    }
}
