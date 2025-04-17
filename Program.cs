using System;
using static modul8_103022300126.BankTransferConfig;
using  modul8_103022300126;

class Program {
    static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        int tf = 0 , fee = 0;

        if (config.config.lang == "lang") {
            Console.WriteLine("please enter the amount of money to transfer:");
            tf = int.Parse(Console.ReadLine());
            if (tf < config.config.transfer.threshold)
            {
                fee = config.config.transfer.low_fee;
                Console.WriteLine($"The transfer fee is {fee}");
            }
            else
            {
                fee = config.config.transfer.high_fee;
                Console.WriteLine($"The transfer fee is {fee}");
            }

            Console.WriteLine("Please type yes to confirm teh transcation");
            string conf = Console.ReadLine();
        }
    }

}