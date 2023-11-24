
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.UtilisateurText = new System.Windows.Forms.TextBox();
            this.MotdepasseText = new System.Windows.Forms.TextBox();
            this.ConnexionButton = new System.Windows.Forms.Button();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(49, 46);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(300, 298);
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
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
            // ConnexionButton
            // 
            this.ConnexionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnexionButton.Location = new System.Drawing.Point(376, 276);
            this.ConnexionButton.Name = "ConnexionButton";
            this.ConnexionButton.Size = new System.Drawing.Size(151, 31);
            this.ConnexionButton.TabIndex = 7;
            this.ConnexionButton.Text = "Se connecter";
            this.ConnexionButton.UseVisualStyleBackColor = true;
            this.ConnexionButton.Click += new System.EventHandler(this.Connexion_Click_1);
            // 
            // LabelUser
            // 
            this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelUser.ForeColor = System.Drawing.Color.White;
            this.LabelUser.Location = new System.Drawing.Point(377, 112);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(89, 21);
            this.LabelUser.TabIndex = 8;
            this.LabelUser.Text = "Utilisateur";
            this.LabelUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelPassword.ForeColor = System.Drawing.Color.White;
            this.LabelPassword.Location = new System.Drawing.Point(373, 187);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(93, 17);
            this.LabelPassword.TabIndex = 9;
            this.LabelPassword.Text = "Mot de passe";
            // 
            // Manegelec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.ConnexionButton);
            this.Controls.Add(this.MotdepasseText);
            this.Controls.Add(this.UtilisateurText);
            this.Controls.Add(this.PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manegelec";
            this.Text = "Manegelec - Accès à l\'application";
            this.Load += new System.EventHandler(this.Manegelec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox UtilisateurText;
        private System.Windows.Forms.TextBox MotdepasseText;
        private System.Windows.Forms.Button ConnexionButton;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label LabelPassword;
    }
}

