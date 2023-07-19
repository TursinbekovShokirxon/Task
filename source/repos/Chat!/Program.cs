namespace Chat_
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }
    public delegate void Sending(string message);
    public class SendMessage
    {
        public Sending Sender;
        public SendMessage()
        {
            Sender += SendI;
        }
        public void SendI(string message)
        {
            Sender.Invoke(message);
        }
    }
}