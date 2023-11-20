
namespace Projet
{
    partial class Manegelec
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manegelec));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UtilisateurText = new System.Windows.Forms.TextBox();
            this.MotdepasseText = new System.Windows.Forms.TextBox();
            this.Connexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 298);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UtilisateurText
            // 
            this.UtilisateurText.ForeColor = System.Drawing.Color.Black;
            this.UtilisateurText.Location = new System.Drawing.Point(376, 145);
            this.UtilisateurText.Name = "UtilisateurText";
            this.UtilisateurText.Size = new System.Drawing.Size(151, 20);
            this.UtilisateurText.TabIndex = 4;
            this.UtilisateurText.Text = "fournier";
            this.UtilisateurText.TextChanged += new System.EventHandler(this.UtilisateurText_TextChanged);
            // 
            // MotdepasseText
            // 
            this.MotdepasseText.ForeColor = System.Drawing.Color.Black;
            this.MotdepasseText.Location = new System.Drawing.Point(376, 225);
            this.MotdepasseText.Name = "MotdepasseText";
            this.MotdepasseText.PasswordChar = '*';
            this.MotdepasseText.Size = new System.Drawing.Size(151, 20);
            this.MotdepasseText.TabIndex = 6;
            this.MotdepasseText.Text = "1234";
            // 
            // Connexion
            // 
            this.Connexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connexion.Location = new System.Drawing.Point(376, 276);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(151, 31);
            this.Connexion.TabIndex = 7;
            this.Connexion.Text = "Se connecter";
            this.Connexion.UseVisualStyleBackColor = true;
            this.Connexion.Click += new System.EventHandler(this.Connexion_Click_1);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Utilisateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe";
            // 
            // Manegelec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.MotdepasseText);
            this.Controls.Add(this.UtilisateurText);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manegelec";
            this.Text = "Manegelec - Accès à l\'application";
            this.Load += new System.EventHandler(this.Manegelec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UtilisateurText;
        private System.Windows.Forms.TextBox MotdepasseText;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

