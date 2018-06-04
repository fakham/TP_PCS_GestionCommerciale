namespace TP_PCS_GestionCommerciale2
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeNomClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientsParVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreClientsParVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeDeconnectéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.modeDeconnectéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeNomClientsToolStripMenuItem,
            this.listeClientsParVilleToolStripMenuItem,
            this.nombreClientsParVilleToolStripMenuItem,
            this.mAJClientToolStripMenuItem,
            this.etatToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // listeNomClientsToolStripMenuItem
            // 
            this.listeNomClientsToolStripMenuItem.Name = "listeNomClientsToolStripMenuItem";
            this.listeNomClientsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.listeNomClientsToolStripMenuItem.Text = "Liste nom clients";
            this.listeNomClientsToolStripMenuItem.Click += new System.EventHandler(this.listeNomClientsToolStripMenuItem_Click);
            // 
            // listeClientsParVilleToolStripMenuItem
            // 
            this.listeClientsParVilleToolStripMenuItem.Name = "listeClientsParVilleToolStripMenuItem";
            this.listeClientsParVilleToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.listeClientsParVilleToolStripMenuItem.Text = "Liste clients par ville";
            this.listeClientsParVilleToolStripMenuItem.Click += new System.EventHandler(this.listeClientsParVilleToolStripMenuItem_Click);
            // 
            // nombreClientsParVilleToolStripMenuItem
            // 
            this.nombreClientsParVilleToolStripMenuItem.Name = "nombreClientsParVilleToolStripMenuItem";
            this.nombreClientsParVilleToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.nombreClientsParVilleToolStripMenuItem.Text = "Nombre clients par ville";
            this.nombreClientsParVilleToolStripMenuItem.Click += new System.EventHandler(this.nombreClientsParVilleToolStripMenuItem_Click);
            // 
            // mAJClientToolStripMenuItem
            // 
            this.mAJClientToolStripMenuItem.Name = "mAJClientToolStripMenuItem";
            this.mAJClientToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.mAJClientToolStripMenuItem.Text = "MAJ Client";
            this.mAJClientToolStripMenuItem.Click += new System.EventHandler(this.mAJClientToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.commandeToolStripMenuItem.Text = "Commande";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // modeDeconnectéToolStripMenuItem
            // 
            this.modeDeconnectéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCommandesToolStripMenuItem,
            this.filterArticlesToolStripMenuItem});
            this.modeDeconnectéToolStripMenuItem.Name = "modeDeconnectéToolStripMenuItem";
            this.modeDeconnectéToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.modeDeconnectéToolStripMenuItem.Text = "Mode Deconnecté";
            // 
            // listeCommandesToolStripMenuItem
            // 
            this.listeCommandesToolStripMenuItem.Name = "listeCommandesToolStripMenuItem";
            this.listeCommandesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listeCommandesToolStripMenuItem.Text = "Liste Commandes";
            this.listeCommandesToolStripMenuItem.Click += new System.EventHandler(this.listeCommandesToolStripMenuItem_Click);
            // 
            // filterArticlesToolStripMenuItem
            // 
            this.filterArticlesToolStripMenuItem.Name = "filterArticlesToolStripMenuItem";
            this.filterArticlesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.filterArticlesToolStripMenuItem.Text = "Filter Articles";
            this.filterArticlesToolStripMenuItem.Click += new System.EventHandler(this.filterArticlesToolStripMenuItem_Click);
            // 
            // etatToolStripMenuItem
            // 
            this.etatToolStripMenuItem.Name = "etatToolStripMenuItem";
            this.etatToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.etatToolStripMenuItem.Text = "Etat";
            this.etatToolStripMenuItem.Click += new System.EventHandler(this.etatToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 485);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeNomClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClientsParVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreClientsParVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeDeconnectéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatToolStripMenuItem;
    }
}