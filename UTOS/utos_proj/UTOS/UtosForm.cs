using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTOS
{
    public delegate void UpdateControlsDelegate();

    public class UtosForm: Form
    {
        public UpdateControlsDelegate dlgUpdateControls = null;
        public bool canAdd = false;
        public bool canEdit = false;
        public bool canDelete = false;
        public bool canSearch = false;
        public bool canRefresh = true;
        public bool canExport = false;

        protected string m_connString;
        protected MySql.Data.MySqlClient.MySqlConnection m_connection = null;

        public UtosForm()
        {
        }

        public void Connect()
        {
            m_connString = System.Configuration.ConfigurationManager.ConnectionStrings["db-utos"].ConnectionString;
            Disconnect();
            try
            {
                m_connection = new MySql.Data.MySqlClient.MySqlConnection();
                m_connection.ConnectionString = m_connString;
                m_connection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Disconnect()
        {
            try
            {
                if (m_connection != null)
                {
                    m_connection.Close();
                    m_connection = null;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public virtual void RefreshData(long? stay_on_id = null, string sql_where = null)
        {
            //
            if (dlgUpdateControls != null)
                dlgUpdateControls();
        }

        public virtual void AddData() { }

        public virtual void EditData() { }

        public virtual void DeleteData() { }

        public virtual void Search() { }

    }
}
