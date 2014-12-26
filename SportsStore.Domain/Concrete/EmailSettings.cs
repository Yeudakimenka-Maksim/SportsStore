namespace SportsStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string FileLocation = @"c:\sports_store_emails";
        public string MailFromAddress = "sportsstore@example.com";
        public string MailToAddress = "orders@example.com";
        public string Password = "MySmtpPassword";
        public string ServerName = "smtp.example.com";
        public int ServerPort = 587;
        public string Username = "MySmtpUsername";
        public bool UseSsl = true;
        public bool WriteAsFile = false;
    }
}