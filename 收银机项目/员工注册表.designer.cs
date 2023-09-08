namespace 收银机项目
{
    partial class 员工注册表
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt员工姓名 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt员工手机号 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt员工密码 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rd男 = new System.Windows.Forms.RadioButton();
            this.rd女 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt确认登录密码 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名：";
            // 
            // txt员工姓名
            // 
            this.txt员工姓名.Font = new System.Drawing.Font("宋体", 16F);
            this.txt员工姓名.Location = new System.Drawing.Point(198, 47);
            this.txt员工姓名.Name = "txt员工姓名";
            this.txt员工姓名.Size = new System.Drawing.Size(148, 38);
            this.txt员工姓名.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F);
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "员工手机号：";
            // 
            // txt员工手机号
            // 
            this.txt员工手机号.Font = new System.Drawing.Font("宋体", 16F);
            this.txt员工手机号.Location = new System.Drawing.Point(198, 113);
            this.txt员工手机号.Name = "txt员工手机号";
            this.txt员工手机号.Size = new System.Drawing.Size(193, 38);
            this.txt员工手机号.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16F);
            this.label3.Location = new System.Drawing.Point(6, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "员工登录密码：";
            // 
            // txt员工密码
            // 
            this.txt员工密码.Font = new System.Drawing.Font("宋体", 16F);
            this.txt员工密码.Location = new System.Drawing.Point(192, 182);
            this.txt员工密码.Name = "txt员工密码";
            this.txt员工密码.Size = new System.Drawing.Size(234, 38);
            this.txt员工密码.TabIndex = 5;
            this.txt员工密码.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F);
            this.label4.Location = new System.Drawing.Point(12, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "员工性别：";
            // 
            // rd男
            // 
            this.rd男.AutoSize = true;
            this.rd男.Font = new System.Drawing.Font("宋体", 16F);
            this.rd男.Location = new System.Drawing.Point(198, 301);
            this.rd男.Name = "rd男";
            this.rd男.Size = new System.Drawing.Size(60, 31);
            this.rd男.TabIndex = 7;
            this.rd男.TabStop = true;
            this.rd男.Text = "男";
            this.rd男.UseVisualStyleBackColor = true;
            // 
            // rd女
            // 
            this.rd女.AutoSize = true;
            this.rd女.Font = new System.Drawing.Font("宋体", 16F);
            this.rd女.Location = new System.Drawing.Point(331, 301);
            this.rd女.Name = "rd女";
            this.rd女.Size = new System.Drawing.Size(60, 31);
            this.rd女.TabIndex = 8;
            this.rd女.TabStop = true;
            this.rd女.Text = "女";
            this.rd女.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 16F);
            this.button1.Location = new System.Drawing.Point(104, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 84);
            this.button1.TabIndex = 9;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 16F);
            this.button2.Location = new System.Drawing.Point(379, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 84);
            this.button2.TabIndex = 10;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16F);
            this.label5.Location = new System.Drawing.Point(6, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "确认登录密码：";
            // 
            // txt确认登录密码
            // 
            this.txt确认登录密码.Font = new System.Drawing.Font("宋体", 16F);
            this.txt确认登录密码.Location = new System.Drawing.Point(192, 235);
            this.txt确认登录密码.Name = "txt确认登录密码";
            this.txt确认登录密码.Size = new System.Drawing.Size(234, 38);
            this.txt确认登录密码.TabIndex = 5;
            this.txt确认登录密码.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // 员工注册表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rd女);
            this.Controls.Add(this.rd男);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt确认登录密码);
            this.Controls.Add(this.txt员工密码);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt员工手机号);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt员工姓名);
            this.Controls.Add(this.label1);
            this.Name = "员工注册表";
            this.Text = "员工注册表";
            this.Load += new System.EventHandler(this.员工注册表_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt员工姓名;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt员工手机号;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt员工密码;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rd男;
        private System.Windows.Forms.RadioButton rd女;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt确认登录密码;
    }
}