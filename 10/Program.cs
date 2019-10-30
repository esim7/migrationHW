using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var office = new WorkOffice()
                {
                    Name = "Интернет магазин SHOP",
                    Address = "г. Астана ул. Абая 8"
                };
                var boss = new Boss()
                {
                    FirstName = "Борис",
                    LastName = "Борисыч",
                    Email = "BORIS228@mail.ru",
                    PhoneNumber = "+77777777777"
                };
                var worker = new Worker()
                {
                    Name = "Васька",
                    PhoneNumber = "+77777777777",
                    Age = 21,
                    Wage = 85000,
                };
                context.Workers.Add(worker);
                context.WorkOffices.Add(office);
                context.Bosses.Add(boss);

                context.SaveChanges();
            }
        }
    }
}
