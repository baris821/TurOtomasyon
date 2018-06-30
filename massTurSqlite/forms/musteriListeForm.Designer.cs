namespace massTurSqlite.forms
{
    partial class musteriListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriListeForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelSoyad = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelAd = new DevExpress.XtraEditors.LabelControl();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.labelTC = new DevExpress.XtraEditors.LabelControl();
            this.gridMusteriList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TCKN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Soyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cinsiyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DogumYeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DogumTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CepTel = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(899, 363);
            this.splitContainerControl1.SplitterPosition = 185;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(185, 363);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.btnListele);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtSoyad);
            this.xtraTabPage1.Controls.Add(this.labelSoyad);
            this.xtraTabPage1.Controls.Add(this.txtAd);
            this.xtraTabPage1.Controls.Add(this.labelAd);
            this.xtraTabPage1.Controls.Add(this.txtTC);
            this.xtraTabPage1.Controls.Add(this.labelTC);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(178, 329);
            this.xtraTabPage1.Text = "Müşteri";
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
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
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
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(11, 154);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(162, 22);
            this.txtSoyad.TabIndex = 5;
            // 
            // labelSoyad
            // 
            this.labelSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelSoyad.Location = new System.Drawing.Point(11, 132);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(106, 16);
            this.labelSoyad.TabIndex = 4;
            this.labelSoyad.Text = "Müşteri Soyad : ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(11, 104);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(162, 22);
            this.txtAd.TabIndex = 3;
            // 
            // labelAd
            // 
            this.labelAd.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelAd.Location = new System.Drawing.Point(11, 80);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(84, 16);
            this.labelAd.TabIndex = 2;
            this.labelAd.Text = "Müşteri Ad : ";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(11, 52);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(162, 22);
            this.txtTC.TabIndex = 1;
            // 
            // labelTC
            // 
            this.labelTC.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTC.Location = new System.Drawing.Point(11, 30);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(125, 16);
            this.labelTC.TabIndex = 0;
            this.labelTC.Text = "TCKN / Müşteri No :";
            // 
            // gridMusteriList
            // 
            this.gridMusteriList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMusteriList.Location = new System.Drawing.Point(0, 0);
            this.gridMusteriList.MainView = this.gridView1;
            this.gridMusteriList.Name = "gridMusteriList";
            this.gridMusteriList.Size = new System.Drawing.Size(708, 363);
            this.gridMusteriList.TabIndex = 0;
            this.gridMusteriList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // TCKN
            // 
            this.TCKN.Caption = "TCKN / Müşteri No";
            this.TCKN.FieldName = "TCKN";
            this.TCKN.Name = "TCKN";
            this.TCKN.Visible = true;
            this.TCKN.VisibleIndex = 0;
            this.TCKN.Width = 120;
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
            // Soyad
            // 
            this.Soyad.Caption = "Soyad";
            this.Soyad.FieldName = "Soyad";
            this.Soyad.Name = "Soyad";
            this.Soyad.Visible = true;
            this.Soyad.VisibleIndex = 2;
            this.Soyad.Width = 87;
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
            // DogumYeri
            // 
            this.DogumYeri.Caption = "Doğum Yeri";
            this.DogumYeri.FieldName = "DogumYeri";
            this.DogumYeri.Name = "DogumYeri";
            this.DogumYeri.Visible = true;
            this.DogumYeri.VisibleIndex = 4;
            this.DogumYeri.Width = 87;
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
            // CepTel
            // 
            this.CepTel.Caption = "Cep Telefonu";
            this.CepTel.FieldName = "CepTel";
            this.CepTel.Name = "CepTel";
            this.CepTel.Visible = true;
            this.CepTel.VisibleIndex = 6;
            this.CepTel.Width = 95;
            // 
            // musteriListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 363);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "musteriListeForm";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.musteriListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelSoyad;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelAd;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.LabelControl labelTC;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraGrid.GridControl gridMusteriList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TCKN;
        private DevExpress.XtraGrid.Columns.GridColumn Ad;
        private DevExpress.XtraGrid.Columns.GridColumn Soyad;
        private DevExpress.XtraGrid.Columns.GridColumn Cinsiyet;
        private DevExpress.XtraGrid.Columns.GridColumn DogumYeri;
        private DevExpress.XtraGrid.Columns.GridColumn DogumTarih;
        private DevExpress.XtraGrid.Columns.GridColumn CepTel;
        private DevExpress.XtraEditors.SimpleButton btnListele;
    }
}