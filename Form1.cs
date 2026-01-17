using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class AnimeEntry
    {
        public string Title { get; set; }
        public string Genre { get; set; }
    }

    public partial class Form1 : Form
    {
        private readonly string filePath = "animeData.json";

        public Form1()
        {
            InitializeComponent();

            btnadd.Text = "Add";
            btnrmv.Text = "Remove";

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Initialize columns to be equal
            SetupColumns();
            LoadData();

            // This ensures that if the window is resized, both columns 
            // update to stay exactly 50% of the total width.
            listView1.SizeChanged += (s, e) => {
                UpdateColumnWidths();
            };
        }

        private void SetupColumns()
        {
            listView1.Columns.Clear();
            // Add columns without fixed widths first
            listView1.Columns.Add("Anime Title");
            listView1.Columns.Add("Genre");
            UpdateColumnWidths();
        }

        private void UpdateColumnWidths()
        {
            if (listView1.Columns.Count >= 2)
            {
                // Divide the total width by 2 (minus a small buffer for the scrollbar)
                int equalWidth = (listView1.ClientSize.Width) / 2;
                listView1.Columns[0].Width = equalWidth;
                listView1.Columns[1].Width = equalWidth;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string animeTitle = Animetxtbx.Text.Trim();
            string animeGenre = Genretxtbx.Text.Trim();

            if (string.IsNullOrEmpty(animeTitle) || string.IsNullOrEmpty(animeGenre))
            {
                MessageBox.Show("Please enter both anime title and genre.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem(animeTitle);
            item.SubItems.Add(animeGenre);
            listView1.Items.Add(item);

            Animetxtbx.Clear();
            Genretxtbx.Clear();
            Animetxtbx.Focus();

            UpdateColumnWidths();
            SaveData();
        }

        private void btnrmv_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listView1.Items.Remove(listView1.SelectedItems[0]);
            UpdateColumnWidths();
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                List<AnimeEntry> list = new List<AnimeEntry>();
                foreach (ListViewItem item in listView1.Items)
                {
                    list.Add(new AnimeEntry
                    {
                        Title = item.Text,
                        Genre = item.SubItems[1].Text
                    });
                }
                string jsonString = JsonSerializer.Serialize(list);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    var list = JsonSerializer.Deserialize<List<AnimeEntry>>(jsonString);

                    if (list != null)
                    {
                        listView1.Items.Clear();
                        foreach (var anime in list)
                        {
                            ListViewItem item = new ListViewItem(anime.Title);
                            item.SubItems.Add(anime.Genre);
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}