namespace TP_PCS_GestionCommerciale2
{
    partial class Form_ListeCommandes_ModeDeconnecte
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
            this.comboBox_nomClient = new System.Windows.Forms.ComboBox();
            this.label_codeCl = new System.Windows.Forms.Label();
            this.label_villeCl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_cmds = new System.Windows.Forms.DataGridView();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.NumCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cmds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des commandes par client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom client : ";
            // 
            // comboBox_nomClient
            // 
            this.comboBox_nomClient.FormattingEnabled = true;
            this.comboBox_nomClient.Location = new System.Drawing.Point(267, 106);
            this.comboBox_nomClient.Name = "comboBox_nomClient";
            this.comboBox_nomClient.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nomClient.TabIndex = 2;
            this.comboBox_nomClient.SelectedIndexChanged += new System.EventHandler(this.comboBox_nomClient_SelectedIndexChanged);
            // 
            // label_codeCl
            // 
            this.label_codeCl.AutoSize = true;
            this.label_codeCl.Location = new System.Drawing.Point(170, 152);
            this.label_codeCl.Name = "label_codeCl";
            this.label_codeCl.Size = new System.Drawing.Size(41, 13);
            this.label_codeCl.TabIndex = 3;
            this.label_codeCl.Text = "Code : ";
            // 
            // label_villeCl
            // 
            this.label_villeCl.AutoSize = true;
            this.label_villeCl.Location = new System.Drawing.Point(301, 152);
            this.label_villeCl.Name = "label_villeCl";
            this.label_villeCl.Size = new System.Drawing.Size(35, 13);
            this.label_villeCl.TabIndex = 4;
            this.label_villeCl.Text = "Ville : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste des commandes :";
            // 
            // dataGridView_cmds
            // 
            this.dataGridView_cmds.AllowUserToAddRows = false;
            this.dataGridView_cmds.AllowUserToDeleteRows = false;
            this.dataGridView_cmds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cmds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCom,
            this.Date,
            this.Detail,
            this.Supprimer});
            this.dataGridView_cmds.Location = new System.Drawing.Point(102, 253);
            this.dataGridView_cmds.Name = "dataGridView_cmds";
            this.dataGridView_cmds.Size = new System.Drawing.Size(484, 150);
            this.dataGridView_cmds.TabIndex = 6;
            this.dataGridView_cmds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cmds_CellContentClick);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(455, 430);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_Supprimer.TabIndex = 7;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // NumCom
            // 
            this.NumCom.HeaderText = "NumCom";
            this.NumCom.Name = "NumCom";
            this.NumCom.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Text = "Voir";
            // 
            // Supprimer
            // 
            this.Supprimer.FalseValue = "";
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.TrueValue = "";
            // 
            // Form_ListeCommandes_ModeDeconnecte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 516);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.dataGridView_cmds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_villeCl);
            this.Controls.Add(this.label_codeCl);
            this.Controls.Add(this.comboBox_nomClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_ListeCommandes_ModeDeconnecte";
            this.Text = "Form_ListeCommandes_ModeDeconnecte";
            this.Load += new System.EventHandler(this.Form_ListeCommandes_ModeDeconnecte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cmds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_nomClient;
        private System.Windows.Forms.Label label_codeCl;
        private System.Windows.Forms.Label label_villeCl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_cmds;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Supprimer;
    }
}