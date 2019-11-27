using System;
using System.Collections;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        private static Bancomat _bankomat;

        static void Main(string[] args)
        {
            _bankomat = new Bancomat();
            Write(160, CurrencyType.Ruble);
            Write(165, CurrencyType.Ruble);
            Write(160, CurrencyType.Dollar);
            Write(165, CurrencyType.Dollar);
            Write(5, CurrencyType.Eur);
        }

        private static void Write(int value, CurrencyType type)
        {
            var banknotes = new List<IBanknote>() as IList<IBanknote>;
            try
            {
                banknotes = _bankomat.CashOut(value, type);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            foreach (var banknote in banknotes)
            {
                Console.WriteLine(banknote.Value + " " + banknote.Currency);
            }
        }
    }
}