namespace paint_interface
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        bool isDrawing = false;
        Point startPoint;
        Color currentColor = Color.Black;
        int penSize = 3;

        List<Bitmap> history = new List<Bitmap>();
        int historyIndex = -1;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            SaveHistory();
        }

        private void SaveHistory()
        {
            if (historyIndex < history.Count - 1)
            {
                history.RemoveRange(historyIndex + 1, history.Count - historyIndex - 1);
            }
            history.Add((Bitmap)bmp.Clone());
            historyIndex++;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            if (radioButton1.Checked)
            {
                Pen p = new Pen(currentColor, penSize);
                g.DrawLine(p, startPoint, e.Location);
                startPoint = e.Location;
                pictureBox1.Refresh();
            }
            else if (radioButton2.Checked)
            {
                Pen p = new Pen(Color.White, penSize * 2);
                g.DrawLine(p, startPoint, e.Location);
                startPoint = e.Location;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            if (radioButton3.Checked)
            {
                Pen p = new Pen(currentColor, penSize);
                g.DrawLine(p, startPoint, e.Location);
                pictureBox1.Refresh();
            }

            isDrawing = false;
            SaveHistory();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            penSize = trackBar1.Value + 1;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            currentColor = c.BackColor;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
            SaveHistory();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (historyIndex > 0)
            {
                historyIndex--;
                bmp = (Bitmap)history[historyIndex].Clone();
                g = Graphics.FromImage(bmp);
                pictureBox1.Image = bmp;
            }
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            if (historyIndex < history.Count - 1)
            {
                historyIndex++;
                bmp = (Bitmap)history[historyIndex].Clone();
                g = Graphics.FromImage(bmp);
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}
