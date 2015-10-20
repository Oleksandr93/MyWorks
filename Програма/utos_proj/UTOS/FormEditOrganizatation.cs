using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTOS
{
    public partial class FormEditOrganizatation : Form
    {
        public string orgName
        {
            get { return tbName.Text.Trim(); }
            set { tbName.Text = value.Trim();  }
        }
        public string orgChiefName
        {
            get { return tbChiefName.Text.Trim(); }
            set { tbChiefName.Text = value.Trim(); }
        }
        public string orgSecretaryName
        {
            get { return tbSecretaryName.Text.Trim(); }
            set { tbSecretaryName.Text = value.Trim(); }
        }
        public string orgStaff
        {
            get
            {
                StringBuilder res = new StringBuilder();
                foreach (OrgStaff item in dgStaff.DataSource as BindingSource)
                {
                    res.Append(item.Serialize());
                    res.Append("|");
                }
                return res.ToString();
            }
            set
            {
                BindingSource src = dgStaff.DataSource as BindingSource;
                src.Clear();
                if (value == null || value.Trim() == "")
                    return;
                string[] srows = value.Split('|');
                foreach (string srow in srows)
                {
                    if (srow.Trim() == "")
                        continue;
                    OrgStaff item = new OrgStaff();
                    item.Deserialize(srow);
                    src.Add(item);
                }
            }
        }

        public FormEditOrganizatation()
        {
            InitializeComponent();
            BindStaff();
        }

        private void BindStaff()
        {
            // bind organization staff DataGridView
            var src_staff = new BindingSource();
            List<OrgStaff> list = new List<OrgStaff>();
            src_staff.DataSource = list;
            col_staff_start_date.ValueType = typeof(DateTime);
            col_staff_birth_date.ValueType = typeof(DateTime);
            dgStaff.AutoGenerateColumns = false;
            dgStaff.DataSource = src_staff;
            bnStaff.BindingSource = src_staff;
        }

        private bool ValidateString(string s)
        {
            return s.Trim() != "";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (!ValidateString(tbName.Text))
            {
                tbName.Focus();
                return;
            }
            if (!ValidateString(tbChiefName.Text))
            {
                tbChiefName.Focus();
                return;
            }
            if (!ValidateString(tbSecretaryName.Text))
            {
                tbSecretaryName.Focus();
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
