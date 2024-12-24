using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04
{
    internal class Employee
    {
        public string? Name{  get; set; }
        public int id {  get; set; }
        public Department department { get; set; }
    }
    internal class Department
    {
        public String Name { get; set; }
        public int id { get; set; }
    }
}
