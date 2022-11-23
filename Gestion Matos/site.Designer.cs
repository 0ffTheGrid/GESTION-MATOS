
namespace Gestion_Matos
{
    partial class site
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(site));
            this.ButtonQuitter = new System.Windows.Forms.Button();
            this.Btn_valider = new System.Windows.Forms.Button();
            this.Btn_supprimer = new System.Windows.Forms.Button();
            this.Btn_modification = new System.Windows.Forms.Button();
            this.Btn_nouveau = new System.Windows.Forms.Button();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.text_box_site_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_box_sites = new System.Windows.Forms.ListBox();
            this.text_box_adresse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonQuitter
            // 
            this.ButtonQuitter.BackColor = System.Drawing.Color.White;
            this.ButtonQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonQuitter.ForeColor = System.Drawing.Color.Black;
            this.ButtonQuitter.Location = new System.Drawing.Point(403, 318);
            this.ButtonQuitter.Name = "ButtonQuitter";
            this.ButtonQuitter.Size = new System.Drawing.Size(94, 37);
            this.ButtonQuitter.TabIndex = 90;
            this.ButtonQuitter.Text = "Quitter";
            this.ButtonQuitter.UseVisualStyleBackColor = false;
            // 
            // Btn_valider
            // 
            this.Btn_valider.BackColor = System.Drawing.Color.White;
            this.Btn_valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_valider.ForeColor = System.Drawing.Color.Black;
            this.Btn_valider.Location = new System.Drawing.Point(356, 268);
            this.Btn_valider.Name = "Btn_valider";
            this.Btn_valider.Size = new System.Drawing.Size(141, 34);
            this.Btn_valider.TabIndex = 89;
            this.Btn_valider.Text = "Valider";
            this.Btn_valider.UseVisualStyleBackColor = false;
            this.Btn_valider.Click += new System.EventHandler(this.Btn_valider_Click);
            // 
            // Btn_supprimer
            // 
            this.Btn_supprimer.BackColor = System.Drawing.Color.White;
            this.Btn_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_supprimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_supprimer.ForeColor = System.Drawing.Color.Black;
            this.Btn_supprimer.Location = new System.Drawing.Point(356, 217);
            this.Btn_supprimer.Name = "Btn_supprimer";
            this.Btn_supprimer.Size = new System.Drawing.Size(141, 34);
            this.Btn_supprimer.TabIndex = 88;
            this.Btn_supprimer.Text = "Supprimer";
            this.Btn_supprimer.UseVisualStyleBackColor = false;
            this.Btn_supprimer.Click += new System.EventHandler(this.Btn_supprimer_Click);
            // 
            // Btn_modification
            // 
            this.Btn_modification.BackColor = System.Drawing.Color.White;
            this.Btn_modification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_modification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_modification.ForeColor = System.Drawing.Color.Black;
            this.Btn_modification.Location = new System.Drawing.Point(209, 270);
            this.Btn_modification.Name = "Btn_modification";
            this.Btn_modification.Size = new System.Drawing.Size(142, 32);
            this.Btn_modification.TabIndex = 87;
            this.Btn_modification.Text = "Modifier";
            this.Btn_modification.UseVisualStyleBackColor = false;
            this.Btn_modification.Click += new System.EventHandler(this.Btn_modification_Click);
            // 
            // Btn_nouveau
            // 
            this.Btn_nouveau.BackColor = System.Drawing.Color.White;
            this.Btn_nouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_nouveau.ForeColor = System.Drawing.Color.Black;
            this.Btn_nouveau.Location = new System.Drawing.Point(208, 217);
            this.Btn_nouveau.Name = "Btn_nouveau";
            this.Btn_nouveau.Size = new System.Drawing.Size(142, 34);
            this.Btn_nouveau.TabIndex = 86;
            this.Btn_nouveau.Text = "Nouveau";
            this.Btn_nouveau.UseVisualStyleBackColor = false;
            this.Btn_nouveau.Click += new System.EventHandler(this.Btn_nouveau_Click);
            // 
            // textBox_nom
            // 
            this.textBox_nom.BackColor = System.Drawing.Color.White;
            this.textBox_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_nom.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_nom.Location = new System.Drawing.Point(290, 80);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(208, 26);
            this.textBox_nom.TabIndex = 84;
            // 
            // text_box_site_id
            // 
            this.text_box_site_id.BackColor = System.Drawing.Color.Black;
            this.text_box_site_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_box_site_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_box_site_id.ForeColor = System.Drawing.Color.White;
            this.text_box_site_id.ImeMode = System.Windows.Forms.ImeMode.On;
            this.text_box_site_id.Location = new System.Drawing.Point(290, 42);
            this.text_box_site_id.Name = "text_box_site_id";
            this.text_box_site_id.ReadOnly = true;
            this.text_box_site_id.Size = new System.Drawing.Size(190, 19);
            this.text_box_site_id.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(206, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Site ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Adresse ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nom";
            // 
            // list_box_sites
            // 
            this.list_box_sites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.list_box_sites.FormattingEnabled = true;
            this.list_box_sites.ItemHeight = 20;
            this.list_box_sites.Location = new System.Drawing.Point(17, 20);
            this.list_box_sites.Name = "list_box_sites";
            this.list_box_sites.Size = new System.Drawing.Size(169, 324);
            this.list_box_sites.TabIndex = 77;
            this.list_box_sites.SelectedIndexChanged += new System.EventHandler(this.list_box_sites_SelectedIndexChanged);
            // 
            // text_box_adresse
            // 
            this.text_box_adresse.BackColor = System.Drawing.Color.White;
            this.text_box_adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_box_adresse.ImeMode = System.Windows.Forms.ImeMode.On;
            this.text_box_adresse.Location = new System.Drawing.Point(290, 124);
            this.text_box_adresse.Multiline = true;
            this.text_box_adresse.Name = "text_box_adresse";
            this.text_box_adresse.Size = new System.Drawing.Size(208, 62);
            this.text_box_adresse.TabIndex = 83;
            // 
            // site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.ButtonQuitter;
            this.ClientSize = new System.Drawing.Size(522, 379);
            this.Controls.Add(this.ButtonQuitter);
            this.Controls.Add(this.Btn_valider);
            this.Controls.Add(this.Btn_supprimer);
            this.Controls.Add(this.Btn_modification);
            this.Controls.Add(this.Btn_nouveau);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.text_box_adresse);
            this.Controls.Add(this.text_box_site_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_box_sites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "site";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Gestion Matos | Sites";
            this.Load += new System.EventHandler(this.site_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonQuitter;
        private System.Windows.Forms.Button Btn_valider;
        private System.Windows.Forms.Button Btn_supprimer;
        private System.Windows.Forms.Button Btn_modification;
        private System.Windows.Forms.Button Btn_nouveau;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox text_box_site_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_box_sites;
        private System.Windows.Forms.TextBox text_box_adresse;
    }
}