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
    public partial class Form2 : Form {

        int ticked = 0;
        Random random = new Random();

        public Form2() {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            ticked++;
            eventProcess(ticked);
        }

        public void eventProcess(int ticked) {
            if (ticked == 158) {
                timer1.Enabled = false;
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }

            label1.Location = new Point(label1.Location.X + random.Next(-2, 3), label1.Location.Y + random.Next(-2, 3));
            label2.Location = new Point(label2.Location.X + random.Next(-2, 3), label2.Location.Y + random.Next(-2, 3));
            label3.Location = new Point(label3.Location.X + random.Next(-2, 3), label3.Location.Y + random.Next(-2, 3));
            label5.Location = new Point(label5.Location.X + random.Next(-2, 3), label5.Location.Y + random.Next(-2, 3));
            label6.Location = new Point(label6.Location.X + random.Next(-2, 3), label6.Location.Y + random.Next(-2, 3));
            label7.Location = new Point(label7.Location.X + random.Next(-2, 3), label7.Location.Y + random.Next(-2, 3));
            label8.Location = new Point(label8.Location.X + random.Next(-2, 3), label8.Location.Y + random.Next(-2, 3));
            label9.Location = new Point(label9.Location.X + random.Next(-2, 3), label9.Location.Y + random.Next(-2, 3));
            label10.Location = new Point(label10.Location.X + random.Next(-2, 3), label10.Location.Y + random.Next(-2, 3));
        }

    }
}
