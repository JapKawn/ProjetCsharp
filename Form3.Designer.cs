
using System;
using System.Windows.Forms;

namespace Projet
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.MenuButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ListButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CheckTout = new System.Windows.Forms.CheckBox();
            this.CheckPayer = new System.Windows.Forms.CheckBox();
            this.CheckExpedier = new System.Windows.Forms.CheckBox();
            this.DataGridViewCommande = new System.Windows.Forms.DataGridView();
            this.LabelListe = new System.Windows.Forms.Label();
            this.LabelGestion = new System.Windows.Forms.Label();
            this.LabelCommandeSelec = new System.Windows.Forms.Label();
            this.LabelRecherche = new System.Windows.Forms.Label();
            this.LabelClient = new System.Windows.Forms.Label();
            this.LabelCommande = new System.Windows.Forms.Label();
            this.LabelDoc = new System.Windows.Forms.Label();
            this.DataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Location = new System.Drawing.Point(688, 429);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 41);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Retour au menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(575, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(575, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ListButton
            // 
            this.ListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListButton.Location = new System.Drawing.Point(581, 293);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(133, 30);
            this.ListButton.TabIndex = 7;
            this.ListButton.Text = "Liste de colisage";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Tout";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CheckTout
            // 
            this.CheckTout.AutoSize = true;
            this.CheckTout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckTout.ForeColor = System.Drawing.Color.White;
            this.CheckTout.Location = new System.Drawing.Point(12, 81);
            this.CheckTout.Name = "CheckTout";
            this.CheckTout.Size = new System.Drawing.Size(48, 17);
            this.CheckTout.TabIndex = 11;
            this.CheckTout.Text = "Tout";
            this.CheckTout.UseVisualStyleBackColor = true;
            this.CheckTout.CheckedChanged += new System.EventHandler(this.CheckTout_CheckedChanged);
            // 
            // CheckPayer
            // 
            this.CheckPayer.AutoSize = true;
            this.CheckPayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPayer.ForeColor = System.Drawing.Color.White;
            this.CheckPayer.Location = new System.Drawing.Point(66, 81);
            this.CheckPayer.Name = "CheckPayer";
            this.CheckPayer.Size = new System.Drawing.Size(62, 17);
            this.CheckPayer.TabIndex = 12;
            this.CheckPayer.Text = "A payer";
            this.CheckPayer.UseVisualStyleBackColor = true;
            this.CheckPayer.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // CheckExpedier
            // 
            this.CheckExpedier.AutoSize = true;
            this.CheckExpedier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckExpedier.ForeColor = System.Drawing.Color.White;
            this.CheckExpedier.Location = new System.Drawing.Point(134, 81);
            this.CheckExpedier.Name = "CheckExpedier";
            this.CheckExpedier.Size = new System.Drawing.Size(76, 17);
            this.CheckExpedier.TabIndex = 13;
            this.CheckExpedier.Text = "A expédier";
            this.CheckExpedier.UseVisualStyleBackColor = true;
            // 
            // DataGridViewCommande
            // 
            this.DataGridViewCommande.AllowUserToResizeColumns = false;
            this.DataGridViewCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewCommande.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCommande.ColumnHeadersVisible = false;
            this.DataGridViewCommande.Location = new System.Drawing.Point(12, 117);
            this.DataGridViewCommande.Name = "DataGridViewCommande";
            this.DataGridViewCommande.RowHeadersVisible = false;
            this.DataGridViewCommande.Size = new System.Drawing.Size(198, 353);
            this.DataGridViewCommande.TabIndex = 14;
            this.DataGridViewCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LabelListe
            // 
            this.LabelListe.AutoSize = true;
            this.LabelListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelListe.ForeColor = System.Drawing.Color.White;
            this.LabelListe.Location = new System.Drawing.Point(9, 48);
            this.LabelListe.Name = "LabelListe";
            this.LabelListe.Size = new System.Drawing.Size(145, 17);
            this.LabelListe.TabIndex = 15;
            this.LabelListe.Text = "Liste des commandes";
            // 
            // LabelGestion
            // 
            this.LabelGestion.AutoSize = true;
            this.LabelGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LabelGestion.ForeColor = System.Drawing.Color.White;
            this.LabelGestion.Location = new System.Drawing.Point(302, 16);
            this.LabelGestion.Name = "LabelGestion";
            this.LabelGestion.Size = new System.Drawing.Size(195, 20);
            this.LabelGestion.TabIndex = 16;
            this.LabelGestion.Text = "Gestion des commandes";
            this.LabelGestion.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelCommandeSelec
            // 
            this.LabelCommandeSelec.AutoSize = true;
            this.LabelCommandeSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelCommandeSelec.ForeColor = System.Drawing.Color.White;
            this.LabelCommandeSelec.Location = new System.Drawing.Point(277, 48);
            this.LabelCommandeSelec.Name = "LabelCommandeSelec";
            this.LabelCommandeSelec.Size = new System.Drawing.Size(261, 17);
            this.LabelCommandeSelec.TabIndex = 17;
            this.LabelCommandeSelec.Text = "Recherche de la commande séléctionné";
            // 
            // LabelRecherche
            // 
            this.LabelRecherche.AutoSize = true;
            this.LabelRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelRecherche.ForeColor = System.Drawing.Color.White;
            this.LabelRecherche.Location = new System.Drawing.Point(580, 35);
            this.LabelRecherche.Name = "LabelRecherche";
            this.LabelRecherche.Size = new System.Drawing.Size(145, 17);
            this.LabelRecherche.TabIndex = 18;
            this.LabelRecherche.Text = "Recherche spécifique";
            this.LabelRecherche.Click += new System.EventHandler(this.label4_Click);
            // 
            // LabelClient
            // 
            this.LabelClient.AutoSize = true;
            this.LabelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelClient.ForeColor = System.Drawing.Color.White;
            this.LabelClient.Location = new System.Drawing.Point(572, 98);
            this.LabelClient.Name = "LabelClient";
            this.LabelClient.Size = new System.Drawing.Size(134, 17);
            this.LabelClient.TabIndex = 19;
            this.LabelClient.Text = "Recherche un client";
            this.LabelClient.Click += new System.EventHandler(this.label5_Click);
            // 
            // LabelCommande
            // 
            this.LabelCommande.AutoSize = true;
            this.LabelCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelCommande.ForeColor = System.Drawing.Color.White;
            this.LabelCommande.Location = new System.Drawing.Point(572, 160);
            this.LabelCommande.Name = "LabelCommande";
            this.LabelCommande.Size = new System.Drawing.Size(183, 17);
            this.LabelCommande.TabIndex = 20;
            this.LabelCommande.Text = "Rechercher une commande";
            // 
            // LabelDoc
            // 
            this.LabelDoc.AutoSize = true;
            this.LabelDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelDoc.ForeColor = System.Drawing.Color.White;
            this.LabelDoc.Location = new System.Drawing.Point(580, 258);
            this.LabelDoc.Name = "LabelDoc";
            this.LabelDoc.Size = new System.Drawing.Size(79, 17);
            this.LabelDoc.TabIndex = 21;
            this.LabelDoc.Text = "Documents";
            // 
            // DataGridViewInfo
            // 
            this.DataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInfo.Location = new System.Drawing.Point(257, 343);
            this.DataGridViewInfo.Name = "DataGridViewInfo";
            this.DataGridViewInfo.Size = new System.Drawing.Size(240, 127);
            this.DataGridViewInfo.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(257, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 95);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(257, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 105);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(778, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridViewInfo);
            this.Controls.Add(this.LabelDoc);
            this.Controls.Add(this.LabelCommande);
            this.Controls.Add(this.LabelClient);
            this.Controls.Add(this.LabelRecherche);
            this.Controls.Add(this.LabelCommandeSelec);
            this.Controls.Add(this.LabelGestion);
            this.Controls.Add(this.LabelListe);
            this.Controls.Add(this.DataGridViewCommande);
            this.Controls.Add(this.CheckExpedier);
            this.Controls.Add(this.CheckPayer);
            this.Controls.Add(this.CheckTout);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MenuButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Gestion des commandes";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        protected System.Windows.Forms.Button MenuButton;
        protected System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.TextBox textBox4;
        protected System.Windows.Forms.Button ListButton;
        protected System.Windows.Forms.CheckBox checkBox1;
        protected System.Windows.Forms.CheckBox CheckTout;
        protected System.Windows.Forms.CheckBox CheckPayer;
        protected System.Windows.Forms.CheckBox CheckExpedier;
        private DataGridViewCellEventHandler dataGridView1_CellContentClick_2;

        public Form3(DataGridViewCellEventHandler dataGridView1_CellContentClick_2)
        {
            this.dataGridView1_CellContentClick_2 = dataGridView1_CellContentClick_2;
        }

        private DataGridView DataGridViewCommande;
        private Label LabelListe;
        private Label LabelGestion;
        private Label LabelCommandeSelec;
        private Label LabelRecherche;
        private Label LabelClient;
        private Label LabelCommande;
        private Label LabelDoc;
        private DataGridView DataGridViewInfo;
        private Panel panel1;
        private Panel panel2;
    }
}