namespace bilgiYarısmasi
{
    public partial class Next : Form
    {
        public Next()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }




        int questionNo = 0, true1 = 0, false1 = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {

            //her bu butona tıklandığında butonlar aktif olsun
            A.Enabled = true;
            B.Enabled = true; 
            C.Enabled = true;
            D.Enabled = true;
            btnNext.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            questionNo++;
            lblQuestionNo.Text = questionNo.ToString();

            if (questionNo == 1)
            {
                richTextBox1.Text = "Dünyanın en büyük dağı nedir ?";
                A.Text = "Everest Dağı";
                B.Text = "Ağrı Dağı";
                C.Text = "Kafkas Dağı";
                D.Text = "Guadolupe Dağı";

                label1.Text = "Everest Dağı";  // Doğru cevap saklandı

            }
            if (questionNo == 2)
            {
                richTextBox1.Text = "Bir tam sayının 10 katı hangisi olamaz ?";
                A.Text = "1000";
                B.Text = "100";
                C.Text = "10";
                D.Text = "1";

                label1.Text = "1";   // Doğru cevap saklandı

            }

            if (questionNo == 3)
            {
                richTextBox1.Text = "Ege bölgesine bulunan ilimiz hangisidir ?";
                A.Text = "istanbul";
                B.Text = "kocaeli";
                C.Text = "Antalya";
                D.Text = "Manisa";

                label1.Text = "Manisa"; // Doğru cevap saklandı
            }

            if (questionNo == 4)
            {
                richTextBox1.Text = "Kedi uzanamadığı çiğere.... Devamı nedir?";
                A.Text = "Kış kış dermiş";
                B.Text = "Mundar dermiş";
                C.Text = "Görüldü atarmış";
                D.Text = "Küsermiş";

                label1.Text = "Mundar dermiş";  // Doğru cevap saklandı
            }

            if (questionNo == 5)
            {
                richTextBox1.Text = "Atatürk üniversitesi hangi ildedir?";
                A.Text = "İzmir";
                B.Text = "Erzurum";
                C.Text = "Hatay";
                D.Text = "Ağrı";

                label1.Text = "Erzurum";  // Doğru cevap saklandı

                btnNext.Text = "Results :";

            }
            if (questionNo == 6) //sorular bittikten sonra oluşanlar
            {
                A.Enabled = false;
                B.Enabled = false;
                C.Enabled = false;
                D.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("True :" + true1 + "\n" + "False : " + false1);

            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //butonlar pasif
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            btnNext.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            label2.Text = A.Text;  // Cevabı saklıyoruz
            if (label1.Text == label2.Text) // Doğru mu yanlış mı diye kontrol
            {
                true1++;
                lblTrue.Text = true1.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                false1++;
                lblFalse.Text = false1.ToString();
                pictureBox1.Visible = true;
            }
            

        }

        private void B_Click(object sender, EventArgs e)
        {
            //butonlar pasif
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            btnNext.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            label2.Text = B.Text;  // Cevabı saklıyoruz
            if (label1.Text == label2.Text) // Doğru mu yanlış mı diye kontrol
            {
                true1++;
                lblTrue.Text = true1.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                false1++;
                lblFalse.Text = false1.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void C_Click(object sender, EventArgs e)
        {
            //butonlar pasif
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            btnNext.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            label2.Text = C.Text;  // Cevabı saklıyoruz
            if (label1.Text == label2.Text) // Doğru mu yanlış mı diye kontrol
            {
                true1++;
                lblTrue.Text = true1.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                false1++;
                lblFalse.Text = false1.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void D_Click(object sender, EventArgs e)
        {
            //butonlar pasif
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            btnNext.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            label2.Text = D.Text;  // Cevabı saklıyoruz
            if (label1.Text == label2.Text) // Doğru mu yanlış mı diye kontrol
            {
                true1++;
                lblTrue.Text = true1.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                false1++;
                lblFalse.Text = false1.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}
