namespace CodeAutoBuild
{
    partial class AutoBuildForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtConnectSql = new TextBox();
            label1 = new Label();
            btnTestSql = new Button();
            comServerTable = new ComboBox();
            label2 = new Label();
            gridColumn = new DataGridView();
            label3 = new Label();
            btnBuild = new Button();
            comServerType = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridColumn).BeginInit();
            SuspendLayout();
            // 
            // txtConnectSql
            // 
            txtConnectSql.Location = new Point(122, 27);
            txtConnectSql.Name = "txtConnectSql";
            txtConnectSql.Size = new Size(380, 23);
            txtConnectSql.TabIndex = 2;
            txtConnectSql.Text = "Data Source=DESKTOP-LJ93NP5\\SQLEXPRESS;Initial Catalog=TestDb;User ID=sa;Password=sa;TrustServerCertificate=true";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 1;
            label1.Text = "数据库连接字符串";
            // 
            // btnTestSql
            // 
            btnTestSql.Location = new Point(508, 27);
            btnTestSql.Name = "btnTestSql";
            btnTestSql.Size = new Size(75, 23);
            btnTestSql.TabIndex = 3;
            btnTestSql.Text = "连接";
            btnTestSql.UseVisualStyleBackColor = true;
            btnTestSql.Click += btnTestSql_Click;
            // 
            // comServerTable
            // 
            comServerTable.FormattingEnabled = true;
            comServerTable.Location = new Point(122, 49);
            comServerTable.Name = "comServerTable";
            comServerTable.Size = new Size(121, 25);
            comServerTable.TabIndex = 4;
            comServerTable.SelectedIndexChanged += comServerTable_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 53);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 4;
            label2.Text = "数据表";
            // 
            // gridColumn
            // 
            gridColumn.AllowUserToAddRows = false;
            gridColumn.AllowUserToDeleteRows = false;
            gridColumn.AllowUserToResizeRows = false;
            gridColumn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridColumn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridColumn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridColumn.Location = new Point(122, 73);
            gridColumn.MultiSelect = false;
            gridColumn.Name = "gridColumn";
            gridColumn.RowTemplate.Height = 25;
            gridColumn.Size = new Size(461, 229);
            gridColumn.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 73);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 6;
            label3.Text = "字段";
            // 
            // btnBuild
            // 
            btnBuild.Location = new Point(122, 308);
            btnBuild.Name = "btnBuild";
            btnBuild.Size = new Size(75, 23);
            btnBuild.TabIndex = 6;
            btnBuild.Text = "生成";
            btnBuild.UseVisualStyleBackColor = true;
            // 
            // comServerType
            // 
            comServerType.FormattingEnabled = true;
            comServerType.Location = new Point(122, 3);
            comServerType.Name = "comServerType";
            comServerType.Size = new Size(121, 25);
            comServerType.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 6);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 1;
            label4.Text = "数据库类型";
            // 
            // AutoBuildForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 343);
            Controls.Add(label4);
            Controls.Add(comServerType);
            Controls.Add(btnBuild);
            Controls.Add(label3);
            Controls.Add(gridColumn);
            Controls.Add(label2);
            Controls.Add(comServerTable);
            Controls.Add(btnTestSql);
            Controls.Add(label1);
            Controls.Add(txtConnectSql);
            Name = "AutoBuildForm";
            ((System.ComponentModel.ISupportInitialize)gridColumn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConnectSql;
        private Label label1;
        private Button btnTestSql;
        private ComboBox comServerTable;
        private Label label2;
        private DataGridView gridColumn;
        private Label label3;
        private Button btnBuild;
        private ComboBox comServerType;
        private Label label4;
    }
}