using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessCentralization;
namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaseDataAccess d = new BaseDataAccess();
        private void Form1_Load(object sender, EventArgs e)
        {
            d.InitializeDataAccess(ProviderType.Oledb,"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True", "Select * from person");
            dataGridView1.DataSource = d.getDataTable("select * from person");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            d.InitializeDataAccess(ProviderType.Oledb,
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True");
            DeclarePersonParametersForUpdate(int.Parse(txtUpdateId.Text), txtUpdateFname.Text, txtUpdateMname.Text,
                txtUpdateLname.Text);
            d.SaveChanges("update person set fname=@fname,mname=@mname,lname=@lname where ID=@id");
            getData();
            clearUpdateTexts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            d.CreateCommandParameters("id", txtUpdateId.Text);
            d.SaveChanges("delete from person where id=@id");
            getData();
            clearUpdateTexts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            d.InitializeDataAccess(ProviderType.Oledb,
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True");
            DeclarePersonParametersForAdd(txtAddFname.Text, txtAddMname.Text, txtAddLname.Text);
            d.SaveChanges("insert into person(fname,mname,lname) values(@fname,@mname,@lname)");
            getData();
        }

         private void DeclarePersonParametersForUpdate(int id, string fname, string mname, string lname)
         {
             d.CreateCommandParameters("fname", fname);
             d.CreateCommandParameters("mname", mname);
             d.CreateCommandParameters("lname", lname);
             d.CreateCommandParameters("id", id);
         }

        private void DeclarePersonParametersForAdd(string fname, string mname, string lname)
        {
            d.CreateCommandParameters("fname", fname);
            d.CreateCommandParameters("mname", mname);
            d.CreateCommandParameters("lname", lname);
        }

        private void clearUpdateTexts()
        {
            txtUpdateId.Text = "";
            txtUpdateFname.Text = "";
            txtUpdateMname.Text = "";
            txtUpdateLname.Text = "";
        }

        private void getData()
        {
            d.InitializeDataAccess(ProviderType.Oledb,
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True",
                "select * from person");
            dataGridView1.DataSource = d.getDataTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUpdateId.Text = dataGridView1.Rows[rowIndex].Cells["id"].Value.ToString();
            txtUpdateFname.Text = dataGridView1.Rows[rowIndex].Cells["fname"].Value.ToString();
            txtUpdateMname.Text = dataGridView1.Rows[rowIndex].Cells["mname"].Value.ToString();
            txtUpdateLname.Text = dataGridView1.Rows[rowIndex].Cells["lname"].Value.ToString();
            TabControl1.SelectedIndex = 1;
        }
    }
}
