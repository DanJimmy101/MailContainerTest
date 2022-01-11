using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailContainerTest.Types
{
    internal class MailTypeFactory
    {
        public static IMailType getInstance(MailType mailType)
        {
            IMailType mailTypeInstance = null;

            switch (mailType)
            {
                case MailType.StandardLetter:
                    mailTypeInstance = new StandardLetterMailType();
                    break;
                case MailType.LargeLetter:
                    mailTypeInstance = new LargeLetterMailType();
                    break;
                case MailType.SmallParcel:
                    mailTypeInstance = new SmallParcelMailType();
                    break;
            }

            return mailTypeInstance;
        }
    }
}
