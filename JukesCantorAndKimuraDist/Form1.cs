using System;
using System.Windows.Forms;

namespace JukesCantorAndKimuraDist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textDNA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[TAGCtagc^\b]"))
            {
                e.Handled = true;
            }
        }

        String seq1 = "";
        String seq2 = "";
        int lenSeq1 = 0;
        int lenSeq2 = 0;
        int diferringCount = 0;
        int transition = 0;
        int transversion = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            seq1 = textBoxSeq1.Text.ToLower();
            seq2 = textBoxSeq2.Text.ToLower();
            lenSeq1 = seq1.Length;
            lenSeq2 = seq2.Length;
            diferringCount = 0;
            transition = 0;
            transversion = 0;
            if (lenSeq1 != lenSeq2)
            {
                MessageBox.Show("Sequence lengths must be equal.", "Warning!");
            }
            else
            {
                CountDifferringSites();

                double distance = 0;
                if (radioButtonJC.Checked)
                {
                    distance = CalcJukesCantor();
                }
                else if (radioButtonKimura.Checked)
                {
                    distance = CalcKimura();
                }
                textBoxResult.Text = distance.ToString();

                if (distance <= 0 || distance >= 0.75)
                {
                    MessageBox.Show("The distance is not in the interval of (0, 0.75).", "Warning!");
                }
                if (distance.ToString().Equals("NaN"))
                {
                    MessageBox.Show("Divided by zero.", "Error!");
                }
            }
        }

        private void CountDifferringSites()
        {
            for (int i = 0; i < lenSeq1; i++)
            {
                if (seq1[i] != seq2[i])
                {
                    diferringCount++;

                    if ((seq1[i] == 'a' || seq1[i] == 'g') && (seq2[i] == 't' || seq2[i] == 'c') || (seq1[i] == 't' || seq1[i] == 'c') && (seq2[i] == 'a' || seq2[i] == 'g'))
                    {
                        transversion++;
                    }
                    else if ((seq1[i] == 'a' || seq1[i] == 'g') && (seq2[i] == 'a' || seq2[i] == 'g') || (seq1[i] == 't' || seq1[i] == 'c') && (seq2[i] == 't' || seq2[i] == 'c'))
                    {
                        transition++;
                    }
                }
            }
        }

        private double CalcJukesCantor()
        {
            return -3.0 / 4.0 * Math.Log(1.0 - (4.0 / 3.0) * ((diferringCount * 1.0) / (lenSeq1 * 1.0)));
        }

        private double CalcKimura()
        {
            return 1.0 / 2.0 * Math.Log(1.0 / (1.0 - 2.0 * (transition * 1.0) / (lenSeq1 * 1.0) - (transversion * 1.0) / (lenSeq1 * 1.0))) + 1.0 / 4.0 * Math.Log(1.0 / (1.0 - 2.0 * (transversion * 1.0) / (lenSeq1 * 1.0)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSeq1.KeyPress += new KeyPressEventHandler(textDNA_KeyPress);
            textBoxSeq2.KeyPress += new KeyPressEventHandler(textDNA_KeyPress);
        }
    }
}
