using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Configuration;

namespace Accounting_Project.Project
{
    public partial class ProductEntryFrm : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
        

        public ProductEntryFrm()
        {
            InitializeComponent();
        }

        void ViewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Product]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void ProductEntryFrm_Load(object sender, EventArgs e)
        {


            ViewData();
        }

        void ClearData()
        {
            ProductName_tx.Clear();
            Rate_tx.Clear();
            ID_tx.Clear();
            MRP_tx.Clear();
        }

        private void Save_bt_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Product] (Pid,Product,Rate,MRP) values("+ID_tx.Text+",'"+ProductName_tx.Text+"',"+Rate_tx.Text+","+MRP_tx.Text+")", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ViewData();
            ClearData();
        }

        private void Close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_bt_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("update [Product] set [Product]='" +
            ProductName_tx.Text + "' ,[Rate]="+ Rate_tx .Text + ",[Mrp]="+MRP_tx .Text + " where [PID]='"+ID_tx.Text +"' " , conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ViewData();
            ClearData();
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("delete from [PRODUCT] where [PID]='" + ID_tx.Text + "' ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ViewData();
            ClearData();
        }

        private void ID_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                //if values is digit, numeric then it will do nothing
            }
            else
            {
                //if the value is not digit ,numeric then it will disable keypress
                e.Handled = true;
            }
        }

        private void Rate_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys. Delete)
            {
                //if values is digit, numeric then it will do nothing
            }
            else
            {
                //if the value is not digit ,numeric then it will disable keypress
                e.Handled = true;
            }
        }

        private void MRP_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete)
            {
                //if values is digit, numeric then it will do nothing
            }
            else
            {
                //if the value is not digit ,numeric then it will disable keypress
                e.Handled = true;
            }
        }

        private void ProductName_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
