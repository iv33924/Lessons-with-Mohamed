namespace notebook_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
            }
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fd.Font;
            }
        }
    }
}
