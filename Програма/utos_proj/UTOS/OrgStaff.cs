using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS
{
    class OrgStaff
    {
        // Data class responsible for storing info about family relateve for an UTOS member

        public string position { get; set; }
        public string full_name { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? birth_date { get; set; }

        public OrgStaff()
        {
            this.position = "";
            this.full_name = "";
            this.start_date = null;
            this.birth_date = null;
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}, працює з {2}, дата народж. {3}", full_name, position, start_date, birth_date);
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
            full_name = NormalizeStr(full_name);
            position = NormalizeStr(position);
            long sdate = start_date != null ? start_date.Value.ToBinary() : 0;
            long bdate = birth_date != null ? birth_date.Value.ToBinary() : 0;
            return String.Format("{0},{1},{2},{3}", full_name, position, sdate, bdate);
        }
        public void Deserialize(string s)
        {
            string[] tokens = s.Split(',');
            full_name = tokens[0];
            position = tokens[1];
            long sdate = Convert.ToInt64(tokens[2]);
            if (sdate != 0)
                start_date = DateTime.FromBinary(sdate);
            else
                start_date = null;
            long bdate = Convert.ToInt64(tokens[3]);
            if (bdate != 0)
                birth_date = DateTime.FromBinary(bdate);
            else
                birth_date = null;
        }
    }
}
