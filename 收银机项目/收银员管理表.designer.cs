namespace 收银机项目
{
    partial class 收银员管理表
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.员工编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工登陆密码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收银员表BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cashierDataSet3 = new 收银机项目.CashierDataSet3();
            this.收银员表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierDataSet2 = new 收银机项目.CashierDataSet2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.收银员表TableAdapter = new 收银机项目.CashierDataSet3TableAdapters.收银员表TableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.收银员表BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.收银员表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 756);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.员工编号DataGridViewTextBoxColumn,
            this.员工姓名DataGridViewTextBoxColumn,
            this.员工电话DataGridViewTextBoxColumn,
            this.员工登陆密码DataGridViewTextBoxColumn,
            this.员工性别DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.收银员表BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 756);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 员工编号DataGridViewTextBoxColumn
            // 
            this.员工编号DataGridViewTextBoxColumn.DataPropertyName = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.HeaderText = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.员工编号DataGridViewTextBoxColumn.Name = "员工编号DataGridViewTextBoxColumn";
            this.员工编号DataGridViewTextBoxColumn.ReadOnly = true;
            this.员工编号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 员工姓名DataGridViewTextBoxColumn
            // 
            this.员工姓名DataGridViewTextBoxColumn.DataPropertyName = "员工姓名";
            this.员工姓名DataGridViewTextBoxColumn.HeaderText = "员工姓名";
            this.员工姓名DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.员工姓名DataGridViewTextBoxColumn.Name = "员工姓名DataGridViewTextBoxColumn";
            this.员工姓名DataGridViewTextBoxColumn.ReadOnly = true;
            this.员工姓名DataGridViewTextBoxColumn.Width = 125;
            // 
            // 员工电话DataGridViewTextBoxColumn
            // 
            this.员工电话DataGridViewTextBoxColumn.DataPropertyName = "员工电话";
            this.员工电话DataGridViewTextBoxColumn.HeaderText = "员工电话";
            this.员工电话DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.员工电话DataGridViewTextBoxColumn.Name = "员工电话DataGridViewTextBoxColumn";
            this.员工电话DataGridViewTextBoxColumn.ReadOnly = true;
            this.员工电话DataGridViewTextBoxColumn.Width = 125;
            // 
            // 员工登陆密码DataGridViewTextBoxColumn
            // 
            this.员工登陆密码DataGridViewTextBoxColumn.DataPropertyName = "员工登陆密码";
            this.员工登陆密码DataGridViewTextBoxColumn.HeaderText = "员工登陆密码";
            this.员工登陆密码DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.员工登陆密码DataGridViewTextBoxColumn.Name = "员工登陆密码DataGridViewTextBoxColumn";
            this.员工登陆密码DataGridViewTextBoxColumn.ReadOnly = true;
            this.员工登陆密码DataGridViewTextBoxColumn.Width = 125;
            // 
            // 员工性别DataGridViewTextBoxColumn
            // 
            this.员工性别DataGridViewTextBoxColumn.DataPropertyName = "员工性别";
            this.员工性别DataGridViewTextBoxColumn.HeaderText = "员工性别";
            this.员工性别DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.员工性别DataGridViewTextBoxColumn.Name = "员工性别DataGridViewTextBoxColumn";
            this.员工性别DataGridViewTextBoxColumn.ReadOnly = true;
            this.员工性别DataGridViewTextBoxColumn.Width = 125;
            // 
            // 收银员表BindingSource1
            // 
            this.收银员表BindingSource1.DataMember = "收银员表";
            this.收银员表BindingSource1.DataSource = this.cashierDataSet3;
            // 
            // cashierDataSet3
            // 
            this.cashierDataSet3.DataSetName = "CashierDataSet3";
            this.cashierDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 收银员表BindingSource
            // 
            this.收银员表BindingSource.DataMember = "收银员表";
            this.收银员表BindingSource.DataSource = this.cashierDataSet2;
            // 
            // cashierDataSet2
            // 
            this.cashierDataSet2.DataSetName = "CashierDataSet2";
            this.cashierDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(761, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 756);
            this.panel3.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 16F);
            this.button5.Location = new System.Drawing.Point(28, 613);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 107);
            this.button5.TabIndex = 3;
            this.button5.Text = "关闭";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 16F);
            this.button3.Location = new System.Drawing.Point(28, 322);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 103);
            this.button3.TabIndex = 1;
            this.button3.TabStop = false;
            this.button3.Text = "删除员工";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 16F);
            this.button2.Location = new System.Drawing.Point(33, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 100);
            this.button2.TabIndex = 0;
            this.button2.Text = "添加员工";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 收银员表TableAdapter
            // 
            this.收银员表TableAdapter.ClearBeforeFill = true;
            // 
            // 收银员管理表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 756);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "收银员管理表";
            this.Text = "收银员管理表";
            this.Load += new System.EventHandler(this.收银员管理表_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.收银员表BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.收银员表BindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CashierDataSet2 cashierDataSet2;
        private System.Windows.Forms.BindingSource 收银员表BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工登陆密码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工性别DataGridViewTextBoxColumn;
        private CashierDataSet3 cashierDataSet3;
        private System.Windows.Forms.BindingSource 收银员表BindingSource1;
        private CashierDataSet3TableAdapters.收银员表TableAdapter 收银员表TableAdapter;
    }
}