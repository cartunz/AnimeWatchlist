using System.IO;

namespace AnimeWatchlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addbtn.Click += addbtn_Click;
            removebtn.Click += removebtn_Click;
            removebtn.Text = "Remove";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string animeTitle = inputtxbox.Text.Trim();
            if (!string.IsNullOrEmpty(animeTitle))
            {
                listBox1.Items.Add(animeTitle);
                inputtxbox.Clear();
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }
    }
}
