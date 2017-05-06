namespace SysInfoChanger
{
    partial class Processor
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
            this.tbName = new ns1.BunifuMaterialTextbox();
            this.lbCores = new System.Windows.Forms.Label();
            this.lbMHz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.HintForeColor = System.Drawing.Color.Empty;
            this.tbName.HintText = "";
            this.tbName.isPassword = false;
            this.tbName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.tbName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.tbName.LineThickness = 4;
            this.tbName.Location = new System.Drawing.Point(20, 15);
            this.tbName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(402, 40);
            this.tbName.TabIndex = 0;
            this.tbName.TabStop = false;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbCores
            // 
            this.lbCores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCores.Location = new System.Drawing.Point(16, 100);
            this.lbCores.Name = "lbCores";
            this.lbCores.Size = new System.Drawing.Size(200, 24);
            this.lbCores.TabIndex = 0;
            this.lbCores.Text = "# of cores: ";
            // 
            // lbMHz
            // 
            this.lbMHz.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMHz.Location = new System.Drawing.Point(222, 100);
            this.lbMHz.Name = "lbMHz";
            this.lbMHz.Size = new System.Drawing.Size(200, 24);
            this.lbMHz.TabIndex = 0;
            this.lbMHz.Text = "MHz: ";
            this.lbMHz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Processor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbMHz);
            this.Controls.Add(this.lbCores);
            this.Controls.Add(this.tbName);
            this.Name = "Processor";
            this.Size = new System.Drawing.Size(442, 156);
            this.ResumeLayout(false);

        }

        #endregion

        public ns1.BunifuMaterialTextbox tbName;
        public System.Windows.Forms.Label lbCores;
        public System.Windows.Forms.Label lbMHz;
    }
}
