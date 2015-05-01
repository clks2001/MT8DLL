namespace MT3Y
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID2BMP = new System.Windows.Forms.Button();
            this.ID2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.JRCPU = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FJCPU = new System.Windows.Forms.Button();
            this.CPU = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID2BMP);
            this.groupBox1.Controls.Add(this.ID2);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "身份证阅读器";
            // 
            // ID2BMP
            // 
            this.ID2BMP.Location = new System.Drawing.Point(161, 21);
            this.ID2BMP.Name = "ID2BMP";
            this.ID2BMP.Size = new System.Drawing.Size(136, 32);
            this.ID2BMP.TabIndex = 2;
            this.ID2BMP.Text = "读身份证（保存照片）";
            this.ID2BMP.UseVisualStyleBackColor = true;
            this.ID2BMP.Click += new System.EventHandler(this.ID2BMP_Click);
            // 
            // ID2
            // 
            this.ID2.Location = new System.Drawing.Point(11, 20);
            this.ID2.Name = "ID2";
            this.ID2.Size = new System.Drawing.Size(136, 32);
            this.ID2.TabIndex = 0;
            this.ID2.Text = "读身份证";
            this.ID2.UseVisualStyleBackColor = true;
            this.ID2.Click += new System.EventHandler(this.ID2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.JRCPU);
            this.groupBox2.Location = new System.Drawing.Point(30, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "金融IC卡";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "社保卡读身份证号码和姓名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JRCPU
            // 
            this.JRCPU.Location = new System.Drawing.Point(11, 20);
            this.JRCPU.Name = "JRCPU";
            this.JRCPU.Size = new System.Drawing.Size(136, 32);
            this.JRCPU.TabIndex = 0;
            this.JRCPU.Text = "读银行卡卡号姓名";
            this.JRCPU.UseVisualStyleBackColor = true;
            this.JRCPU.Click += new System.EventHandler(this.JRCPU_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(30, 244);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 184);
            this.listBox1.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(193, 443);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "清除";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FJCPU);
            this.groupBox3.Controls.Add(this.CPU);
            this.groupBox3.Location = new System.Drawing.Point(30, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CPU卡";
            // 
            // FJCPU
            // 
            this.FJCPU.Location = new System.Drawing.Point(163, 19);
            this.FJCPU.Name = "FJCPU";
            this.FJCPU.Size = new System.Drawing.Size(136, 32);
            this.FJCPU.TabIndex = 0;
            this.FJCPU.Text = "非接CPU操作";
            this.FJCPU.UseVisualStyleBackColor = true;
            this.FJCPU.Click += new System.EventHandler(this.FJCPU_Click);
            // 
            // CPU
            // 
            this.CPU.Location = new System.Drawing.Point(12, 19);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(136, 32);
            this.CPU.TabIndex = 0;
            this.CPU.Text = "接触CPU操作";
            this.CPU.UseVisualStyleBackColor = true;
            this.CPU.Click += new System.EventHandler(this.CPU_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 470);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 57);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 533);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(30, 560);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(419, 21);
            this.textBox5.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(369, 533);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 21);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "证件类型";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Name = "Form1";
            this.Text = "MT3Y 通用例程 V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ID2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button JRCPU;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button ID2BMP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button FJCPU;
        private System.Windows.Forms.Button CPU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}

