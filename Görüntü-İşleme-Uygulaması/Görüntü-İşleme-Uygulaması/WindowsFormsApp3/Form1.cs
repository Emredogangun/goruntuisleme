using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public static OpenFileDialog openFile;
        public Bitmap bmp = new Bitmap("C:\\5591.jpg");
        public Bitmap bmp2 = new Bitmap("C:\\5591.jpg");
        public Bitmap bmp3 = new Bitmap("C:\\bb.png");


        public Form1()
        {
            InitializeComponent();
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\aa.bmp");


        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Negative":
                    negative();
                        break;
                case "Gray":
                    gray();
                    break;
                case "Aynalama":
                    aynalama();
                    break;
                case "Ters":
                    ters();
                    break;
                case "Ters Aynalama":
                    tersaynalama();
                    break;
                case "Uzaklastirma":
                    uzaklastirma();
                    break;

                case "Yakinlastirma":
                    yakinlastirma();
                    break;
                case "Karsitlik":
                    karsitlik();
                    break;
                case "Parlaklik":
                    parlaklik();
                    break;
                case "öteleme":
                    Tasima();
                    break;
                case "eşikleme":
                    Esikleme();
                    break;
                case "histogram":
                    ResminHistograminiCiz();
                    break;
                case "toplama":
                    pikselToplamaToolStripMenuItem();
                    break;
                default:
                    break;
            }

        }
        public void negative()
        {

            //image okuma 
               
            int width = bmp.Width;
            int height = bmp.Height;
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int b = p.B;
                    int g = p.G;
                    int r = p.R;
                    // negative değerler
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }
        public void gray()
        {
            Color OkunanRenk, DonusenRenk; int R = 0, G = 0, B = 0;
              
            int width = bmp.Width;
            int height = bmp.Height;
             
            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.     
            for (int x = 0; x < width; x++)
            {
                j = 0;
                for (int y = 0; y < height; y++)
                {
                    OkunanRenk = bmp.GetPixel(x, y);
                    int GriDegeri = Convert.ToInt16(OkunanRenk.R * 0.299 + OkunanRenk.G * 0.587 + OkunanRenk.B * 0.114); //Gri-ton formülü              
                    R = GriDegeri;
                    G = GriDegeri;
                    B = GriDegeri;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    bmp.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Image = bmp;

        }
        public void tersaynalama()
        {
            Color OkunanRenk, DonusenRenk; int R = 0, G = 0, B = 0;
             
            int width = bmp.Width;
            int height = bmp.Height;

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.     
            for (int x = 0; x < width; x++)
            {
                j = 0;
                for (int y = 0; y < height; y++)
                {
                    OkunanRenk = bmp.GetPixel(x, y);
                     
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    bmp2.SetPixel(width-i-1, height-j-1, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Image = bmp2;
        }
        public void aynalama()
        {
            Color OkunanRenk, DonusenRenk; int R = 0, G = 0, B = 0;
             
            int width = bmp.Width;
            int height = bmp.Height;

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.     
            for (int x = 0; x < width; x++)
            {
                j = 0;
                for (int y = 0; y < height; y++)
                {
                    OkunanRenk = bmp.GetPixel(x, y);

                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    bmp2.SetPixel(width - i - 1, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Image = bmp2;

        }
        public void ters()
        {
            Color OkunanRenk, DonusenRenk; int R = 0, G = 0, B = 0;
             
            int width = bmp.Width;
            int height = bmp.Height;

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.     
            for (int x = 0; x < width; x++)
            {
                j = 0;
                for (int y = 0; y < height; y++)
                {
                    OkunanRenk = bmp.GetPixel(x, y);

                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    bmp2.SetPixel(i , height-j-1, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Image = bmp2;
        }
        public void uzaklastirma()
        {
            Color OkunanRenk, DonusenRenk; int R = 0, G = 0, B = 0;
 
            int width = bmp.Width;
            int height = bmp.Height;
             bmp2 = new Bitmap(width, height);

            int oran = Convert.ToInt32(textBox1.Text);
            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.     
            for (int x = 0; x < width; x+= oran)
            {
                j = 0;
                for (int y = 0; y < height; y+= oran)
                {
                    OkunanRenk = bmp.GetPixel(x, y);

                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    bmp2.SetPixel(i,j, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Height = pictureBox1.Height;
            pictureBox2.Width = pictureBox1.Width ;
            pictureBox2.Image = bmp2;
        }
        public void yakinlastirma()
        {
            Color OkunanRenk, DonusenRenk; int R = 0, G = 0, B = 0;
 
            int width = bmp.Width;
            int height = bmp.Height;
            double oran = Convert.ToDouble(textBox1.Text);
             bmp2 = new Bitmap(width * Convert.ToInt32(oran), height * Convert.ToInt32(oran));

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.     
            for (double x = 1; x < width; x+=1/oran)
            {
                j = 0;
                for (double y = 1; y < height; y+=1/oran)
                {
                    OkunanRenk = bmp.GetPixel(Convert.ToInt32(Math.Floor(x)), Convert.ToInt32(Math.Floor(y)));

                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    bmp2.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Height =pictureBox1.Height*Convert.ToInt32(oran);
            pictureBox2.Width = pictureBox1.Width * Convert.ToInt32(oran); 
            pictureBox2.Image = bmp2;
        }
        public void karsitlik()
        {
            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk;  
            int width = bmp.Width;
            int height = bmp.Height;   
           
            double KontrastSeviyesi = trackBar1.Value ;

            double KontrastFaktoru = (259 * (KontrastSeviyesi + 255)) / (255 * (259 - KontrastSeviyesi));

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < width; x++)
            {
                j = 0;
                for (int y = 0; y < height; y++)
                {
                    OkunanRenk = bmp.GetPixel(x, y);
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;

                    R = (int)((KontrastFaktoru * (R - 128)) + 128);
                    G = (int)((KontrastFaktoru * (G - 128)) + 128);
                    B = (int)((KontrastFaktoru * (B - 128)) + 128);

                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak. 
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    bmp2.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Image = bmp2;
        }
        public void parlaklik()
        {
            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk; 
            int width = bmp.Width;
            int height = bmp.Height; 

            int parlaklikSeviyesi = trackBar2.Value;
 
            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < width; x++)
            {
                j = 0;
                for (int y = 0; y < height; y++)
                {
                    OkunanRenk = bmp.GetPixel(x, y);
                   
                        R = Math.Abs(OkunanRenk.R + parlaklikSeviyesi);
                        G = Math.Abs(OkunanRenk.G + parlaklikSeviyesi);
                        B = Math.Abs(OkunanRenk.B + parlaklikSeviyesi);
                    
                   
                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak. 
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255; 

                    DonusenRenk = Color.FromArgb(R, G, B);
                    bmp2.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Image = bmp2;
        }
        public void Tasima()
        {   
            Color OkunanRenk,ornek;
            ornek  = Color.FromArgb(255, 255, 255); ;


            int ResimGenisligi = bmp.Width;
            int ResimYuksekligi =bmp.Height;

            
            double x2 = 0, y2 = 0;
            //Taşıma mesafelerini atıyor.        
            int Tx = 100;
            int Ty = 50;
            for (int x = 0; x < (ResimGenisligi); x++)
                for (int y = 0; y < (ResimYuksekligi); y++)
                    bmp2.SetPixel(x,y, ornek);
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = bmp.GetPixel(x1, y1);

                    x2 = x1 + Tx;
                    y2 = y1 + Ty;

                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        bmp2.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }

            pictureBox2.Image = bmp2;
        }
        public void Esikleme()
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            int ResimGenisligi = bmp.Width; //GirisResmi global tanımlandı.    
            int ResimYuksekligi = bmp2.Height;
            bmp2 = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur. 

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.        
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = bmp.GetPixel(x, y);
                    if (OkunanRenk.R>=128)
                        R = 255;
                    else
                        R = 0; 


                if (OkunanRenk.G >= 128) G = 255; else G = 0;
            
                    if (OkunanRenk.B >= 128) B = 255; else B = 0;

            DonusenRenk = Color.FromArgb(R, G, B); bmp2.SetPixel(i, j, DonusenRenk); j++;
                 }
        i++;
        }


            pictureBox2.Image = bmp2;
        }

        public void ResminHistograminiCiz()
        {
            pictureBox2.Height = pictureBox1.Height * Convert.ToInt32(3);
            pictureBox2.Width = pictureBox1.Width * Convert.ToInt32(3);

            ArrayList DiziPiksel = new ArrayList();

           
            Color OkunanRenk;
           
            int ResimGenisligi = bmp.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = bmp.Height;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    OkunanRenk = bmp.GetPixel(x, y);
                    //OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3; //Griton resimde üç kanal rengi aynı değere sahiptir.

                    DiziPiksel.Add(OkunanRenk.R); //Gri resim olduğu için tek kanalı okuması yeterli olacaktır. 
                }

            }

            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r < 255; r++) //256 tane renk tonu için dönecek.
            {
                int PikselSayisi = 0;
                for (int s = 0; s < DiziPiksel.Count; s++) //resimdeki piksel sayısınca dönecek. 
                {
                    if (r == Convert.ToInt16(DiziPiksel[s]))
                        PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }

            //Değerleri listbox'a ekliyor. 
            int RenkMaksPikselSayisi = 0; //Grafikte y eksenini ölçeklerken kullanılacak. 
            for (int k = 0; k <= 255; k++)
            {
                listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]);

                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }
          
            //Grafiği çiziyor. 
            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.Blue, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pictureBox2.CreateGraphics();

            pictureBox2.Refresh();
            int GrafikYuksekligi = 450;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi, OlcekX = 1.6;
            for (int x = 0; x <= 255; x++)
            {
                CizimAlani.DrawLine(Kalem1, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), 0);

            }
            textBox1.Text = "Maks.Piks=" + RenkMaksPikselSayisi.ToString();

        }

        private void pikselToplamaToolStripMenuItem()
        {
            Bitmap Resim1, Resim2, CikisResmi;
            Resim1 = bmp2;
            Resim2 = bmp3;
            int ResimGenisligi = Resim1.Width;
            int ResimYuksekligi = Resim1.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            Color Renk1, Renk2;
            int x, y;
            int R = 0, G = 0, B = 0;
             for (x = 0; x < ResimGenisligi; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan
             {
                for (y = 0; y < ResimYuksekligi; y++)
                {
                    Renk1 = Resim1.GetPixel(x, y);
                    Renk2 = Resim2.GetPixel(x, y);
                    //İki resmi direk toplama
                    //R = Renk1.R + Renk2.R;
                    //G = Renk1.G + Renk2.G;
                    //B = Renk1.B + Renk2.B;
                    //İki resmi ölçekli olarak toplama
                    if (Renk2.R > 20 && Renk2.G > 20 && Renk2.B > 20)
                    {
                        R = Convert.ToInt16(Renk1.R * 0.3 + Renk2.R * 0.7);
                        G = Convert.ToInt16(Renk1.G * 0.3 + Renk2.G * 0.7);
                        B = Convert.ToInt16(Renk1.B * 0.3 + Renk2.B * 0.7);
                    }
                    else
                    {
                        R = Renk1.R;
                        G = Renk1.G;
                        B = Renk1.B;
                    }
                    //Sınırı aşan değerleri 255 ayarlama
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    //Sınırı aşan değerleri Başa sarma şeklinde ayarlama
                    //if (R > 255) R = (R - 255);
                    //if (G > 255) G = (G - 255);
                    //if (B > 255) B = (B - 255);
                    CikisResmi.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }
            pictureBox2.Image = CikisResmi;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            karsitlik();
            label3.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            parlaklik();
            label4.Text = trackBar2.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            if (openFile.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return ;
            }


         bmp2 = new Bitmap(openFile.FileName);
         bmp = new Bitmap(openFile.FileName);
        pictureBox1.ImageLocation = openFile.FileName; 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bmp2 = new Bitmap(openFile.FileName);
            bmp = new Bitmap(openFile.FileName);
            pictureBox1.ImageLocation = openFile.FileName;
            pictureBox2.ImageLocation = openFile.FileName;
            pictureBox2.Height = pictureBox1.Height;
            pictureBox2.Width = pictureBox1.Width;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

