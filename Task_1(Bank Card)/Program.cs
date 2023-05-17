using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Code_Academy__1
{
    internal class Program
    {
        class Card
        {
            public long Card_number { get; set; }

            public int CVV { get; set; }


            public string Valid_THRU { get; set; }

            public string Bank { get; set; }

            public string Name { get; set; }

            public string Surname { get; set; }


            public decimal Balance { get; private set; }

            public void ChangeofBalance(decimal sum)
            {
                Balance += sum; // sum eger menfi olsa demeli mexaricdir menfi oldugu ucun toplandigda balance azalir,musbet olduqda ise medaxil olur balance artir
            }
        }





        static void Main(string[] args)
        {
            Card card = new Card();

            card.Surname = "Donald";

            card.Name = "Trump";

            card.Bank = "Bank of America";

            card.CVV = 911;

            card.Card_number = 123320989763234;

            card.Valid_THRU = "05/27";

            card.ChangeofBalance(100000);
        }





    }
}
