using InventorySuite.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace InventorySuite.Inventory.Masters.ProductGroup
{
    class ProductGroup
    {


        public int ProductGroupID = 0;
        public string GroupName = "";

        public int Save()
        {
            object Id = 0;

            object[,] Parameters = new object[,] { { "@GroupName", GroupName } };
            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("InsertProductGroup", Parameters);
            return Convert.ToInt32(Id);

        }

        public int Edit()

        {
            object Id = 0;

            object[,] Parameters = new object[,] { { "@ID", ProductGroupID }, { "@GroupName", GroupName } };
            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("UpdateProductGroup", Parameters);
            return Convert.ToInt32(Id);
        }

        public int Delete()
        {

            object Id = 0;

            object[,] Parameters = new object[,] { { "@ID", ProductGroupID } };
            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("DeleteProductGroup", Parameters);

            return Convert.ToInt32(Id);


        }
        public DataSet SelectUsers()
        {
            DataSet ds = new DataSet();
            DBActions db = new General.DBActions();
            ds = db.ExecuteQuery_SP("SelectProductGroup");
            return ds;
        }

















    }
}
