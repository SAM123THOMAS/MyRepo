namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double BasicAmt, GrossSalary, DA, HRA;

            Console.WriteLine("Enter the Basic Salary Amount: ");
            BasicAmt = Convert.ToInt64(Console.ReadLine());

            if (BasicAmt <= 10000)
            {
                HRA = BasicAmt * 0.2;
                DA = BasicAmt * 0.8;

            }
            else if (BasicAmt <= 20000)
            {
                HRA = BasicAmt * 0.25;
                DA = BasicAmt * 0.9;
            }
            else
            {
                HRA = BasicAmt * 0.3;
                DA = BasicAmt * 0.95;
            }
            GrossSalary = BasicAmt + HRA + DA;

            Console.WriteLine("GrossSalary = " + GrossSalary);
        }
    }
}