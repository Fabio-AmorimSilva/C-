using System;

namespace calculateTax
{
    class Program
    {

        /// <summary>
        /// Receives an amount and a region code to calculate the values of tax by
        /// region
        /// </summary>
        /// <param name="amount">Amount of money spended</param>
        /// <param name="RegionCode">Two letter code which indicates the region 
        /// for caculate the tax</param>
        /// <returns>The amount x rate by region</returns>
        static decimal calculateTax(decimal amount, string RegionCode){

            decimal rate = 0.0M;

            switch(RegionCode){
                case "CH": //Switzerland
                    rate = 0.08M;
                break;
                case "DK": //Denmark
                case "NO": //Norway
                    rate = 0.25M;
                break;
                case "GB": //United Kingdom
                case "FR": //France
                    rate = 0.2M;
                break;
                case "HU": //Hungray
                    rate = 0.27M;
                break;
                case "OR": //Oregon
                case "AK": //Alaska
                case "MT": //Montana
                    rate = 0.0M;
                break;
                case "ND": //Noth Dakota
                case "WI": //Wisconsin
                case "ME": //Maryland
                case "VA": //Virginia
                    rate = 0.05M;
                break;
                case "CA": //California
                    rate = 0.0825M;
                break;
                default: //most US states
                    rate = 0.06M;
                break;
                    
            }

            return amount * rate;
        }

        /// <summary>
        /// Makes the user insert the amount value and two letter code for the caculus of taxes
        /// </summary>
        static void RunSalesTax(){
            Console.WriteLine("Enter an amount: ");
            string amountInText = Console.ReadLine();

            Console.WriteLine("Enter a two-letter region code: ");
            string region = Console.ReadLine();

            if(decimal.TryParse(amountInText, out decimal amount)){
                decimal taxToPay = calculateTax(amount, region);
                Console.WriteLine($"You must pay {taxToPay} in sales tax.");

            }else {
                Console.WriteLine("You did not enter a valid amount!");

            }

        }

        static void Main(string[] args)
        {

            RunSalesTax();

        }
    }
}
