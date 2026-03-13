namespace SinemaBufeSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int kasastutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt32(textmýsýr.Text);
            bilet = Convert.ToInt32(textbilet.Text);
            su = Convert.ToInt32(textsu.Text);
            cay = Convert.ToInt32(textcay.Text);
            toplam = misir * 4 + bilet * 8 + su * 1 + cay * 2;
            labelmusteritutar.Text = toplam.ToString();

            kasastutar = kasastutar + toplam;
            labelkasatutar.Text = kasastutar.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textbilet.Text = " ";
            textcay.Text = " ";
            textmýsýr.Text = " ";
            textsu.Text = " ";
            textmýsýr.Focus();
        }
    }
}
