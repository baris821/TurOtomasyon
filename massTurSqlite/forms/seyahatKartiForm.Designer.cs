namespace massTurSqlite.forms
{
    partial class seyahatKartiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seyahatKartiForm));
            this.groupTCArama = new DevExpress.XtraEditors.GroupControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.labelTC = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.comboSezon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelSezon = new DevExpress.XtraEditors.LabelControl();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.comboTur = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelTur = new DevExpress.XtraEditors.LabelControl();
            this.comboDonem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelDonem = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupParkur = new DevExpress.XtraEditors.GroupControl();
            this.groupTurBilgi = new DevExpress.XtraEditors.GroupControl();
            this.labelBitTarih = new DevExpress.XtraEditors.LabelControl();
            this.labelKod = new DevExpress.XtraEditors.LabelControl();
            this.labelBasTarih = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupKisiBilgi = new DevExpress.XtraEditors.GroupControl();
            this.labelSoyad = new DevExpress.XtraEditors.LabelControl();
            this.labelAd = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupTCArama)).BeginInit();
            this.groupTCArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboSezon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDonem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupParkur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTurBilgi)).BeginInit();
            this.groupTurBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupKisiBilgi)).BeginInit();
            this.groupKisiBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTCArama
            // 
            this.groupTCArama.AutoSize = true;
            this.groupTCArama.Controls.Add(this.btnAra);
            this.groupTCArama.Controls.Add(this.txtTC);
            this.groupTCArama.Controls.Add(this.labelTC);
            this.groupTCArama.Location = new System.Drawing.Point(12, 12);
            this.groupTCArama.Name = "groupTCArama";
            this.groupTCArama.Size = new System.Drawing.Size(344, 59);
            this.groupTCArama.TabIndex = 0;
            this.groupTCArama.Text = "TC ile Arama";
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.Location = new System.Drawing.Point(256, 25);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(82, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(95, 26);
            this.txtTC.Name = "txtTC";
            this.txtTC.Properties.Mask.EditMask = "d";
            this.txtTC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTC.Size = new System.Drawing.Size(155, 22);
            this.txtTC.TabIndex = 1;
            // 
            // labelTC
            // 
            this.labelTC.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTC.Location = new System.Drawing.Point(6, 29);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(83, 16);
            this.labelTC.TabIndex = 0;
            this.labelTC.Text = "TC Kimlik No :";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(170, 358);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.comboSezon);
            this.xtraTabPage1.Controls.Add(this.labelSezon);
            this.xtraTabPage1.Controls.Add(this.btnOnayla);
            this.xtraTabPage1.Controls.Add(this.comboTur);
            this.xtraTabPage1.Controls.Add(this.labelTur);
            this.xtraTabPage1.Controls.Add(this.comboDonem);
            this.xtraTabPage1.Controls.Add(this.labelDonem);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(163, 324);
            this.xtraTabPage1.Text = "Tur Seç";
            // 
            // comboSezon
            // 
            this.comboSezon.Location = new System.Drawing.Point(3, 37);
            this.comboSezon.Name = "comboSezon";
            this.comboSezon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboSezon.Size = new System.Drawing.Size(153, 22);
            this.comboSezon.TabIndex = 6;
            // 
            // labelSezon
            // 
            this.labelSezon.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelSezon.Location = new System.Drawing.Point(3, 14);
            this.labelSezon.Name = "labelSezon";
            this.labelSezon.Size = new System.Drawing.Size(52, 16);
            this.labelSezon.TabIndex = 5;
            this.labelSezon.Text = "Sezon : ";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.Image")));
            this.btnOnayla.Location = new System.Drawing.Point(3, 180);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(153, 37);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // comboTur
            // 
            this.comboTur.Location = new System.Drawing.Point(3, 141);
            this.comboTur.Name = "comboTur";
            this.comboTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTur.Size = new System.Drawing.Size(153, 22);
            this.comboTur.TabIndex = 3;
            // 
            // labelTur
            // 
            this.labelTur.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTur.Location = new System.Drawing.Point(3, 118);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(34, 16);
            this.labelTur.TabIndex = 2;
            this.labelTur.Text = "Tur : ";
            // 
            // comboDonem
            // 
            this.comboDonem.Location = new System.Drawing.Point(3, 88);
            this.comboDonem.Name = "comboDonem";
            this.comboDonem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboDonem.Size = new System.Drawing.Size(153, 22);
            this.comboDonem.TabIndex = 1;
            // 
            // labelDonem
            // 
            this.labelDonem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelDonem.Location = new System.Drawing.Point(3, 65);
            this.labelDonem.Name = "labelDonem";
            this.labelDonem.Size = new System.Drawing.Size(57, 16);
            this.labelDonem.TabIndex = 0;
            this.labelDonem.Text = "Dönem : ";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 77);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupParkur);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupTurBilgi);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1054, 358);
            this.splitContainerControl1.SplitterPosition = 170;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupParkur
            // 
            this.groupParkur.AutoSize = true;
            this.groupParkur.Location = new System.Drawing.Point(396, 28);
            this.groupParkur.Name = "groupParkur";
            this.groupParkur.Size = new System.Drawing.Size(198, 81);
            this.groupParkur.TabIndex = 6;
            this.groupParkur.Text = "Parkur Çizelgesi";
            this.groupParkur.Visible = false;
            // 
            // groupTurBilgi
            // 
            this.groupTurBilgi.Controls.Add(this.labelBitTarih);
            this.groupTurBilgi.Controls.Add(this.labelKod);
            this.groupTurBilgi.Controls.Add(this.labelBasTarih);
            this.groupTurBilgi.Controls.Add(this.labelControl5);
            this.groupTurBilgi.Controls.Add(this.labelControl2);
            this.groupTurBilgi.Controls.Add(this.labelControl1);
            this.groupTurBilgi.Location = new System.Drawing.Point(20, 28);
            this.groupTurBilgi.Name = "groupTurBilgi";
            this.groupTurBilgi.Size = new System.Drawing.Size(354, 217);
            this.groupTurBilgi.TabIndex = 0;
            this.groupTurBilgi.Text = "Tur Bilgileri";
            this.groupTurBilgi.Visible = false;
            // 
            // labelBitTarih
            // 
            this.labelBitTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelBitTarih.Location = new System.Drawing.Point(205, 140);
            this.labelBitTarih.Name = "labelBitTarih";
            this.labelBitTarih.Size = new System.Drawing.Size(0, 21);
            this.labelBitTarih.TabIndex = 5;
            // 
            // labelKod
            // 
            this.labelKod.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelKod.Location = new System.Drawing.Point(205, 40);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(0, 21);
            this.labelKod.TabIndex = 4;
            // 
            // labelBasTarih
            // 
            this.labelBasTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelBasTarih.Location = new System.Drawing.Point(205, 87);
            this.labelBasTarih.Name = "labelBasTarih";
            this.labelBasTarih.Size = new System.Drawing.Size(0, 21);
            this.labelBasTarih.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(17, 140);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 21);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Bitiş Tarihi : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(17, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(151, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Başlangıç Tarihi : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(17, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tur Kodu : ";
            // 
            // groupKisiBilgi
            // 
            this.groupKisiBilgi.Controls.Add(this.labelSoyad);
            this.groupKisiBilgi.Controls.Add(this.labelAd);
            this.groupKisiBilgi.Controls.Add(this.labelControl4);
            this.groupKisiBilgi.Controls.Add(this.labelControl3);
            this.groupKisiBilgi.Location = new System.Drawing.Point(363, 12);
            this.groupKisiBilgi.Name = "groupKisiBilgi";
            this.groupKisiBilgi.Size = new System.Drawing.Size(656, 59);
            this.groupKisiBilgi.TabIndex = 2;
            this.groupKisiBilgi.Text = "Kişi Bilgileri";
            this.groupKisiBilgi.Visible = false;
            // 
            // labelSoyad
            // 
            this.labelSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelSoyad.Location = new System.Drawing.Point(395, 29);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(0, 16);
            this.labelSoyad.TabIndex = 3;
            // 
            // labelAd
            // 
            this.labelAd.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelAd.Location = new System.Drawing.Point(55, 29);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(0, 16);
            this.labelAd.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(335, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 16);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Soyad : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(17, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ad : ";
            // 
            // seyahatKartiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 435);
            this.Controls.Add(this.groupKisiBilgi);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupTCArama);
            this.Name = "seyahatKartiForm";
            this.Text = "seyahatKartiForm";
            this.Load += new System.EventHandler(this.seyahatKartiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupTCArama)).EndInit();
            this.groupTCArama.ResumeLayout(false);
            this.groupTCArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboSezon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDonem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupParkur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTurBilgi)).EndInit();
            this.groupTurBilgi.ResumeLayout(false);
            this.groupTurBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupKisiBilgi)).EndInit();
            this.groupKisiBilgi.ResumeLayout(false);
            this.groupKisiBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupTCArama;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.LabelControl labelTC;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.ComboBoxEdit comboSezon;
        private DevExpress.XtraEditors.LabelControl labelSezon;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraEditors.ComboBoxEdit comboTur;
        private DevExpress.XtraEditors.LabelControl labelTur;
        private DevExpress.XtraEditors.ComboBoxEdit comboDonem;
        private DevExpress.XtraEditors.LabelControl labelDonem;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupKisiBilgi;
        private DevExpress.XtraEditors.LabelControl labelSoyad;
        private DevExpress.XtraEditors.LabelControl labelAd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupTurBilgi;
        private DevExpress.XtraEditors.LabelControl labelBitTarih;
        private DevExpress.XtraEditors.LabelControl labelKod;
        private DevExpress.XtraEditors.LabelControl labelBasTarih;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupParkur;
    }
}