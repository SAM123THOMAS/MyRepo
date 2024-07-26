namespace Day_3
{
    internal class Program

    {


        public static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x= y;
            y = temp;
            Console.WriteLine("Value of Numbers after swap in function x=" + x + " y=" + y);

        }
        static void Main1(string[] args)
        {
             int x=1; int y=2;
            Console.WriteLine("Value of Numbers before swap x=" + x +" y="+ y);

            swap(ref x,ref y);
            Console.WriteLine("Value of Numbers after swap x=" + x + " y=" + y);

        }
    }
}