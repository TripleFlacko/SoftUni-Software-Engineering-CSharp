using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender)
        {
            var mail = Inbox.FirstOrDefault(x => x.Sender == sender);
            if (mail != null)
            {
                Inbox.Remove(mail);
                return true;
            }
            return false;
        }
        public int ArchiveInboxMessages()
        {
            var count = 0;
            foreach (var mail in Inbox)
            {
                Archive.Add(mail);
                count++;
            }
            Inbox.Clear();
            return count;
        }
        public string GetLongestMessage()
        {
            return Inbox.OrderByDescending(x => x.Body.Length).First().ToString();
        }
        public string InboxView()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (var mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
