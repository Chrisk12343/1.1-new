namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string scalc = textnum1.Text;
            double dcalc = 0;
            if (double.TryParse(scalc, out dcalc))
                //what this supposed to do is make it where you type a number it gives you the message below. 
                //but i messed up the first time and forgot the ! infront of the double so it does the oppposite now
            { labelsum.Text = "Invalid input"; }
            
            


        }

        private void textnum1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
