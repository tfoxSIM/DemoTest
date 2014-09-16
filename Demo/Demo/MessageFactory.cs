namespace Demo
{
    public class MessageFactory : IMessageFactory
    {
        public string GetGreeting(string name)
        {
            return string.Format("Hello {0}", name);
        }

        public string GetGoodbye(string name)
        {
            return string.Format("Goodbye {0}", name);
        }
    }
}
