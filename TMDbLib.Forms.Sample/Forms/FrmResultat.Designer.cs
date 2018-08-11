namespace TMDBForms.Forms
{
    partial class FrmResultat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LbGenres = new System.Windows.Forms.ListBox();
            this.LvActeurs = new System.Windows.Forms.ListView();
            this.LvActeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblOverview = new System.Windows.Forms.Label();
            this.TxtOverview = new System.Windows.Forms.TextBox();
            this.TvImages = new System.Windows.Forms.TreeView();
            this.PbPoster = new System.Windows.Forms.PictureBox();
            this.PbBackdrop = new System.Windows.Forms.PictureBox();
            this.LvStaff = new System.Windows.Forms.ListView();
            this.Section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fonction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtTMDbID = new System.Windows.Forms.TextBox();
            this.TxtRuntime = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtRating = new System.Windows.Forms.TextBox();
            this.TxtMpaa = new System.Windows.Forms.TextBox();
            this.LblRuntime = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.LblMpaa = new System.Windows.Forms.Label();
            this.LblRating = new System.Windows.Forms.Label();
            this.LblIMDbID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBackdrop)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(592, 524);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 20);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(655, 33);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbGenres
            // 
            this.LbGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbGenres.FormattingEnabled = true;
            this.LbGenres.Location = new System.Drawing.Point(15, 75);
            this.LbGenres.Name = "LbGenres";
            this.LbGenres.Size = new System.Drawing.Size(120, 52);
            this.LbGenres.TabIndex = 5;
            // 
            // LvActeurs
            // 
            this.LvActeurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvActeurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LvActeur,
            this.LvRole});
            this.LvActeurs.Location = new System.Drawing.Point(408, 75);
            this.LvActeurs.Name = "LvActeurs";
            this.LvActeurs.Size = new System.Drawing.Size(258, 124);
            this.LvActeurs.TabIndex = 6;
            this.LvActeurs.UseCompatibleStateImageBehavior = false;
            this.LvActeurs.View = System.Windows.Forms.View.Details;
            // 
            // LvActeur
            // 
            this.LvActeur.Text = "Acteur";
            this.LvActeur.Width = 120;
            // 
            // LvRole
            // 
            this.LvRole.Text = "Role";
            this.LvRole.Width = 120;
            // 
            // LblOverview
            // 
            this.LblOverview.Location = new System.Drawing.Point(12, 187);
            this.LblOverview.Name = "LblOverview";
            this.LblOverview.Size = new System.Drawing.Size(126, 15);
            this.LblOverview.TabIndex = 7;
            this.LblOverview.Text = "Overview";
            // 
            // TxtOverview
            // 
            this.TxtOverview.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOverview.Location = new System.Drawing.Point(12, 205);
            this.TxtOverview.Multiline = true;
            this.TxtOverview.Name = "TxtOverview";
            this.TxtOverview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOverview.Size = new System.Drawing.Size(654, 109);
            this.TxtOverview.TabIndex = 8;
            // 
            // TvImages
            // 
            this.TvImages.Location = new System.Drawing.Point(13, 321);
            this.TvImages.Name = "TvImages";
            this.TvImages.Size = new System.Drawing.Size(157, 197);
            this.TvImages.TabIndex = 9;
            this.TvImages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvImages_AfterSelect);
            // 
            // PbPoster
            // 
            this.PbPoster.Location = new System.Drawing.Point(536, 321);
            this.PbPoster.Name = "PbPoster";
            this.PbPoster.Size = new System.Drawing.Size(131, 197);
            this.PbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPoster.TabIndex = 10;
            this.PbPoster.TabStop = false;
            // 
            // PbBackdrop
            // 
            this.PbBackdrop.Location = new System.Drawing.Point(178, 321);
            this.PbBackdrop.Name = "PbBackdrop";
            this.PbBackdrop.Size = new System.Drawing.Size(350, 197);
            this.PbBackdrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBackdrop.TabIndex = 11;
            this.PbBackdrop.TabStop = false;
            // 
            // LvStaff
            // 
            this.LvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Section,
            this.Fonction,
            this.Nom});
            this.LvStaff.Location = new System.Drawing.Point(144, 75);
            this.LvStaff.Name = "LvStaff";
            this.LvStaff.Size = new System.Drawing.Size(258, 124);
            this.LvStaff.TabIndex = 6;
            this.LvStaff.UseCompatibleStateImageBehavior = false;
            this.LvStaff.View = System.Windows.Forms.View.Details;
            // 
            // Section
            // 
            this.Section.Text = "Section";
            // 
            // Fonction
            // 
            this.Fonction.Text = "Fonction";
            this.Fonction.Width = 80;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 100;
            // 
            // TxtTMDbID
            // 
            this.TxtTMDbID.Enabled = false;
            this.TxtTMDbID.Location = new System.Drawing.Point(75, 49);
            this.TxtTMDbID.Name = "TxtTMDbID";
            this.TxtTMDbID.Size = new System.Drawing.Size(60, 20);
            this.TxtTMDbID.TabIndex = 12;
            // 
            // TxtRuntime
            // 
            this.TxtRuntime.Enabled = false;
            this.TxtRuntime.Location = new System.Drawing.Point(299, 47);
            this.TxtRuntime.Name = "TxtRuntime";
            this.TxtRuntime.Size = new System.Drawing.Size(40, 20);
            this.TxtRuntime.TabIndex = 12;
            // 
            // TxtYear
            // 
            this.TxtYear.Enabled = false;
            this.TxtYear.Location = new System.Drawing.Point(197, 47);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(40, 20);
            this.TxtYear.TabIndex = 12;
            // 
            // TxtRating
            // 
            this.TxtRating.Enabled = false;
            this.TxtRating.Location = new System.Drawing.Point(626, 45);
            this.TxtRating.Name = "TxtRating";
            this.TxtRating.Size = new System.Drawing.Size(40, 20);
            this.TxtRating.TabIndex = 12;
            // 
            // TxtMpaa
            // 
            this.TxtMpaa.Enabled = false;
            this.TxtMpaa.Location = new System.Drawing.Point(524, 45);
            this.TxtMpaa.Name = "TxtMpaa";
            this.TxtMpaa.Size = new System.Drawing.Size(40, 20);
            this.TxtMpaa.TabIndex = 12;
            // 
            // LblRuntime
            // 
            this.LblRuntime.Location = new System.Drawing.Point(243, 50);
            this.LblRuntime.Name = "LblRuntime";
            this.LblRuntime.Size = new System.Drawing.Size(50, 15);
            this.LblRuntime.TabIndex = 7;
            this.LblRuntime.Text = "Runtime";
            // 
            // LblYear
            // 
            this.LblYear.Location = new System.Drawing.Point(141, 50);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(50, 15);
            this.LblYear.TabIndex = 7;
            this.LblYear.Text = "Year";
            // 
            // LblMpaa
            // 
            this.LblMpaa.Location = new System.Drawing.Point(468, 48);
            this.LblMpaa.Name = "LblMpaa";
            this.LblMpaa.Size = new System.Drawing.Size(50, 15);
            this.LblMpaa.TabIndex = 7;
            this.LblMpaa.Text = "MPAA";
            // 
            // LblRating
            // 
            this.LblRating.Location = new System.Drawing.Point(570, 48);
            this.LblRating.Name = "LblRating";
            this.LblRating.Size = new System.Drawing.Size(50, 15);
            this.LblRating.TabIndex = 7;
            this.LblRating.Text = "Rating";
            // 
            // LblIMDbID
            // 
            this.LblIMDbID.Location = new System.Drawing.Point(12, 52);
            this.LblIMDbID.Name = "LblIMDbID";
            this.LblIMDbID.Size = new System.Drawing.Size(50, 15);
            this.LblIMDbID.TabIndex = 7;
            this.LblIMDbID.Text = "IMDB ID";
            // 
            // FrmResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 556);
            this.Controls.Add(this.TxtMpaa);
            this.Controls.Add(this.TxtRating);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtRuntime);
            this.Controls.Add(this.TxtTMDbID);
            this.Controls.Add(this.PbBackdrop);
            this.Controls.Add(this.PbPoster);
            this.Controls.Add(this.TvImages);
            this.Controls.Add(this.TxtOverview);
            this.Controls.Add(this.LblRating);
            this.Controls.Add(this.LblMpaa);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblIMDbID);
            this.Controls.Add(this.LblRuntime);
            this.Controls.Add(this.LblOverview);
            this.Controls.Add(this.LvStaff);
            this.Controls.Add(this.LvActeurs);
            this.Controls.Add(this.LbGenres);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResultat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resultat";
            this.Load += new System.EventHandler(this.FrmResultat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBackdrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.ListBox LbGenres;
        private System.Windows.Forms.ListView LvActeurs;
        private System.Windows.Forms.ColumnHeader LvActeur;
        private System.Windows.Forms.ColumnHeader LvRole;
        private System.Windows.Forms.Label LblOverview;
        private System.Windows.Forms.TextBox TxtOverview;
        private System.Windows.Forms.TreeView TvImages;
        private System.Windows.Forms.PictureBox PbPoster;
        private System.Windows.Forms.PictureBox PbBackdrop;
        private System.Windows.Forms.ListView LvStaff;
        private System.Windows.Forms.ColumnHeader Section;
        private System.Windows.Forms.ColumnHeader Fonction;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.TextBox TxtTMDbID;
        private System.Windows.Forms.TextBox TxtRuntime;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtRating;
        private System.Windows.Forms.TextBox TxtMpaa;
        private System.Windows.Forms.Label LblRuntime;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.Label LblMpaa;
        private System.Windows.Forms.Label LblRating;
        private System.Windows.Forms.Label LblIMDbID;
    }
}