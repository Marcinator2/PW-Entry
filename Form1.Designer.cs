namespace PW_Entry
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxDelay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxWartezeit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPasswd = new System.Windows.Forms.TextBox();
            this.btnPasswort = new System.Windows.Forms.Button();
            this.lbxListe = new System.Windows.Forms.ListBox();
            this.btnListeimportieren = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnFensterSuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delay in ms:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(31, 241);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 79);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxDelay
            // 
            this.tbxDelay.Location = new System.Drawing.Point(31, 213);
            this.tbxDelay.Name = "tbxDelay";
            this.tbxDelay.Size = new System.Drawing.Size(70, 22);
            this.tbxDelay.TabIndex = 2;
            this.tbxDelay.Text = "250";
            this.tbxDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDelay_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wartezeit in Sekunden";
            // 
            // tbxWartezeit
            // 
            this.tbxWartezeit.Location = new System.Drawing.Point(31, 169);
            this.tbxWartezeit.Name = "tbxWartezeit";
            this.tbxWartezeit.Size = new System.Drawing.Size(131, 22);
            this.tbxWartezeit.TabIndex = 4;
            this.tbxWartezeit.Text = "2";
            this.tbxWartezeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxWartezeit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWartezeit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passwort eingeben:";
            // 
            // tbxPasswd
            // 
            this.tbxPasswd.Location = new System.Drawing.Point(31, 64);
            this.tbxPasswd.Name = "tbxPasswd";
            this.tbxPasswd.Size = new System.Drawing.Size(153, 22);
            this.tbxPasswd.TabIndex = 6;
            this.tbxPasswd.UseSystemPasswordChar = true;
            // 
            // btnPasswort
            // 
            this.btnPasswort.Location = new System.Drawing.Point(31, 103);
            this.btnPasswort.Name = "btnPasswort";
            this.btnPasswort.Size = new System.Drawing.Size(153, 35);
            this.btnPasswort.TabIndex = 7;
            this.btnPasswort.Text = "Passwort anzeigen";
            this.btnPasswort.UseVisualStyleBackColor = true;
            this.btnPasswort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPasswort_MouseDown);
            this.btnPasswort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPasswort_MouseUp);
            // 
            // lbxListe
            // 
            this.lbxListe.FormattingEnabled = true;
            this.lbxListe.ItemHeight = 16;
            this.lbxListe.Location = new System.Drawing.Point(207, 92);
            this.lbxListe.Name = "lbxListe";
            this.lbxListe.Size = new System.Drawing.Size(162, 228);
            this.lbxListe.TabIndex = 9;
            this.lbxListe.SelectedIndexChanged += new System.EventHandler(this.lbxListe_SelectedIndexChanged);
            // 
            // btnListeimportieren
            // 
            this.btnListeimportieren.Location = new System.Drawing.Point(207, 57);
            this.btnListeimportieren.Name = "btnListeimportieren";
            this.btnListeimportieren.Size = new System.Drawing.Size(162, 29);
            this.btnListeimportieren.TabIndex = 10;
            this.btnListeimportieren.Text = "Liste importieren";
            this.btnListeimportieren.UseVisualStyleBackColor = true;
            this.btnListeimportieren.Click += new System.EventHandler(this.btnListeImportieren_Click);
            // 
            // btnFensterSuchen
            // 
            this.btnFensterSuchen.Location = new System.Drawing.Point(207, 15);
            this.btnFensterSuchen.Name = "btnFensterSuchen";
            this.btnFensterSuchen.Size = new System.Drawing.Size(162, 32);
            this.btnFensterSuchen.TabIndex = 11;
            this.btnFensterSuchen.Text = "Fenster suchen";
            this.btnFensterSuchen.UseVisualStyleBackColor = true;
            this.btnFensterSuchen.Click += new System.EventHandler(this.btnFensterSuchen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 332);
            this.Controls.Add(this.btnFensterSuchen);
            this.Controls.Add(this.btnListeimportieren);
            this.Controls.Add(this.lbxListe);
            this.Controls.Add(this.btnPasswort);
            this.Controls.Add(this.tbxPasswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxWartezeit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDelay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PW-Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxWartezeit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPasswd;
        private System.Windows.Forms.Button btnPasswort;
        private System.Windows.Forms.ListBox lbxListe;
        private System.Windows.Forms.Button btnListeimportieren;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnFensterSuchen;
    }
}

