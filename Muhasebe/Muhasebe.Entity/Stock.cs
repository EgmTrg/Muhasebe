using System;

namespace Muhasebe.Entity
{
    class Stock : TableObjects
    {
        public override string PrimaryKey => "ProductID";
        public int GroupNo { get; set; }
        public int StockCode { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Quantity_In { get; set; }
        public int Quantity_Out { get; set; }
        public int Quantity_Remaining { get; set; }
        public bool Status { get; set; }
        public decimal Price_Buy { get; set; }
        public decimal Price_Payee { get; set; }
        public decimal Price_Reatil { get; set; }
    }
}
