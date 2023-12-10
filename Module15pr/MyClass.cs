using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15_Practise
{
    public class MyClass
    {

        
        private int privateField = 42;
        public string publicField = "Public Field";
        
        public int PublicProperty { get; set; }
        private string PrivateProperty { get; set; }

        
        public MyClass()
        {
        }


        
        private MyClass(int value)
        {
            this.PrivateProperty = "Private Property";
            this.PublicProperty = value;
        }
        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }



        
        public int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}
