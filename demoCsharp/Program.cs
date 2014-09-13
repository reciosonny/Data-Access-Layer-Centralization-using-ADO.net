using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessCentralization;
using System.Data;
using System.Windows.Forms;




namespace test
{
    class Program : BaseDataAccess
    {
        static void Main(string[] args)
        {
            //BaseDataAccess test = new BaseDataAccess();
            //test.InitializeDataAccess(ProviderType.Oledb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True", "Select * from person");

            //foreach (var i in (from DataRow item in test.getDataTable(0).Rows
            //                   where item["fname"].ToString() == "Sonny"
            //                   select item["fname"]))
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (DataRow item in test.getDataTable(0).Rows)
            //{
            //    Console.WriteLine("First name: " + item["fname"]);
            //    Console.WriteLine("Middle name: " + item["mname"]);
            //    Console.WriteLine("Last name: " + item["lname"]);
            //}
            Application.Run(new Form1());
        }
    }
}
