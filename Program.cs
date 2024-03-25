namespace MyFirstRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage printMessage = new PrintMessage();
            printMessage.Print();
            printMessage.PrintUpdated("yaqubaliy");
            do
            {
                Console.WriteLine("Hello");
            }
            while (true);

        }
    }
}
