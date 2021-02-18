
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Accounting_Project.Project
{
    public partial class LoginFrm : MetroFramework .Forms .MetroForm
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
    
    public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, System.EventArgs e)
        {
        }

        private void Login_bt_Click(object sender, System.EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();

            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Users] where [User] ='"+User_tx.Text+"' and [Pwd]= '" + Pwd_tx.Text+"'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables [0].Rows .Count > 0)
            {
                MainFrm F = new MainFrm();
                F.Show();
                F.Login_lb.Text = User_tx.Text;  
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Wrong User Name and Password !", "Information", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
                User_tx.Clear();
                Pwd_tx.Clear();
                User_tx.Focus();
            }
        }

        private void Exit_bt_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
