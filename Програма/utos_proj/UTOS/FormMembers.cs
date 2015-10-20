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
    public partial class FormMembers : UtosForm
    {

        public FormMembers()
        {
            InitializeComponent();
            canAdd = true;
            canSearch = true;
            canExport = true;
        }


        public override void RefreshData(long? stay_on_id = null, string sql_where = null)
        {
            try
            {
                dgMembers.Enabled = false;
                dgMembers.AutoGenerateColumns = false;
                string sql = @"SELECT *, CONCAT_WS(' ', lname, fname, mname) as full_name,
                               CONCAT_WS(': ', name, chief_name) as org_name  
                               FROM members m LEFT JOIN organizations o on m.id_org = o.id";
                if (sql_where != null)
                    sql += " WHERE " + sql_where;

                MySqlCommand cmd = new MySqlCommand(sql, m_connection);
                //MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                //dt.Load(rdr);
                dgMembers.DataSource = dt;

                if (stay_on_id != null)
                    foreach (DataGridViewRow row in dgMembers.Rows)
                    {
                        object cell_id = row.Cells[0].Value;
                        if (cell_id is long && Convert.ToInt64(cell_id) == stay_on_id)
                        {
                            dgMembers.CurrentCell = row.Cells[1];
                            break;
                        }
                    }

                dgMembers.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dlgUpdateControls != null)
                dlgUpdateControls();
        }

        private DateTime ConvertDBObjToDateTime(object obj)
        {
            return (obj is DBNull) ? new DateTime(1900, 1, 1) : Convert.ToDateTime(obj);
        }
        private long? ConvertDBObjToLong(object obj)
        {
            if (obj is DBNull)
                return null;
            else
                return Convert.ToInt64(obj);
        }
        private double? ConvertDBObjToDouble(object obj)
        {
            if (obj is DBNull)
                return null;
            else
                return Convert.ToDouble(obj);
        }
        private string ConvertDBBlobToString(object obj)
        {
            if (obj is DBNull)
                return null;
            else
                return Encoding.UTF8.GetString(obj as byte[]);
        }

        private void AddFormEditMemberSQLParams(MySqlCommand cmd, FormEditMember frm)
        {
            cmd.Parameters.AddWithValue("@ticket_number", frm.fld_ticket_number);
            cmd.Parameters.AddWithValue("@fname", frm.fld_fname);
            cmd.Parameters.AddWithValue("@lname", frm.fld_lname);
            cmd.Parameters.AddWithValue("@mname", frm.fld_mname);
            cmd.Parameters.AddWithValue("@reg_date", frm.fld_reg_date);
            cmd.Parameters.AddWithValue("@nationality", frm.fld_nationality);
            cmd.Parameters.AddWithValue("@birth_date", frm.fld_birth_date);
            cmd.Parameters.AddWithValue("@address", frm.fld_address);
            cmd.Parameters.AddWithValue("@phone", frm.fld_phone);
            cmd.Parameters.AddWithValue("@sign_date", frm.fld_sign_date);
            cmd.Parameters.AddWithValue("@foto", frm.fld_foto);
            cmd.Parameters.AddWithValue("@id_org", frm.fld_id_org);
            cmd.Parameters.AddWithValue("@passport_sn", frm.fld_passport_sn);
            cmd.Parameters.AddWithValue("@passport_number", frm.fld_passport_number);
            cmd.Parameters.AddWithValue("@passport_issuer", frm.fld_passport_issuer);
            cmd.Parameters.AddWithValue("@passport_date", frm.fld_passport_date);
            cmd.Parameters.AddWithValue("@pension_card_number", frm.fld_pension_card_number);
            cmd.Parameters.AddWithValue("@pension_card_date", frm.fld_pension_card_date);
            cmd.Parameters.AddWithValue("@disability_group", frm.fld_disability_group);
            cmd.Parameters.AddWithValue("@disability_cause", frm.fld_disability_cause);
            cmd.Parameters.AddWithValue("@point_system", frm.fld_point_system);
            cmd.Parameters.AddWithValue("@welfare", frm.fld_welfare);
            cmd.Parameters.AddWithValue("@martial_status", frm.fld_martial_status);
            cmd.Parameters.AddWithValue("@education", frm.fld_education);
            cmd.Parameters.AddWithValue("@speciality", frm.fld_speciality);
            cmd.Parameters.AddWithValue("@employer", frm.fld_employer);
            cmd.Parameters.AddWithValue("@position", frm.fld_position);
            cmd.Parameters.AddWithValue("@employer_last", frm.fld_employer_last);
            cmd.Parameters.AddWithValue("@position_last", frm.fld_position_last);
            cmd.Parameters.AddWithValue("@social_impact", frm.fld_social_impact);
            cmd.Parameters.AddWithValue("@affiliation_fee", frm.fld_affiliation_fee);
            cmd.Parameters.AddWithValue("@affiliation_date", frm.fld_affiliation_date);
            cmd.Parameters.AddWithValue("@idcode", frm.fld_idcode);
            cmd.Parameters.AddWithValue("@extra_injury", frm.fld_extra_injury);
            cmd.Parameters.AddWithValue("@family_members", frm.fld_family_members);
            cmd.Parameters.AddWithValue("@org_relations", frm.fld_org_relations);
            cmd.Parameters.AddWithValue("@payments", frm.fld_payments);
            cmd.Parameters.AddWithValue("@welfare_assistance", frm.fld_welfare_assistance);
        }

        private void LoadFormEditMemberFromSQL(FormEditMember frm, MySqlDataReader rdr)
        {
            frm.fld_ticket_number = rdr["ticket_number"].ToString();
            frm.fld_fname = rdr["fname"].ToString();
            frm.fld_lname = rdr["lname"].ToString();
            frm.fld_mname = rdr["mname"].ToString();
            frm.fld_nationality = rdr["nationality"].ToString();
            frm.fld_reg_date = ConvertDBObjToDateTime(rdr["reg_date"]);
            frm.fld_sign_date = ConvertDBObjToDateTime(rdr["sign_date"]);
            frm.fld_birth_date = ConvertDBObjToDateTime(rdr["birth_date"]);
            frm.fld_address = rdr["address"].ToString();
            frm.fld_phone = rdr["phone"].ToString();
            frm.fld_foto = rdr["foto"] as byte[];
            frm.fld_id_org = ConvertDBObjToLong(rdr["id_org"]);
            frm.fld_passport_sn = rdr["passport_sn"].ToString();
            frm.fld_passport_number = rdr["passport_number"].ToString();
            frm.fld_passport_issuer = rdr["passport_issuer"].ToString();
            frm.fld_passport_date = ConvertDBObjToDateTime(rdr["passport_date"]);
            frm.fld_pension_card_number = rdr["pension_card_number"].ToString();
            frm.fld_pension_card_date = ConvertDBObjToDateTime(rdr["pension_card_date"]);
            frm.fld_disability_group = rdr["disability_group"].ToString();
            frm.fld_disability_cause = rdr["disability_cause"].ToString();
            frm.fld_point_system = rdr["point_system"].ToString();
            frm.fld_welfare = ConvertDBObjToDouble(rdr["welfare"]);
            frm.fld_martial_status = rdr["martial_status"].ToString();
            frm.fld_education = rdr["education"].ToString();
            frm.fld_speciality = rdr["speciality"].ToString();
            frm.fld_employer = rdr["employer"].ToString();
            frm.fld_position = rdr["position"].ToString();
            frm.fld_employer_last = rdr["employer_last"].ToString();
            frm.fld_position_last = rdr["position_last"].ToString();
            frm.fld_social_impact = rdr["social_impact"].ToString();
            frm.fld_affiliation_fee = ConvertDBObjToDouble(rdr["affiliation_fee"]);
            frm.fld_affiliation_date = ConvertDBObjToDateTime(rdr["affiliation_date"]);
            frm.fld_idcode = rdr["idcode"].ToString();
            frm.fld_extra_injury = rdr["extra_injury"].ToString();
            frm.fld_family_members = ConvertDBBlobToString(rdr["family_members"]);
            frm.fld_org_relations = ConvertDBBlobToString(rdr["org_relations"]);
            frm.fld_payments = ConvertDBBlobToString(rdr["payments"]);
            frm.fld_welfare_assistance = ConvertDBBlobToString(rdr["welfare_assistance"]);
        }

        public override void AddData() 
        {
            FormEditMember frm = new FormEditMember(m_connection);
            frm.LoadOrganizations();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    string sql = @"INSERT INTO members 
                        (ticket_number, fname, lname, mname, reg_date, nationality, birth_date, address, phone, 
                         sign_date, foto, id_org, passport_sn, passport_number, passport_issuer, passport_date, 
                         pension_card_number, pension_card_date, disability_group, disability_cause, point_system, welfare,
                         martial_status, education, speciality, employer, position, employer_last, position_last, 
                         social_impact, affiliation_fee, affiliation_date, idcode, extra_injury, 
                         family_members, org_relations, payments, welfare_assistance) 
                        VALUES (@ticket_number, @fname, @lname, @mname, @reg_date, @nationality, @birth_date, @address, @phone, 
                                @sign_date, @foto, @id_org, @passport_sn, @passport_number, @passport_issuer, @passport_date, 
                                @pension_card_number, @pension_card_date, @disability_group, @disability_cause, @point_system, @welfare,
                                @martial_status, @education, @speciality, @employer, @position, @employer_last, @position_last, 
                                @social_impact, @affiliation_fee, @affiliation_date, @idcode, @extra_injury, 
                                @family_members, @org_relations, @payments, @welfare_assistance)";
                    MySqlCommand cmd = new MySqlCommand(sql, m_connection);
                    AddFormEditMemberSQLParams(cmd, frm);
                    int rows_affected = cmd.ExecuteNonQuery();
                    RefreshData(cmd.LastInsertedId);
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            frm.Close();
        }

        public override void EditData() 
        {
            DataGridViewRow row = dgMembers.CurrentRow;
            long id = Convert.ToInt64(row.Cells["id"].Value);

            FormEditMember frm = new FormEditMember(m_connection);
            frm.LoadOrganizations();

            try
            {
                string sql_select = @"SELECT * FROM members WHERE id=@id";
                MySqlCommand cmd_select = new MySqlCommand(sql_select, m_connection);
                cmd_select.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd_select.ExecuteReader();
                if (rdr.Read())
                {
                    LoadFormEditMemberFromSQL(frm, rdr);
                    rdr.Close();

                    DialogResult res = frm.ShowDialog();
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        string sql_update = @"UPDATE members SET
                         ticket_number=@ticket_number, fname=@fname, lname=@lname, mname=@mname, reg_date=@reg_date,
                         nationality=@nationality, birth_date=@birth_date, address=@address, phone=@phone, sign_date=@sign_date,
                         foto=@foto, id_org=@id_org, passport_sn=@passport_sn, passport_number=@passport_number, 
                         passport_issuer=@passport_issuer, passport_date=@passport_date, pension_card_number=@pension_card_number,
                         pension_card_date=@pension_card_date, disability_group=@disability_group, disability_cause=@disability_cause,
                         point_system=@point_system, welfare=@welfare, martial_status=@martial_status, education=@education, 
                         speciality=@speciality, employer=@employer, position=@position, employer_last=@employer_last, 
                         position_last=@position_last, social_impact=@social_impact, affiliation_fee=@affiliation_fee, 
                         affiliation_date=@affiliation_date, idcode=@idcode, extra_injury=@extra_injury, 
                         family_members=@family_members, org_relations=@org_relations, payments=@payments, 
                         welfare_assistance=@welfare_assistance
                        WHERE id=@id";
                        MySqlCommand cmd_update = new MySqlCommand(sql_update, m_connection);
                        cmd_update.Parameters.AddWithValue("@id", id);
                        AddFormEditMemberSQLParams(cmd_update, frm);
                        int rows_affected = cmd_update.ExecuteNonQuery();
                        RefreshData(id);
                    }
                }
                else
                    MessageBox.Show(String.Format("There is no member data with id={0}!", id), "Error");

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            frm.Close();

        }

        public override void DeleteData() 
        {
            DataGridViewRow row = dgMembers.CurrentRow;
            long id = Convert.ToInt64(row.Cells["id"].Value);

            DialogResult res = MessageBox.Show(string.Format("Видалити картку {0}?", row.Cells["full_name"].Value),
                "Видалення картки члена УТОС", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM members WHERE id=@id";
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

        public override void Search()
        {
            FormSearch frm = new FormSearch();
            DialogResult res = frm.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                this.RefreshData(null, frm.sql_where);
            }
            frm.Close();
        }

        private void FormMembers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }

        private void FormMembers_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void dgMembers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            canEdit = true;
            canDelete = true;
        }

        private void dgMembers_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            canEdit = false;
            canDelete = false;
        }
    }
}
