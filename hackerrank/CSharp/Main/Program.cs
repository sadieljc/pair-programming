using Main.SherlockAndArray;

namespace Main
{
    public class Program
    {
        private const string Path = "..\\..\\SherlockAndArray\\TestCase3_oneLine.txt";

        static void Main(string[] args)
        {
            var service = new SherlockAndArrayService();
            service.Execute(Path);
        }
    }
}


