
namespace Projet
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.PanelButton = new System.Windows.Forms.Button();
            this.LabelGestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.BackColor = System.Drawing.Color.White;
            this.PanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelButton.ForeColor = System.Drawing.Color.White;
            this.PanelButton.Image = ((System.Drawing.Image)(resources.GetObject("PanelButton.Image")));
            this.PanelButton.Location = new System.Drawing.Point(12, 12);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(66, 69);
            this.PanelButton.TabIndex = 2;
            this.PanelButton.UseVisualStyleBackColor = false;
            this.PanelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelGestion
            // 
            this.LabelGestion.AutoSize = true;
            this.LabelGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGestion.ForeColor = System.Drawing.Color.White;
            this.LabelGestion.Location = new System.Drawing.Point(84, 38);
            this.LabelGestion.Name = "LabelGestion";
            this.LabelGestion.Size = new System.Drawing.Size(158, 16);
            this.LabelGestion.TabIndex = 3;
            this.LabelGestion.Text = "Gestion des commandes";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(243, 240);
            this.Controls.Add(this.LabelGestion);
            this.Controls.Add(this.PanelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Menagelec - Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PanelButton;
        private System.Windows.Forms.Label LabelGestion;
    }
}