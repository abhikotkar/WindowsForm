using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    [Serializable]
    public class Course
    {
        public int Courseid { get; set; }
        public string Coursename { get; set; }
        public int CourseFees { get; set; }
    }
}
