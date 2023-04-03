using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb102home_task
{
    internal class NoteBook:Product
    {
        public string OpSystem;
        public string Processor;
        public bool HasGraphicCard;
        public NoteBook(string brandName, string model, double price, double cost, int count,string opSystem
            , string processor):base(brandName,model,price,cost,count)
        {
            OpSystem = opSystem;
            Processor = processor;
        }
        public NoteBook(string brandName, string model, double price, double cost, int count, string opSystem
    , string processor,bool hasGraphicCard) :this(brandName,model,price,cost,count,opSystem,processor)
        {
            HasGraphicCard = hasGraphicCard;
        }
    }
}
