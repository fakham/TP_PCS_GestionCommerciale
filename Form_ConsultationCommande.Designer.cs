namespace TP_PCS_GestionCommerciale2
{
    partial class Form_ConsultationCommande
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
            this.textBox_villeCl = new System.Windows.Forms.TextBox();
            this.textBox_nomCl = new System.Windows.Forms.TextBox();
            this.comboBox_codeCl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_articles = new System.Windows.Forms.DataGridView();
            this.textBox_CA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_cmds = new System.Windows.Forms.DataGridView();
            this.button_supprimerCmd = new System.Windows.Forms.Button();
            this.textBox_tva = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ttc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cmds)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_villeCl
            // 
            this.textBox_villeCl.Location = new System.Drawing.Point(115, 168);
            this.textBox_villeCl.Name = "textBox_villeCl";
            this.textBox_villeCl.Size = new System.Drawing.Size(173, 20);
            this.textBox_villeCl.TabIndex = 16;
            // 
            // textBox_nomCl
            // 
            this.textBox_nomCl.Location = new System.Drawing.Point(115, 136);
            this.textBox_nomCl.Name = "textBox_nomCl";
            this.textBox_nomCl.Size = new System.Drawing.Size(173, 20);
            this.textBox_nomCl.TabIndex = 15;
            // 
            // comboBox_codeCl
            // 
            this.comboBox_codeCl.FormattingEnabled = true;
            this.comboBox_codeCl.Location = new System.Drawing.Point(115, 105);
            this.comboBox_codeCl.Name = "comboBox_codeCl";
            this.comboBox_codeCl.Size = new System.Drawing.Size(173, 21);
            this.comboBox_codeCl.TabIndex = 14;
            this.comboBox_codeCl.SelectedIndexChanged += new System.EventHandler(this.comboBox_codeCl_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ville ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "code client";
            // 
            // dataGridView_articles
            // 
            this.dataGridView_articles.AllowUserToAddRows = false;
            this.dataGridView_articles.AllowUserToDeleteRows = false;
            this.dataGridView_articles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_articles.Location = new System.Drawing.Point(56, 418);
            this.dataGridView_articles.Name = "dataGridView_articles";
            this.dataGridView_articles.ReadOnly = true;
            this.dataGridView_articles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_articles.Size = new System.Drawing.Size(638, 168);
            this.dataGridView_articles.TabIndex = 17;
            // 
            // textBox_CA
            // 
            this.textBox_CA.Location = new System.Drawing.Point(557, 139);
            this.textBox_CA.Name = "textBox_CA";
            this.textBox_CA.Size = new System.Drawing.Size(173, 20);
            this.textBox_CA.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chiffre d\'affaires";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Consultation des commandes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "commades du clients";
            // 
            // dataGridView_cmds
            // 
            this.dataGridView_cmds.AllowUserToAddRows = false;
            this.dataGridView_cmds.AllowUserToDeleteRows = false;
            this.dataGridView_cmds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cmds.Location = new System.Drawing.Point(56, 236);
            this.dataGridView_cmds.Name = "dataGridView_cmds";
            this.dataGridView_cmds.ReadOnly = true;
            this.dataGridView_cmds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cmds.Size = new System.Drawing.Size(308, 124);
            this.dataGridView_cmds.TabIndex = 22;
            this.dataGridView_cmds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cmds_CellContentClick);
            // 
            // button_supprimerCmd
            // 
            this.button_supprimerCmd.Location = new System.Drawing.Point(402, 242);
            this.button_supprimerCmd.Name = "button_supprimerCmd";
            this.button_supprimerCmd.Size = new System.Drawing.Size(175, 23);
            this.button_supprimerCmd.TabIndex = 23;
            this.button_supprimerCmd.Text = "<< Supprimer la Commande";
            this.button_supprimerCmd.UseVisualStyleBackColor = true;
            this.button_supprimerCmd.Click += new System.EventHandler(this.button_supprimerCmd_Click);
            // 
            // textBox_tva
            // 
            this.textBox_tva.Location = new System.Drawing.Point(474, 314);
            this.textBox_tva.Name = "textBox_tva";
            this.textBox_tva.Size = new System.Drawing.Size(173, 20);
            this.textBox_tva.TabIndex = 27;
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(474, 282);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(173, 20);
            this.textBox_total.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "TVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total";
            // 
            // textBox_ttc
            // 
            this.textBox_ttc.Location = new System.Drawing.Point(474, 349);
            this.textBox_ttc.Name = "textBox_ttc";
            this.textBox_ttc.Size = new System.Drawing.Size(173, 20);
            this.textBox_ttc.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "TTC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "details de la commande sélectionnée : ";
            // 
            // button_Quitter
            // 
            this.button_Quitter.Location = new System.Drawing.Point(704, 563);
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.Size = new System.Drawing.Size(75, 23);
            this.button_Quitter.TabIndex = 31;
            this.button_Quitter.Text = "Quitter";
            this.button_Quitter.UseVisualStyleBackColor = true;
            this.button_Quitter.Click += new System.EventHandler(this.button_Quitter_Click);
            // 
            // Form_ConsultationCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 598);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_ttc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_tva);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_supprimerCmd);
            this.Controls.Add(this.dataGridView_cmds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_CA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_articles);
            this.Controls.Add(this.textBox_villeCl);
            this.Controls.Add(this.textBox_nomCl);
            this.Controls.Add(this.comboBox_codeCl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form_ConsultationCommande";
            this.Text = "Form_ConsultationCommande";
            this.Load += new System.EventHandler(this.Form_ConsultationCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cmds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_villeCl;
        private System.Windows.Forms.TextBox textBox_nomCl;
        private System.Windows.Forms.ComboBox comboBox_codeCl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_articles;
        private System.Windows.Forms.TextBox textBox_CA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_cmds;
        private System.Windows.Forms.Button button_supprimerCmd;
        private System.Windows.Forms.TextBox textBox_tva;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ttc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_Quitter;
    }
}