using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UTOS
{
    public partial class FormEditMember : Form
    {
        // form members
        protected MySql.Data.MySqlClient.MySqlConnection m_connection = null;

        // form constructor
        public FormEditMember(MySql.Data.MySqlClient.MySqlConnection connection)
        {
            InitializeComponent();
            m_connection = connection;

            BindFamilyMembers();
            BindOrgRelations();
            BindPayments();
            BindWelfareAssistance();
        }

        // some internal classes
        private class ComboItem
        {
            public string Text {get; set;}
            public long Value {get; set;}
            public ComboItem(string text, long value)
            {
                Text = text;
                Value = value;
            }
            public ComboItem(object text, object value)
            {
                Text = text as string;
                Value = Convert.ToInt64(value);
            }
            public override string ToString()
            {
                return Text;
            }
        }
        

        // data fields as properties
        public string fld_ticket_number
        {
            get { return tbTicketNumber.Text.Trim();}
            set { tbTicketNumber.Text = value.Trim(); }
        }
        public string fld_org_name
        {
            get { return cbOrgName.SelectedText as string; }
        }
        public long? fld_id_org
        {
            get { return Convert.ToInt64(cbOrgName.SelectedValue); }
            set 
            {
                cbOrgName.SelectedIndex = -1;
                for (int i = 0; i < cbOrgName.Items.Count; i++)
                {
                    ComboItem item = cbOrgName.Items[i] as ComboItem;
                    if (item.Value == value)
                    {
                        cbOrgName.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
        public string fld_lname
        {
            get { return tbLName.Text.Trim(); }
            set { tbLName.Text = value.Trim(); }
        }
        public string fld_fname
        {
            get { return tbFName.Text.Trim(); }
            set { tbFName.Text = value.Trim(); }
        }
        public string fld_mname
        {
            get { return tbMName.Text.Trim(); }
            set { tbMName.Text = value.Trim(); }
        }
        public string fld_nationality
        {
            get { return tbNatinality.Text.Trim(); }
            set { tbNatinality.Text = value.Trim(); }
        }
        public string fld_address
        {
            get { return tbAddress.Text.Trim(); }
            set { tbAddress.Text = value.Trim(); }
        }
        public string fld_phone
        {
            get { return tbPhone.Text.Trim(); }
            set { tbPhone.Text = value.Trim(); }
        }
        public DateTime fld_birth_date
        {
            get { return dtBirthDate.Value; }
            set { dtBirthDate.Value = value; }
        }
        public DateTime fld_reg_date
        {
            get { return dtRegDate.Value; }
            set { dtRegDate.Value = value; }
        }
        public DateTime fld_sign_date
        {
            get { return dtSignDate.Value; }
            set { dtSignDate.Value = value; }
        }
        public byte[] fld_foto
        {
            get
            {
                if (picFoto.Image != null)
                {
                    var ms = new MemoryStream();
                    picFoto.Image.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
                else
                    return null;
            }
            set
            {
                if (value == null)
                    picFoto.Image = null;
                else
                {
                    var ms = new MemoryStream(value);
                    picFoto.Image = Image.FromStream(ms);
                }
            }
        }
        public string fld_passport_sn
        {
            get { return tbPassportSN.Text.Trim(); }
            set { tbPassportSN.Text = value.Trim(); }
        }
        public string fld_passport_number
        {
            get { return tbPassportNumber.Text.Trim(); }
            set { tbPassportNumber.Text = value.Trim(); }
        }
        public string fld_passport_issuer
        {
            get { return tbPassportIssuer.Text.Trim(); }
            set { tbPassportIssuer.Text = value.Trim(); }
        }
        public DateTime fld_passport_date
        {
            get { return dtPassportDate.Value; }
            set { dtPassportDate.Value = value; }
        }
        public string fld_pension_card_number
        {
            get { return tbPensionCardNumber.Text.Trim(); }
            set { tbPensionCardNumber.Text = value.Trim(); }
        }
        public DateTime fld_pension_card_date
        {
            get { return dtPensionCardDate.Value; }
            set { dtPensionCardDate.Value = value; }
        }
        public string fld_disability_group
        {
            get { return tbDisabilityGroup.Text.Trim(); }
            set { tbDisabilityGroup.Text = value.Trim(); }
        }
        public string fld_disability_cause
        {
            get { return cbDisabilityCause.Text.Trim(); }
            set { cbDisabilityCause.Text = value.Trim(); }
        }
        public string fld_point_system
        {
            get { return cbPointSystem.Text.Trim(); }
            set { cbPointSystem.Text = value.Trim(); }
        }
        public double? fld_welfare
        {
            get { return (double?)tbWelfare.Value; }
            set { tbWelfare.Value = value != null ? (decimal)value : 0; }
        }
        public string fld_martial_status
        {
            get { return cbMartialStatus.Text.Trim(); }
            set { cbMartialStatus.Text = value.Trim(); }
        }
        public string fld_education
        {
            get { return tbEducation.Text.Trim(); }
            set { tbEducation.Text = value.Trim(); }
        }
        public string fld_speciality
        {
            get { return tbSpeciality.Text.Trim(); }
            set { tbSpeciality.Text = value.Trim(); }
        }
        public string fld_employer
        {
            get { return tbEmployer.Text.Trim(); }
            set { tbEmployer.Text = value.Trim(); }
        }
        public string fld_position
        {
            get { return tbPosition.Text.Trim(); }
            set { tbPosition.Text = value.Trim(); }
        }
        public string fld_employer_last
        {
            get { return tbEmployerLast.Text.Trim(); }
            set { tbEmployerLast.Text = value.Trim(); }
        }
        public string fld_position_last
        {
            get { return tbPositionLast.Text.Trim(); }
            set { tbPositionLast.Text = value.Trim(); }
        }
        public string fld_social_impact
        {
            get { return tbSocialImpact.Text.Trim(); }
            set { tbSocialImpact.Text = value.Trim(); }
        }
        public double? fld_affiliation_fee
        {
            get { return (double?)tbAffiliationFee.Value; }
            set { tbAffiliationFee.Value = value != null ? (decimal)value : 0; }
        }
        public DateTime fld_affiliation_date
        {
            get { return dtAffiliationDate.Value; }
            set { dtAffiliationDate.Value = value; }
        }
        public string fld_idcode
        {
            get { return tbIdCode.Text.Trim(); }
            set { tbIdCode.Text = value.Trim(); }
        }
        public string fld_extra_injury
        {
            get { return tbExtraInjury.Text.Trim(); }
            set { tbExtraInjury.Text = value.Trim(); }
        }
        public string fld_family_members
        {
            get
            {
                StringBuilder res = new StringBuilder();
                foreach (FamilyMember item in dgFamily.DataSource as BindingSource)
                {
                    res.Append(item.Serialize());
                    res.Append("|");
                }
                return res.ToString();
            }
            set
            {
                BindingSource src = dgFamily.DataSource as BindingSource;
                src.Clear();
                if (value == null || value.Trim() == "")
                    return;
                string[] srows = value.Split('|');
                foreach (string srow in srows)
                {
                    if (srow.Trim() == "")
                        continue;
                    FamilyMember item = new FamilyMember();
                    item.Deserialize(srow);
                    src.Add(item);
                }
            }
        }
        public string fld_org_relations
        {
            get
            {
                StringBuilder res = new StringBuilder();
                foreach (OrgRecord item in dgOrgRelation.DataSource as BindingSource)
                {
                    res.Append(item.Serialize());
                    res.Append("|");
                }
                return res.ToString();
            }
            set
            {
                BindingSource src = dgOrgRelation.DataSource as BindingSource;
                src.Clear();
                if (value == null || value.Trim() == "")
                    return;
                string[] srows = value.Split('|');
                foreach (string srow in srows)
                {
                    if (srow.Trim() == "")
                        continue;
                    OrgRecord item = new OrgRecord();
                    item.Deserialize(srow);
                    
                    //add org to combo list if it doesn't exist
                    List<ComboItem> src_combo_orgs = org_name.DataSource as List<ComboItem>;
                    bool found = false;
                    foreach (ComboItem org_item in src_combo_orgs)
                        if (org_item.Text == item.org_name)
                        {
                            found = true;
                            break;
                        }
                    if (!found)
                        src_combo_orgs.Add(new ComboItem(item.org_name, -1));

                    src.Add(item);
                }
            }
        }
        public string fld_payments
        {
            get
            {
                StringBuilder res = new StringBuilder();
                foreach (Payment item in dgPayments.DataSource as BindingSource)
                {
                    res.Append(item.Serialize());
                    res.Append("|");
                }
                return res.ToString();
            }
            set
            {
                BindingSource src = dgPayments.DataSource as BindingSource;
                src.Clear();
                if (value == null || value.Trim() == "")
                    return;
                string[] srows = value.Split('|');
                foreach (string srow in srows)
                {
                    if (srow.Trim() == "")
                        continue;
                    Payment item = new Payment();
                    item.Deserialize(srow);
                    src.Add(item);
                }
            }
        }
        public string fld_welfare_assistance
        {
            get
            {
                StringBuilder res = new StringBuilder();
                foreach (WelfareItem item in dgWelfareAssistance.DataSource as BindingSource)
                {
                    res.Append(item.Serialize());
                    res.Append("|");
                }
                return res.ToString();
            }
            set
            {
                BindingSource src = dgWelfareAssistance.DataSource as BindingSource;
                src.Clear();
                if (value == null || value.Trim() == "")
                    return;
                string[] srows = value.Split('|');
                foreach (string srow in srows)
                {
                    if (srow.Trim() == "")
                        continue;
                    WelfareItem item = new WelfareItem();
                    item.Deserialize(srow);
                    src.Add(item);
                }
            }
        }
        // end of properties


        // form methods
        private void FormEditMember_Load(object sender, EventArgs e)
        {
            //
        }

        private void BindFamilyMembers()
        {
            // bind family members DataGridView
            var src_family_members = new BindingSource();
            List<FamilyMember> list = new List<FamilyMember>();
            src_family_members.DataSource = list;
            col_family_birthd_date.ValueType = typeof(DateTime);
            dgFamily.AutoGenerateColumns = false;
            dgFamily.DataSource = src_family_members;
            bnFamily.BindingSource = src_family_members;
        }

        private void BindOrgRelations()
        {
            // bind organizaton records DataGridView
            var src_org_rels = new BindingSource();
            List<OrgRecord> list = new List<OrgRecord>();
            src_org_rels.DataSource = list;
            reg_date.ValueType = typeof(DateTime);
            exit_date.ValueType = typeof(DateTime);
            dgOrgRelation.AutoGenerateColumns = false;
            dgOrgRelation.DataSource = src_org_rels;
            bnOrgRelation.BindingSource = src_org_rels;
        }
        private void BindPayments()
        {
            // bind payments DataGridView
            var src_payments = new BindingSource();
            List<Payment> list = new List<Payment>();
            src_payments.DataSource = list;
            col_payment_value.ValueType = typeof(double);
            col_payment_date.ValueType = typeof(DateTime);
            dgPayments.AutoGenerateColumns = false;
            dgPayments.DataSource = src_payments;
            bnPayments.BindingSource = src_payments;
        }
        private void BindWelfareAssistance()
        {
            // bind welfare assistance DataGridView
            var src_welfare = new BindingSource();
            List<WelfareItem> list = new List<WelfareItem>();
            src_welfare.DataSource = list;
            welfare_date.ValueType = typeof(DateTime);
            dgWelfareAssistance.AutoGenerateColumns = false;
            dgWelfareAssistance.DataSource = src_welfare;
            bnWelfareAssistance.BindingSource = src_welfare;
        }
        
        public void LoadOrganizations()
        {
            cbOrgName.DataSource = null;
            try
            {
                string sql = "SELECT id, CONCAT_WS(': ', name, chief_name) as org_name, name FROM organizations";
                MySqlCommand cmd = new MySqlCommand(sql, m_connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<ComboItem> items = new List<ComboItem>();
                List<ComboItem> org_rel_items = new List<ComboItem>();
                while (rdr.Read())
                {
                    ComboItem item = new ComboItem(rdr["org_name"], rdr["id"]);
                    ComboItem org_rel_item = new ComboItem(rdr["name"], rdr["id"]);
                    items.Add(item);
                    org_rel_items.Add(org_rel_item);
                }
                rdr.Close();
                cbOrgName.DataSource = items;
                cbOrgName.DisplayMember = "Text";
                cbOrgName.ValueMember = "Value";
                org_name.DataSource = org_rel_items;
                org_name.DisplayMember = "Text";
                org_name.ValueMember = "Text";
                //org_name.ValueType = typeof(long);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            cbOrgName.SelectedIndex = -1;
        }

        private void btAddOrg_Click(object sender, EventArgs e)
        {
            FormEditOrganizatation frm = new FormEditOrganizatation();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                string sql = "INSERT INTO organizations (name, chief_name, secretary_name) VALUES (@name, @chief_name, @secretary_name)";
                MySqlCommand cmd = new MySqlCommand(sql, m_connection);
                cmd.Parameters.AddWithValue("@name", frm.orgName);
                cmd.Parameters.AddWithValue("@chief_name", frm.orgChiefName);
                cmd.Parameters.AddWithValue("@secretary_name", frm.orgSecretaryName);
                int rows = cmd.ExecuteNonQuery();
                LoadOrganizations();
                this.fld_id_org = cmd.LastInsertedId;
            }
        }


        private bool ValidateNotEmptyString(string s)
        {
            return s.Trim() != "";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // validate some required fields
            if (fld_ticket_number == "")
            {
                tabControl1.SelectTab(0);
                tbTicketNumber.Focus();
                return;
            }
            if (fld_lname == "")
            {
                tabControl1.SelectTab(0);
                tbLName.Focus();
                return;
            }
            if (fld_fname == "")
            {
                tabControl1.SelectTab(0);
                tbFName.Focus();
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btLoadFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Image imgFull = Image.FromFile(dlg.FileName);
                    float k = 1;
                    if (imgFull.Width >= imgFull.Height)
                        k = (float)picFoto.Width / (float)imgFull.Width;
                    else
                        k = (float)picFoto.Height / (float)imgFull.Height;
                    int iNewWidth = (int)(imgFull.Width * k);
                    int iNewHeight = (int)(imgFull.Height * k);
                    Image imgThumb = imgFull.GetThumbnailImage(iNewWidth, iNewHeight, null, IntPtr.Zero);
                    picFoto.Image = imgThumb;
                    //picFoto.Load(dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
