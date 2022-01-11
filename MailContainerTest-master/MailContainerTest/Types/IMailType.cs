using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailContainerTest.Types
{
    interface IMailType
    {
        bool IsInValidState(MailContainer mailContainer ,int numberOfMailItems);
    }
}
