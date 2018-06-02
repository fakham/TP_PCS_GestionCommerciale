namespace TP_PCS_GestionCommerciale2
{
    partial class Form_ListeClientsVille
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
            this.comboBox_ville = new System.Windows.Forms.ComboBox();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ville : ";
            // 
            // comboBox_ville
            // 
            this.comboBox_ville.FormattingEnabled = true;
            this.comboBox_ville.Location = new System.Drawing.Point(178, 51);
            this.comboBox_ville.Name = "comboBox_ville";
            this.comboBox_ville.Size = new System.Drawing.Size(168, 21);
            this.comboBox_ville.TabIndex = 1;
            this.comboBox_ville.SelectedIndexChanged += new System.EventHandler(this.comboBox_ville_SelectedIndexChanged);
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Location = new System.Drawing.Point(49, 95);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(407, 261);
            this.dataGridView_clients.TabIndex = 2;
            // 
            // Form_ListeClientsVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 427);
            this.Controls.Add(this.dataGridView_clients);
            this.Controls.Add(this.comboBox_ville);
            this.Controls.Add(this.label1);
            this.Name = "Form_ListeClientsVille";
            this.Text = "Form_ListeClientsVille";
            this.Load += new System.EventHandler(this.Form_ListeClientsVille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ville;
        private System.Windows.Forms.DataGridView dataGridView_clients;
    }
}