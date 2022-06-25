namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final, ort;

            vize = Convert.ToInt32(this.vize.Text);
            final = Convert.ToInt32(this.final.Text);
            ort = Convert.ToInt32((vize * 0.4 + final * 0.6));
            this.label6.Text = ort.ToString();
            if (ort < 50)
            {
                label7.Text = "Kaldýnýz";
            }
            else
            {
                label7.Text = "Geçtiniz.";
            }
        }
    }
}