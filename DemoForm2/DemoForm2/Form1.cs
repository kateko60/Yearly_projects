namespace DemoForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string Calculation_Formulae;
            Calculation_Formulae = txtDisplay.Text;


        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Numer_Eight = int.Parse(BTNEight.Text);
            txtDisplay = ;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Numer_Five = int.Parse(BTNFive.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Numer_Seven = int.Parse(BTNSeven.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int Numer_Nine = int.Parse(BTNNine.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Numer_Six = int.Parse(BTNSix.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Numer_Four = int.Parse(BTNFour.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Numer_One = int.Parse(BTNOne.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Numer_Two = int.Parse(BTNTwo.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int Numer_Three = int.Parse(BTNThree.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int Numer_Zero = int.Parse(BTNZero.Text);
        }


    }
}