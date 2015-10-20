using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS
{
    class WelfareItem
    {
        // Data class responsible for storing welfare assistance item for an UTOS member

        public string org_name { get; set; }
        public string description { get; set; }
        public DateTime? date { get; set; }
        public WelfareItem()
        {
            this.org_name = "";
            this.description = "";
            this.date = null;
        }
        public WelfareItem(string org_name, string description, DateTime? date = null)
        {
            this.org_name = org_name;
            this.description = description;
            this.date = date;
        }
        public override string ToString()
        {
            return String.Format("{0}: {1} - {2}", date, org_name, description);
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
            description = NormalizeStr(description);
            long bin_date = date != null ? date.Value.ToBinary() : 0;
            return String.Format("{0},{1},{2}", bin_date, org_name, description);
        }
        public void Deserialize(string s)
        {
            string[] tokens = s.Split(',');
            
            long bin_date = Convert.ToInt64(tokens[0]);
            if (bin_date != 0)
                date = DateTime.FromBinary(bin_date);
            else
                date = null;

            org_name = tokens[1];
            description = tokens[2];
        }
    }
}
