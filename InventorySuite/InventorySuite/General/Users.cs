using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace InventorySuite.General
{
    class Users
    {

        public int UserID = 0;
        public string UserName = "";
        public string Passwd = "";
        public string UserType = "";

    
    public int Save()
    {
            object Id = 0;

            // Do save function

            object[,] Parameters = new object[,]  { { "@UserName",UserName },   
                { "@Passwd",Passwd },
                { "@UserType",UserType }
                 };
            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("InsertUser", Parameters);
                      return (int)Id;

        }

        public int Edit()

        {
           object Id = 0;
                                
            object[,] Parameters = new object[,]  { {"@ID", UserID}, { "@UserName",UserName },
                { "@Passwd",Passwd },
                { "@UserType",UserType }
                 };
            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar ("UpdateUsers", Parameters);
                  return( int) Id;
        }
        public int Delete()
        {
            
            object Id = 0;

            object[,] Parameters = new object[,]  { {"@ID", UserID}  };
            DBActions db = new General.DBActions();
            Id = db.ExecuteScalar("DeleteUsersByID", Parameters);
            return (int)Id;

          
        }
        public DataSet SelectUsers()
        {
             DataSet ds = new DataSet();
           DBActions db = new General.DBActions();
            ds = db.ExecuteQuery_SP("SelectUser");
            return ds;
        }

        public int ValidateUsers()
        {
            object[,] Parameters = new object[,]  { { "@UserName",UserName },
                { "@Password",Passwd } };
            DataSet ds = new DataSet();
            DBActions db = new General.DBActions();
            ds = db.ExecuteQuery("SelectUserByUserNameAndPassword", Parameters);
            int result = 0;

            if (ds.Tables[0].Rows.Count > 0)
                result = 1;
            return result;


        }


    }

}
