
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
            this.Utilisateur = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UtilisateurText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MotdepasseText = new System.Windows.Forms.TextBox();
            this.Connexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Utilisateur
            // 
            this.Utilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.Utilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Utilisateur.ForeColor = System.Drawing.Color.White;
            this.Utilisateur.Location = new System.Drawing.Point(376, 113);
            this.Utilisateur.Margin = new System.Windows.Forms.Padding(0);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(151, 13);
            this.Utilisateur.TabIndex = 1;
            this.Utilisateur.Text = "Utilisateur";
            this.Utilisateur.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(376, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 13);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Mot de passe";
            // 
            // MotdepasseText
            // 
            this.MotdepasseText.ForeColor = System.Drawing.Color.Black;
            this.MotdepasseText.Location = new System.Drawing.Point(376, 225);
            this.MotdepasseText.Name = "MotdepasseText";
            this.MotdepasseText.Size = new System.Drawing.Size(151, 20);
            this.MotdepasseText.TabIndex = 6;
            // 
            // Connexion
            // 
            this.Connexion.Location = new System.Drawing.Point(376, 276);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(151, 31);
            this.Connexion.TabIndex = 7;
            this.Connexion.Text = "Se connecter";
            this.Connexion.UseVisualStyleBackColor = true;
            this.Connexion.Click += new System.EventHandler(this.Connexion_Click_1);
            // 
            // Manegelec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.MotdepasseText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UtilisateurText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Utilisateur);
            this.Name = "Manegelec";
            this.Text = "Manegelec - Accès à l\'application";
            this.Load += new System.EventHandler(this.Manegelec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Utilisateur;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UtilisateurText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox MotdepasseText;
        private System.Windows.Forms.Button Connexion;
    }
}

