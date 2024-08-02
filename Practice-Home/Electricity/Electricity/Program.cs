namespace Electricity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Units, Amount;

            Console.WriteLine("Enter the Electricity Unit: ");
            Units = Convert.ToInt32(Console.ReadLine());

            if (Units <= 50)
            {
                Amount = Units * 0.5;
            }
            else if (Units <= 150)
            {
                Amount = (50 * 0.5) + ((Units - 50) * 0.75);
            }
            else if (Units <= 250)
            {

                Amount = (50 * 0.5) + (100 * 0.75) + ((Units - 150) * 1.20);
            }
            else
            {
                Amount = (50 * 0.5) + (100 * 0.75) + (100 * 1.20) + ((Units - 250) * 1.50);
            }

            Amount = Amount + Amount * 0.2;
            Console.WriteLine("Bill Amount " + Amount);
        }
    }
}