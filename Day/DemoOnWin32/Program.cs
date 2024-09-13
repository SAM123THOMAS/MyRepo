using System.Runtime.InteropServices;

namespace DemoOnWin32
{
    internal class Program
    {

        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr IWnd, string text, string caption, uint type);
        static void Main1(string[] args)
        {
            int value = MessageBox(IntPtr.Zero, "I am message box", "Box Heading", 2);
            //if (value == 1)
            //{
            //    Console.WriteLine("CLicked ok");
            //}
            //if (value == 2)
            //{
            //    Console.WriteLine("CLicked cancel");
            //}

            switch (value)
            {
                case 4:
                    {
                        Console.WriteLine("Clciked Ignore");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Clciked Enter");
                        break;

                    }
                case 6:
                    {
                        Console.WriteLine("Clciked Abort");
                        break;

                    }

            }
        }
    }
}