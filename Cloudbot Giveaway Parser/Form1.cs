using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloudbot_Giveaway_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] text = new TextBox[] { textBox1 };
            int i = textBox1.Lines.Count();
            var winners = new Dictionary<string, int>();
            float giveawyCount = 0;
            for (int x = 1; x < i-2;)
            {
                string v = textBox1.Lines[x];
                x = x + 4;
                try {
                    winners.Add(v, 1);
                } catch {

                    winners[v] = winners[v] + 1;
                };
                giveawyCount = giveawyCount + 1;
            }
            textBox2.Text = "User - Number of Wins  - Percent of Wins ";
            foreach (var item in winners)
            {
                textBox2.Text = textBox2.Text + Environment.NewLine + item.Key + " - " + item.Value +  " - " + item.Value/giveawyCount + "%";
            }

        }
    }
}
