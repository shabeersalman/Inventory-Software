using InventorySuite.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace InventorySuite.Inventory.Transactions
{
    class transactiondetails
    {

        public int pcode { get; set; }
        public int InvTransactionDetailID { get; set; }
        public int InvTransactionMasterID { get; set; }
        public int ProductID { get; set; }
        public decimal TotalQTY { get; set; }
        public decimal Price { get; set; }
        public decimal TotalGross { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal NetTotal { get; set; }
        public double StockIn = 0;
        public double StockOut = 0;


        public int Save()
        {
            object Id = 0;


            object[,] Parameters = new object[,]

             {

                { "@InvTransactionMasterID",InvTransactionMasterID },
                { "@ProductID ",ProductID },
                { "@TotalQTY",TotalQTY },
                { "@Price ",Price },
                { "@TotalGross",TotalGross },
                { "@TotalDiscount",TotalDiscount },
                { "@NetTotal",NetTotal },
                { "@StockIn",StockIn },
                { "@StockOut",StockOut }

             };

            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("InserItnvTransactionDetails", Parameters);
            return Convert.ToInt32(Id);


        }

        public DataSet SelecInvdetails()
        {

            object Id = 0;

            object[,] Parameters = new object[,]  { { "@ProductCode", pcode }
                 };
            DataSet ds = new DataSet();
            DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("SelectProductDetails", Parameters);

            return ds;


        }

        public int UpdateStockInProduts()
        {

            object Id = 0;


            object[,] Parameters = new object[,]

             {
                { "@ID",ProductID },
                { "@Stockin",StockIn },
                { "@StockOut",StockOut }

             };

            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("UpdateStockInProducts", Parameters);
            return Convert.ToInt32(Id);


        }
        public int  RefreshStock()
        {
            DataSet ds = new DataSet();
            DBActions db = new General.DBActions();
            ds= db.ExecuteQuery_SP("RefreshStock");
            int result = 0;
            if (ds.Tables[0].Rows.Count > 0)
                result = 1;
            return result;


        }





    }
}
