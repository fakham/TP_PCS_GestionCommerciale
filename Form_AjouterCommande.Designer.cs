namespace TP_PCS_GestionCommerciale2
{
    partial class Form_AjouterCommande
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_numeroCmd = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dateCmd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_codeCl = new System.Windows.Forms.ComboBox();
            this.textBox_nomCl = new System.Windows.Forms.TextBox();
            this.textBox_villeCl = new System.Windows.Forms.TextBox();
            this.dataGridView_articles = new System.Windows.Forms.DataGridView();
            this.CodeArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_codeArt = new System.Windows.Forms.ComboBox();
            this.textBox_designationArt = new System.Windows.Forms.TextBox();
            this.textBox_puArt = new System.Windows.Forms.TextBox();
            this.textBox_qunatiteArt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_AjouterLigne = new System.Windows.Forms.Button();
            this.button_supprimerLigne = new System.Windows.Forms.Button();
            this.button_Quitter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.button_enregistrerCmd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisie d\'une commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "numero commande";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "date commande";
            // 
            // textBox_numeroCmd
            // 
            this.textBox_numeroCmd.Location = new System.Drawing.Point(189, 92);
            this.textBox_numeroCmd.Name = "textBox_numeroCmd";
            this.textBox_numeroCmd.Size = new System.Drawing.Size(100, 20);
            this.textBox_numeroCmd.TabIndex = 3;
            // 
            // dateTimePicker_dateCmd
            // 
            this.dateTimePicker_dateCmd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateCmd.Location = new System.Drawing.Point(189, 121);
            this.dateTimePicker_dateCmd.Name = "dateTimePicker_dateCmd";
            this.dateTimePicker_dateCmd.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_dateCmd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "code client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ville ";
            // 
            // comboBox_codeCl
            // 
            this.comboBox_codeCl.FormattingEnabled = true;
            this.comboBox_codeCl.Location = new System.Drawing.Point(435, 92);
            this.comboBox_codeCl.Name = "comboBox_codeCl";
            this.comboBox_codeCl.Size = new System.Drawing.Size(100, 21);
            this.comboBox_codeCl.TabIndex = 8;
            this.comboBox_codeCl.SelectedIndexChanged += new System.EventHandler(this.comboBox_codeCl_SelectedIndexChanged);
            // 
            // textBox_nomCl
            // 
            this.textBox_nomCl.Location = new System.Drawing.Point(435, 123);
            this.textBox_nomCl.Name = "textBox_nomCl";
            this.textBox_nomCl.Size = new System.Drawing.Size(100, 20);
            this.textBox_nomCl.TabIndex = 9;
            // 
            // textBox_villeCl
            // 
            this.textBox_villeCl.Location = new System.Drawing.Point(435, 155);
            this.textBox_villeCl.Name = "textBox_villeCl";
            this.textBox_villeCl.Size = new System.Drawing.Size(100, 20);
            this.textBox_villeCl.TabIndex = 10;
            // 
            // dataGridView_articles
            // 
            this.dataGridView_articles.AllowUserToAddRows = false;
            this.dataGridView_articles.AllowUserToDeleteRows = false;
            this.dataGridView_articles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_articles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeArt,
            this.Designation,
            this.PU,
            this.Quantite,
            this.Montant});
            this.dataGridView_articles.Location = new System.Drawing.Point(12, 236);
            this.dataGridView_articles.Name = "dataGridView_articles";
            this.dataGridView_articles.ReadOnly = true;
            this.dataGridView_articles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_articles.Size = new System.Drawing.Size(638, 168);
            this.dataGridView_articles.TabIndex = 11;
            // 
            // CodeArt
            // 
            this.CodeArt.HeaderText = "Code Article";
            this.CodeArt.Name = "CodeArt";
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.Width = 200;
            // 
            // PU
            // 
            this.PU.HeaderText = "PU";
            this.PU.Name = "PU";
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            // 
            // comboBox_codeArt
            // 
            this.comboBox_codeArt.FormattingEnabled = true;
            this.comboBox_codeArt.Location = new System.Drawing.Point(54, 209);
            this.comboBox_codeArt.Name = "comboBox_codeArt";
            this.comboBox_codeArt.Size = new System.Drawing.Size(100, 21);
            this.comboBox_codeArt.TabIndex = 12;
            this.comboBox_codeArt.SelectedIndexChanged += new System.EventHandler(this.comboBox_codeArt_SelectedIndexChanged);
            // 
            // textBox_designationArt
            // 
            this.textBox_designationArt.Location = new System.Drawing.Point(161, 209);
            this.textBox_designationArt.Name = "textBox_designationArt";
            this.textBox_designationArt.Size = new System.Drawing.Size(188, 20);
            this.textBox_designationArt.TabIndex = 13;
            // 
            // textBox_puArt
            // 
            this.textBox_puArt.Location = new System.Drawing.Point(359, 209);
            this.textBox_puArt.Name = "textBox_puArt";
            this.textBox_puArt.Size = new System.Drawing.Size(88, 20);
            this.textBox_puArt.TabIndex = 14;
            // 
            // textBox_qunatiteArt
            // 
            this.textBox_qunatiteArt.Location = new System.Drawing.Point(461, 209);
            this.textBox_qunatiteArt.Name = "textBox_qunatiteArt";
            this.textBox_qunatiteArt.Size = new System.Drawing.Size(81, 20);
            this.textBox_qunatiteArt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Message ";
            // 
            // button_AjouterLigne
            // 
            this.button_AjouterLigne.Location = new System.Drawing.Point(665, 207);
            this.button_AjouterLigne.Name = "button_AjouterLigne";
            this.button_AjouterLigne.Size = new System.Drawing.Size(104, 23);
            this.button_AjouterLigne.TabIndex = 17;
            this.button_AjouterLigne.Text = "Ajouter Ligne";
            this.button_AjouterLigne.UseVisualStyleBackColor = true;
            this.button_AjouterLigne.Click += new System.EventHandler(this.button_AjouterLigne_Click);
            // 
            // button_supprimerLigne
            // 
            this.button_supprimerLigne.Location = new System.Drawing.Point(665, 355);
            this.button_supprimerLigne.Name = "button_supprimerLigne";
            this.button_supprimerLigne.Size = new System.Drawing.Size(104, 23);
            this.button_supprimerLigne.TabIndex = 18;
            this.button_supprimerLigne.Text = "Supprimer Ligne";
            this.button_supprimerLigne.UseVisualStyleBackColor = true;
            this.button_supprimerLigne.Click += new System.EventHandler(this.button_supprimerLigne_Click);
            // 
            // button_Quitter
            // 
            this.button_Quitter.Location = new System.Drawing.Point(678, 433);
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.Size = new System.Drawing.Size(104, 23);
            this.button_Quitter.TabIndex = 19;
            this.button_Quitter.Text = "Quitter";
            this.button_Quitter.UseVisualStyleBackColor = true;
            this.button_Quitter.Click += new System.EventHandler(this.button_Quitter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Total : ";
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(538, 416);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(108, 20);
            this.textBox_total.TabIndex = 21;
            this.textBox_total.Text = "0";
            // 
            // button_enregistrerCmd
            // 
            this.button_enregistrerCmd.Location = new System.Drawing.Point(136, 414);
            this.button_enregistrerCmd.Name = "button_enregistrerCmd";
            this.button_enregistrerCmd.Size = new System.Drawing.Size(143, 23);
            this.button_enregistrerCmd.TabIndex = 22;
            this.button_enregistrerCmd.Text = "Enregistrer la commande";
            this.button_enregistrerCmd.UseVisualStyleBackColor = true;
            this.button_enregistrerCmd.Click += new System.EventHandler(this.button_enregistrerCmd_Click);
            // 
            // Form_AjouterCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 468);
            this.Controls.Add(this.button_enregistrerCmd);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.button_supprimerLigne);
            this.Controls.Add(this.button_AjouterLigne);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_qunatiteArt);
            this.Controls.Add(this.textBox_puArt);
            this.Controls.Add(this.textBox_designationArt);
            this.Controls.Add(this.comboBox_codeArt);
            this.Controls.Add(this.dataGridView_articles);
            this.Controls.Add(this.textBox_villeCl);
            this.Controls.Add(this.textBox_nomCl);
            this.Controls.Add(this.comboBox_codeCl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_dateCmd);
            this.Controls.Add(this.textBox_numeroCmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_AjouterCommande";
            this.Text = "Form_AjouterCommande";
            this.Load += new System.EventHandler(this.Form_AjouterCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_numeroCmd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateCmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_codeCl;
        private System.Windows.Forms.TextBox textBox_nomCl;
        private System.Windows.Forms.TextBox textBox_villeCl;
        private System.Windows.Forms.DataGridView dataGridView_articles;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.ComboBox comboBox_codeArt;
        private System.Windows.Forms.TextBox textBox_designationArt;
        private System.Windows.Forms.TextBox textBox_puArt;
        private System.Windows.Forms.TextBox textBox_qunatiteArt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_AjouterLigne;
        private System.Windows.Forms.Button button_supprimerLigne;
        private System.Windows.Forms.Button button_Quitter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Button button_enregistrerCmd;
    }
}