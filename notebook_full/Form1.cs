using System;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace notebook_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void îçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|Âñå ôàéëû (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|Âñå ôàéëû (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                }
            }
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void âûðåçàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Cut();
            }
        }

        private void êîïèðîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void âñòàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.SelectedText = "";
            }
        }

        private void øðèôòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = textBox1.Font;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = fontDialog.Font;
                }
            }
        }

        private void îÏðîãðàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Áëîêíîò\n\nÂåðñèÿ 1.0",
                "Î ïðîãðàììå",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ôîðìàòToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ôàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ñïðàâêàToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void öâåòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = textBox1.ForeColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.ForeColor = colorDialog.Color;
                }
            }
        }

        private void ïå÷àòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;

                printDocument.PrintPage += (s, ev) =>
                {
                    ev.Graphics.DrawString(
                        textBox1.Text,
                        textBox1.Font,
                        System.Drawing.Brushes.Black,
                        ev.MarginBounds.Left,
                        ev.MarginBounds.Top
                    );
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
    }


}