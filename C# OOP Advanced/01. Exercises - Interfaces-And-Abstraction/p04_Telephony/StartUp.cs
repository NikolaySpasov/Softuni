namespace p04_Telephony
{
    using System;
    using p04_Telephony.Models;

    public class StartUp
    {
        public static void Main()
        {
            string[] callNumbers = Console.ReadLine().Split();//(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] urlAddresses = Console.ReadLine().Split();//(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Smartphone phone = new Smartphone();

            foreach (string number in callNumbers)
            {
                Console.WriteLine(phone.Call(number));
            }

            foreach (string url in urlAddresses)
            {
                Console.WriteLine(phone.Browse(url));
            }

        }
    }
}
