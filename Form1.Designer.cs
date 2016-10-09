namespace thuthu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listThumoi = new System.Windows.Forms.ListBox();
            this.listDanhSachThu = new System.Windows.Forms.ListBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.imageSave = new System.Windows.Forms.ImageList(this.components);
            this.lblthumoi = new System.Windows.Forms.Label();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuloadds = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuSao = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listThumoi
            // 
            this.listThumoi.AllowDrop = true;
            this.listThumoi.DataSource = this.listThumoi.CustomTabOffsets;
            this.listThumoi.Location = new System.Drawing.Point(78, 100);
            this.listThumoi.Name = "listThumoi";
            this.listThumoi.Size = new System.Drawing.Size(141, 225);
            this.listThumoi.TabIndex = 0;
            this.listThumoi.SelectedIndexChanged += new System.EventHandler(this.listThumoi_SelectedIndexChanged);
            // 
            // listDanhSachThu
            // 
            this.listDanhSachThu.AllowDrop = true;
            this.listDanhSachThu.DataSource = this.listDanhSachThu.CustomTabOffsets;
            this.listDanhSachThu.FormattingEnabled = true;
            this.listDanhSachThu.Location = new System.Drawing.Point(237, 100);
            this.listDanhSachThu.Name = "listDanhSachThu";
            this.listDanhSachThu.Size = new System.Drawing.Size(136, 225);
            this.listDanhSachThu.TabIndex = 1;
            this.listDanhSachThu.SelectedIndexChanged += new System.EventHandler(this.listDanhSachThu_SelectedIndexChanged);
            this.listDanhSachThu.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstdanhsach_DragDrop);
            // 
            // btnluu
            // 
            this.btnluu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnluu.ImageKey = "tải xuống.png";
            this.btnluu.ImageList = this.imageSave;
            this.btnluu.Location = new System.Drawing.Point(357, 367);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(122, 27);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu ";
            this.btnluu.UseMnemonic = false;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // imageSave
            // 
            this.imageSave.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSave.ImageStream")));
            this.imageSave.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSave.Images.SetKeyName(0, "tải xuống.png");
            // 
            // lblthumoi
            // 
            this.lblthumoi.AutoSize = true;
            this.lblthumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthumoi.Location = new System.Drawing.Point(86, 77);
            this.lblthumoi.Name = "lblthumoi";
            this.lblthumoi.Size = new System.Drawing.Size(72, 20);
            this.lblthumoi.TabIndex = 3;
            this.lblthumoi.Text = "Thu Moi";
            this.lblthumoi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(240, 77);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(133, 20);
            this.lblDanhSach.TabIndex = 4;
            this.lblDanhSach.Text = "Danh Sach Thu";
            this.lblDanhSach.Click += new System.EventHandler(this.lblDanhSach_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(-3, 348);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 16);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.sửaĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmuloadds,
            this.lưuDanhSáchToolStripMenuItem,
            this.kếtThúcToolStripMenuItem});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ Sơ";
            // 
            // mmuloadds
            // 
            this.mmuloadds.Name = "mmuloadds";
            this.mmuloadds.Size = new System.Drawing.Size(153, 22);
            this.mmuloadds.Text = "Tải Danh Sách";
            this.mmuloadds.Click += new System.EventHandler(this.mmuloadds_Click);
            // 
            // lưuDanhSáchToolStripMenuItem
            // 
            this.lưuDanhSáchToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lưuDanhSáchToolStripMenuItem.Image = global::thuthu.Properties.Resources.tải_xuống;
            this.lưuDanhSáchToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lưuDanhSáchToolStripMenuItem.Name = "lưuDanhSáchToolStripMenuItem";
            this.lưuDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.lưuDanhSáchToolStripMenuItem.Text = "Lưu Danh Sách";
            this.lưuDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.kếtThúcToolStripMenuItem.Text = "Kết Thúc";
            this.kếtThúcToolStripMenuItem.Click += new System.EventHandler(this.kếtThúcToolStripMenuItem_Click);
            // 
            // sửaĐổiToolStripMenuItem
            // 
            this.sửaĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmuCat,
            this.mmuDan,
            this.mmuSao});
            this.sửaĐổiToolStripMenuItem.Name = "sửaĐổiToolStripMenuItem";
            this.sửaĐổiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sửaĐổiToolStripMenuItem.Text = "Sửa Đổi";
            // 
            // mmuCat
            // 
            this.mmuCat.Name = "mmuCat";
            this.mmuCat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mmuCat.Size = new System.Drawing.Size(136, 22);
            this.mmuCat.Text = "Cắt";
            // 
            // mmuDan
            // 
            this.mmuDan.Name = "mmuDan";
            this.mmuDan.ShortcutKeyDisplayString = "Crtl+V";
            this.mmuDan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mmuDan.Size = new System.Drawing.Size(136, 22);
            this.mmuDan.Text = "Dán";
            // 
            // mmuSao
            // 
            this.mmuSao.Name = "mmuSao";
            this.mmuSao.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mmuSao.Size = new System.Drawing.Size(136, 22);
            this.mmuSao.Text = "Sao";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 496);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.lblthumoi);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.listDanhSachThu);
            this.Controls.Add(this.listThumoi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listThumoi;
        private System.Windows.Forms.ListBox listDanhSachThu;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label lblthumoi;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ImageList imageSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuloadds;
        private System.Windows.Forms.ToolStripMenuItem lưuDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuCat;
        private System.Windows.Forms.ToolStripMenuItem mmuDan;
        private System.Windows.Forms.ToolStripMenuItem mmuSao;
        private System.Windows.Forms.Timer timer1;
    }
}

