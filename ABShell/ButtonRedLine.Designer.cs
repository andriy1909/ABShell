namespace ABShell
{
    partial class ButtonRedLine
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
            this.imgLine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLine)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLine
            // 
            this.imgLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLine.Image = global::ABShell.Properties.Resources.redLine;
            this.imgLine.Location = new System.Drawing.Point(0, 0);
            this.imgLine.Name = "imgLine";
            this.imgLine.Size = new System.Drawing.Size(64, 64);
            this.imgLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLine.TabIndex = 0;
            this.imgLine.TabStop = false;
            this.imgLine.Visible = false;
            this.imgLine.Click += new System.EventHandler(this.imgRedLine_Click);
            // 
            // ButtonRedLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.imgLine);
            this.DoubleBuffered = true;
            this.Name = "ButtonRedLine";
            this.Size = new System.Drawing.Size(64, 64);
            this.Click += new System.EventHandler(this.ButtonRedLine_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLine;
    }
}
