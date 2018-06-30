namespace massTurSqlite.forms
{
    partial class anaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnMusLis = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMusEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSeyahat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonMusteri = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.Cari = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.cariIslem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnCariAcilis = new DevExpress.XtraBars.BarButtonItem();
            this.btnCariGrup = new DevExpress.XtraBars.BarButtonItem();
            this.btnCariListe = new DevExpress.XtraBars.BarButtonItem();
            this.btnCariHareket = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnMusLis,
            this.barBtnMusEkle,
            this.barBtnSeyahat,
            this.barButtonItem4,
            this.barButtonItem1,
            this.btnCariAcilis,
            this.btnCariGrup,
            this.btnCariListe,
            this.btnCariHareket});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.Cari});
            this.ribbon.Size = new System.Drawing.Size(1038, 194);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnMusLis
            // 
            this.barBtnMusLis.Caption = "Müşteri Listesi";
            this.barBtnMusLis.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnMusLis.Glyph")));
            this.barBtnMusLis.Id = 1;
            this.barBtnMusLis.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.barBtnMusLis.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnMusLis.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnMusLis.LargeGlyph")));
            this.barBtnMusLis.Name = "barBtnMusLis";
            this.barBtnMusLis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnMusLis_ItemClick);
            // 
            // barBtnMusEkle
            // 
            this.barBtnMusEkle.Caption = "Müşteri Ekle";
            this.barBtnMusEkle.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnMusEkle.Glyph")));
            this.barBtnMusEkle.Id = 2;
            this.barBtnMusEkle.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.barBtnMusEkle.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnMusEkle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnMusEkle.LargeGlyph")));
            this.barBtnMusEkle.Name = "barBtnMusEkle";
            this.barBtnMusEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnMusEkle_ItemClick);
            // 
            // barBtnSeyahat
            // 
            this.barBtnSeyahat.Caption = "Seyahat Kartı";
            this.barBtnSeyahat.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSeyahat.Glyph")));
            this.barBtnSeyahat.Id = 3;
            this.barBtnSeyahat.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.barBtnSeyahat.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnSeyahat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSeyahat.LargeGlyph")));
            this.barBtnSeyahat.Name = "barBtnSeyahat";
            this.barBtnSeyahat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSeyahat_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonMusteri});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Müşteri";
            // 
            // ribbonMusteri
            // 
            this.ribbonMusteri.ItemLinks.Add(this.barBtnSeyahat);
            this.ribbonMusteri.ItemLinks.Add(this.barBtnMusEkle);
            this.ribbonMusteri.ItemLinks.Add(this.barBtnMusLis);
            this.ribbonMusteri.Name = "ribbonMusteri";
            this.ribbonMusteri.ShowCaptionButton = false;
            this.ribbonMusteri.Text = "Müşteri İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 645);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1038, 40);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Cari
            // 
            this.Cari.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.cariIslem});
            this.Cari.Image = ((System.Drawing.Image)(resources.GetObject("Cari.Image")));
            this.Cari.Name = "Cari";
            this.Cari.Text = "Cari";
            // 
            // cariIslem
            // 
            this.cariIslem.ItemLinks.Add(this.btnCariAcilis);
            this.cariIslem.ItemLinks.Add(this.btnCariGrup);
            this.cariIslem.ItemLinks.Add(this.btnCariListe);
            this.cariIslem.ItemLinks.Add(this.btnCariHareket);
            this.cariIslem.Name = "cariIslem";
            this.cariIslem.Text = "Cari İşlemler";
            // 
            // btnCariAcilis
            // 
            this.btnCariAcilis.Caption = "Cari Açılış Kartı";
            this.btnCariAcilis.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCariAcilis.Glyph")));
            this.btnCariAcilis.Id = 6;
            this.btnCariAcilis.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCariAcilis.LargeGlyph")));
            this.btnCariAcilis.Name = "btnCariAcilis";
            // 
            // btnCariGrup
            // 
            this.btnCariGrup.Caption = "Cari Gruplar";
            this.btnCariGrup.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCariGrup.Glyph")));
            this.btnCariGrup.Id = 7;
            this.btnCariGrup.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCariGrup.LargeGlyph")));
            this.btnCariGrup.Name = "btnCariGrup";
            // 
            // btnCariListe
            // 
            this.btnCariListe.Caption = "Cari Listesi";
            this.btnCariListe.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCariListe.Glyph")));
            this.btnCariListe.Id = 8;
            this.btnCariListe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCariListe.LargeGlyph")));
            this.btnCariListe.Name = "btnCariListe";
            // 
            // btnCariHareket
            // 
            this.btnCariHareket.Caption = "Cari Hareketler";
            this.btnCariHareket.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCariHareket.Glyph")));
            this.btnCariHareket.Id = 9;
            this.btnCariHareket.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCariHareket.LargeGlyph")));
            this.btnCariHareket.Name = "btnCariHareket";
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 685);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "anaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "anaForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonMusteri;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnMusLis;
        private DevExpress.XtraBars.BarButtonItem barBtnMusEkle;
        private DevExpress.XtraBars.BarButtonItem barBtnSeyahat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnCariAcilis;
        private DevExpress.XtraBars.BarButtonItem btnCariGrup;
        private DevExpress.XtraBars.BarButtonItem btnCariListe;
        private DevExpress.XtraBars.BarButtonItem btnCariHareket;
        private DevExpress.XtraBars.Ribbon.RibbonPage Cari;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup cariIslem;
    }
}