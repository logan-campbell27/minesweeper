using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneMinesweeperConsole
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string filePath = @"C:\demos\highScores.txt";

            List<String> scores = File.ReadAllLines(filePath).ToList();

            scores.Sort();
            scores.Reverse();
            label1.Text = "1. "+scores[0];
            label2.Text = "2. "+scores[1];
            label3.Text = "3. "+scores[2];
            label4.Text = "4. "+scores[3];
            label5.Text = "5. "+scores[4];


        }
    }
}
