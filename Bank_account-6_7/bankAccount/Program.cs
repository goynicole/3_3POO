using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création de l'objet avec le constructeur new + On va hydrater l'objet
            Bank_account bank = new Bank_account("Gaetan", "euros", 20000);
            bank.Currency = "yen";
            Console.WriteLine("Bonjour monsieur, " + bank.holder + " le solde de votre compte est de " + bank.balance + bank.Currency);
            bank.credit(1000);
            Console.WriteLine("Le nouveau solde de votre compte est de : " + bank.balance);
            Console.ReadKey();

        }
    }
}
