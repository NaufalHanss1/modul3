using System.Xml.Linq;

namespace modul3_1302210048
{
    public partial class Form1 : Form
    {
        int bil1, bil2;


        public Form1()

       
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button1.Text;
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button7.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(bil1== 0)
            {
                bil1 = int.Parse(label1.Text);
            }
            label1.Text = " ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(bil2 == 0)
            {
                bil2 = int.Parse(label1.Text);

            }
            label1.Text = " " + (bil1+bil2);
            bil1 = bil1 + bil2;
            bil2 = 0;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 6;
        }
    }
}