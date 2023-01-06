using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneMinesweeperConsole
{
    public partial class Form1 : Form
    {
        public double difficulty;

        public Form1()
        {
            InitializeComponent();

        }

        private void btn_gameplay_Click(object sender, EventArgs e)
        {
            if (rdr_easy.Checked)
            {
                difficulty = .1;
             
            }
            if (rdr_medium.Checked)
            {
                difficulty = .2;
            }
            if (rdr_hard.Checked)
            {
                difficulty = .3;
            }
            Form2 f2 = new Form2(difficulty);
            f2.Show();
        }

        private void btn_highScore_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
