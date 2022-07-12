using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    [Serializable]
    public class Employee
    {
        public int Empid { get; set; }

        public String Empname { get; set; }

        public int Empsal { get; set; }
    }
}
