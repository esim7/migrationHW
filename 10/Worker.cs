using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public class Worker 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public int Wage { get; set; }
        public string Position { get; set; }
        public Boss Boss { get; set; }
        public WorkOffice WorkOffice { get; set; }
    }
}
