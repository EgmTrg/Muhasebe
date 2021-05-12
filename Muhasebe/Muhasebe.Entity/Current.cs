using System;

namespace Muhasebe.Entity
{
    public class Current : TableObjects
    {
        public override string PrimaryKey => throw new NotImplementedException();
        public int CurrentID { get; set; }
        public int Code { get; set; }
        public string Title { get; set; }
        public int Dept { get; set; }
        public int Payee { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int Phone1 { get; set; }
        public int Phone2 { get; set; }
        public int MobilPhone { get; set; }
        public string TaxNo { get; set; }
        public int PersonalID { get; set; }
    }
}
