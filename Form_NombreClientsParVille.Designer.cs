namespace TP_PCS_GestionCommerciale2
{
    partial class Form_NombreClientsParVille
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
            this.comboBox_ville = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_ville
            // 
            this.comboBox_ville.FormattingEnabled = true;
            this.comboBox_ville.Location = new System.Drawing.Point(187, 82);
            this.comboBox_ville.Name = "comboBox_ville";
            this.comboBox_ville.Size = new System.Drawing.Size(161, 21);
            this.comboBox_ville.TabIndex = 0;
            this.comboBox_ville.SelectedIndexChanged += new System.EventHandler(this.comboBox_ville_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ville : ";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(227, 170);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(13, 13);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "0";
            // 
            // Form_NombreClientsParVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 258);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ville);
            this.Name = "Form_NombreClientsParVille";
            this.Text = "Form_NombreClientsParVille";
            this.Load += new System.EventHandler(this.Form_NombreClientsParVille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ville;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nombre;
    }
}