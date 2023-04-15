using Microsoft.EntityFrameworkCore;
using TPC_TPH_TPCC.Context;
using TPC_TPH_TPCC.Entities;

namespace TPC_TPH_TPCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (CompanyDbContext  context=new CompanyDbContext () )
            {
                //FullTimeEmployee employee1 = new FullTimeEmployee()
                //{
                //    Name = "Basel",
                //    Address = "Gaza",
                //    Age = 25,
                //    Salary = 5000
                //};


                //PartTimeEmployee employee2 = new PartTimeEmployee()
                //{
                //    Name = "Basel",
                //    Address = "Gaza",
                //    Age = 25,
                //    CountOfHoures = 10,
                //    HoureRate = 10,
                //};

                #region TPH
                //context.Employees.Add(employee1);//الموظف الاول 
                //                                    //full time
                //context.Employees.Add(employee2);//الموظف الثاني 
                //                                 //PartTime
                //context.SaveChanges();


                #endregion


            }
        }
    }
}