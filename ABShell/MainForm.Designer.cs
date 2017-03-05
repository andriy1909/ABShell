namespace ABShell
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnHead = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFont = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnStandart = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContents = new System.Windows.Forms.Panel();
            this.addBut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbUseShell = new ABShell.CheckBox2();
            this.cbUseDisp = new ABShell.CheckBox2();
            this.btnABOffice = new ABShell.UserButton();
            this.btnTeamViewer = new ABShell.ButtonApp();
            this.btnDescktop = new ABShell.ButtonApp();
            this.btnPrinters = new ABShell.ButtonApp();
            this.pnHead.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnStandart.SuspendLayout();
            this.pnContents.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHead
            // 
            this.pnHead.Controls.Add(this.panel1);
            this.pnHead.Controls.Add(this.pictureBox1);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(534, 113);
            this.pnHead.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnFont);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(236, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 112);
            this.panel1.TabIndex = 34;
            // 
            // btnFont
            // 
            this.btnFont.BackgroundImage = global::ABShell.Properties.Resources.application_x_font_afm_5280;
            this.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFont.FlatAppearance.BorderSize = 0;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFont.Location = new System.Drawing.Point(6, 3);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(36, 31);
            this.btnFont.TabIndex = 48;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Visible = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(48, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(243, 100);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABShell.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pnStandart
            // 
            this.pnStandart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStandart.Controls.Add(this.btnTeamViewer);
            this.pnStandart.Controls.Add(this.btnDescktop);
            this.pnStandart.Controls.Add(this.btnPrinters);
            this.pnStandart.Controls.Add(this.btnSetting);
            this.pnStandart.Controls.Add(this.btnRestart);
            this.pnStandart.Controls.Add(this.btnPowerOff);
            this.pnStandart.Controls.Add(this.btnLogout);
            this.pnStandart.Location = new System.Drawing.Point(-1, 138);
            this.pnStandart.Name = "pnStandart";
            this.pnStandart.Size = new System.Drawing.Size(534, 79);
            this.pnStandart.TabIndex = 32;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetting.BackgroundImage = global::ABShell.Properties.Resources.settings;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetting.Location = new System.Drawing.Point(231, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(70, 70);
            this.btnSetting.TabIndex = 96;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::ABShell.Properties.Resources.reload_03;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(383, 3);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(70, 70);
            this.btnRestart.TabIndex = 98;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.BackgroundImage = global::ABShell.Properties.Resources.power_01;
            this.btnPowerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerOff.FlatAppearance.BorderSize = 0;
            this.btnPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPowerOff.Location = new System.Drawing.Point(459, 4);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(70, 70);
            this.btnPowerOff.TabIndex = 99;
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::ABShell.Properties.Resources.login_02_3_3_2;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.Location = new System.Drawing.Point(307, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 70);
            this.btnLogout.TabIndex = 97;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Блокировать диспечер задач";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Заменять Windows Shell";
            // 
            // pnContents
            // 
            this.pnContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContents.Controls.Add(this.btnABOffice);
            this.pnContents.Controls.Add(this.addBut);
            this.pnContents.Location = new System.Drawing.Point(0, 242);
            this.pnContents.Name = "pnContents";
            this.pnContents.Size = new System.Drawing.Size(534, 93);
            this.pnContents.TabIndex = 57;
            // 
            // addBut
            // 
            this.addBut.BackgroundImage = global::ABShell.Properties.Resources.add_1078;
            this.addBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBut.FlatAppearance.BorderSize = 0;
            this.addBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(88, 18);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(51, 51);
            this.addBut.TabIndex = 47;
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Visible = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 25);
            this.panel3.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Настройки";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 25);
            this.panel4.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Программы";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cbUseShell);
            this.panel5.Controls.Add(this.cbUseDisp);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(40, 271);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(463, 64);
            this.panel5.TabIndex = 60;
            this.panel5.Visible = false;
            // 
            // cbUseShell
            // 
            this.cbUseShell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseShell.Checked = false;
            this.cbUseShell.Location = new System.Drawing.Point(313, 25);
            this.cbUseShell.Name = "cbUseShell";
            this.cbUseShell.SetText = null;
            this.cbUseShell.Size = new System.Drawing.Size(64, 37);
            this.cbUseShell.TabIndex = 52;
            this.cbUseShell.Click += new System.EventHandler(this.cbUseShell_Click);
            // 
            // cbUseDisp
            // 
            this.cbUseDisp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseDisp.Checked = false;
            this.cbUseDisp.Location = new System.Drawing.Point(89, 25);
            this.cbUseDisp.Name = "cbUseDisp";
            this.cbUseDisp.SetText = "";
            this.cbUseDisp.Size = new System.Drawing.Size(64, 37);
            this.cbUseDisp.TabIndex = 53;
            this.cbUseDisp.Click += new System.EventHandler(this.cbUseDisp_Click);
            // 
            // btnABOffice
            // 
            this.btnABOffice.BackColor = System.Drawing.SystemColors.Control;
            this.btnABOffice.id = 0;
            this.btnABOffice.image = global::ABShell.Properties.Resources.aboffice;
            this.btnABOffice.isVisible = false;
            this.btnABOffice.Location = new System.Drawing.Point(3, 3);
            this.btnABOffice.Name = "btnABOffice";
            this.btnABOffice.path = "C:\\office4\\client\\O4Client.exe";
            this.btnABOffice.SetText = "АБ ОФИС";
            this.btnABOffice.Size = new System.Drawing.Size(70, 87);
            this.btnABOffice.TabIndex = 100;
            this.btnABOffice.Click += new System.EventHandler(this.standartButt_Click);
            // 
            // btnTeamViewer
            // 
            this.btnTeamViewer.BackgroundImage = global::ABShell.Properties.Resources.TeamViewer;
            this.btnTeamViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeamViewer.FlatAppearance.BorderSize = 0;
            this.btnTeamViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeamViewer.id = 95;
            this.btnTeamViewer.image = global::ABShell.Properties.Resources.TeamViewer;
            this.btnTeamViewer.isVisible = false;
            this.btnTeamViewer.Location = new System.Drawing.Point(155, 3);
            this.btnTeamViewer.login = "";
            this.btnTeamViewer.Name = "btnTeamViewer";
            this.btnTeamViewer.password = "";
            this.btnTeamViewer.path = "";
            this.btnTeamViewer.server = "";
            this.btnTeamViewer.Size = new System.Drawing.Size(70, 70);
            this.btnTeamViewer.TabIndex = 95;
            this.btnTeamViewer.UseVisualStyleBackColor = true;
            this.btnTeamViewer.Click += new System.EventHandler(this.button_Click);
            // 
            // btnDescktop
            // 
            this.btnDescktop.BackgroundImage = global::ABShell.Properties.Resources.system;
            this.btnDescktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDescktop.FlatAppearance.BorderSize = 0;
            this.btnDescktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescktop.id = 5;
            this.btnDescktop.image = global::ABShell.Properties.Resources.system;
            this.btnDescktop.isVisible = false;
            this.btnDescktop.Location = new System.Drawing.Point(3, 3);
            this.btnDescktop.login = "";
            this.btnDescktop.Name = "btnDescktop";
            this.btnDescktop.password = "";
            this.btnDescktop.path = "explorer";
            this.btnDescktop.server = "";
            this.btnDescktop.Size = new System.Drawing.Size(70, 70);
            this.btnDescktop.TabIndex = 93;
            this.btnDescktop.UseVisualStyleBackColor = true;
            this.btnDescktop.Click += new System.EventHandler(this.btnDescktop_Click);
            // 
            // btnPrinters
            // 
            this.btnPrinters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrinters.BackgroundImage")));
            this.btnPrinters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrinters.FlatAppearance.BorderSize = 0;
            this.btnPrinters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinters.id = 5;
            this.btnPrinters.image = ((System.Drawing.Image)(resources.GetObject("btnPrinters.image")));
            this.btnPrinters.isVisible = false;
            this.btnPrinters.Location = new System.Drawing.Point(79, 3);
            this.btnPrinters.login = "";
            this.btnPrinters.Name = "btnPrinters";
            this.btnPrinters.password = "";
            this.btnPrinters.path = "control printers";
            this.btnPrinters.server = "";
            this.btnPrinters.Size = new System.Drawing.Size(70, 70);
            this.btnPrinters.TabIndex = 94;
            this.btnPrinters.UseVisualStyleBackColor = true;
            this.btnPrinters.Click += new System.EventHandler(this.btnPrinters_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 335);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnContents);
            this.Controls.Add(this.pnStandart);
            this.Controls.Add(this.pnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integra  v1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnHead.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnStandart.ResumeLayout(false);
            this.pnContents.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnStandart;
        private ButtonApp btnPrinters;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CheckBox2 cbUseDisp;
        private CheckBox2 cbUseShell;
        private ButtonApp btnDescktop;
        private System.Windows.Forms.Panel pnContents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private ButtonApp btnTeamViewer;
        private UserButton btnABOffice;
        private System.Windows.Forms.Button addBut;
    }
}

