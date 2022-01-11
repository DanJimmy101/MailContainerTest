using MailContainerTest.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailContainerTest.Data
{
    interface IMailContainerDataStoreRepository
    {
        MailContainer GetMailContainer(string mailContainerNumber);
        void UpdateMailContainer(MailContainer mailContainer);

    }
}
