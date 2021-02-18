namespace Accounting_Project.Project
{
    public partial class MainFrm : MetroFramework .Forms .MetroForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void Product_tl_Click(object sender, System.EventArgs e)
        {
            Project.ProductEntryFrm f = new ProductEntryFrm();
            f.Show();
        }
    }
}
