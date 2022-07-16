using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsのUI気持ちよすぎだろ_ {
    public partial class Form5 : Form {

        int ticked = 0;


        public Form5() {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e) {
            label2.Visible = false;
        }

        public void eventProcess(int ticked) {
            label1.Text = "WindowsのUI気持ちよすぎだろ!";
            this.Text = "WindowsのUI気持ちよすぎだろ!";
            if (ticked > 760) {
                label1.Text = "UI";
                this.Text = "UI";
                Bitmap bitmap = null;
                Graphics g = Graphics.FromImage(bitmap);
                g.FillRectangle(new SolidBrush(Color.White), 2, 2, 2, 2);
            }else
            if (ticked > 620) {

                this.Text = "UI";
                label2.Visible = true;
                label2.Font = new Font("MS Mincho", ticked - 620 + 1, FontStyle.Bold);
            } else
            if (ticked > 440) {

                label1.Text = "気持ちよすぎだろ!";
                this.Text = "気持ちよすぎだろ!";
            } else
            if (ticked > 420) {

                label1.Text = "*舌擦*";
                this.Text = "*舌擦*";
            } else
            if (ticked > 360) {

                label1.Text = "UI";
                this.Text = "UI";
            } else
            if (ticked > 210) {
                label1.Text = "UI気持ちよすぎだろ!";
                this.Text = "UI気持ちよすぎだろ!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            ticked++;
            eventProcess(ticked);
        }
    }
}
