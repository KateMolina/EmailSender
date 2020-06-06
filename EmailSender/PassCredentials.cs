using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public static class PassCredentials
    {
        public static string getPassword( string p_sPswd)
        {
            string pass = string.Empty;
            foreach (char a in p_sPswd)
            {
                char ch = a;
                ch--;
                pass += ch;
            }

            return pass;
        }

        public static string getCodedPass(string p_sPasswrd)
        {
            string sCode = string.Empty;
            foreach(char a in p_sPasswrd)
            {
                char ch = a;
                ch++;
                sCode += ch;
            }return sCode;
        }
    }
}
