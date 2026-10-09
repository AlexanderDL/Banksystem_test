using System;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0;
            double belopp = 0;
            string val = "";

            do
            {
                Console.WriteLine("========= BANKSYSTEM =========");
                Console.WriteLine("1. Visa saldo");
                Console.WriteLine("2. Sätt in pengar");
                Console.WriteLine("3. Ta ut pengar");
                Console.WriteLine("4. Kontrollera om du har råd");
                Console.WriteLine("5. Visa kontoinformation");
                Console.WriteLine("6. Avsluta");
                Console.WriteLine("==============================");
                Console.Write("Välj ett alternativ: ");

                val = Console.ReadLine();
                Console.WriteLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine($"Ditt saldo är: {saldo} kr");
                        break;

                    case "2":
                        Console.Write("Hur mycket vill du sätta in? ");
                        belopp = double.Parse(Console.ReadLine());

                        if (belopp > 0)
                        {
                            saldo = saldo + belopp;
                            Console.WriteLine("Insättningen lyckades!");
                            Console.WriteLine($"Ditt nya saldo är: {saldo} kr");
                        }
                        else
                        {
                            Console.WriteLine("Fel! Beloppet måste vara större än noll.");
                        }
                        break;

                    case "3":
                        Console.Write("Hur mycket vill du ta ut? ");
                        belopp = double.Parse(Console.ReadLine());

                        if (belopp > 0)
                        {
                            if (belopp <= saldo)
                            {
                                saldo = saldo - belopp;
                                Console.WriteLine("Uttaget lyckades!");
                                Console.WriteLine($"Ditt nya saldo är: {saldo} kr");
                            }
                            else
                            {
                                Console.WriteLine("Fel! Du har inte tillräckligt med pengar.");
                                Console.WriteLine($"Ditt saldo är: {saldo} kr");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Fel! Beloppet måste vara större än noll.");
                        }
                        break;

                    case "4":
                        Console.Write("Vad kostar varan? ");
                        double varuKostnad = double.Parse(Console.ReadLine());

                        if (saldo >= varuKostnad)
                        {
                            Console.WriteLine("Du har råd att köpa varan!");

                            double pengarKvar = saldo - varuKostnad;
                            Console.WriteLine($"Pengar kvar efter köpet: {pengarKvar} kr");
                        }
                        else
                        {
                            Console.WriteLine("Du har inte råd att köpa varan.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Kontotyp: Privatkonto");
                        Console.WriteLine("Valuta: SEK");
                        Console.WriteLine($"Aktuellt saldo: {saldo} kr");
                        break;

                    case "6":
                        Console.WriteLine("Tack för att du använde banksystemet!");
                        Console.WriteLine("Programmet avslutas.");
                        break;

                    default:
                        Console.WriteLine("Felaktigt val! Välj ett alternativ mellan 1 och 6.");
                        break;
                }

                Console.WriteLine();

            } while (val != "6");
        }
    }
}