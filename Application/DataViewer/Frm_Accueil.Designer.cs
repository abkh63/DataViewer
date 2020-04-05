namespace DataViewer
{
    partial class DataViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewer));
            this.listView1 = new System.Windows.Forms.ListView();
            this.sexe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.media = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.annee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Onglets = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ck_box_media_categorie = new System.Windows.Forms.CheckedListBox();
            this.ck_box_media_type = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ck_box_media = new System.Windows.Forms.CheckedListBox();
            this.ck_box_annee = new System.Windows.Forms.CheckedListBox();
            this.ck_box_heure = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.visualiser = new System.Windows.Forms.Button();
            this.Onglets.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sexe,
            this.media,
            this.type,
            this.categorie,
            this.annee,
            this.heure,
            this.taux});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 3);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1249, 780);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // sexe
            // 
            this.sexe.Text = "Sexe";
            this.sexe.Width = 180;
            // 
            // media
            // 
            this.media.Text = "Média";
            this.media.Width = 270;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 150;
            // 
            // categorie
            // 
            this.categorie.Text = "Catégorie";
            this.categorie.Width = 150;
            // 
            // annee
            // 
            this.annee.Text = "Année";
            this.annee.Width = 120;
            // 
            // heure
            // 
            this.heure.Text = "Heure";
            this.heure.Width = 100;
            // 
            // taux
            // 
            this.taux.Text = "Taux";
            this.taux.Width = 280;
            // 
            // Onglets
            // 
            this.Onglets.Controls.Add(this.tabPage1);
            this.Onglets.Controls.Add(this.tabPage2);
            this.Onglets.Location = new System.Drawing.Point(0, 1);
            this.Onglets.Margin = new System.Windows.Forms.Padding(2);
            this.Onglets.Name = "Onglets";
            this.Onglets.SelectedIndex = 0;
            this.Onglets.Size = new System.Drawing.Size(1268, 811);
            this.Onglets.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1260, 785);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.ck_box_media_categorie);
            this.tabPage2.Controls.Add(this.ck_box_media_type);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ck_box_media);
            this.tabPage2.Controls.Add(this.ck_box_annee);
            this.tabPage2.Controls.Add(this.ck_box_heure);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.visualiser);
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1260, 785);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualize";
            // 
            // ck_box_media_categorie
            // 
            this.ck_box_media_categorie.CheckOnClick = true;
            this.ck_box_media_categorie.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_box_media_categorie.FormattingEnabled = true;
            this.ck_box_media_categorie.Location = new System.Drawing.Point(849, 457);
            this.ck_box_media_categorie.Margin = new System.Windows.Forms.Padding(2);
            this.ck_box_media_categorie.Name = "ck_box_media_categorie";
            this.ck_box_media_categorie.Size = new System.Drawing.Size(109, 55);
            this.ck_box_media_categorie.TabIndex = 15;
            // 
            // ck_box_media_type
            // 
            this.ck_box_media_type.CheckOnClick = true;
            this.ck_box_media_type.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_box_media_type.FormattingEnabled = true;
            this.ck_box_media_type.Location = new System.Drawing.Point(849, 255);
            this.ck_box_media_type.Margin = new System.Windows.Forms.Padding(2);
            this.ck_box_media_type.Name = "ck_box_media_type";
            this.ck_box_media_type.Size = new System.Drawing.Size(109, 55);
            this.ck_box_media_type.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(878, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(873, 411);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Catégorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(595, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Média";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(263, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Année";
            // 
            // ck_box_media
            // 
            this.ck_box_media.CheckOnClick = true;
            this.ck_box_media.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_box_media.FormattingEnabled = true;
            this.ck_box_media.Location = new System.Drawing.Point(558, 195);
            this.ck_box_media.Margin = new System.Windows.Forms.Padding(2);
            this.ck_box_media.Name = "ck_box_media";
            this.ck_box_media.Size = new System.Drawing.Size(134, 378);
            this.ck_box_media.TabIndex = 9;
            // 
            // ck_box_annee
            // 
            this.ck_box_annee.CheckOnClick = true;
            this.ck_box_annee.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_box_annee.FormattingEnabled = true;
            this.ck_box_annee.Location = new System.Drawing.Point(241, 428);
            this.ck_box_annee.Margin = new System.Windows.Forms.Padding(2);
            this.ck_box_annee.Name = "ck_box_annee";
            this.ck_box_annee.Size = new System.Drawing.Size(109, 174);
            this.ck_box_annee.TabIndex = 8;
            // 
            // ck_box_heure
            // 
            this.ck_box_heure.CheckOnClick = true;
            this.ck_box_heure.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_box_heure.FormattingEnabled = true;
            this.ck_box_heure.Location = new System.Drawing.Point(241, 173);
            this.ck_box_heure.Margin = new System.Windows.Forms.Padding(2);
            this.ck_box_heure.Name = "ck_box_heure";
            this.ck_box_heure.Size = new System.Drawing.Size(109, 174);
            this.ck_box_heure.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Heure";
            // 
            // visualiser
            // 
            this.visualiser.BackColor = System.Drawing.Color.SlateGray;
            this.visualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualiser.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualiser.ForeColor = System.Drawing.Color.White;
            this.visualiser.Location = new System.Drawing.Point(538, 608);
            this.visualiser.Margin = new System.Windows.Forms.Padding(2);
            this.visualiser.Name = "visualiser";
            this.visualiser.Size = new System.Drawing.Size(167, 58);
            this.visualiser.TabIndex = 0;
            this.visualiser.Text = "Visualiser";
            this.visualiser.UseVisualStyleBackColor = false;
            this.visualiser.Click += new System.EventHandler(this.Visualiser_Click);
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1279, 814);
            this.Controls.Add(this.Onglets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DataViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Viewer";
            this.Onglets.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader sexe;
        private System.Windows.Forms.ColumnHeader media;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader categorie;
        private System.Windows.Forms.ColumnHeader annee;
        private System.Windows.Forms.ColumnHeader heure;
        private System.Windows.Forms.ColumnHeader taux;
        private System.Windows.Forms.TabControl Onglets;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button visualiser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ck_box_heure;
        private System.Windows.Forms.CheckedListBox ck_box_media;
        private System.Windows.Forms.CheckedListBox ck_box_annee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ck_box_media_categorie;
        private System.Windows.Forms.CheckedListBox ck_box_media_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

