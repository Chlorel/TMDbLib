using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
    public partial class FrmResultat : Form
    {
        TMDbClient client;
        int MovieID;

        public FrmResultat(TMDbClient cli, int id)
        {
            InitializeComponent();
            client = cli;
            MovieID = id;

            this.ShowDialog();
        }

        private void ProcessImages(TMDbClient client, IEnumerable<ImageData> images, IEnumerable<string> sizes, string NodeName)
        {
            // Displays basic information about each image, as well as all the possible adresses for it.
            // All images should be available in all the sizes provided by the configuration.
            TvImages.Nodes[0].Nodes.Add(NodeName, NodeName);
            int Img = 0;
            foreach (ImageData imageData in images)
            {
                Img++;
                string sFrmt = Img + " - ["+ imageData.Width + "x"+ imageData.Height + "]";
                TvImages.Nodes[0].Nodes[NodeName].Nodes.Add(sFrmt, sFrmt);

                // Calculate the images path
                // There are multiple resizing available for each image, directly from TMDb.
                // There's always the "original" size if you're in doubt which to choose.
                foreach (string size in sizes)
                {
                    Uri imageUri = client.GetImageUrl(size, imageData.FilePath);
                    TvImages.Nodes[0].Nodes[NodeName].Nodes[sFrmt].Nodes.Add(size, size);
                    TvImages.Nodes[0].Nodes[NodeName].Nodes[sFrmt].Nodes[size].Tag = imageUri;
                }
            }
        }

        protected Image LoadImage(string ImgUrl)
        {
            try
            {
                WebClient WClient = new WebClient();
                byte[] imgData = WClient.DownloadData(ImgUrl);
                MemoryStream MemStream = new MemoryStream(imgData);
                Image Img = System.Drawing.Image.FromStream(MemStream, true, true);
                return Img;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null;
            }
        }

        private async void FrmResultat_Load(object sender, EventArgs e)
        {
            string MyLanguage = client.DefaultLanguage;
            client.DefaultLanguage = "en";
            Movie movieEN = await client.GetMovieAsync(MovieID, MovieMethods.Images);
            client.DefaultLanguage = MyLanguage;
            Movie movie = await client.GetMovieAsync(MovieID, MovieMethods.AlternativeTitles | MovieMethods.Releases | MovieMethods.Credits | MovieMethods.Images);

            LbGenres.Items.Clear();
            LvActeurs.Items.Clear();
            TvImages.Nodes.Clear();

            if (movie.Genres.Count != 0)
            {
                foreach ( var Genre in movie.Genres)
                {
                    LbGenres.Items.Add(Genre.Name);
                }
            }
            List<Crew> Staff = movie.Credits.Crew;
            if (Staff.Count != 0 )
            {
                foreach ( var People in Staff )
                {
                    ListViewItem Lvi = new ListViewItem(People.Department);
                    Lvi.SubItems.Add(People.Job);
                    Lvi.SubItems.Add(People.Name);
                    LvStaff.Items.Add(Lvi);
                }
            }
            List<Cast> Casting = movie.Credits.Cast;
            if (Casting.Count != 0)
            {
                foreach ( var Actor in Casting)
                {
                    ListViewItem Lvi = new ListViewItem(Actor.Name);
                    Lvi.SubItems.Add(Actor.Character);
                    LvActeurs.Items.Add(Lvi);
                }
            }

            TxtTMDbID.Text = movie.Id.ToString();
            TxtRuntime.Text = movie.Runtime.ToString();
            TxtYear.Text = movie.ReleaseDate.Value.Year.ToString();

            List<Country> Rc = movie.Releases.Countries;
            foreach ( Country C in Rc )
            {
                if ( C.Iso_3166_1.ToUpper() == "US")
                {
                    TxtMpaa.Text = C.Certification;
                    break;
                }
            }

            TxtRating.Text = movie.VoteAverage.ToString();
            string MyTitle = movie.Title + " (" + TxtYear.Text + ")";
            LblTitle.Text = MyTitle;

            TxtOverview.Text = movie.Overview;

            TvImages.Nodes.Add("Images");
            if (movieEN.Images.Backdrops.Count > 0)
            {
                ProcessImages(client, movieEN.Images.Backdrops, client.Config.Images.BackdropSizes, "Backdrops");
            }
            if (movie.Images.Posters.Count > 0)
            {
                ProcessImages(client, movie.Images.Posters, client.Config.Images.PosterSizes, "Posters");
            }

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void TvImages_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode Node = TvImages.SelectedNode;
            string[] Nodelevels = Node.FullPath.Split('\\');

            if (Nodelevels.Length == 4)
            {
                Uri Url = (Uri)Node.Tag;
                if (Nodelevels[1] == "Backdrops")
                {
                    PbBackdrop.Image = LoadImage(Url.ToString());
                }
                else
                {
                    PbPoster.Image = LoadImage(Url.ToString());
                }
            }

        }
    }
}
