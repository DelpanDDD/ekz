using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Password
    {
        public static string CheckPass(string password)
        {
            string correct = "все хорошо";
            string error = "все плохо";
            //Длинна
            if (password.Length >= 8 && password.Length <= 20)
            {
                return correct;
            }
            else return error;
        }
    }
}
