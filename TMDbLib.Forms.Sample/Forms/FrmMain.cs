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
        string      LANGUE;
        int         MovieID;

        public FrmMain()
        {
            InitializeComponent();
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
            try
            {
                client = new TMDbClient(TxtAPIKEY.Text);

                List<TMDbLib.Objects.Languages.Language> Lng = await client.GetLanguagesAsync();

                foreach ( var l in Lng)
                {
                    CmbLanguage.Items.Add(l.Iso_639_1);
                    if (l.Iso_639_1 == LANGUE)
                    {
                        CmbLanguage.Text = LANGUE;
                    }
                }

                TMDBForms.Properties.Settings.Default.APIKEY = TxtAPIKEY.Text;
                TMDBForms.Properties.Settings.Default.Save();

                await FetchConfig(client);
            }
            catch (Exception ex)
            {
                string message = ex.Message;

            }
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
            LANGUE = CmbLanguage.Text;

            TMDBForms.Properties.Settings.Default.LANGUE = LANGUE;
            TMDBForms.Properties.Settings.Default.Save();

            BtnLangue.Enabled = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LANGUE         = TMDBForms.Properties.Settings.Default.LANGUE;
            TxtAPIKEY.Text = TMDBForms.Properties.Settings.Default.APIKEY;
        }

        private void BtnLangue_Click(object sender, EventArgs e)
        {
            client.DefaultLanguage = LANGUE;
            BtnSearch.Enabled = true;
        }
    }
}
