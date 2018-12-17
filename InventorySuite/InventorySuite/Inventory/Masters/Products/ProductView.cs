using InventorySuite.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace InventorySuite.Inventory.Masters.Products
{
    class ProductView
    {


        public int ProductID = 0;
        public string ProductCode = "";
        public string ProductName = "";
        public string ManualBarcode = "";
        public int ProductGroupID = 0;
        public double PurchasePrice = 0;
        public double SalePrice = 0;
        public double Stock = 0;
 




        public int Save()
        {
            object Id = 0;


           object[,] Parameters = new object[,] 
            {
                { "@ProductCode",ProductCode },
                { "@ProductName",ProductName },
                { "@ManualBarcode",ManualBarcode },
                { "@ProductGroupID",ProductGroupID },
                { "@PurchasePrice",PurchasePrice },
                { "@SalePrice",SalePrice },
                  { "@Stock",Stock }

            };

            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("InserProducts", Parameters);
            return Convert.ToInt32(Id);


        }
        public int Edit()

        {
            object Id = 0;

            object[,] Parameters = new object[,] 
                {
                    { "@ID", ProductID }, 
                { "@ProductCode",ProductCode },
                { "@ProductName",ProductName },
                { "@ManualBarcode",ManualBarcode },
                { "@ProductGroupID",ProductGroupID },
                { "@PurchasePrice",PurchasePrice },
                { "@SalePrice",SalePrice },
                { "@Stock",Stock }
                 };
            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("UpdateProducts", Parameters);
            return Convert.ToInt32(Id);
        }


        public int Delete()
        {

            object Id = 0;

            object[,] Parameters = new object[,] { { "@ID", ProductID } };
            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("DeleteProduct", Parameters);

            return Convert.ToInt32(Id);


        }
        public DataSet SelectProducts()
        {
            DataSet ds = new DataSet();
            DBActions db = new General.DBActions();
            ds = db.ExecuteQuery_SP("SelectProducts");
            return ds;
        }

        public DataSet LoadProductCode()
        {
            DataSet ds = new DataSet();
            DBActions db = new General.DBActions();
            ds = db.ExecuteQuery_SP("GetLastProductCode");
            return ds;
        }
        public DataSet LoadProductList()
        {

         
            object[,] Parameters = new object[,]  { {"@ProductName",ProductName }
                 };
            DataSet ds = new DataSet();
            DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("LoadProducListonGridView", Parameters);

            return ds;
        }



    }

}
