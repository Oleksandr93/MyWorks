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
    public partial class FormMain : Form
    {
        private UtosForm activeForm = null;
        private FormMembers frmMembers = new FormMembers();
        private FormOrganizations frmOrganizations = new FormOrganizations();

        public FormMain()
        {
            InitializeComponent();
        }

        private void activateForm(UtosForm form)
        {
            // close another form
            if (activeForm != null && activeForm != form)
            {
                activeForm.Hide();
                activeForm.MdiParent = null;
                activeForm = null;
            }

            // activate selected form
            activeForm = form;
            activeForm.dlgUpdateControls = updateControls;
            activeForm.MdiParent = this;
            activeForm.WindowState = FormWindowState.Maximized;
            activeForm.Show();

            activeForm.RefreshData();
            updateControls();
        }

        private void updateControls()
        {
            if (activeForm == null)
            {
                btAdd.Enabled = false;
                btEdit.Enabled = false;
                btDelete.Enabled = false;
                btSearch.Enabled = false;
                btExport.Enabled = false;
                btRefresh.Enabled = false;
                miEditCard.Enabled = false;
                miDeleteCard.Enabled = false;
                miEditOrg.Enabled = false;
                miDeleteOrg.Enabled = false;
                miSearch.Enabled = false;
                miExport.Enabled = false;
            }
            else
            {
                btAdd.Enabled = activeForm.canAdd;
                btEdit.Enabled = activeForm.canEdit;
                btDelete.Enabled = activeForm.canDelete;
                btSearch.Enabled = activeForm.canSearch;
                btExport.Enabled = activeForm.canExport;
                btRefresh.Enabled = activeForm.canRefresh;
                if (activeForm is FormMembers)
                {
                    miEditCard.Enabled = activeForm.canEdit;
                    miDeleteCard.Enabled = activeForm.canDelete;
                    miSearch.Enabled = activeForm.canSearch;
                    miExport.Enabled = activeForm.canExport;
                    miEditOrg.Enabled = false;
                    miDeleteOrg.Enabled = false;
                }
                else if (activeForm is FormOrganizations)
                {
                    miEditCard.Enabled = false;
                    miDeleteCard.Enabled = false;
                    miSearch.Enabled = false;
                    miExport.Enabled = false;
                    miEditOrg.Enabled = activeForm.canEdit;
                    miDeleteOrg.Enabled = activeForm.canDelete;
                }
                else
                {
                    miEditCard.Enabled = false;
                    miDeleteCard.Enabled = false;
                    miSearch.Enabled = false;
                    miExport.Enabled = false;
                    miEditOrg.Enabled = false;
                    miDeleteOrg.Enabled = false;
                }
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMembers_Click(object sender, EventArgs e)
        {
            activateForm(frmMembers);
        }

        private void btOrganizations_Click(object sender, EventArgs e)
        {
            activateForm(frmOrganizations);
        }

        private void btPayments_Click(object sender, EventArgs e)
        {
            //activateForm(frmPayments);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            activeForm.EditData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            activeForm.AddData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            activeForm.DeleteData();
        }

        private void miCards_Click(object sender, EventArgs e)
        {
            activateForm(frmMembers);
        }

        private void miNewCard_Click(object sender, EventArgs e)
        {
            activateForm(frmMembers);
            activeForm.AddData();
        }

        private void miViewOrgs_Click(object sender, EventArgs e)
        {
            activateForm(frmOrganizations);
        }

        private void miAddOrg_Click(object sender, EventArgs e)
        {
            activateForm(frmOrganizations);
            activeForm.AddData();
        }

        private void miViewPayments_Click(object sender, EventArgs e)
        {
            //activateForm(frmPayments);
            //activeForm.AddData();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            activeForm.Search();
        }

        private void msiAbout_Click(object sender, EventArgs e)
        {
            FormAbout frm = new FormAbout();
            frm.ShowDialog();
        }


        private void btRefresh_Click(object sender, EventArgs e)
        {
            activeForm.RefreshData();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            //TODO: export members to Word
            FormExport frm = new FormExport();
            frm.ShowDialog();
        }


    }
}
