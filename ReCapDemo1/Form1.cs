using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];  //Arraylar ile her butonu ayrı ayrı kontrol edebiliriz
            int top = 0;
            int left = 0;
            
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //8 satır için bir değer oluşturuldu. 0.Boyutun alabileceği en büyük değer 7 dir. yani toplamda 8
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++) //i 0 ken j 0,
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i,j]);
                }
                top += 50;
                left = 0;
            }


            //Button şekilde buton oluşturulabilir fakat bizim istediğimiz 8-8 olması
            //Button button = new Button();     // Zaten var olan Button classı açarız
            //this.Controls.Add(button);        //Butonu ekrana ekle demektir.
            //button.Width = 50;                //Buton'a genişlik ekleme
            //button.Height = 50;               //Buton'a yükseklik ekleme
            //button.Text = "My button";        //Butona metin ekleme
        }
    }
}
