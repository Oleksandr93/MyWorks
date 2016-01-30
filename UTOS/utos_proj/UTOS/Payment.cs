using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTOS
{
    class Payment
    {
        // Data class responsible for storing payments for an UTOS member

        public double payment_value { get; set; }
        public DateTime? payment_date { get; set; }
        public Payment()
        {
            this.payment_value = 0;
            this.payment_date = null;
        }
        public Payment(double payment_value, DateTime? payment_date = null)
        {
            this.payment_value = payment_value;
            this.payment_date = payment_date;
        }
        public override string ToString()
        {
            return String.Format("{0} on {1}", payment_value, payment_date);
        }
        public string Serialize()
        {
            string str_value = ((int)Math.Round(payment_value * 100)).ToString();
            long bin_payment_date = payment_date != null ? payment_date.Value.ToBinary() : 0;
            return String.Format("{0},{1}", str_value, bin_payment_date);
        }
        public void Deserialize(string s)
        {
            string[] tokens = s.Split(',');
            try
            {
                payment_value = Convert.ToInt64(tokens[0]) / 100.0;
            } 
            catch (Exception)
            {
                payment_value = 0;
            }
            long bin_payment_date = Convert.ToInt64(tokens[1]);
            if (bin_payment_date != 0)
                payment_date = DateTime.FromBinary(bin_payment_date);
            else
                payment_date = null;
        }
    }
}
