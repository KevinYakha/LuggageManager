namespace LuggageManager
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            LuggageFacade sendMyLuggage = new LuggageFacade();
            sendMyLuggage.sendLuggage();

            Console.ReadKey();
        }
    }
}