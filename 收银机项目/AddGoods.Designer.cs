namespace 收银机项目
{
    partial class AddGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGoods));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.删除 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab数量 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab总计 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.but搜索 = new System.Windows.Forms.Button();
            this.tet商品编号 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.账单编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.支付方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户实付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.找零DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品购买数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.支付时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结账状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结帐表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierDataSet6 = new 收银机项目.CashierDataSet6();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tet流水编号 = new System.Windows.Forms.TextBox();
            this.结帐表TableAdapter = new 收银机项目.CashierDataSet6TableAdapters.结帐表TableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.结帐表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet6)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 1264);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(559, 976);
            this.panel5.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(559, 976);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "图片";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品编号";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "商品名称";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "商品单价";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "商品数量";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "小计";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.删除);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(559, 100);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 976);
            this.panel6.TabIndex = 2;
            // 
            // 删除
            // 
            this.删除.BackColor = System.Drawing.SystemColors.ControlDark;
            this.删除.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.删除.ForeColor = System.Drawing.Color.Crimson;
            this.删除.Location = new System.Drawing.Point(19, 249);
            this.删除.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.删除.Name = "删除";
            this.删除.Size = new System.Drawing.Size(165, 159);
            this.删除.TabIndex = 3;
            this.删除.Text = "删除";
            this.删除.UseVisualStyleBackColor = false;
            this.删除.Click += new System.EventHandler(this.删除_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(19, 451);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 155);
            this.button3.TabIndex = 2;
            this.button3.Text = "整表清空";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Highlight;
            this.button7.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(19, 855);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 121);
            this.button7.TabIndex = 2;
            this.button7.Text = "挂单";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(19, 669);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 142);
            this.button2.TabIndex = 2;
            this.button2.Text = "获取结账单";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(19, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 164);
            this.button1.TabIndex = 2;
            this.button1.Text = "修改数量";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lab数量);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lab总计);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 1076);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(759, 188);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 19F);
            this.label5.Location = new System.Drawing.Point(380, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "总数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 19F);
            this.label6.Location = new System.Drawing.Point(608, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "件";
            // 
            // lab数量
            // 
            this.lab数量.AutoSize = true;
            this.lab数量.Font = new System.Drawing.Font("宋体", 19F);
            this.lab数量.ForeColor = System.Drawing.Color.Blue;
            this.lab数量.Location = new System.Drawing.Point(533, 87);
            this.lab数量.Name = "lab数量";
            this.lab数量.Size = new System.Drawing.Size(36, 38);
            this.lab数量.TabIndex = 1;
            this.lab数量.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 19F);
            this.label3.Location = new System.Drawing.Point(97, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "￥";
            // 
            // lab总计
            // 
            this.lab总计.AutoSize = true;
            this.lab总计.Font = new System.Drawing.Font("宋体", 19F);
            this.lab总计.ForeColor = System.Drawing.Color.Red;
            this.lab总计.Location = new System.Drawing.Point(177, 87);
            this.lab总计.Name = "lab总计";
            this.lab总计.Size = new System.Drawing.Size(93, 38);
            this.lab总计.TabIndex = 0;
            this.lab总计.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 19F);
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "商品总计：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.but搜索);
            this.panel3.Controls.Add(this.tet商品编号);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 100);
            this.panel3.TabIndex = 0;
            // 
            // but搜索
            // 
            this.but搜索.BackColor = System.Drawing.SystemColors.Highlight;
            this.but搜索.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but搜索.ForeColor = System.Drawing.SystemColors.Control;
            this.but搜索.Location = new System.Drawing.Point(559, 8);
            this.but搜索.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but搜索.Name = "but搜索";
            this.but搜索.Size = new System.Drawing.Size(165, 82);
            this.but搜索.TabIndex = 2;
            this.but搜索.Text = "搜索";
            this.but搜索.UseVisualStyleBackColor = false;
            this.but搜索.Click += new System.EventHandler(this.but搜索_Click);
            // 
            // tet商品编号
            // 
            this.tet商品编号.Font = new System.Drawing.Font("宋体", 19F);
            this.tet商品编号.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tet商品编号.Location = new System.Drawing.Point(184, 31);
            this.tet商品编号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tet商品编号.Multiline = true;
            this.tet商品编号.Name = "tet商品编号";
            this.tet商品编号.Size = new System.Drawing.Size(307, 56);
            this.tet商品编号.TabIndex = 1;
            this.tet商品编号.Text = "商品编号/名称";
            this.tet商品编号.TextChanged += new System.EventHandler(this.tet商品编号_TextChanged);
            this.tet商品编号.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tet商品编号_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 19F);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "条形码：";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(759, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1383, 1264);
            this.panel2.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridView1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 100);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1383, 962);
            this.panel9.TabIndex = 2;
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
            this.dataGridView1.DataSource = this.结帐表BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1383, 962);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // 账单编号DataGridViewTextBoxColumn
            // 
            this.账单编号DataGridViewTextBoxColumn.DataPropertyName = "账单编号";
            this.账单编号DataGridViewTextBoxColumn.HeaderText = "账单编号";
            this.账单编号DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.账单编号DataGridViewTextBoxColumn.Name = "账单编号DataGridViewTextBoxColumn";
            this.账单编号DataGridViewTextBoxColumn.ReadOnly = true;
            this.账单编号DataGridViewTextBoxColumn.Width = 150;
            // 
            // 支付方式DataGridViewTextBoxColumn
            // 
            this.支付方式DataGridViewTextBoxColumn.DataPropertyName = "支付方式";
            this.支付方式DataGridViewTextBoxColumn.HeaderText = "支付方式";
            this.支付方式DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.支付方式DataGridViewTextBoxColumn.Name = "支付方式DataGridViewTextBoxColumn";
            this.支付方式DataGridViewTextBoxColumn.ReadOnly = true;
            this.支付方式DataGridViewTextBoxColumn.Width = 150;
            // 
            // 用户实付DataGridViewTextBoxColumn
            // 
            this.用户实付DataGridViewTextBoxColumn.DataPropertyName = "用户实付";
            this.用户实付DataGridViewTextBoxColumn.HeaderText = "用户实付";
            this.用户实付DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.用户实付DataGridViewTextBoxColumn.Name = "用户实付DataGridViewTextBoxColumn";
            this.用户实付DataGridViewTextBoxColumn.ReadOnly = true;
            this.用户实付DataGridViewTextBoxColumn.Width = 150;
            // 
            // 找零DataGridViewTextBoxColumn
            // 
            this.找零DataGridViewTextBoxColumn.DataPropertyName = "找零";
            this.找零DataGridViewTextBoxColumn.HeaderText = "找零";
            this.找零DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.找零DataGridViewTextBoxColumn.Name = "找零DataGridViewTextBoxColumn";
            this.找零DataGridViewTextBoxColumn.ReadOnly = true;
            this.找零DataGridViewTextBoxColumn.Width = 150;
            // 
            // 员工编号DataGridViewTextBoxColumn
            // 
            this.员工编号DataGridViewTextBoxColumn.DataPropertyName = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.HeaderText = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.员工编号DataGridViewTextBoxColumn.Name = "员工编号DataGridViewTextBoxColumn";
            this.员工编号DataGridViewTextBoxColumn.ReadOnly = true;
            this.员工编号DataGridViewTextBoxColumn.Width = 150;
            // 
            // 商品购买数量DataGridViewTextBoxColumn
            // 
            this.商品购买数量DataGridViewTextBoxColumn.DataPropertyName = "商品购买数量";
            this.商品购买数量DataGridViewTextBoxColumn.HeaderText = "商品购买数量";
            this.商品购买数量DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.商品购买数量DataGridViewTextBoxColumn.Name = "商品购买数量DataGridViewTextBoxColumn";
            this.商品购买数量DataGridViewTextBoxColumn.ReadOnly = true;
            this.商品购买数量DataGridViewTextBoxColumn.Width = 150;
            // 
            // 支付时间DataGridViewTextBoxColumn
            // 
            this.支付时间DataGridViewTextBoxColumn.DataPropertyName = "支付时间";
            this.支付时间DataGridViewTextBoxColumn.HeaderText = "支付时间";
            this.支付时间DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.支付时间DataGridViewTextBoxColumn.Name = "支付时间DataGridViewTextBoxColumn";
            this.支付时间DataGridViewTextBoxColumn.ReadOnly = true;
            this.支付时间DataGridViewTextBoxColumn.Width = 150;
            // 
            // 结账状态DataGridViewTextBoxColumn
            // 
            this.结账状态DataGridViewTextBoxColumn.DataPropertyName = "结账状态";
            this.结账状态DataGridViewTextBoxColumn.HeaderText = "结账状态";
            this.结账状态DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.结账状态DataGridViewTextBoxColumn.Name = "结账状态DataGridViewTextBoxColumn";
            this.结账状态DataGridViewTextBoxColumn.ReadOnly = true;
            this.结账状态DataGridViewTextBoxColumn.Width = 150;
            // 
            // 结帐表BindingSource
            // 
            this.结帐表BindingSource.DataMember = "结帐表";
            this.结帐表BindingSource.DataSource = this.cashierDataSet6;
            // 
            // cashierDataSet6
            // 
            this.cashierDataSet6.DataSetName = "CashierDataSet6";
            this.cashierDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button11);
            this.panel8.Controls.Add(this.button8);
            this.panel8.Controls.Add(this.button6);
            this.panel8.Controls.Add(this.button5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 1062);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1383, 202);
            this.panel8.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Highlight;
            this.button11.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(1088, 40);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(200, 113);
            this.button11.TabIndex = 2;
            this.button11.Text = "返回登录";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Highlight;
            this.button8.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(807, 40);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 113);
            this.button8.TabIndex = 2;
            this.button8.Text = "重印小票";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(458, 40);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 113);
            this.button6.TabIndex = 2;
            this.button6.Text = "在线结账";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(32, 40);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 113);
            this.button5.TabIndex = 2;
            this.button5.Text = "现金结账";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button10);
            this.panel7.Controls.Add(this.button9);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.tet流水编号);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1383, 100);
            this.panel7.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Highlight;
            this.button10.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(938, 6);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(165, 82);
            this.button10.TabIndex = 2;
            this.button10.Text = "删除";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Highlight;
            this.button9.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(742, 6);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(165, 84);
            this.button9.TabIndex = 2;
            this.button9.Text = "刷新";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(550, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 88);
            this.button4.TabIndex = 2;
            this.button4.Text = "搜索";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 19F);
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "流水单号：";
            // 
            // tet流水编号
            // 
            this.tet流水编号.Font = new System.Drawing.Font("宋体", 19F);
            this.tet流水编号.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tet流水编号.Location = new System.Drawing.Point(211, 26);
            this.tet流水编号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tet流水编号.Multiline = true;
            this.tet流水编号.Name = "tet流水编号";
            this.tet流水编号.Size = new System.Drawing.Size(307, 45);
            this.tet流水编号.TabIndex = 1;
            this.tet流水编号.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tet流水编号_KeyPress);
            // 
            // 结帐表TableAdapter
            // 
            this.结帐表TableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "54b245d20cf64b214fdf9da4843674e2.jpeg");
            this.imageList1.Images.SetKeyName(1, "306f3f191956ec23e776c90411e969e2.jpeg");
            this.imageList1.Images.SetKeyName(2, "692e85cc6973f6ffc704f3881f885aea.jpeg");
            this.imageList1.Images.SetKeyName(3, "156316673029c15443adc122fe9e1f69.jpg");
            this.imageList1.Images.SetKeyName(4, "b16b3c85212c1fa7c6c3fa42a4062872.jpeg");
            this.imageList1.Images.SetKeyName(5, "b24c94c379ece77ff87463015a1712ed.jpeg");
            this.imageList1.Images.SetKeyName(6, "b99cbada3e380db00aa0025a36c1ea16.jpeg");
            this.imageList1.Images.SetKeyName(7, "f3ca39d6c52773faefdfbfb30522550d.jpeg");
            this.imageList1.Images.SetKeyName(8, "f26bd7d90072516f150eb4e2edcccf9a.jpg");
            // 
            // AddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2142, 1264);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddGoods";
            this.Text = "AddGoods";
            this.Load += new System.EventHandler(this.AddGoods_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.结帐表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet6)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button but搜索;
        private System.Windows.Forms.TextBox tet商品编号;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tet流水编号;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lab总计;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button 删除;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab数量;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private CashierDataSet6 cashierDataSet6;
        private System.Windows.Forms.BindingSource 结帐表BindingSource;
        private CashierDataSet6TableAdapters.结帐表TableAdapter 结帐表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账单编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 支付方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户实付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 找零DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品购买数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 支付时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结账状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList imageList1;
    }
}