namespace TP_PCS_GestionCommerciale2
{
    partial class Form_FilterArticles
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_description = new System.Windows.Forms.CheckBox();
            this.checkBox_PU = new System.Windows.Forms.CheckBox();
            this.checkBox_QtteStock = new System.Windows.Forms.CheckBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_PU = new System.Windows.Forms.TextBox();
            this.textBox_QtteStock = new System.Windows.Forms.TextBox();
            this.button_recherche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_articles = new System.Windows.Forms.DataGridView();
            this.button_XML = new System.Windows.Forms.Button();
            this.button_imprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Critère de Filter : ";
            // 
            // checkBox_description
            // 
            this.checkBox_description.AutoSize = true;
            this.checkBox_description.Location = new System.Drawing.Point(98, 87);
            this.checkBox_description.Name = "checkBox_description";
            this.checkBox_description.Size = new System.Drawing.Size(79, 17);
            this.checkBox_description.TabIndex = 1;
            this.checkBox_description.Text = "Description";
            this.checkBox_description.UseVisualStyleBackColor = true;
            // 
            // checkBox_PU
            // 
            this.checkBox_PU.AutoSize = true;
            this.checkBox_PU.Location = new System.Drawing.Point(98, 119);
            this.checkBox_PU.Name = "checkBox_PU";
            this.checkBox_PU.Size = new System.Drawing.Size(41, 17);
            this.checkBox_PU.TabIndex = 2;
            this.checkBox_PU.Text = "PU";
            this.checkBox_PU.UseVisualStyleBackColor = true;
            // 
            // checkBox_QtteStock
            // 
            this.checkBox_QtteStock.AutoSize = true;
            this.checkBox_QtteStock.Location = new System.Drawing.Point(98, 151);
            this.checkBox_QtteStock.Name = "checkBox_QtteStock";
            this.checkBox_QtteStock.Size = new System.Drawing.Size(77, 17);
            this.checkBox_QtteStock.TabIndex = 3;
            this.checkBox_QtteStock.Text = "Qtte Stock";
            this.checkBox_QtteStock.UseVisualStyleBackColor = true;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(207, 85);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(100, 20);
            this.textBox_description.TabIndex = 4;
            // 
            // textBox_PU
            // 
            this.textBox_PU.Location = new System.Drawing.Point(207, 117);
            this.textBox_PU.Name = "textBox_PU";
            this.textBox_PU.Size = new System.Drawing.Size(100, 20);
            this.textBox_PU.TabIndex = 5;
            // 
            // textBox_QtteStock
            // 
            this.textBox_QtteStock.Location = new System.Drawing.Point(207, 149);
            this.textBox_QtteStock.Name = "textBox_QtteStock";
            this.textBox_QtteStock.Size = new System.Drawing.Size(100, 20);
            this.textBox_QtteStock.TabIndex = 6;
            // 
            // button_recherche
            // 
            this.button_recherche.Location = new System.Drawing.Point(382, 147);
            this.button_recherche.Name = "button_recherche";
            this.button_recherche.Size = new System.Drawing.Size(75, 23);
            this.button_recherche.TabIndex = 7;
            this.button_recherche.Text = "Recherche";
            this.button_recherche.UseVisualStyleBackColor = true;
            this.button_recherche.Click += new System.EventHandler(this.button_recherche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Produits : ";
            // 
            // dataGridView_articles
            // 
            this.dataGridView_articles.AllowUserToAddRows = false;
            this.dataGridView_articles.AllowUserToDeleteRows = false;
            this.dataGridView_articles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_articles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_articles.Location = new System.Drawing.Point(28, 239);
            this.dataGridView_articles.Name = "dataGridView_articles";
            this.dataGridView_articles.ReadOnly = true;
            this.dataGridView_articles.Size = new System.Drawing.Size(479, 185);
            this.dataGridView_articles.TabIndex = 9;
            this.dataGridView_articles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_articles_CellContentClick);
            // 
            // button_XML
            // 
            this.button_XML.Location = new System.Drawing.Point(82, 442);
            this.button_XML.Name = "button_XML";
            this.button_XML.Size = new System.Drawing.Size(104, 23);
            this.button_XML.TabIndex = 10;
            this.button_XML.Text = "Générer XML";
            this.button_XML.UseVisualStyleBackColor = true;
            this.button_XML.Click += new System.EventHandler(this.button_XML_Click);
            // 
            // button_imprimer
            // 
            this.button_imprimer.Location = new System.Drawing.Point(400, 442);
            this.button_imprimer.Name = "button_imprimer";
            this.button_imprimer.Size = new System.Drawing.Size(75, 23);
            this.button_imprimer.TabIndex = 11;
            this.button_imprimer.Text = "Imprimer";
            this.button_imprimer.UseVisualStyleBackColor = true;
            this.button_imprimer.Click += new System.EventHandler(this.button_imprimer_Click);
            // 
            // Form_FilterArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 495);
            this.Controls.Add(this.button_imprimer);
            this.Controls.Add(this.button_XML);
            this.Controls.Add(this.dataGridView_articles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_recherche);
            this.Controls.Add(this.textBox_QtteStock);
            this.Controls.Add(this.textBox_PU);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.checkBox_QtteStock);
            this.Controls.Add(this.checkBox_PU);
            this.Controls.Add(this.checkBox_description);
            this.Controls.Add(this.label1);
            this.Name = "Form_FilterArticles";
            this.Text = "Form_FilterArticles";
            this.Load += new System.EventHandler(this.Form_FilterArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_description;
        private System.Windows.Forms.CheckBox checkBox_PU;
        private System.Windows.Forms.CheckBox checkBox_QtteStock;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_PU;
        private System.Windows.Forms.TextBox textBox_QtteStock;
        private System.Windows.Forms.Button button_recherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_articles;
        private System.Windows.Forms.Button button_XML;
        private System.Windows.Forms.Button button_imprimer;
    }
}