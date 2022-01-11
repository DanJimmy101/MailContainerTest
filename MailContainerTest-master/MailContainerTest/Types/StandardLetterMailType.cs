using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailContainerTest.Types
{
    internal class StandardLetterMailType : IMailType
    {
        public bool IsInValidState(MailContainer mailContainer, int numberOfMailItems)
        {
            if (mailContainer == null)
            {
                return false;
            }
            else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.StandardLetter))
            {
                return false;
            }
            return true;
        }
    }
}
