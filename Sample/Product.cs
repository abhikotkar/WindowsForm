using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    [Serializable]   //attribuits in c#
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Prize { get; set; }
    }
}
