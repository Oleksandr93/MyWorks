using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UTOS
{
    public partial class FormOrganizations : UtosForm
    {
        public FormOrganizations()
        {
            InitializeComponent();
            canAdd = true;
        }

        public override void RefreshData(long? stay_on_id = null, string sql_where = null)
        {
            try
            {
                dgOrganizations.Enabled = false;
                dgOrganizations.AutoGenerateColumns = false;
                string sql = "SELECT * FROM organizations";
                MySqlCommand cmd = new MySqlCommand(sql, m_connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dgOrganizations.DataSource = dt;

                if (stay_on_id != null)
                    foreach (DataGridViewRow row in dgOrganizations.Rows)
                    {
                        object cell_id = row.Cells[0].Value;
                        if (cell_id is long && Convert.ToInt64(cell_id) == stay_on_id)
                        {
                            dgOrganizations.CurrentCell = row.Cells[1];
                            break;
                        }
                    }

                dgOrganizations.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dlgUpdateControls != null)
                dlgUpdateControls();
        }

        public override void AddData()
        {
            FormEditOrganizatation frm = new FormEditOrganizatation();

            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                string sql = @"INSERT INTO organizations (name, chief_name, secretary_name, staff) 
                               VALUES (@name, @chief_name, @secretary_name, @staff)";
                MySqlCommand cmd = new MySqlCommand(sql, m_connection);
                cmd.Parameters.AddWithValue("@name", frm.orgName);
                cmd.Parameters.AddWithValue("@chief_name", frm.orgChiefName);
                cmd.Parameters.AddWithValue("@secretary_name", frm.orgSecretaryName);
                cmd.Parameters.AddWithValue("@staff", frm.orgStaff);

                int rows_affected = cmd.ExecuteNonQuery();
                RefreshData(cmd.LastInsertedId);
            }
        }

        public override void EditData()
        {
            DataGridViewRow row = dgOrganizations.CurrentRow;
            long id = Convert.ToInt64(row.Cells["id"].Value);
            FormEditOrganizatation frm = new FormEditOrganizatation();

            try
            {
                string sql_select = @"SELECT * FROM organizations WHERE id=@id";
                MySqlCommand cmd_select = new MySqlCommand(sql_select, m_connection);
                cmd_select.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd_select.ExecuteReader();
                if (rdr.Read())
                {
                    // load values into the form
                    frm.orgName = rdr["name"].ToString();
                    frm.orgChiefName = rdr["chief_name"].ToString();
                    frm.orgSecretaryName = rdr["secretary_name"].ToString();
                    frm.orgStaff = rdr["staff"] is DBNull ? null : Encoding.UTF8.GetString(rdr["staff"] as byte[]);

                    rdr.Close();

                    DialogResult res = frm.ShowDialog();
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        string sql_update = @"UPDATE organizations SET
                         name=@name, chief_name=@chief_name, secretary_name=@secretary_name, staff=@staff WHERE id=@id";
                        MySqlCommand cmd_update = new MySqlCommand(sql_update, m_connection);
                        cmd_update.Parameters.AddWithValue("@id", id);
                        // add values from the form
                        cmd_update.Parameters.AddWithValue("@name", frm.orgName);
                        cmd_update.Parameters.AddWithValue("@chief_name", frm.orgChiefName);
                        cmd_update.Parameters.AddWithValue("@secretary_name", frm.orgSecretaryName);
                        cmd_update.Parameters.AddWithValue("@staff", frm.orgStaff);

                        int rows_affected = cmd_update.ExecuteNonQuery();
                        RefreshData(id);
                    }
                }
                else
                    MessageBox.Show(String.Format("There is no organization with id={0}!", id), "Error");

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            frm.Close();
        }

        public override void DeleteData()
        {
            DataGridViewRow row = dgOrganizations.CurrentRow;
            DialogResult res = MessageBox.Show(string.Format("Видалити організацію {0}?", row.Cells["name"].Value),
                "Видалення первинної організації", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM organizations WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, m_connection);
                    cmd.Parameters.AddWithValue("@id", row.Cells["id"].Value);
                    int rows = cmd.ExecuteNonQuery();
                    RefreshData();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormOrganizations_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void FormOrganizations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }

        private void dgOrganizations_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            canEdit = true;
            canDelete = true;
        }

        private void dgOrganizations_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            canEdit = false;
            canDelete = false;
        }

    }
}
