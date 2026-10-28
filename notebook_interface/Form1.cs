using System;
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

        private void оздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Cut();
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.SelectedText = "";
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Текстовый редактор «Notebook»\n\nВерсия 1.0\nРазработано в качестве учебного проекта.",
                "О программе",
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

        private void форматToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}