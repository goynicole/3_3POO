using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    public class Bank_account
    {
        public String holder;
        private String currency = "euros";
        public Double balance;

        public string Currency { get => currency; set {
                if (value == "dollars")
                { currency = value; }
            }
        }

        /// <summary>
        /// Le constructeur nous permet d'hydrater l'objet lors de sa création.
        /// </summary>
        /// <param name="_holder"> Nom du propriétaire du compte.</param>
        /// <param name="_currency">Devise du compte</param>
        /// <param name="_balance">Solde actuel du compte</param>
        public Bank_account(String _holder, String _currency, Double _balance)
        {
            holder = _holder;
            Currency = _currency;
            balance = _balance;
        }
        /// <summary>
        /// Cette méthode permet de créditer le compte bancaire
        /// </summary>
        /// <param name="amount">C'est le montant en euros à créditer</param>
        public void credit(double amount)
        {
            // "this" evite les confusions lors du choix des var
            this.balance = this.balance + amount;            
        }

        public void debit(double amount)
        {
            this.balance = this.balance - amount;
        }
    }
}
