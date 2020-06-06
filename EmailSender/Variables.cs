using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public static class Variables
    {
        private static Dictionary<string, string> dicSenders = new Dictionary<string, string>(){ { "malinaraspberry888@gmail.com", PassCredentials.getPassword("1234l;i") }};

        public static Dictionary<string, string> Senders { get { return dicSenders; } }

    }
}
