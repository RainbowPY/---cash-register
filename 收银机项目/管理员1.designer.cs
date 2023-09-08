namespace 收银机项目
{
    partial class 管理员1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.结帐表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierDataSet = new 收银机项目.CashierDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.结帐表TableAdapter = new 收银机项目.CashierDataSetTableAdapters.结帐表TableAdapter();
            this.cashierDataSet4 = new 收银机项目.CashierDataSet4();
            this.结帐表BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.结帐表TableAdapter1 = new 收银机项目.CashierDataSet4TableAdapters.结帐表TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.账单编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.支付方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户实付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.找零DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品购买数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.支付时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结账状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.结帐表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.结帐表BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2067, 114);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 19F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(1074, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "四带两队";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 19F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(392, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 19F);
            this.label2.Location = new System.Drawing.Point(52, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "管理员账号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 19F);
            this.label1.Location = new System.Drawing.Point(908, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2067, 1104);
            this.panel2.TabIndex = 1;
            // 
            // 结帐表BindingSource
            // 
            this.结帐表BindingSource.DataMember = "结帐表";
            this.结帐表BindingSource.DataSource = this.cashierDataSet;
            // 
            // cashierDataSet
            // 
            this.cashierDataSet.DataSetName = "CashierDataSet";
            this.cashierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 1050);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2067, 168);
            this.panel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 18F);
            this.button4.Location = new System.Drawing.Point(1568, 52);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(304, 65);
            this.button4.TabIndex = 1;
            this.button4.Text = "刷新";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 18F);
            this.button3.Location = new System.Drawing.Point(1015, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 65);
            this.button3.TabIndex = 1;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 18F);
            this.button2.Location = new System.Drawing.Point(497, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "商品管理";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 18F);
            this.button1.Location = new System.Drawing.Point(46, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "收银员管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 结帐表TableAdapter
            // 
            this.结帐表TableAdapter.ClearBeforeFill = true;
            // 
            // cashierDataSet4
            // 
            this.cashierDataSet4.DataSetName = "CashierDataSet4";
            this.cashierDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 结帐表BindingSource1
            // 
            this.结帐表BindingSource1.DataMember = "结帐表";
            this.结帐表BindingSource1.DataSource = this.cashierDataSet4;
            // 
            // 结帐表TableAdapter1
            // 
            this.结帐表TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.账单编号DataGridViewTextBoxColumn,
            this.支付方式DataGridViewTextBoxColumn,
            this.用户实付DataGridViewTextBoxColumn,
            this.找零DataGridViewTextBoxColumn,
            this.员工编号DataGridViewTextBoxColumn,
            this.商品购买数量DataGridViewTextBoxColumn,
            this.支付时间DataGridViewTextBoxColumn,
            this.结账状态DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.结帐表BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2067, 1104);
            this.dataGridView1.TabIndex = 1;
            // 
            // 账单编号DataGridViewTextBoxColumn
            // 
            this.账单编号DataGridViewTextBoxColumn.DataPropertyName = "账单编号";
            this.账单编号DataGridViewTextBoxColumn.HeaderText = "账单编号";
            this.账单编号DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.账单编号DataGridViewTextBoxColumn.Name = "账单编号DataGridViewTextBoxColumn";
            this.账单编号DataGridViewTextBoxColumn.ReadOnly = true;
            this.账单编号DataGridViewTextBoxColumn.Width = 140;
            // 
            // 支付方式DataGridViewTextBoxColumn
            // 
            this.支付方式DataGridViewTextBoxColumn.DataPropertyName = "支付方式";
            this.支付方式DataGridViewTextBoxColumn.HeaderText = "支付方式";
            this.支付方式DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.支付方式DataGridViewTextBoxColumn.Name = "支付方式DataGridViewTextBoxColumn";
            this.支付方式DataGridViewTextBoxColumn.ReadOnly = true;
            this.支付方式DataGridViewTextBoxColumn.Width = 140;
            // 
            // 用户实付DataGridViewTextBoxColumn
            // 
            this.用户实付DataGridViewTextBoxColumn.DataPropertyName = "用户实付";
            this.用户实付DataGridViewTextBoxColumn.HeaderText = "用户实付";
            this.用户实付DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.用户实付DataGridViewTextBoxColumn.Name = "用户实付DataGridViewTextBoxColumn";
            this.用户实付DataGridViewTextBoxColumn.ReadOnly = true;
            this.用户实付DataGridViewTextBoxColumn.Width = 140;
            // 
            // 找零DataGridViewTextBoxColumn
            // 
            this.找零DataGridViewTextBoxColumn.DataPropertyName = "找零";
            this.找零DataGridViewTextBoxColumn.HeaderText = "找零";
            this.找零DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.找零DataGridViewTextBoxColumn.Name = "找零DataGridViewTextBoxColumn";
            this.找零DataGridViewTextBoxColumn.ReadOnly = true;
            this.找零DataGridViewTextBoxColumn.Width = 140;
            // 
            // 员工编号DataGridViewTextBoxColumn
            // 
            this.员工编号DataGridViewTextBoxColumn.DataPropertyName = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.HeaderText = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.员工编号DataGridViewTextBoxColumn.Name = "员工编号DataGridViewTextBoxColumn";
            this.员工编号DataGridViewTextBoxColumn.ReadOnly = true;
            this.员工编号DataGridViewTextBoxColumn.Width = 140;
            // 
            // 商品购买数量DataGridViewTextBoxColumn
            // 
            this.商品购买数量DataGridViewTextBoxColumn.DataPropertyName = "商品购买数量";
            this.商品购买数量DataGridViewTextBoxColumn.HeaderText = "商品购买数量";
            this.商品购买数量DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.商品购买数量DataGridViewTextBoxColumn.Name = "商品购买数量DataGridViewTextBoxColumn";
            this.商品购买数量DataGridViewTextBoxColumn.ReadOnly = true;
            this.商品购买数量DataGridViewTextBoxColumn.Width = 140;
            // 
            // 支付时间DataGridViewTextBoxColumn
            // 
            this.支付时间DataGridViewTextBoxColumn.DataPropertyName = "支付时间";
            this.支付时间DataGridViewTextBoxColumn.HeaderText = "支付时间";
            this.支付时间DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.支付时间DataGridViewTextBoxColumn.Name = "支付时间DataGridViewTextBoxColumn";
            this.支付时间DataGridViewTextBoxColumn.ReadOnly = true;
            this.支付时间DataGridViewTextBoxColumn.Width = 140;
            // 
            // 结账状态DataGridViewTextBoxColumn
            // 
            this.结账状态DataGridViewTextBoxColumn.DataPropertyName = "结账状态";
            this.结账状态DataGridViewTextBoxColumn.HeaderText = "结账状态";
            this.结账状态DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.结账状态DataGridViewTextBoxColumn.Name = "结账状态DataGridViewTextBoxColumn";
            this.结账状态DataGridViewTextBoxColumn.ReadOnly = true;
            this.结账状态DataGridViewTextBoxColumn.Width = 140;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 18F);
            this.button5.Location = new System.Drawing.Point(1381, 30);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(304, 65);
            this.button5.TabIndex = 1;
            this.button5.Text = "返回登录";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // 管理员1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2067, 1218);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "管理员1";
            this.Text = "管理员1";
            this.Load += new System.EventHandler(this.管理员1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.结帐表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.结帐表BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CashierDataSet cashierDataSet;
        private System.Windows.Forms.BindingSource 结帐表BindingSource;
        private CashierDataSetTableAdapters.结帐表TableAdapter 结帐表TableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private CashierDataSet4 cashierDataSet4;
        private System.Windows.Forms.BindingSource 结帐表BindingSource1;
        private CashierDataSet4TableAdapters.结帐表TableAdapter 结帐表TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账单编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 支付方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户实付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 找零DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品购买数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 支付时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结账状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}