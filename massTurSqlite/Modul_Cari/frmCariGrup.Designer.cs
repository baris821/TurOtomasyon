namespace massTurSqlite.Modul_Cari
{
    partial class frmCariGrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariGrup));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtGrupAd = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridSplitContainer1Grid = new DevExpress.XtraGrid.GridControl();
            this.gridSplitContainer1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtGrupAd);
            this.groupControl1.Controls.Add(this.txtGrupKodu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(297, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cari Grup Bilgisi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Grup Kodu : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Grup Adı : ";
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.Location = new System.Drawing.Point(84, 28);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.Size = new System.Drawing.Size(209, 22);
            this.txtGrupKodu.TabIndex = 2;
            // 
            // txtGrupAd
            // 
            this.txtGrupAd.Location = new System.Drawing.Point(84, 56);
            this.txtGrupAd.Name = "txtGrupAd";
            this.txtGrupAd.Size = new System.Drawing.Size(209, 22);
            this.txtGrupAd.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnKaydet);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 316);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(297, 100);
            this.groupControl2.TabIndex = 1;
            // 
            // gridSplitContainer1Grid
            // 
            this.gridSplitContainer1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1Grid.Location = new System.Drawing.Point(0, 100);
            this.gridSplitContainer1Grid.MainView = this.gridSplitContainer1View;
            this.gridSplitContainer1Grid.Name = "gridSplitContainer1Grid";
            this.gridSplitContainer1Grid.Size = new System.Drawing.Size(297, 216);
            this.gridSplitContainer1Grid.TabIndex = 2;
            this.gridSplitContainer1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSplitContainer1View});
            // 
            // gridSplitContainer1View
            // 
            this.gridSplitContainer1View.GridControl = this.gridSplitContainer1Grid;
            this.gridSplitContainer1View.Name = "gridSplitContainer1View";
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(114, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(181, 73);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnKaydet.Location = new System.Drawing.Point(2, 25);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(178, 73);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            // 
            // frmCariGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 416);
            this.Controls.Add(this.gridSplitContainer1Grid);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmCariGrup";
            this.Text = "frmCariGrup";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtGrupAd;
        private DevExpress.XtraEditors.TextEdit txtGrupKodu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraGrid.GridControl gridSplitContainer1Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSplitContainer1View;
    }
}