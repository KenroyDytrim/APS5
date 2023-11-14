namespace APS5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WindowsBox = new System.Windows.Forms.GroupBox();
            this.panelW = new System.Windows.Forms.Panel();
            this.LinuxBox = new System.Windows.Forms.GroupBox();
            this.panelL = new System.Windows.Forms.Panel();
            this.AndroidBox = new System.Windows.Forms.GroupBox();
            this.panelA = new System.Windows.Forms.Panel();
            this.InterfaceBox = new System.Windows.Forms.GroupBox();
            this.Platform = new System.Windows.Forms.ComboBox();
            this.Create = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.CopBox = new System.Windows.Forms.ListBox();
            this.listObjects = new System.Windows.Forms.ListBox();
            this.textD1 = new System.Windows.Forms.TextBox();
            this.textD2 = new System.Windows.Forms.TextBox();
            this.textD3 = new System.Windows.Forms.TextBox();
            this.textD4 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.WindowsBox.SuspendLayout();
            this.LinuxBox.SuspendLayout();
            this.AndroidBox.SuspendLayout();
            this.InterfaceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowsBox
            // 
            this.WindowsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WindowsBox.Controls.Add(this.pictureBox1);
            this.WindowsBox.Controls.Add(this.panelW);
            this.WindowsBox.Location = new System.Drawing.Point(32, 12);
            this.WindowsBox.Name = "WindowsBox";
            this.WindowsBox.Size = new System.Drawing.Size(479, 401);
            this.WindowsBox.TabIndex = 0;
            this.WindowsBox.TabStop = false;
            this.WindowsBox.Text = "Windows";
            // 
            // panelW
            // 
            this.panelW.AutoScroll = true;
            this.panelW.Location = new System.Drawing.Point(35, 22);
            this.panelW.Name = "panelW";
            this.panelW.Size = new System.Drawing.Size(425, 373);
            this.panelW.TabIndex = 0;
            this.panelW.DoubleClick += new System.EventHandler(this.panelW_DoubleClick);
            // 
            // LinuxBox
            // 
            this.LinuxBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LinuxBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LinuxBox.Controls.Add(this.pictureBox2);
            this.LinuxBox.Controls.Add(this.panelL);
            this.LinuxBox.Location = new System.Drawing.Point(552, 12);
            this.LinuxBox.Name = "LinuxBox";
            this.LinuxBox.Size = new System.Drawing.Size(479, 401);
            this.LinuxBox.TabIndex = 1;
            this.LinuxBox.TabStop = false;
            this.LinuxBox.Text = "Linux";
            // 
            // panelL
            // 
            this.panelL.AutoScroll = true;
            this.panelL.Location = new System.Drawing.Point(35, 22);
            this.panelL.Name = "panelL";
            this.panelL.Size = new System.Drawing.Size(438, 373);
            this.panelL.TabIndex = 0;
            this.panelL.DoubleClick += new System.EventHandler(this.panelL_DoubleClick);
            // 
            // AndroidBox
            // 
            this.AndroidBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AndroidBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AndroidBox.Controls.Add(this.pictureBox3);
            this.AndroidBox.Controls.Add(this.panelA);
            this.AndroidBox.Location = new System.Drawing.Point(1075, 12);
            this.AndroidBox.Name = "AndroidBox";
            this.AndroidBox.Size = new System.Drawing.Size(257, 401);
            this.AndroidBox.TabIndex = 1;
            this.AndroidBox.TabStop = false;
            this.AndroidBox.Text = "Android";
            // 
            // panelA
            // 
            this.panelA.AutoScroll = true;
            this.panelA.Location = new System.Drawing.Point(33, 22);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(218, 373);
            this.panelA.TabIndex = 0;
            this.panelA.DoubleClick += new System.EventHandler(this.panelA_DoubleClick);
            // 
            // InterfaceBox
            // 
            this.InterfaceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InterfaceBox.Controls.Add(this.Platform);
            this.InterfaceBox.Controls.Add(this.Create);
            this.InterfaceBox.Location = new System.Drawing.Point(72, 439);
            this.InterfaceBox.Name = "InterfaceBox";
            this.InterfaceBox.Size = new System.Drawing.Size(351, 165);
            this.InterfaceBox.TabIndex = 1;
            this.InterfaceBox.TabStop = false;
            this.InterfaceBox.Text = "Интерфейс";
            // 
            // Platform
            // 
            this.Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Platform.FormattingEnabled = true;
            this.Platform.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "Android"});
            this.Platform.Location = new System.Drawing.Point(58, 41);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(222, 33);
            this.Platform.TabIndex = 1;
            this.Platform.Text = "Windows";
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(104, 87);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(121, 47);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.Location = new System.Drawing.Point(552, 439);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(143, 30);
            this.textName.TabIndex = 2;
            // 
            // CopBox
            // 
            this.CopBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopBox.FormattingEnabled = true;
            this.CopBox.ItemHeight = 25;
            this.CopBox.Items.AddRange(new object[] {
            "Кнопка",
            "Надпись"});
            this.CopBox.Location = new System.Drawing.Point(552, 489);
            this.CopBox.Name = "CopBox";
            this.CopBox.Size = new System.Drawing.Size(143, 79);
            this.CopBox.TabIndex = 3;
            // 
            // listObjects
            // 
            this.listObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listObjects.FormattingEnabled = true;
            this.listObjects.ItemHeight = 25;
            this.listObjects.Location = new System.Drawing.Point(834, 430);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(278, 154);
            this.listObjects.TabIndex = 4;
            this.listObjects.SelectedIndexChanged += new System.EventHandler(this.listObjects_SelectedIndexChanged);
            // 
            // textD1
            // 
            this.textD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textD1.Location = new System.Drawing.Point(1165, 430);
            this.textD1.Name = "textD1";
            this.textD1.Size = new System.Drawing.Size(143, 30);
            this.textD1.TabIndex = 5;
            // 
            // textD2
            // 
            this.textD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textD2.Location = new System.Drawing.Point(1165, 480);
            this.textD2.Name = "textD2";
            this.textD2.Size = new System.Drawing.Size(143, 30);
            this.textD2.TabIndex = 6;
            // 
            // textD3
            // 
            this.textD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textD3.Location = new System.Drawing.Point(1165, 526);
            this.textD3.Name = "textD3";
            this.textD3.Size = new System.Drawing.Size(143, 30);
            this.textD3.TabIndex = 7;
            // 
            // textD4
            // 
            this.textD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textD4.Location = new System.Drawing.Point(1165, 574);
            this.textD4.Name = "textD4";
            this.textD4.Size = new System.Drawing.Size(143, 30);
            this.textD4.TabIndex = 8;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(1165, 610);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(143, 47);
            this.Save.TabIndex = 9;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 42);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 41);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 663);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textD4);
            this.Controls.Add(this.textD3);
            this.Controls.Add(this.textD2);
            this.Controls.Add(this.textD1);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.CopBox);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.InterfaceBox);
            this.Controls.Add(this.AndroidBox);
            this.Controls.Add(this.LinuxBox);
            this.Controls.Add(this.WindowsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Интерфейс";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.WindowsBox.ResumeLayout(false);
            this.LinuxBox.ResumeLayout(false);
            this.AndroidBox.ResumeLayout(false);
            this.InterfaceBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox WindowsBox;
        private System.Windows.Forms.GroupBox LinuxBox;
        private System.Windows.Forms.GroupBox AndroidBox;
        private System.Windows.Forms.GroupBox InterfaceBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ComboBox Platform;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ListBox CopBox;
        private System.Windows.Forms.Panel panelW;
        private System.Windows.Forms.Panel panelL;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.ListBox listObjects;
        private System.Windows.Forms.TextBox textD1;
        private System.Windows.Forms.TextBox textD2;
        private System.Windows.Forms.TextBox textD3;
        private System.Windows.Forms.TextBox textD4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

