namespace massTurSqlite.Modul_Cari
{
    partial class frmCariListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariListe));
            this.CepTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DogumYeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cinsiyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelCariGrup = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAd = new DevExpress.XtraEditors.TextEdit();
            this.labelAd = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKod = new DevExpress.XtraEditors.TextEdit();
            this.Soyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TCKN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelTC = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DogumTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMusteriList = new DevExpress.XtraGrid.GridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriList)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CepTel
            // 
            this.CepTel.Caption = "Cep Telefonu";
            this.CepTel.FieldName = "CepTel";
            this.CepTel.Name = "CepTel";
            this.CepTel.Visible = true;
            this.CepTel.VisibleIndex = 6;
            this.CepTel.Width = 95;
            // 
            // DogumYeri
            // 
            this.DogumYeri.Caption = "Doğum Yeri";
            this.DogumYeri.FieldName = "DogumYeri";
            this.DogumYeri.Name = "DogumYeri";
            this.DogumYeri.Visible = true;
            this.DogumYeri.VisibleIndex = 4;
            this.DogumYeri.Width = 87;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Caption = "Cinsiyet";
            this.Cinsiyet.FieldName = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Visible = true;
            this.Cinsiyet.VisibleIndex = 3;
            this.Cinsiyet.Width = 87;
            // 
            // btnListele
            // 
            this.btnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.Image")));
            this.btnListele.Location = new System.Drawing.Point(11, 231);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(162, 42);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Tümünü Listele";
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.Location = new System.Drawing.Point(11, 183);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(162, 42);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(11, 154);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(162, 22);
            this.txtSoyad.TabIndex = 5;
            // 
            // labelCariGrup
            // 
            this.labelCariGrup.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelCariGrup.Location = new System.Drawing.Point(11, 132);
            this.labelCariGrup.Name = "labelCariGrup";
            this.labelCariGrup.Size = new System.Drawing.Size(72, 16);
            this.labelCariGrup.TabIndex = 4;
            this.labelCariGrup.Text = "Cari Grup : ";
            // 
            // txtCariAd
            // 
            this.txtCariAd.Location = new System.Drawing.Point(11, 104);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Size = new System.Drawing.Size(162, 22);
            this.txtCariAd.TabIndex = 3;
            // 
            // labelAd
            // 
            this.labelAd.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelAd.Location = new System.Drawing.Point(11, 80);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(60, 16);
            this.labelAd.TabIndex = 2;
            this.labelAd.Text = "Cari Ad : ";
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(11, 52);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(162, 22);
            this.txtCariKod.TabIndex = 1;
            // 
            // Soyad
            // 
            this.Soyad.Caption = "Soyad";
            this.Soyad.FieldName = "Soyad";
            this.Soyad.Name = "Soyad";
            this.Soyad.Visible = true;
            this.Soyad.VisibleIndex = 2;
            this.Soyad.Width = 87;
            // 
            // Ad
            // 
            this.Ad.Caption = "Ad";
            this.Ad.FieldName = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.Visible = true;
            this.Ad.VisibleIndex = 1;
            this.Ad.Width = 87;
            // 
            // TCKN
            // 
            this.TCKN.Caption = "TCKN / Müşteri No";
            this.TCKN.FieldName = "TCKN";
            this.TCKN.Name = "TCKN";
            this.TCKN.Visible = true;
            this.TCKN.VisibleIndex = 0;
            this.TCKN.Width = 120;
            // 
            // labelTC
            // 
            this.labelTC.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTC.Location = new System.Drawing.Point(11, 30);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(66, 16);
            this.labelTC.TabIndex = 0;
            this.labelTC.Text = "Cari Kod : ";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TCKN,
            this.Ad,
            this.Soyad,
            this.Cinsiyet,
            this.DogumYeri,
            this.DogumTarih,
            this.CepTel});
            this.gridView1.GridControl = this.gridMusteriList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            // 
            // DogumTarih
            // 
            this.DogumTarih.Caption = "Doğum Tarihi";
            this.DogumTarih.FieldName = "DogumTarih";
            this.DogumTarih.Name = "DogumTarih";
            this.DogumTarih.Visible = true;
            this.DogumTarih.VisibleIndex = 5;
            this.DogumTarih.Width = 87;
            // 
            // gridMusteriList
            // 
            this.gridMusteriList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMusteriList.Location = new System.Drawing.Point(0, 0);
            this.gridMusteriList.MainView = this.gridView1;
            this.gridMusteriList.Name = "gridMusteriList";
            this.gridMusteriList.Size = new System.Drawing.Size(778, 503);
            this.gridMusteriList.TabIndex = 0;
            this.gridMusteriList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.btnListele);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtSoyad);
            this.xtraTabPage1.Controls.Add(this.labelCariGrup);
            this.xtraTabPage1.Controls.Add(this.txtCariAd);
            this.xtraTabPage1.Controls.Add(this.labelAd);
            this.xtraTabPage1.Controls.Add(this.txtCariKod);
            this.xtraTabPage1.Controls.Add(this.labelTC);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(178, 469);
            this.xtraTabPage1.Text = "Müşteri";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(185, 503);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridMusteriList);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(969, 503);
            this.splitContainerControl1.SplitterPosition = 185;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmCariListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 503);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmCariListe";
            this.Text = "frmCariListe";
            this.Load += new System.EventHandler(this.frmCariListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriList)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn CepTel;
        private DevExpress.XtraGrid.Columns.GridColumn DogumYeri;
        private DevExpress.XtraGrid.Columns.GridColumn Cinsiyet;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelCariGrup;
        private DevExpress.XtraEditors.TextEdit txtCariAd;
        private DevExpress.XtraEditors.LabelControl labelAd;
        private DevExpress.XtraEditors.TextEdit txtCariKod;
        private DevExpress.XtraGrid.Columns.GridColumn Soyad;
        private DevExpress.XtraGrid.Columns.GridColumn Ad;
        private DevExpress.XtraGrid.Columns.GridColumn TCKN;
        private DevExpress.XtraEditors.LabelControl labelTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn DogumTarih;
        private DevExpress.XtraGrid.GridControl gridMusteriList;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}