using CodeAutoBuild.Emun;
using CodeAutoBuild.Helper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CodeAutoBuild
{
    public partial class AutoBuildForm : Form
    {
        public AutoBuildForm()
        {
            InitializeComponent();
            SetComboData();
        }

        private void SetComboData()
        {
            var ServerType = Tools.GetEmunList(typeof(SqlType));
            comServerType.DataSource = ServerType;
            comServerType.ValueMember = nameof(ComboData.Key);
            comServerType.DisplayMember = nameof(ComboData.Value);
        }

        private void btnTestSql_Click(object sender, EventArgs e)
        {
            try
            {
                SqlType serverType = (SqlType)Convert.ToInt32(comServerType.SelectedValue);
                string sqlConnection = txtConnectSql.Text;

                switch (serverType)
                {
                    case SqlType.SqlServer:
                        {
                            SqlConnection connection = new SqlConnection(sqlConnection);
                            SqlCommand cmd = new SqlCommand("SELECT NAME FROM SYS.TABLES", connection);
                            connection.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                            List<ComboData> tableList = new List<ComboData>();
                            while (dr.Read())
                            {
                                tableList.Add(new ComboData()
                                {
                                    Key = dr[0].ToString(),
                                    Value = dr[0].ToString()
                                });
                            }
                            connection.Close();

                            comServerTable.DataSource = tableList;
                            comServerTable.ValueMember = nameof(ComboData.Value);
                            comServerTable.DisplayMember = nameof(ComboData.Key);
                            MessageBox.Show("连接成功", "成功", MessageBoxButtons.OK);
                        }
                        break;
                    default:
                        MessageBox.Show("尚未开放当前数据库的代码生成功能", "错误", MessageBoxButtons.OK);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接字符串错误，请确认后再连接", "错误", MessageBoxButtons.OK);
            }
        }

        private void comServerTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlType serverType = (SqlType)Convert.ToInt32(comServerType.SelectedValue);
                string tableName = comServerTable.SelectedValue.ToString();
                string sqlConnection = txtConnectSql.Text;

                switch (serverType)
                {
                    case SqlType.SqlServer:
                        {
                            SqlConnection connection = new SqlConnection(sqlConnection);
                            SqlCommand cmd = new SqlCommand("SELECT COLUMN_NAME,DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TableName", connection);
                            SqlParameter parameter = new SqlParameter("@TableName", tableName);
                            cmd.Parameters.Add(parameter);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("checked", typeof(bool));
                            connection.Open();
                            adapter.Fill(dataTable);
                            connection.Close();
                            gridColumn.DataSource = dataTable;
                            gridColumn.Columns["checked"].HeaderText = "选择";
                            gridColumn.Columns["COLUMN_NAME"].HeaderText = "列名";
                            gridColumn.Columns["DATA_TYPE"].HeaderText = "列属性";

                            gridColumn.Columns["COLUMN_NAME"].ReadOnly = true;
                            gridColumn.Columns["DATA_TYPE"].ReadOnly = true;
                        }
                        break;
                    default:
                        MessageBox.Show("尚未开放当前数据库的代码生成功能", "错误", MessageBoxButtons.OK);
                        break;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}