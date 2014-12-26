using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessCentralization;

namespace test.BLL
{
    public class PersonBLL : BaseDataAccess
    {
        public void Add(string fname, string mname, string lname)
        {
            InitializeDataAccess(ProviderType.Oledb,
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True");
            CreateCommandParameters("fname", fname);
            CreateCommandParameters("mname", mname);
            CreateCommandParameters("lname", lname);
            
            SaveChanges("insert into person(fname,mname,lname) values(@fname,@mname,@lname)");
        }

        public DataTable GetData()
        {
            InitializeDataAccess(ProviderType.Oledb,
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True");
            return getDataTable("select * from person");
        }

        public string GetLastName()
        {
            InitializeDataAccess(ProviderType.Oledb,
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True");
            return GetFirstValueInFirstRow("select top 1 lname from person").ToString();
        }

    }
}
