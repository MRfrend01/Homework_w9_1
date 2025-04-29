namespace Homework_w9_1
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
        
        }
    }
    public class VATCalculator
    {
        private double vatRate = 0.2; // Default 20%

        public void SetVATValue(double rate)
        {
            vatRate = rate / 100;
        }

        public double FindVATFromPrice(double price)
        {
            return Math.Round(price * vatRate, 2);
        }

        public double FindPrice(bool isWithTax, double amount)
        {
            if (isWithTax)
            {
                // Return price without tax
                return Math.Round(amount / (1 + vatRate), 2);
            }
            else
            {
                // Return price with tax
                return Math.Round(amount * (1 + vatRate), 2);
            }
        }

        public double FindPriceBasedOnTax(double taxAmount)
        {
            return Math.Round(taxAmount / vatRate, 2);
        }

        public bool IsTaxPercent20()
        {
            return Math.Abs(vatRate - 0.2) < 0.0001;
        }
    }
}