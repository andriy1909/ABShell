namespace ABShell
{
    partial class SettingBut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingBut));
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.imgButtom = new System.Windows.Forms.PictureBox();
            this.btnVis = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgButtom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenImg.FlatAppearance.BorderSize = 0;
            this.btnOpenImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenImg.Location = new System.Drawing.Point(19, 96);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(69, 21);
            this.btnOpenImg.TabIndex = 13;
            this.btnOpenImg.Text = "Обзор";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOpenPath);
            this.panel2.Controls.Add(this.tbPath);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(107, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 52);
            this.panel2.TabIndex = 17;
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.Location = new System.Drawing.Point(6, 25);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(285, 22);
            this.tbPath.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Путь к программе";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(107, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 52);
            this.panel1.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(6, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(285, 22);
            this.tbName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название программы";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImage = global::ABShell.Properties.Resources.button_cancel_6758;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(420, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(43, 47);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::ABShell.Properties.Resources.plainicon2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(52, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 47);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnVis_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::ABShell.Properties.Resources.edittrash_7432;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 47);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenPath.BackgroundImage")));
            this.btnOpenPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenPath.FlatAppearance.BorderSize = 0;
            this.btnOpenPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPath.Location = new System.Drawing.Point(297, 22);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(27, 29);
            this.btnOpenPath.TabIndex = 14;
            this.btnOpenPath.UseVisualStyleBackColor = true;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::ABShell.Properties.Resources.button_ok_1908;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(371, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(43, 47);
            this.btnSave.TabIndex = 15;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imgButtom
            // 
            this.imgButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgButtom.Image = global::ABShell.Properties.Resources.program_3090;
            this.imgButtom.Location = new System.Drawing.Point(17, 18);
            this.imgButtom.Name = "imgButtom";
            this.imgButtom.Size = new System.Drawing.Size(72, 72);
            this.imgButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgButtom.TabIndex = 12;
            this.imgButtom.TabStop = false;
            this.imgButtom.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVis
            // 
            this.btnVis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVis.BackgroundImage = global::ABShell.Properties.Resources.plainicon_com_49216_128px_2dd;
            this.btnVis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVis.FlatAppearance.BorderSize = 0;
            this.btnVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVis.Location = new System.Drawing.Point(52, 124);
            this.btnVis.Name = "btnVis";
            this.btnVis.Size = new System.Drawing.Size(43, 47);
            this.btnVis.TabIndex = 21;
            this.btnVis.UseVisualStyleBackColor = true;
            this.btnVis.Click += new System.EventHandler(this.btnVis_Click);
            // 
            // SettingBut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(475, 182);
            this.Controls.Add(this.btnVis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenImg);
            this.Controls.Add(this.imgButtom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingBut";
            this.Text = "Настройки";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgButtom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.PictureBox imgButtom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVis;
    }
}