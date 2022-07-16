using System;
using System.Media;
using System.Windows.Forms;

namespace WindowsのUI気持ちよすぎだろ_ {
    public partial class Form1 : Form {

        int ticked = 0;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox2.Visible = false;
            SoundPlayer sp = new SoundPlayer(WindowsのUI気持ちよすぎだろ_.Properties.Resources.元凶);
            sp.Play();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            ticked++;
            eventProcess(ticked);
            //pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X+random.Next(-5,5),pictureBox2.Location.Y + random.Next(-5, 5));
        }

        public void eventProcess(int ticked) {
            if (ticked > 50) {
                label2.Visible = true;
                pictureBox2.Visible = true;
                pictureBox1.Location = new System.Drawing.Point(386, (int)(Math.Sin(ticked) * 20) + 100);
                pictureBox2.Location = new System.Drawing.Point(482, (int)(Math.Sin(ticked) * 20) + 180);
            }
            if (ticked > 90) {
                label3.Visible = true;
            }
            if (ticked > 140) {
                label4.Visible = true;
            }
            if (ticked == 206) {

                timer1.Enabled = false;
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }

    }
}
