namespace TP_PCS_GestionCommerciale2
{
    partial class Form_ListeNomClients
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
            this.listBox_nomClients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_nomClients
            // 
            this.listBox_nomClients.FormattingEnabled = true;
            this.listBox_nomClients.Location = new System.Drawing.Point(146, 62);
            this.listBox_nomClients.Name = "listBox_nomClients";
            this.listBox_nomClients.Size = new System.Drawing.Size(226, 277);
            this.listBox_nomClients.TabIndex = 0;
            // 
            // Form_ListeNomClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 456);
            this.Controls.Add(this.listBox_nomClients);
            this.Name = "Form_ListeNomClients";
            this.Text = "Form_ListeNomClients";
            this.Load += new System.EventHandler(this.Form_ListeNomClients_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_nomClients;
    }
}