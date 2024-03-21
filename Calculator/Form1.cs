using System.Diagnostics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string birinciSayi = "";
        private double ikinciSayi;

        private double m1;
        private double m2;

        private bool negatifPozitifKontrol;
        private bool toplamaKontrol;
        private bool cikarmaKontrol;
        private bool carpmaKontrol;
        private bool bolmeKontrol;

        public Form1()
        {
            InitializeComponent();
        }

        private void ToolTipX(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();


            toolTip1.SetToolTip(label4, "Tum bellegi temizle");
            toolTip1.SetToolTip(label5, "Bellekten cagirma");
            toolTip1.SetToolTip(label6, "Bellege ekleme");
            toolTip1.SetToolTip(label7, "Bellege cikarma");
            toolTip1.SetToolTip(label8, "Bellek deposu");
            toolTip1.SetToolTip(label7, "Made in Enis Ingec");
        }

        private void Memory(object sender, EventArgs e)
        {
            Label lbl = sender as Label;



            switch (lbl.Text)
            {
                case "MC":
                    m1 = 0;
                    m2 = 0;
                    label4.ForeColor = Color.DarkGray;
                    label5.ForeColor = Color.DarkGray;
                    break;

                case "MR":
                    if (m1 != 0 && m2 == 0)
                    {
                        label1.Text = m1.ToString();
                    }
                    else if (m2 != 0 && m1 == 0)
                    {
                        label1.Text = m2.ToString();
                    }
                    else if (m1 != 0 && m2 != 0)
                    {
                        m1 = m1 + m2;
                        m2 = 0;
                        label1.Text = (m1).ToString();
                    }
                    break;

                case "M+":
                    if (birinciSayi != "")
                    {
                        m1 = Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label4.ForeColor = Color.Black;
                        label5.ForeColor = Color.Black;
                    }
                    break;

                case "M-":
                    if (birinciSayi != "")
                    {
                        label1.Text = birinciSayi;
                        m2 = -Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label4.ForeColor = Color.Black;
                        label5.ForeColor = Color.Black;
                    }
                    break;

                case "MS":
                    if (birinciSayi != "")
                    {
                        m1 = Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label4.ForeColor = Color.Black;
                        label5.ForeColor = Color.Black;
                    }
                    break;
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Text)
            {
                case "CE":
                    birinciSayi = "";
                    label1.Text = "0";
                    break;

                case "C":
                    birinciSayi = "";
                    ikinciSayi = 0;
                    label1.Text = "0";
                    toplamaKontrol = false;
                    cikarmaKontrol = false;
                    carpmaKontrol = false;
                    bolmeKontrol = false;
                    break;
            }
        }

        private void Back(object sender, EventArgs e)
        {
            if (birinciSayi.Length > 1)
            {
                birinciSayi = birinciSayi.Remove(birinciSayi.Length - 1);
                label1.Text = birinciSayi;
            }
            else if (ikinciSayi != 0)
            {
                birinciSayi = ikinciSayi.ToString();
                ikinciSayi = 0;
                birinciSayi = birinciSayi.Remove(birinciSayi.Length - 1);
                label1.Text = birinciSayi;
            }
            else
            {
                birinciSayi = "";
                label1.Text = "0";
            }
        }

        private void xBolme(object sender, EventArgs e)
        {
            if (birinciSayi != "")
            {
                ikinciSayi = 1 / Convert.ToDouble(birinciSayi);
                label1.Text = ikinciSayi.ToString();
                birinciSayi = "";
            }
            else if (ikinciSayi == 0)
            {
                label1.Text = "Sifira bolunemez!";
            }
        }

        private void Karesi(object sender, EventArgs e)
        {
            if (birinciSayi != "")
            {
                ikinciSayi = Convert.ToDouble(birinciSayi) * Convert.ToDouble(birinciSayi);
                birinciSayi = ikinciSayi.ToString();
                label1.Text = ikinciSayi.ToString();
            }
            else if (ikinciSayi != 0)
            {
                ikinciSayi = ikinciSayi * ikinciSayi;
                birinciSayi = ikinciSayi.ToString();
                label1.Text = ikinciSayi.ToString();
            }
        }

        private void Karekok(object sender, EventArgs e)
        {
            if (birinciSayi != "")
            {
                ikinciSayi = Math.Sqrt(Convert.ToDouble(birinciSayi));
                birinciSayi = ikinciSayi.ToString();
                label1.Text = ikinciSayi.ToString();
            }
        }

        private void Yuzdelik(object sender, EventArgs e)
        {
            if (ikinciSayi == 0 && birinciSayi != "")
            {
                ikinciSayi = Convert.ToDouble(birinciSayi);
                birinciSayi = "";
                label1.Text = "Yuzdelik orani";
            }
            else if (birinciSayi != "")
            {
                ikinciSayi = (ikinciSayi * Convert.ToDouble(birinciSayi)) / 100;
                label1.Text = ikinciSayi.ToString();
            }
        }



        private void Sayilar(object sender, EventArgs e)
        {
            Button btn = sender as Button;              // sender'ý Button türüne dönüþtürür egerki buton degeri yoksa null deðerini atar hata vermez.

            birinciSayi += btn.Text;                    // ilk islemde 0 basilmasin!
            label1.Text = birinciSayi;
        }

        private void Islemler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;                // sender'ý Button türüne dönüþtürür gerki buton degeri yoksa hata verir.

            switch (btn.Text)
            {
                case "+":
                    if (birinciSayi != "")
                    {
                        ikinciSayi += Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label1.Text = ikinciSayi.ToString();
                        toplamaKontrol = true;
                    }
                    break;

                case "-":
                    if (ikinciSayi == 0 && birinciSayi != "")               // ikinciSayi == 0 olayi yanlis !!
                    {
                        ikinciSayi = Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label1.Text = ikinciSayi.ToString();
                        cikarmaKontrol = true;

                    }
                    else if (birinciSayi != "")
                    {
                        ikinciSayi -= Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label1.Text = ikinciSayi.ToString();
                    }
                    break;

                case "x":
                    if (ikinciSayi == 0 && birinciSayi != "")
                    {
                        ikinciSayi = Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label1.Text = ikinciSayi.ToString();
                        carpmaKontrol = true;
                    }
                    else if (birinciSayi != "")
                    {
                        ikinciSayi *= Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label1.Text = ikinciSayi.ToString();
                    }
                    break;

                case "÷":
                    if (ikinciSayi == 0 && birinciSayi != "")
                    {
                        ikinciSayi = Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label1.Text = ikinciSayi.ToString();
                        bolmeKontrol = true;
                    }
                    else if (birinciSayi != "")
                    {
                        ikinciSayi /= Convert.ToDouble(birinciSayi);
                        birinciSayi = "";
                        label1.Text = ikinciSayi.ToString();
                    }
                    break;

                case "+/_":
                    if (birinciSayi != "" && negatifPozitifKontrol == false)
                    {
                        birinciSayi = (-Convert.ToDouble(birinciSayi)).ToString();
                        label1.Text = birinciSayi.ToString();
                        negatifPozitifKontrol = true;
                    }
                    else if (negatifPozitifKontrol == true)
                    {
                        birinciSayi = (-1 * Convert.ToDouble(birinciSayi)).ToString();
                        label1.Text = birinciSayi.ToString();
                        negatifPozitifKontrol = false;
                    }
                    break;

                case ",":
                    if (!birinciSayi.Contains(","))
                    {
                        birinciSayi = "0";
                        birinciSayi = birinciSayi + ",";
                        label1.Text = birinciSayi;
                    }
                    break;

                case "=":

                    if (toplamaKontrol == true && birinciSayi != "")
                    {
                        ikinciSayi += Convert.ToDouble(birinciSayi);
                        label1.Text = ikinciSayi.ToString();
                    }
                    else if (cikarmaKontrol == true && birinciSayi != "")
                    {
                        ikinciSayi -= Convert.ToDouble(birinciSayi);
                        label1.Text = ikinciSayi.ToString();
                    }
                    else if (carpmaKontrol == true && birinciSayi != "")
                    {
                        ikinciSayi *= Convert.ToDouble(birinciSayi);
                        label1.Text = ikinciSayi.ToString();
                    }
                    else if (bolmeKontrol == true && birinciSayi != "")
                    {
                        ikinciSayi /= Convert.ToDouble(birinciSayi);
                        label1.Text = ikinciSayi.ToString();
                    }
                    break;
            }
        }
    }
}