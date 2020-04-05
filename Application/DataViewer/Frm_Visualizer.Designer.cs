namespace DataViewer
{
    partial class Frm_Visualizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Visualizer));
            this.chartMedia = new LiveCharts.WinForms.CartesianChart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMedia = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAnnee = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.chartAnnees = new LiveCharts.WinForms.CartesianChart();
            this.tabHeure = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.chartHeures = new LiveCharts.WinForms.CartesianChart();
            this.tabType = new System.Windows.Forms.TabPage();
            this.lblWarning2 = new System.Windows.Forms.Label();
            this.lblWarning1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartTv = new LiveCharts.WinForms.PieChart();
            this.chartRadio = new LiveCharts.WinForms.PieChart();
            this.tabCategorie = new System.Windows.Forms.TabPage();
            this.lblWarning4 = new System.Windows.Forms.Label();
            this.lblWarning3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chartPrivee = new LiveCharts.WinForms.PieChart();
            this.chartPublique = new LiveCharts.WinForms.PieChart();
            this.tabData = new System.Windows.Forms.TabPage();
            this.lvData = new System.Windows.Forms.ListView();
            this.sexe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.media = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.annee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabMedia.SuspendLayout();
            this.tabAnnee.SuspendLayout();
            this.tabHeure.SuspendLayout();
            this.tabType.SuspendLayout();
            this.tabCategorie.SuspendLayout();
            this.tabData.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMedia
            // 
            this.chartMedia.Location = new System.Drawing.Point(24, 58);
            this.chartMedia.Margin = new System.Windows.Forms.Padding(2);
            this.chartMedia.Name = "chartMedia";
            this.chartMedia.Size = new System.Drawing.Size(1119, 583);
            this.chartMedia.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMedia);
            this.tabControl1.Controls.Add(this.tabAnnee);
            this.tabControl1.Controls.Add(this.tabHeure);
            this.tabControl1.Controls.Add(this.tabType);
            this.tabControl1.Controls.Add(this.tabCategorie);
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 680);
            this.tabControl1.TabIndex = 4;
            // 
            // tabMedia
            // 
            this.tabMedia.Controls.Add(this.label1);
            this.tabMedia.Controls.Add(this.chartMedia);
            this.tabMedia.Location = new System.Drawing.Point(4, 22);
            this.tabMedia.Margin = new System.Windows.Forms.Padding(2);
            this.tabMedia.Name = "tabMedia";
            this.tabMedia.Padding = new System.Windows.Forms.Padding(2);
            this.tabMedia.Size = new System.Drawing.Size(1143, 654);
            this.tabMedia.TabIndex = 0;
            this.tabMedia.Text = "Media";
            this.tabMedia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Taux de participation des hommes et des femmes / Media";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabAnnee
            // 
            this.tabAnnee.Controls.Add(this.label4);
            this.tabAnnee.Controls.Add(this.chartAnnees);
            this.tabAnnee.Location = new System.Drawing.Point(4, 22);
            this.tabAnnee.Margin = new System.Windows.Forms.Padding(2);
            this.tabAnnee.Name = "tabAnnee";
            this.tabAnnee.Padding = new System.Windows.Forms.Padding(2);
            this.tabAnnee.Size = new System.Drawing.Size(1143, 654);
            this.tabAnnee.TabIndex = 1;
            this.tabAnnee.Text = "Années";
            this.tabAnnee.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(554, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Taux de participation des hommes et des femmes / Année";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartAnnees
            // 
            this.chartAnnees.Location = new System.Drawing.Point(19, 54);
            this.chartAnnees.Margin = new System.Windows.Forms.Padding(2);
            this.chartAnnees.Name = "chartAnnees";
            this.chartAnnees.Size = new System.Drawing.Size(1119, 583);
            this.chartAnnees.TabIndex = 2;
            // 
            // tabHeure
            // 
            this.tabHeure.Controls.Add(this.label5);
            this.tabHeure.Controls.Add(this.chartHeures);
            this.tabHeure.Location = new System.Drawing.Point(4, 22);
            this.tabHeure.Margin = new System.Windows.Forms.Padding(2);
            this.tabHeure.Name = "tabHeure";
            this.tabHeure.Size = new System.Drawing.Size(1143, 654);
            this.tabHeure.TabIndex = 2;
            this.tabHeure.Text = "Heures";
            this.tabHeure.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(550, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Taux de participation des hommes et des femmes / Heure";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartHeures
            // 
            this.chartHeures.Location = new System.Drawing.Point(6, 67);
            this.chartHeures.Margin = new System.Windows.Forms.Padding(2);
            this.chartHeures.Name = "chartHeures";
            this.chartHeures.Size = new System.Drawing.Size(1119, 583);
            this.chartHeures.TabIndex = 3;
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.lblWarning2);
            this.tabType.Controls.Add(this.lblWarning1);
            this.tabType.Controls.Add(this.label6);
            this.tabType.Controls.Add(this.label3);
            this.tabType.Controls.Add(this.label2);
            this.tabType.Controls.Add(this.chartTv);
            this.tabType.Controls.Add(this.chartRadio);
            this.tabType.Location = new System.Drawing.Point(4, 22);
            this.tabType.Name = "tabType";
            this.tabType.Size = new System.Drawing.Size(1143, 654);
            this.tabType.TabIndex = 3;
            this.tabType.Text = "Types Media";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // lblWarning2
            // 
            this.lblWarning2.AutoSize = true;
            this.lblWarning2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWarning2.Location = new System.Drawing.Point(810, 308);
            this.lblWarning2.Name = "lblWarning2";
            this.lblWarning2.Size = new System.Drawing.Size(98, 57);
            this.lblWarning2.TabIndex = 14;
            this.lblWarning2.Text = "NO DATA \r\nAVAILABLE\r\n!";
            this.lblWarning2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarning1
            // 
            this.lblWarning1.AutoSize = true;
            this.lblWarning1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWarning1.Location = new System.Drawing.Point(208, 308);
            this.lblWarning1.Name = "lblWarning1";
            this.lblWarning1.Size = new System.Drawing.Size(98, 57);
            this.lblWarning1.TabIndex = 13;
            this.lblWarning1.Text = "NO DATA\r\nAVAILABLE\r\n!";
            this.lblWarning1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(632, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Taux de participation des hommes et des femmes / Type de Media";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Radio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(851, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "TV";
            // 
            // chartTv
            // 
            this.chartTv.Location = new System.Drawing.Point(648, 110);
            this.chartTv.Name = "chartTv";
            this.chartTv.Size = new System.Drawing.Size(417, 434);
            this.chartTv.TabIndex = 1;
            // 
            // chartRadio
            // 
            this.chartRadio.Location = new System.Drawing.Point(55, 110);
            this.chartRadio.Name = "chartRadio";
            this.chartRadio.Size = new System.Drawing.Size(417, 434);
            this.chartRadio.TabIndex = 0;
            this.chartRadio.Text = "pieChart1";
            // 
            // tabCategorie
            // 
            this.tabCategorie.Controls.Add(this.lblWarning4);
            this.tabCategorie.Controls.Add(this.lblWarning3);
            this.tabCategorie.Controls.Add(this.label7);
            this.tabCategorie.Controls.Add(this.label8);
            this.tabCategorie.Controls.Add(this.label9);
            this.tabCategorie.Controls.Add(this.chartPrivee);
            this.tabCategorie.Controls.Add(this.chartPublique);
            this.tabCategorie.Location = new System.Drawing.Point(4, 22);
            this.tabCategorie.Name = "tabCategorie";
            this.tabCategorie.Size = new System.Drawing.Size(1143, 654);
            this.tabCategorie.TabIndex = 4;
            this.tabCategorie.Text = "Catégories Media";
            this.tabCategorie.UseVisualStyleBackColor = true;
            // 
            // lblWarning4
            // 
            this.lblWarning4.AutoSize = true;
            this.lblWarning4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWarning4.Location = new System.Drawing.Point(808, 301);
            this.lblWarning4.Name = "lblWarning4";
            this.lblWarning4.Size = new System.Drawing.Size(98, 57);
            this.lblWarning4.TabIndex = 11;
            this.lblWarning4.Text = "NO DATA\r\nAVAILABLE\r\n!";
            this.lblWarning4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarning3
            // 
            this.lblWarning3.AutoSize = true;
            this.lblWarning3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWarning3.Location = new System.Drawing.Point(223, 301);
            this.lblWarning3.Name = "lblWarning3";
            this.lblWarning3.Size = new System.Drawing.Size(98, 57);
            this.lblWarning3.TabIndex = 12;
            this.lblWarning3.Text = "NO DATA\r\nAVAILABLE\r\n!";
            this.lblWarning3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(675, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Taux de participation des hommes et des femmes / Catégorie de Media";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 588);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Publique";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(858, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Privé";
            // 
            // chartPrivee
            // 
            this.chartPrivee.Location = new System.Drawing.Point(636, 114);
            this.chartPrivee.Name = "chartPrivee";
            this.chartPrivee.Size = new System.Drawing.Size(417, 434);
            this.chartPrivee.TabIndex = 7;
            this.chartPrivee.Text = "pieChart1";
            // 
            // chartPublique
            // 
            this.chartPublique.Location = new System.Drawing.Point(67, 114);
            this.chartPublique.Name = "chartPublique";
            this.chartPublique.Size = new System.Drawing.Size(417, 434);
            this.chartPublique.TabIndex = 6;
            this.chartPublique.Text = "pieChart1";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.lvData);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(1143, 654);
            this.tabData.TabIndex = 5;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // lvData
            // 
            this.lvData.AllowColumnReorder = true;
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sexe,
            this.media,
            this.type,
            this.categorie,
            this.annee,
            this.heure,
            this.taux});
            this.lvData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(2, 2);
            this.lvData.Margin = new System.Windows.Forms.Padding(2);
            this.lvData.Name = "lvData";
            this.lvData.ShowItemToolTips = true;
            this.lvData.Size = new System.Drawing.Size(1136, 648);
            this.lvData.TabIndex = 1;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // sexe
            // 
            this.sexe.Text = "Sexe";
            this.sexe.Width = 150;
            // 
            // media
            // 
            this.media.Text = "Média";
            this.media.Width = 250;
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
            this.annee.Width = 110;
            // 
            // heure
            // 
            this.heure.Text = "Heure";
            this.heure.Width = 100;
            // 
            // taux
            // 
            this.taux.Text = "Taux";
            this.taux.Width = 270;
            // 
            // Frm_Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 684);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Visualizer";
            this.Text = "Frm_Visualizer";
            this.tabControl1.ResumeLayout(false);
            this.tabMedia.ResumeLayout(false);
            this.tabMedia.PerformLayout();
            this.tabAnnee.ResumeLayout(false);
            this.tabAnnee.PerformLayout();
            this.tabHeure.ResumeLayout(false);
            this.tabHeure.PerformLayout();
            this.tabType.ResumeLayout(false);
            this.tabType.PerformLayout();
            this.tabCategorie.ResumeLayout(false);
            this.tabCategorie.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart chartMedia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMedia;
        private System.Windows.Forms.TabPage tabAnnee;
        private LiveCharts.WinForms.CartesianChart chartAnnees;
        private System.Windows.Forms.TabPage tabHeure;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart chartHeures;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.TabPage tabCategorie;
        private LiveCharts.WinForms.PieChart chartTv;
        private LiveCharts.WinForms.PieChart chartRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private LiveCharts.WinForms.PieChart chartPrivee;
        private LiveCharts.WinForms.PieChart chartPublique;
        private System.Windows.Forms.Label lblWarning4;
        private System.Windows.Forms.Label lblWarning1;
        private System.Windows.Forms.Label lblWarning3;
        private System.Windows.Forms.Label lblWarning2;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader sexe;
        private System.Windows.Forms.ColumnHeader media;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader categorie;
        private System.Windows.Forms.ColumnHeader annee;
        private System.Windows.Forms.ColumnHeader heure;
        private System.Windows.Forms.ColumnHeader taux;
    }
}