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
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuLang = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuLangGER = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLangENG = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSicht = new System.Windows.Forms.Label();
            this.barSicht = new ProgressBarSample.TextProgressBar();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxDelay
            // 
            resources.ApplyResources(this.tbxDelay, "tbxDelay");
            this.tbxDelay.Name = "tbxDelay";
            this.tbxDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDelay_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbxWartezeit
            // 
            resources.ApplyResources(this.tbxWartezeit, "tbxWartezeit");
            this.tbxWartezeit.Name = "tbxWartezeit";
            this.tbxWartezeit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWartezeit_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbxPasswd
            // 
            resources.ApplyResources(this.tbxPasswd, "tbxPasswd");
            this.tbxPasswd.Name = "tbxPasswd";
            this.tbxPasswd.UseSystemPasswordChar = true;
            // 
            // btnPasswort
            // 
            resources.ApplyResources(this.btnPasswort, "btnPasswort");
            this.btnPasswort.Name = "btnPasswort";
            this.btnPasswort.UseVisualStyleBackColor = true;
            this.btnPasswort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPasswort_MouseDown);
            this.btnPasswort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPasswort_MouseUp);
            // 
            // lbxListe
            // 
            this.lbxListe.FormattingEnabled = true;
            resources.ApplyResources(this.lbxListe, "lbxListe");
            this.lbxListe.Name = "lbxListe";
            this.lbxListe.SelectedIndexChanged += new System.EventHandler(this.lbxListe_SelectedIndexChanged);
            // 
            // btnListeimportieren
            // 
            resources.ApplyResources(this.btnListeimportieren, "btnListeimportieren");
            this.btnListeimportieren.Name = "btnListeimportieren";
            this.btnListeimportieren.UseVisualStyleBackColor = true;
            this.btnListeimportieren.Click += new System.EventHandler(this.btnListeImportieren_Click);
            // 
            // btnFensterSuchen
            // 
            resources.ApplyResources(this.btnFensterSuchen, "btnFensterSuchen");
            this.btnFensterSuchen.Name = "btnFensterSuchen";
            this.btnFensterSuchen.UseVisualStyleBackColor = true;
            this.btnFensterSuchen.Click += new System.EventHandler(this.btnFensterSuchen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLang});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menuLang
            // 
            this.menuLang.DropDown = this.contextMenuStrip1;
            this.menuLang.Name = "menuLang";
            resources.ApplyResources(this.menuLang, "menuLang");
            this.menuLang.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLangGER,
            this.menuLangENG});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.OwnerItem = this.menuLang;
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // menuLangGER
            // 
            this.menuLangGER.Name = "menuLangGER";
            resources.ApplyResources(this.menuLangGER, "menuLangGER");
            this.menuLangGER.Click += new System.EventHandler(this.menuLangGER_Click);
            // 
            // menuLangENG
            // 
            this.menuLangENG.Name = "menuLangENG";
            resources.ApplyResources(this.menuLangENG, "menuLangENG");
            this.menuLangENG.Click += new System.EventHandler(this.menuLangENG_Click);
            // 
            // lblSicht
            // 
            resources.ApplyResources(this.lblSicht, "lblSicht");
            this.lblSicht.Name = "lblSicht";
            // 
            // barSicht
            // 
            this.barSicht.CustomText = "";
            resources.ApplyResources(this.barSicht, "barSicht");
            this.barSicht.Name = "barSicht";
            this.barSicht.ProgressColor = System.Drawing.Color.Lime;
            this.barSicht.TextColor = System.Drawing.Color.Black;
            this.barSicht.TextFont = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.barSicht.Value = 90;
            this.barSicht.VisualMode = ProgressBarSample.ProgressBarDisplayMode.NoText;
            this.barSicht.Click += new System.EventHandler(this.barSicht_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSicht);
            this.Controls.Add(this.barSicht);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.69D;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLangGER;
        private System.Windows.Forms.ToolStripMenuItem menuLangENG;
        private ProgressBarSample.TextProgressBar barSicht;
        private System.Windows.Forms.Label lblSicht;
    }
}

