namespace Homework_w9
{
    internal class Program
{
    private static void Main(string[] args)
    {
 
    }
}

    public class Cat
    {
        public bool CatIsPlaying(bool isSummer, int temp)
        {
            if (isSummer)
            {
                return temp >= 25 && temp <= 45;
            }
            else
            {
                return temp >= 25 && temp <= 35;
            }
        }
    }
}