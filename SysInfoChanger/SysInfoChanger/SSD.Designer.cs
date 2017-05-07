namespace SysInfoChanger
{
    partial class SSD
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSD));
            this.btFolder = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbPath = new System.Windows.Forms.Label();
            this._fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.bsSize = new Bunifu.Framework.UI.BunifuSlider();
            this.lbSize = new System.Windows.Forms.Label();
            this.dudLetter = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.btFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // btFolder
            // 
            this.btFolder.BackColor = System.Drawing.Color.Transparent;
            this.btFolder.Image = ((System.Drawing.Image)(resources.GetObject("btFolder.Image")));
            this.btFolder.ImageActive = null;
            this.btFolder.Location = new System.Drawing.Point(20, 15);
            this.btFolder.Name = "btFolder";
            this.btFolder.Size = new System.Drawing.Size(50, 50);
            this.btFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btFolder.TabIndex = 0;
            this.btFolder.TabStop = false;
            this.btFolder.Zoom = 10;
            this.btFolder.Click += new System.EventHandler(this.btFolder_Click);
            // 
            // lbPath
            // 
            this.lbPath.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPath.Location = new System.Drawing.Point(67, 29);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(355, 29);
            this.lbPath.TabIndex = 0;
            this.lbPath.Text = "...";
            this.lbPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _fbd
            // 
            this._fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // bsSize
            // 
            this.bsSize.BackColor = System.Drawing.Color.Transparent;
            this.bsSize.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(206)))), ((int)(((byte)(74)))));
            this.bsSize.BorderRadius = 5;
            this.bsSize.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.bsSize.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(186)))), ((int)(((byte)(22)))));
            this.bsSize.Location = new System.Drawing.Point(20, 68);
            this.bsSize.Margin = new System.Windows.Forms.Padding(0);
            this.bsSize.MaximumValue = 65000;
            this.bsSize.Name = "bsSize";
            this.bsSize.Size = new System.Drawing.Size(309, 44);
            this.bsSize.TabIndex = 0;
            this.bsSize.TabStop = false;
            this.bsSize.Value = 500;
            this.bsSize.ValueChanged += new System.EventHandler(this.bsSize_ValueChanged);
            // 
            // lbSize
            // 
            this.lbSize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSize.Location = new System.Drawing.Point(322, 78);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(100, 30);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "0.5 TB";
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dudLetter
            // 
            this.dudLetter.BackColor = System.Drawing.Color.White;
            this.dudLetter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dudLetter.ForeColor = System.Drawing.Color.Black;
            this.dudLetter.Location = new System.Drawing.Point(373, 111);
            this.dudLetter.Name = "dudLetter";
            this.dudLetter.Size = new System.Drawing.Size(49, 27);
            this.dudLetter.TabIndex = 0;
            this.dudLetter.TabStop = false;
            this.dudLetter.Text = "X:\\";
            // 
            // SSD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dudLetter);
            this.Controls.Add(this.btFolder);
            this.Controls.Add(this.bsSize);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbPath);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SSD";
            this.Size = new System.Drawing.Size(442, 156);
            ((System.ComponentModel.ISupportInitialize)(this.btFolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btFolder;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.FolderBrowserDialog _fbd;
        private Bunifu.Framework.UI.BunifuSlider bsSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.DomainUpDown dudLetter;
    }
}
