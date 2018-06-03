namespace TP_PCS_GestionCommerciale2
{
    partial class Form_DetailCommande
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
            this.label_NumCmd = new System.Windows.Forms.Label();
            this.label_DateCmd = new System.Windows.Forms.Label();
            this.label_NumCl = new System.Windows.Forms.Label();
            this.dataGridView_articles = new System.Windows.Forms.DataGridView();
            this.NumP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtteCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Commande";
            // 
            // label_NumCmd
            // 
            this.label_NumCmd.AutoSize = true;
            this.label_NumCmd.Location = new System.Drawing.Point(98, 90);
            this.label_NumCmd.Name = "label_NumCmd";
            this.label_NumCmd.Size = new System.Drawing.Size(91, 13);
            this.label_NumCmd.TabIndex = 1;
            this.label_NumCmd.Text = "NumCommande : ";
            // 
            // label_DateCmd
            // 
            this.label_DateCmd.AutoSize = true;
            this.label_DateCmd.Location = new System.Drawing.Point(98, 127);
            this.label_DateCmd.Name = "label_DateCmd";
            this.label_DateCmd.Size = new System.Drawing.Size(39, 13);
            this.label_DateCmd.TabIndex = 2;
            this.label_DateCmd.Text = "Date : ";
            // 
            // label_NumCl
            // 
            this.label_NumCl.AutoSize = true;
            this.label_NumCl.Location = new System.Drawing.Point(98, 162);
            this.label_NumCl.Name = "label_NumCl";
            this.label_NumCl.Size = new System.Drawing.Size(67, 13);
            this.label_NumCl.TabIndex = 3;
            this.label_NumCl.Text = "Num Client : ";
            // 
            // dataGridView_articles
            // 
            this.dataGridView_articles.AllowUserToAddRows = false;
            this.dataGridView_articles.AllowUserToDeleteRows = false;
            this.dataGridView_articles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_articles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_articles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumP,
            this.Description,
            this.Prix,
            this.QtteCom});
            this.dataGridView_articles.Location = new System.Drawing.Point(41, 208);
            this.dataGridView_articles.Name = "dataGridView_articles";
            this.dataGridView_articles.ReadOnly = true;
            this.dataGridView_articles.Size = new System.Drawing.Size(507, 184);
            this.dataGridView_articles.TabIndex = 4;
            this.dataGridView_articles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_articles_CellFormatting);
            // 
            // NumP
            // 
            this.NumP.HeaderText = "NumP";
            this.NumP.Name = "NumP";
            this.NumP.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // QtteCom
            // 
            this.QtteCom.HeaderText = "QtteCom";
            this.QtteCom.Name = "QtteCom";
            this.QtteCom.ReadOnly = true;
            // 
            // Form_DetailCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 431);
            this.Controls.Add(this.dataGridView_articles);
            this.Controls.Add(this.label_NumCl);
            this.Controls.Add(this.label_DateCmd);
            this.Controls.Add(this.label_NumCmd);
            this.Controls.Add(this.label1);
            this.Name = "Form_DetailCommande";
            this.Text = "Form_DetailCommande";
            this.Load += new System.EventHandler(this.Form_DetailCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NumCmd;
        private System.Windows.Forms.Label label_DateCmd;
        private System.Windows.Forms.Label label_NumCl;
        private System.Windows.Forms.DataGridView dataGridView_articles;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtteCom;
    }
}