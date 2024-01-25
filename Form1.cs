namespace EApp
{
    public partial class Electricity_App : Form
    {
        public Electricity_App()
        {
            InitializeComponent();
        }
        Home h = new Home(); //globally declare
        Commercial C = new Commercial(); //globaly declare

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            h.Show();
        }

        private void Commercial_Click(object sender, EventArgs e)
        {

            this.Hide();
            C.Show();
        }
    }
}
