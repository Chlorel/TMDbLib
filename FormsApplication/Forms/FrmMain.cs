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
using Newtonsoft.Json;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace TMDBForms.Forms
{
    public partial class FrmMain : Form
    {
        TMDbClient  client;
        int         MovieID;

        public FrmMain()
        {
            InitializeComponent();
            BtnAPIKEY.Enabled = false;
        }

        private async Task FetchConfig(TMDbClient client)
        {
            FileInfo configJson = new FileInfo("config.json");

            if (configJson.Exists && configJson.LastWriteTimeUtc >= DateTime.UtcNow.AddHours(-1))
            {
                string json = File.ReadAllText(configJson.FullName, Encoding.UTF8);
                client.SetConfig(JsonConvert.DeserializeObject<TMDbConfig>(json));
            }
            else
            {
                var config = await client.GetConfigAsync();
                string json = JsonConvert.SerializeObject(config);
                File.WriteAllText(configJson.FullName, json, Encoding.UTF8);
            }
        }

        private async Task FetchMovieExample(TMDbClient client, string query)
        {
            // This example shows the fetching of a movie.
            // Say the user searches for "Thor" in order to find "Thor: The Dark World" or "Thor"
            SearchContainer<SearchMovie> results = await client.SearchMovieAsync(query);

            // The results is a list, currently on page 1 because we didn't specify any page.
            // Let's iterate the first few hits
            ListViewItem LvItem;
            LvResults.Items.Clear();
            string rdate = "";
            foreach (SearchMovie result in results.Results.Take(10))
            {
                LvItem = new ListViewItem();
                LvItem.Text = result.Id.ToString();
                LvItem.SubItems.Add(result.Title);
                try
                {
                    rdate = result.ReleaseDate.Value.Year.ToString();
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    rdate = "";
                }
                LvItem.SubItems.Add(rdate);
                LvResults.Items.Add(LvItem);
            }
        }

        private async void BtnAPIKEY_Click(object sender, EventArgs e)
        {
            client = new TMDbClient(TxtAPIKEY.Text);
            client.DefaultLanguage = CmbLanguage.Text;
            await FetchConfig(client);

            BtnSearch.Enabled = true;
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = TxtSearch.Text;
            // Try fetching a movie
            await FetchMovieExample(client, query);

        }

        private void LvResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieID = Convert.ToInt32( LvResults.SelectedItems[0].Text );
            var Frm = new FrmResultat(client, MovieID);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void CmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAPIKEY.Enabled = true;
        }
    }
}
