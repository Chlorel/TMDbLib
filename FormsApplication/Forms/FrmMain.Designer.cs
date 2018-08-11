namespace TMDBForms.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblAPIKEY = new System.Windows.Forms.Label();
            this.TxtAPIKEY = new System.Windows.Forms.TextBox();
            this.BtnAPIKEY = new System.Windows.Forms.Button();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LvResults = new System.Windows.Forms.ListView();
            this.LvID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnOk = new System.Windows.Forms.Button();
            this.CmbLanguage = new System.Windows.Forms.ComboBox();
            this.LblLanguage = new System.Windows.Forms.Label();
            this.BtnLangue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAPIKEY
            // 
            this.LblAPIKEY.Location = new System.Drawing.Point(12, 9);
            this.LblAPIKEY.Name = "LblAPIKEY";
            this.LblAPIKEY.Size = new System.Drawing.Size(70, 20);
            this.LblAPIKEY.TabIndex = 0;
            this.LblAPIKEY.Text = "APIKEY";
            this.LblAPIKEY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtAPIKEY
            // 
            this.TxtAPIKEY.Location = new System.Drawing.Point(87, 9);
            this.TxtAPIKEY.Name = "TxtAPIKEY";
            this.TxtAPIKEY.Size = new System.Drawing.Size(285, 20);
            this.TxtAPIKEY.TabIndex = 1;
            // 
            // BtnAPIKEY
            // 
            this.BtnAPIKEY.Location = new System.Drawing.Point(378, 8);
            this.BtnAPIKEY.Name = "BtnAPIKEY";
            this.BtnAPIKEY.Size = new System.Drawing.Size(75, 20);
            this.BtnAPIKEY.TabIndex = 2;
            this.BtnAPIKEY.Text = "Authentify";
            this.BtnAPIKEY.UseVisualStyleBackColor = true;
            this.BtnAPIKEY.Click += new System.EventHandler(this.BtnAPIKEY_Click);
            // 
            // LblSearch
            // 
            this.LblSearch.Location = new System.Drawing.Point(12, 62);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(70, 33);
            this.LblSearch.TabIndex = 3;
            this.LblSearch.Text = "Search";
            this.LblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(87, 62);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(285, 33);
            this.TxtSearch.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Location = new System.Drawing.Point(378, 62);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 33);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LvResults
            // 
            this.LvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LvID,
            this.LvTitle,
            this.LvDate});
            this.LvResults.Location = new System.Drawing.Point(87, 101);
            this.LvResults.Name = "LvResults";
            this.LvResults.Size = new System.Drawing.Size(285, 142);
            this.LvResults.TabIndex = 6;
            this.LvResults.UseCompatibleStateImageBehavior = false;
            this.LvResults.View = System.Windows.Forms.View.Details;
            this.LvResults.SelectedIndexChanged += new System.EventHandler(this.LvResults_SelectedIndexChanged);
            // 
            // LvID
            // 
            this.LvID.Text = "ID";
            // 
            // LvTitle
            // 
            this.LvTitle.Text = "Title";
            this.LvTitle.Width = 150;
            // 
            // LvDate
            // 
            this.LvDate.Text = "Year";
            this.LvDate.Width = 58;
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Location = new System.Drawing.Point(378, 224);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 20);
            this.BtnOk.TabIndex = 5;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // CmbLanguage
            // 
            this.CmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLanguage.FormattingEnabled = true;
            this.CmbLanguage.Items.AddRange(new object[] {
            "en",
            "fr",
            "de",
            "it",
            "fi"});
            this.CmbLanguage.Location = new System.Drawing.Point(87, 35);
            this.CmbLanguage.Name = "CmbLanguage";
            this.CmbLanguage.Size = new System.Drawing.Size(121, 21);
            this.CmbLanguage.TabIndex = 7;
            this.CmbLanguage.SelectedIndexChanged += new System.EventHandler(this.CmbLanguage_SelectedIndexChanged);
            // 
            // LblLanguage
            // 
            this.LblLanguage.Location = new System.Drawing.Point(12, 34);
            this.LblLanguage.Name = "LblLanguage";
            this.LblLanguage.Size = new System.Drawing.Size(70, 20);
            this.LblLanguage.TabIndex = 0;
            this.LblLanguage.Text = "Language";
            this.LblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnLangue
            // 
            this.BtnLangue.Enabled = false;
            this.BtnLangue.Location = new System.Drawing.Point(378, 33);
            this.BtnLangue.Name = "BtnLangue";
            this.BtnLangue.Size = new System.Drawing.Size(75, 21);
            this.BtnLangue.TabIndex = 2;
            this.BtnLangue.Text = "Select";
            this.BtnLangue.UseVisualStyleBackColor = true;
            this.BtnLangue.Click += new System.EventHandler(this.BtnLangue_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 256);
            this.Controls.Add(this.CmbLanguage);
            this.Controls.Add(this.LvResults);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.BtnLangue);
            this.Controls.Add(this.BtnAPIKEY);
            this.Controls.Add(this.TxtAPIKEY);
            this.Controls.Add(this.LblLanguage);
            this.Controls.Add(this.LblAPIKEY);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMDbLib Test";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAPIKEY;
        private System.Windows.Forms.TextBox TxtAPIKEY;
        private System.Windows.Forms.Button BtnAPIKEY;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ListView LvResults;
        private System.Windows.Forms.ColumnHeader LvID;
        private System.Windows.Forms.ColumnHeader LvTitle;
        private System.Windows.Forms.ColumnHeader LvDate;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.ComboBox CmbLanguage;
        private System.Windows.Forms.Label LblLanguage;
        private System.Windows.Forms.Button BtnLangue;
    }
}

