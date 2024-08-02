using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{

    public class Sample
    {
        private string _defaultDiscount;

        public Sample()
        {
            _defaultDiscount = "%20";
        }

        public string Discount
        {
            get { return _defaultDiscount; }
            set { _defaultDiscount = value; }
        }
        internal class PropertiesVsFields
        {
            public static void Main2()
            {
                Sample Dis = new Sample();
                Console.WriteLine(Dis.Discount);
            }
        }
    }
}
