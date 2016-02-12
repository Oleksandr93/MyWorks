using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS
{
    class OrgRecord
    {
        // Data class responsible for storing organization registration and exit dates for an UTOS member

        public string org_name { get; set; }
        public DateTime? reg_date { get; set; }
        public DateTime? exit_date { get; set; }
        public OrgRecord()
        {
            this.org_name = "";
            this.reg_date = null;
            this.exit_date = null;
        }
        public OrgRecord(string org_name, DateTime? reg_date = null, DateTime? exit_date = null)
        {
            this.org_name = org_name;
            this.reg_date = reg_date;
            this.exit_date = exit_date;
        }
        public override string ToString()
        {
            return String.Format("{0}: {1}-{2}", org_name, reg_date, exit_date);
        }
        private string NormalizeStr(string s)
        {
            if (s == null)
                return s;
            string s2 = s.Replace(",", "");
            return s2.Replace("|", "");
        }
        public string Serialize()
        {
            org_name = NormalizeStr(org_name);
            long bin_reg_date = reg_date != null ? reg_date.Value.ToBinary() : 0;
            long bin_exit_date = exit_date != null ? exit_date.Value.ToBinary() : 0;
            return String.Format("{0},{1},{2}", org_name, bin_reg_date, bin_exit_date);
        }
        public void Deserialize(string s)
        {
            string[] tokens = s.Split(',');
            org_name = tokens[0];
            long bin_reg_date = Convert.ToInt64(tokens[1]);
            if (bin_reg_date != 0)
                reg_date = DateTime.FromBinary(bin_reg_date);
            else
                reg_date = null;
            long bin_exit_date = Convert.ToInt64(tokens[2]);
            if (bin_exit_date != 0)
                exit_date = DateTime.FromBinary(bin_exit_date);
            else
                exit_date = null;
        }
    }
}
