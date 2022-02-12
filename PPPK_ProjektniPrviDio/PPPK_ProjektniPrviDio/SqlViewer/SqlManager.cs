using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadatak.Dal;
using Zadatak.Models;
using Zadatak0102.Dal;

namespace Zadatak0102
{
    public partial class SqlManager : Form
    {

        public SqlManager()
        {
            InitializeComponent();
            LoadDatabases();
        }


        private void LoadDatabases() => CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());

        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            LbTables.DataSource = (CbDatabases.SelectedItem as Database).Tables;

        }

        private void Clear() => LbTableColums.DataSource = null;

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            ClearData();

            string[] list = tbCommandLine.Text.Trim().ToLower().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder messages = new StringBuilder();
            foreach (string command in list)
            {

                if (SqlParser.IsSQLQueryValid(command.Trim(), out List<String> errors, out TSqlTokenType keyword))
                {
                    try
                    {
                        if (keyword.Equals(TSqlTokenType.Select))
                        {
                            DataSet ds = RepositoryFactory.GetRepository().ExecuteSelectQuery((CbDatabases.SelectedItem as Database).Name, command);
                            AddTable(ds.Tables[0]);
                        }
                        else
                        {
                            int rowsAffected = RepositoryFactory.GetRepository().ExecuteCommand((CbDatabases.SelectedItem as Database).Name, command);
                            if (rowsAffected != -1)
                            {
                                messages.Append(rowsAffected + " rows affected." + Environment.NewLine);
                            }
                            else
                            {
                                messages.Append("Command executed successfully." + Environment.NewLine);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        messages.Append(ex.Message);
                    }

                }
                else
                {
                    errors.ForEach(ee => messages.Append(ee + Environment.NewLine));
                }
            }

            tbInfoMessage.Text = messages.ToString();
        }

        private void AddTable(DataTable dataTable)
        {
            DataGridView dataGridView = new DataGridView
            {
                Width = Convert.ToInt32(flpData.Width * 0.98),
                ReadOnly = true
            };
            flpData.Controls.Add(dataGridView);
            dataGridView.DataSource = dataTable;
        }

        private void LbTables_SelectedIndexChanged(object sender, EventArgs e) => LbTableColums.DataSource = (LbTables.SelectedItem as DBEntity).Columns;

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearData();
            tbCommandLine.Clear();
            tbCommandLine.Focus();
        }



        private void ClearData()
        {
            tbInfoMessage.Clear();
            flpData.Controls.Clear();

        }

        private void SqlManager_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        void LbTables_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.LbTables.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                try
                {
                    DataSet ds = RepositoryFactory.GetRepository().ExecuteSelectQuery((CbDatabases.SelectedItem as Database).Name, "select * from " + LbTables.SelectedItem);
                    AddTable(ds.Tables[0]);
                }
                catch (Exception er)
                {
                    tbInfoMessage.Text = er.Message;
                }

            }
        }

    }

}
