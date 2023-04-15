using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_TPH_TPCC.Entities
{
    //TPCC
    public abstract class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

    }

    
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee()
        {
            StartDate=DateTime.Now;
        }

        public DateTime StartDate { get; set; }

        public double Salary{ get; set; }
    }

    
    public class PartTimeEmployee : Employee
    {
        

        public int CountOfHoures{ get; set; }

        public double HoureRate { get; set; }
    }
}
