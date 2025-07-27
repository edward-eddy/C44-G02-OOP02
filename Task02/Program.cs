using Task02.Classes;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class01 class01 = new Class01();
            Class02 class02 = new Class02();

            class01.InternalProtected = 13;
            class02.InternalProtected = 12;

        }
    }
}
