namespace MailContainerTest.Types
{
    public class MailContainer
    {
        public MailContainer()
        {

        }
        public MailContainer(string mailContainerNumber, int capacity, MailContainerStatus status, AllowedMailType allowedMailType)
        {
            this.MailContainerNumber = mailContainerNumber;
            this.Capacity = capacity;   
            this.Status = status;   
            this.AllowedMailType = allowedMailType;
        }
        public string MailContainerNumber { get; } 
        public int Capacity { get; private set; }
        public MailContainerStatus Status { get; }
        public AllowedMailType AllowedMailType { get; }

        public void UpdateCapacity(int numberOfMailItems)
        {
            this.Capacity -= numberOfMailItems;
        }

    }
}
