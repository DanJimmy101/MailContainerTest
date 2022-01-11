using MailContainerTest.Data;
using MailContainerTest.Types;
using System.Configuration;

namespace MailContainerTest.Services
{
    public class MailTransferService : IMailTransferService
    {
        public MakeMailTransferResult MakeMailTransfer(MakeMailTransferRequest request)
        {
            var dataStoreType = ConfigurationManager.AppSettings["DataStoreType"];

            IMailContainerDataStoreRepository mailContainerDataStore = MailContainerRepositoryFactory.getInstance(dataStoreType);

            MailContainer mailContainer = mailContainerDataStore.GetMailContainer(request.SourceMailContainerNumber);
           
            var result = new MakeMailTransferResult();

            IMailType mailType = MailTypeFactory.getInstance(request.MailType);

            result.Success = mailType.IsInValidState(mailContainer, request.NumberOfMailItems);

            if (result.Success)
            {
                mailContainer.UpdateCapacity(request.NumberOfMailItems);

                mailContainerDataStore.UpdateMailContainer(mailContainer);
            }

            return result;
        }
    }
}
