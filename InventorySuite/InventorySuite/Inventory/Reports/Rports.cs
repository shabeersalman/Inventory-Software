using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace InventorySuite.Inventory.Reports
{
    class Rports
    {

        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public string TransactionType { get; set; }
        public DateTime AsonDate { get; set; }
        public int  ProductID { get; set; }
        public int ProductGroupID { get; set; }



        public DataSet TransReports()
        {

            object Id = 0;

            object[,] Parameters = new object[,]  { { "@fromdate", fromdate} , { "@todate",todate }, { "@TransactionType",TransactionType }
                 };
            DataSet ds = new DataSet();
           General.DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("TransReport", Parameters);

            return ds;

        }


        public DataSet StockReport()
        {


            object Id = 0;

            object[,] Parameters = new object[,]  { { "@date", AsonDate} , 
                { "@ProductGroupID",ProductGroupID },
                { "@ProductID",ProductID }};
            DataSet ds = new DataSet();
            General.DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("StockReport", Parameters);
            return ds;

        }
        public DataSet StockLedgerReport()
        {


         

            object[,] Parameters = new object[,]  { { "@date", AsonDate},
                { "@ProductID",ProductID }};
            DataSet ds = new DataSet();
            General.DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("SelecStockLedgerReport", Parameters);
            return ds;

        }



        public DataSet ItemWiserReport()    
        {


            object[,] Parameters = new object[,]  { { "@fromdate", fromdate} , { "@todate",todate }, { "@TransactionType",TransactionType }
                 };
            DataSet ds = new DataSet();
            General.DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("ItemWiseStockReport", Parameters);

            return ds;

        }


        public DataSet SelectTransRegisterReport()
        {


            object[,] Parameters = new object[,]  { { "@fromdate", fromdate} , { "@todate",todate }, { "@TransactionType",TransactionType },
                  { "@ProductGroupID",ProductGroupID },
                { "@ProductID",ProductID }};
            DataSet ds = new DataSet();
            General.DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("SelectTransRegisterReport", Parameters);

            return ds;

        }




    }
}
