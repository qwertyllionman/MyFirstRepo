namespace MyFirstRepo
{
    internal static class PrintMessageUpdated
    {
        public static void PrintUpdated(this PrintMessage printMessage, string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
