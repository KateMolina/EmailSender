using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodePasswordDLL;

namespace EmailSender
{
    public static class Variables
    {
        private static Dictionary<string, string> dicSenders = new Dictionary<string, string>(){ { "malinaraspberry888@gmail.com", CodePassword.getPassword("#Purple55") }};

        public static Dictionary<string, string> Senders { get { return dicSenders; } }

        private static Dictionary<string, int> dicSmtp = new Dictionary<string, int>() { { "smtp.gmail.com", 587 }, { "smtp.yandex.ru", 25 } };

        public static Dictionary<string, int> SmtpServers { get { return dicSmtp; } }

    }
}
