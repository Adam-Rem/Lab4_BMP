namespace Lab4_BMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            Bitmap b = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            for (int n = 0; n < image1.Width; n++)
            {
                for (int m = 0; m < image1.Height; m++)
                {

                    Color x = image1.GetPixel(n, m);
                    if (x.GetBrightness() < 0.125f)         //usuwanie czarnych kolorów z wykorzystaniem getbrightness
                    {
                        image1.SetPixel(n, m, Color.White);
                    }
                }
            }
            pictureBox1.Image = image1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            for (int n = 0; n < image1.Width; n++)
            {
                for (int m = 0; m < image1.Height; m++)
                {

                    Color x = image1.GetPixel(n, m);


                    if (x.R > x.G + 20 || x.B > x.G + 20)         //ustawienie zielonego i usuniecie innych niz zielony 
                    {
                        image1.SetPixel(n, m, Color.White);
                    }
                }
            }
            pictureBox1.Image = image1;
        }
    }
}