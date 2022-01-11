using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailContainerTest.Types
{
    internal class LargeLetterMailType : IMailType
    {
        public bool IsInValidState(MailContainer mailContainer, int numberOfMailItems)
        {
            if (mailContainer == null)
            {
                return false;
            }
            else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.LargeLetter))
            {
                return false;
            }
            else if (mailContainer.Capacity < numberOfMailItems)
            {
                return false;
            }
            return true;
        }
    }
}
