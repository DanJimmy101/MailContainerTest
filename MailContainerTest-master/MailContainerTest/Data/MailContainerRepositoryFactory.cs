using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailContainerTest.Data
{
    internal class MailContainerRepositoryFactory
    {
        public static IMailContainerDataStoreRepository getInstance(String? dataStoreType)
        {
            IMailContainerDataStoreRepository repository;

            switch (dataStoreType)
            {
                case "Backup":
                    repository = new BackupMailContainerDataStore();
                    break;
                default:
                    repository = new MailContainerDataStore();
                    break;
            }

            return repository;
        }
    }
}
