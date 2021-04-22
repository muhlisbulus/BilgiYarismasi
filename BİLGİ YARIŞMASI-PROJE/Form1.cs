using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİLGİ_YARIŞMASI_PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sonraki_Click(object sender, EventArgs e)
        {
            int soru_no = 0;
            soru_no++;
            soruno.Text = soru_no.ToString();
            if (soru_no == 1)
            {
                richTextBox1.Text = "CUMHURİYET KAÇ YILINDA KURULMUŞTUR";
                button1.Text = "1920";
                button2.Text = "1921";
                button3.Text = "1923";
                button4.Text = "1926";
                label4.Text = button3.Text;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            int dogru = 0, yanlis = 0;
            label5.Text = button1.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;

                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            int dogru = 0, yanlis = 0;
            label5.Text = button2.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;

                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            int dogru = 0, yanlis = 0;
            label5.Text = button3.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;

                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            int dogru = 0, yanlis = 0;
            label5.Text = button4.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;

                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
