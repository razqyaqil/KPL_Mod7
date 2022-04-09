
using System;

namespace modul7_1302202072 // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {

            BankTransferConfig config = new BankTransferConfig();

            int transfer = 0;
            string lang = config.lang;
            switch (lang)
            {
                case "en":
                    Console.Write("Please insert the amount of money to transfer : ");
                    transfer = Convert.ToInt32(Console.ReadLine());

                    int fee = 0;
                    if (transfer > config.transferThreshold)
                    {
                        fee = config.highfee;


                    }
                    else if (transfer <= config.transferThreshold)
                    {
                        fee = config.lowfee;
                    }

                    int biayaTf = transfer + fee;
                    Console.WriteLine("Total amount: {0}", biayaTf);

                    Console.WriteLine("Select Transfer Method");
                    int i = 1;
                    foreach (string metod in config.metod)
                    {

                        Console.WriteLine("{0} {1}", i, metod);
                        i++;
                    }
                    string methodPilihan = Console.ReadLine();

                    Console.WriteLine("Please type {0}", config.confirm[lang]);
                    string confirm = Console.ReadLine();

                    if (confirm == config.confirm[lang].ToString())
                    {
                        Console.WriteLine("The transfer is complete");
                    }
                    else
                    {
                        Console.WriteLine("Transfer is Canceled");
                    }

                    break;

                case "id":
                    Console.Write("Masukan jumlah uang yang ingin di transfer : ");
                    transfer = Convert.ToInt32(Console.ReadLine());
                    fee = 0;
                    if (transfer > config.transferThreshold)
                    {
                        fee = config.highfee;


                    }
                    else if (transfer <= config.transferThreshold)
                    {
                        fee = config.lowfee;
                    }

                    biayaTf = transfer + fee;
                    Console.WriteLine("Total biaya: {0}", biayaTf);

                    Console.WriteLine("Select Transfer Method");
                    i = 1;
                    foreach (string metod in config.metod)
                    {

                        Console.WriteLine("{0} {1}", i, metod);
                        i++;
                    }
                    methodPilihan = Console.ReadLine();

                    Console.WriteLine("Ketik {0}", config.confirm[lang]);
                    confirm = Console.ReadLine();

                    if (confirm == config.confirm[lang].ToString())
                    {
                        Console.WriteLine("Proses transfer berhasil");
                    }
                    else
                    {
                        Console.WriteLine("Transfer dibatalkan");
                    }

                    break;
                    
            }







        }
    }
}