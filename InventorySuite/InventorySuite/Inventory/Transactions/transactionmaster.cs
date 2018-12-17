using InventorySuite.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace InventorySuite.Inventory.Transactions
{
    class transactionmaster
    {
        public int InvTransactionMasterID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public int VoucherNumber { get; set; }
        public string PartyName { get; set; }
        public string Address1 { get; set; }
        public string Mob { get; set; }
        public Decimal TotalGross { get; set; }
        public Decimal TotalDiscount { get; set; }
        public Decimal GrandTotal { get; set; }
        public Decimal PaidAmount { get; set; }
        public int Save()
        {
            object Id = 0;


            object[,] Parameters = new object[,]

             {

                { "@TransactionDate ",TransactionDate },
                 { "@TransactionType",TransactionType },
                { "@PartyName ",PartyName },
                { "@Mob",Mob },
                { "@Address1",Address1 },
                { "@TotalGross ",TotalGross },
                { "@TotalDiscount",TotalDiscount },
                { "@GrandTotal",GrandTotal },
                { "@PaidAmount",PaidAmount }



             };

            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("InserItnvTransactionMaster", Parameters);
            return Convert.ToInt32(Id);


        }

        public DataSet LoadEditDetails()
        {

            object Id = 0;

            object[,] Parameters = new object[,]  { { "@VoucherNumber", VoucherNumber} , { "@TransactionType",TransactionType }
                 };
            DataSet ds = new DataSet();
            DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("LoadEditDetails", Parameters);

            return ds;


        }
    


        public DataSet LoadVoucherNo()
        {

          

            object[,] Parameters = new object[,]  { { "@TransactionType",TransactionType }
                 };
            DataSet ds = new DataSet();
            DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("GetMaxofLastVoucherNo", Parameters);

            return ds;


        }


        public void Setisactiveornot()
        {

            object Id = 0;

            object[,] Parameters = new object[,] { { "@InvTransactionMasterID", InvTransactionMasterID } };
            DBActions db = new General.DBActions();
             db.ExecuteScalar("Setisactiveornot", Parameters);


        }

        public int SAVEFOREDIT ()
        {
            object Id = 0;


            object[,] Parameters = new object[,]

             {

                { "@TransactionDate ",TransactionDate },
                {"@VoucherNumber",VoucherNumber},
                 { "@TransactionType",TransactionType },
                { "@PartyName ",PartyName },
                { "@Mob",Mob },
                { "@Address1",Address1 },
                { "@TotalGross ",TotalGross },
                { "@TotalDiscount",TotalDiscount },
                { "@GrandTotal",GrandTotal },
                { "@PaidAmount",PaidAmount }



             };

            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("SaveMasterDetailsForEdit", Parameters);
            return Convert.ToInt32(Id);


        }


    }
}