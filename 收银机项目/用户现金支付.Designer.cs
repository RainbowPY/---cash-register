namespace 收银机项目
{
    partial class txt现金支付
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
            this.label2 = new System.Windows.Forms.Label();
            this.tet实付 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lab总价 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab找零 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 19F);
            this.label2.Location = new System.Drawing.Point(51, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "实付现金：";
            // 
            // tet实付
            // 
            this.tet实付.Font = new System.Drawing.Font("宋体", 16F);
            this.tet实付.Location = new System.Drawing.Point(264, 182);
            this.tet实付.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tet实付.Name = "tet实付";
            this.tet实付.Size = new System.Drawing.Size(281, 44);
            this.tet实付.TabIndex = 2;
            this.tet实付.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tet实付_KeyDown);
            this.tet实付.MouseLeave += new System.EventHandler(this.tet实付_MouseLeave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(255, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 128);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 19F);
            this.label3.Location = new System.Drawing.Point(51, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "商品总价：";
            // 
            // lab总价
            // 
            this.lab总价.AutoSize = true;
            this.lab总价.Font = new System.Drawing.Font("宋体", 19F);
            this.lab总价.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lab总价.Location = new System.Drawing.Point(310, 68);
            this.lab总价.Name = "lab总价";
            this.lab总价.Size = new System.Drawing.Size(131, 38);
            this.lab总价.TabIndex = 5;
            this.lab总价.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 19F);
            this.label5.Location = new System.Drawing.Point(127, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "找零：";
            // 
            // lab找零
            // 
            this.lab找零.AutoSize = true;
            this.lab找零.Font = new System.Drawing.Font("宋体", 19F);
            this.lab找零.ForeColor = System.Drawing.Color.Lime;
            this.lab找零.Location = new System.Drawing.Point(310, 284);
            this.lab找零.Name = "lab找零";
            this.lab找零.Size = new System.Drawing.Size(93, 38);
            this.lab找零.TabIndex = 5;
            this.lab找零.Text = "0.00";
            // 
            // txt现金支付
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.lab找零);
            this.Controls.Add(this.lab总价);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tet实付);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "txt现金支付";
            this.Text = "用户现金支付";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tet实付;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab总价;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab找零;
    }
}