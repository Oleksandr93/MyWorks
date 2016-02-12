using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS
{
    public class FamilyMember
    {
        // Data class responsible for storing info about family relateve for an UTOS member

        public string full_name
        { get { return String.Format("{0} {1} {2}", lname, fname, mname); } }
        public string fname { get; set; }
        public string lname { get; set; }
        public string mname { get; set; }
        public string relation { get; set; }
        public DateTime? birth_date { get; set; }
        public FamilyMember()
        {
            this.fname = "";
            this.lname = "";
            this.mname = "";
            this.relation = "";
            this.birth_date = null;
        }
        public FamilyMember(string fname, string lname, string mname, string relation, DateTime? birth_date = null)
        {
            this.fname = fname;
            this.lname = lname;
            this.mname = mname;
            this.relation = relation;
            this.birth_date = birth_date;
        }
        public override string ToString()
        {
            return String.Format("{0} ({1})", full_name, birth_date);
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
            fname = NormalizeStr(fname);
            lname = NormalizeStr(lname);
            mname = NormalizeStr(mname);
            relation = NormalizeStr(relation);
            long bdate = birth_date != null ? birth_date.Value.ToBinary() : 0;
            return String.Format("{0},{1},{2},{3},{4}", fname, lname, mname, relation, bdate);
        }
        public void Deserialize(string s)
        {
            string[] tokens = s.Split(',');
            fname = tokens[0];
            lname = tokens[1];
            mname = tokens[2];
            relation = tokens[3];
            long bdate = Convert.ToInt64(tokens[4]);
            if (bdate != 0)
                birth_date = DateTime.FromBinary(bdate);
            else
                birth_date = null;
        }
    }
}
