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
    public partial class FormSearch : Form
    {
        public string sql_where = "";

        public FormSearch()
        {
            InitializeComponent();
        }

        private bool ValidateNotEmptyString(string s)
        {
            return s.Trim() != "";
        }

        private string ConstructQueryPart(string fieldName, TextBox tbValue, ComboBox cbOperation = null)
        {
            if (tbValue.Text.Trim() == "")
                return "";

            string op = "";
            if (cbOperation != null)
                if (cbOperation.SelectedIndex >= 0)
                    op = " " + cbOperation.Text.Split(' ')[0] + " ";
                else
                    return "";

            return String.Format("{0}{1} LIKE '%{2}%'", op, fieldName, tbValue.Text);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string sql_where = ConstructQueryPart("ticket_number", tbTicketNumber);
            sql_where += ConstructQueryPart("concat_ws(' ', lname, fname, mname)", tbName, sql_where != "" ? cbName : null);
            sql_where += ConstructQueryPart("address", tbAddress, sql_where != "" ? cbAddress : null);
            sql_where += ConstructQueryPart("phone", tbPhone, sql_where != "" ? cbPhone : null);
            sql_where += ConstructQueryPart("idcode", tbIdCode, sql_where != "" ? cbIdCode : null);
            sql_where += ConstructQueryPart("concat_ws(passport_sn, passport_number)", tbPassportNumber, sql_where != "" ? cbPassportNumber : null);
            sql_where += ConstructQueryPart("pension_card_number", tbPensionCardNumber, sql_where != "" ? cbPensionCardNumber : null);
            sql_where += ConstructQueryPart("disability_group", tbDisabilityGroup, sql_where != "" ? cbDisabilityGroup : null);
            sql_where += ConstructQueryPart("education", tbEducation, sql_where != "" ? cbEducation : null);
            sql_where += ConstructQueryPart("speciality", tbSpeciality, sql_where != "" ? cbSpeciality : null);
            sql_where += ConstructQueryPart("concat_ws(' ', position, position_last)", tbPosition, sql_where != "" ? cbPosition : null);

            if (sql_where != "")
            {
                this.sql_where = sql_where;
                this.DialogResult = DialogResult.OK;
            }
            else
                tbTicketNumber.Focus();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            //cbTicketNumber.SelectedIndex = 0;
            //cbName.SelectedIndex = 0;
            //cbAddress.SelectedIndex = 0;
            //cbPhone.SelectedIndex = 0;
            //cbIdCode.SelectedIndex = 0;
            //cbPassportNumber.SelectedIndex = 0;
            //cbPensionCardNumber.SelectedIndex = 0;
            //cbDisabilityGroup.SelectedIndex = 0;
            //cbEducation.SelectedIndex = 0;
            //cbSpeciality.SelectedIndex = 0;
            //cbPosition.SelectedIndex = 0;
        }

    }
}
