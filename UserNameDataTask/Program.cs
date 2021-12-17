using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi: ");
            string userName = (Console.ReadLine());
            Console.WriteLine("sisesta arv 1 kuni 3-ni");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            switch (UserNumber)
            {
                case 1:
                    GetUserNameData1(userName);
                    break;
                case 2:
                    GetUserNameData2(userName);
                    break;
                case 3:
                    GetUserNameData3(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva");
                    break;
            }

        }
        public static void GetUserNameData1(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void GetUserNameData2(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }
        public static void GetUserNameData3(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
    }
}
    

