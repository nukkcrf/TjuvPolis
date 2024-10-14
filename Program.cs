namespace TjuvPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();

            city.DisplayCity();
            city.MovePeople();
            Thread.Sleep(2000);// vanta 2 sekunder

        }
    }
}
