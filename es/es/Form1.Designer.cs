using System.Drawing;

namespace es
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_cuoco = new System.Windows.Forms.ComboBox();
            this.lbl_secondi = new System.Windows.Forms.Label();
            this.lbl_piatto = new System.Windows.Forms.Label();
            this.txt_piatto = new System.Windows.Forms.TextBox();
            this.btn_conferma = new System.Windows.Forms.Button();
            this.nmr_secondi = new System.Windows.Forms.NumericUpDown();
            this.lbl_cuochi = new System.Windows.Forms.Label();
            this.btn_prep = new System.Windows.Forms.Button();
            this.lst_messaggi = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_secondi)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_cuoco
            // 
            this.cmb_cuoco.BackColor = System.Drawing.Color.White;
            this.cmb_cuoco.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cuoco.FormattingEnabled = true;
            this.cmb_cuoco.Location = new System.Drawing.Point(450, 80);
            this.cmb_cuoco.Name = "cmb_cuoco";
            this.cmb_cuoco.Size = new System.Drawing.Size(150, 35);
            this.cmb_cuoco.TabIndex = 0;
            // 
            // lbl_secondi
            // 
            this.lbl_secondi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lbl_secondi.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secondi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbl_secondi.Location = new System.Drawing.Point(450, 225);
            this.lbl_secondi.Name = "lbl_secondi";
            this.lbl_secondi.Size = new System.Drawing.Size(220, 65);
            this.lbl_secondi.TabIndex = 1;
            this.lbl_secondi.Text = "dimmi i secondi di preparazione";
            // 
            // lbl_piatto
            // 
            this.lbl_piatto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lbl_piatto.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_piatto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbl_piatto.Location = new System.Drawing.Point(450, 120);
            this.lbl_piatto.Name = "lbl_piatto";
            this.lbl_piatto.Size = new System.Drawing.Size(200, 60);
            this.lbl_piatto.TabIndex = 2;
            this.lbl_piatto.Text = "dimmi il nome del piatto";
            // 
            // txt_piatto
            // 
            this.txt_piatto.BackColor = System.Drawing.Color.White;
            this.txt_piatto.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_piatto.Location = new System.Drawing.Point(450, 185);
            this.txt_piatto.Name = "txt_piatto";
            this.txt_piatto.Size = new System.Drawing.Size(150, 34);
            this.txt_piatto.TabIndex = 3;
            // 
            // btn_conferma
            // 
            this.btn_conferma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btn_conferma.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_conferma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_conferma.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conferma.Location = new System.Drawing.Point(450, 340);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(150, 45);
            this.btn_conferma.TabIndex = 5;
            this.btn_conferma.Text = "conferma";
            this.btn_conferma.UseVisualStyleBackColor = false;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // nmr_secondi
            // 
            this.nmr_secondi.BackColor = System.Drawing.Color.White;
            this.nmr_secondi.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmr_secondi.Location = new System.Drawing.Point(450, 300);
            this.nmr_secondi.Maximum = new decimal(new int[] {
            6000000,
            0,
            0,
            0});
            this.nmr_secondi.Name = "nmr_secondi";
            this.nmr_secondi.Size = new System.Drawing.Size(150, 34);
            this.nmr_secondi.TabIndex = 7;
            // 
            // lbl_cuochi
            // 
            this.lbl_cuochi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lbl_cuochi.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuochi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbl_cuochi.Location = new System.Drawing.Point(450, 20);
            this.lbl_cuochi.Name = "lbl_cuochi";
            this.lbl_cuochi.Size = new System.Drawing.Size(286, 55);
            this.lbl_cuochi.TabIndex = 8;
            this.lbl_cuochi.Text = "scegli che cuoco deve preparare il piatto";
            // 
            // btn_prep
            // 
            this.btn_prep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_prep.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prep.Location = new System.Drawing.Point(606, 340);
            this.btn_prep.Name = "btn_prep";
            this.btn_prep.Size = new System.Drawing.Size(150, 45);
            this.btn_prep.TabIndex = 9;
            this.btn_prep.Text = "prepara";
            this.btn_prep.UseVisualStyleBackColor = false;
            this.btn_prep.Click += new System.EventHandler(this.btn_prep_Click);
            // 
            // lst_messaggi
            // 
            this.lst_messaggi.BackColor = System.Drawing.Color.White;
            this.lst_messaggi.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_messaggi.FormattingEnabled = true;
            this.lst_messaggi.ItemHeight = 27;
            this.lst_messaggi.Location = new System.Drawing.Point(20, 20);
            this.lst_messaggi.Name = "lst_messaggi";
            this.lst_messaggi.Size = new System.Drawing.Size(400, 382);
            this.lst_messaggi.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(762, 413);
            this.Controls.Add(this.lst_messaggi);
            this.Controls.Add(this.btn_prep);
            this.Controls.Add(this.lbl_cuochi);
            this.Controls.Add(this.nmr_secondi);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.txt_piatto);
            this.Controls.Add(this.lbl_piatto);
            this.Controls.Add(this.lbl_secondi);
            this.Controls.Add(this.cmb_cuoco);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_secondi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_cuoco;
        private System.Windows.Forms.Label lbl_secondi;
        private System.Windows.Forms.Label lbl_piatto;
        private System.Windows.Forms.TextBox txt_piatto;
        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.NumericUpDown nmr_secondi;
        private System.Windows.Forms.Label lbl_cuochi;
        private System.Windows.Forms.Button btn_prep;
        private System.Windows.Forms.ListBox lst_messaggi;
    }
}

