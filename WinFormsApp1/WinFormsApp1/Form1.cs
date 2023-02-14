using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                secondform f2 = new secondform();
                f2.ShowDialog();
                
            }
            else if(result == DialogResult.No)
            {
                MessageBox.Show("you have selected No Option");
            }
            else
            {
                MessageBox.Show("you have selected to Cancel your transaction");
            }
        }
    }
}