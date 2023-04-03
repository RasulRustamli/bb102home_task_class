using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb102home_task
{
    internal class Product
    {
        public string Id;
        public string BrandName;
        public string Model;
        public double Price;
        public double Cost;
        public double Income;
        public int Count;
        public Product(string brandName,string model,double price,double cost,int count)
        {

            BrandName=brandName;
            Model=model;
            Price=price;
            Cost=cost;
            if(count<0)
            {
                Count=0;
            }
            else
            {
                Count = count;

            }
            Id = BrandName.Substring(0, 2) + Model.Substring(0, 2);
        }

        public void Sale(int newcount)
        {
            if(newcount<=Count && newcount>0)
            {
                Income += (Price - Cost) * newcount;
                Count -= newcount;
              
            }
            else
            {
                Console.WriteLine("Kifayet qeder mehsul yoxdur");
            }
        }
    }
}
