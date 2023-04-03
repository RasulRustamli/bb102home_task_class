using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb102home_task
{
    internal class Phone:Product
    {
        public int Ram { get; set; }
        public string Color { get; set; }
        public double Balance { get; set; }
        public Phone(string brandName, string model, double price, double cost, int count,int ram,double balance
            ,string color="Black" ):base(brandName,model,price,cost,count)
        {
            Ram = ram;
            Balance = 0;
            Color = color;
        }
        public void Call(int seconds)
        {
            if(Balance>=seconds*0.1)
            {
                Balance-=seconds*0.1;
            }
            else
            {
                Console.WriteLine("Kifayet qeder balansiniz yoxdur");
            }
        }
        public void Pay(double money)
        {
            Balance += money;
        }


    }
}
