using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsのUI気持ちよすぎだろ_ {
    public partial class Form4 : Form {

        int ticked = 0;
        
        Random random = new Random();

        public Form4() {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            PictureBox px = new PictureBox();
            if (random.Next(-1, 1) == 0) {
                px.Image = WindowsのUI気持ちよすぎだろ_.Properties.Resources.OIP_11C;
            } else {
                px.Image = WindowsのUI気持ちよすぎだろ_.Properties.Resources.OIP_C11;
            }
            label2.Font = new Font("MS Mincho", (ticked)/3+1, FontStyle.Bold);
            px.Location = new Point(random.Next(0, 640), random.Next(0, 400));
            px.Width = 50;
            px.Height = 70;
            px.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(px);
            ticked++;
            if (ticked == 120) {
                Form5 form5 = new Form5();
                form5.Show();
                timer1.Enabled = false;
            }
        }

    }
}
