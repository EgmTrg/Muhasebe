using System;

namespace Muhasebe.Entity
{
    public class Current : TableObjects
    {
        public override string PrimaryKey => throw new NotImplementedException();
        public int CurrentID { get; set; }
        public int Code { get; set; }
        public string Title { get; set; }
        public double Debt { get; set; }
        public double Payee { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public long Phone1 { get; set; }
        public long Phone2 { get; set; }
        public long MobilPhone { get; set; }
        public string TaxNo { get; set; }
        public int PersonalID { get; set; }
        public DateTime DateTime { get; set; }
        public string Explain { get; set; }
    }
}
