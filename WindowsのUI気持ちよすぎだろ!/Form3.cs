using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WindowsのUI気持ちよすぎだろ_ {
    public partial class Form3 : Form {

        int ticked = 30;

        public Form3() {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            ticked++;
            eventProcess(ticked);
        }

        public void eventProcess(int ticked) {
            pictureBox4.Location= new Point(-ticked*2+100, -ticked*2+120);
            pictureBox4.Width+=4;
            pictureBox4.Height+=4;

            pictureBox1.Location = new Point((int)(Math.Sin(ticked)*100)+80, (int)(Math.Cos(ticked) * 100) + 80);
            pictureBox2.Location = new Point((int)(Math.Sin(ticked + 120) * 100) + 80, (int)(Math.Cos(ticked + 120) * 100) + 80);
            pictureBox3.Location = new Point((int)(Math.Sin(ticked+240) * 100) + 80, (int)(Math.Cos(ticked+240) * 100) + 80);
            if (ticked > 50) {
                label2.Visible = true;
            }
            if (ticked > 90) {
                label3.Visible = true;
            }
            if (ticked > 140) {
                label4.Visible = true;
            }
            if (ticked == 206) {
                Form4 form4 = new Form4();
                form4.Show();
                timer1.Enabled = false;
            }
        }
    }
}
