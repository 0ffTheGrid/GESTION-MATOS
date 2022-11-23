
namespace Gestion_Matos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_materiel = new System.Windows.Forms.Button();
            this.Btn_interventions = new System.Windows.Forms.Button();
            this.button_site = new System.Windows.Forms.Button();
            this.button_type = new System.Windows.Forms.Button();
            this.client_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_quitter = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_materiel
            // 
            this.button_materiel.BackColor = System.Drawing.Color.White;
            this.button_materiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_materiel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_materiel.Location = new System.Drawing.Point(26, 257);
            this.button_materiel.Name = "button_materiel";
            this.button_materiel.Size = new System.Drawing.Size(227, 72);
            this.button_materiel.TabIndex = 4;
            this.button_materiel.Text = "Materiels";
            this.button_materiel.UseVisualStyleBackColor = false;
            this.button_materiel.Click += new System.EventHandler(this.button_materiel_Click);
            // 
            // Btn_interventions
            // 
            this.Btn_interventions.BackColor = System.Drawing.Color.White;
            this.Btn_interventions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_interventions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_interventions.Location = new System.Drawing.Point(301, 257);
            this.Btn_interventions.Name = "Btn_interventions";
            this.Btn_interventions.Size = new System.Drawing.Size(228, 72);
            this.Btn_interventions.TabIndex = 3;
            this.Btn_interventions.Text = "Interventions";
            this.Btn_interventions.UseVisualStyleBackColor = false;
            this.Btn_interventions.Click += new System.EventHandler(this.Btn_interventions_Click);
            // 
            // button_site
            // 
            this.button_site.BackColor = System.Drawing.Color.White;
            this.button_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_site.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_site.Location = new System.Drawing.Point(26, 452);
            this.button_site.Name = "button_site";
            this.button_site.Size = new System.Drawing.Size(227, 62);
            this.button_site.TabIndex = 2;
            this.button_site.Text = "Sites";
            this.button_site.UseVisualStyleBackColor = false;
            this.button_site.Click += new System.EventHandler(this.button_site_Click);
            // 
            // button_type
            // 
            this.button_type.BackColor = System.Drawing.Color.White;
            this.button_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_type.Location = new System.Drawing.Point(301, 355);
            this.button_type.Name = "button_type";
            this.button_type.Size = new System.Drawing.Size(227, 66);
            this.button_type.TabIndex = 1;
            this.button_type.Text = " Types";
            this.button_type.UseVisualStyleBackColor = false;
            this.button_type.Click += new System.EventHandler(this.button_type_Click);
            // 
            // client_btn
            // 
            this.client_btn.BackColor = System.Drawing.Color.White;
            this.client_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.client_btn.Location = new System.Drawing.Point(26, 355);
            this.client_btn.Name = "client_btn";
            this.client_btn.Size = new System.Drawing.Size(227, 66);
            this.client_btn.TabIndex = 0;
            this.client_btn.Text = "Clients";
            this.client_btn.UseVisualStyleBackColor = false;
            this.client_btn.Click += new System.EventHandler(this.client_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_quitter);
            this.panel2.Controls.Add(this.button_type);
            this.panel2.Controls.Add(this.button_materiel);
            this.panel2.Controls.Add(this.Btn_interventions);
            this.panel2.Controls.Add(this.client_btn);
            this.panel2.Controls.Add(this.button_site);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 573);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 41);
            this.label2.TabIndex = 19;
            this.label2.Text = "GESTION MATOS";
            // 
            // button_quitter
            // 
            this.button_quitter.BackColor = System.Drawing.Color.White;
            this.button_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quitter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_quitter.Location = new System.Drawing.Point(301, 452);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(227, 62);
            this.button_quitter.TabIndex = 16;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = false;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(551, 573);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Matos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_materiel;
        private System.Windows.Forms.Button Btn_interventions;
        private System.Windows.Forms.Button button_site;
        private System.Windows.Forms.Button button_type;
        private System.Windows.Forms.Button client_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Label label2;
    }
}

