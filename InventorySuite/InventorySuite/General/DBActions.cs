using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace InventorySuite.General 
{
   public class DBActions
    {
        public string Username, Password, Servername, DBName;
        SqlConnection Sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
    

        void openDB()

        {
            Username = "sa";
            Password = "Polosys*123";
            Servername = "SHABEER";
            DBName = "SampleInventory";

            string constring = " Data Source =" + Servername + "; Initial Catalog =" + DBName + "; User ID =" + Username + "; Password =" + Password;
            Sqlcon.ConnectionString = constring;

        try{
                Sqlcon.Open();
             }
         catch(Exception ex)
            { 
                MessageBox.Show("Error"+ ex);
               
            }

        }

        void closeDB()
        {

            try
            {
                Sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }


        public bool ExecuteNonQuery(string ProcedureName, object[,] ParametersName)
        {

              if (Sqlcon.State != ConnectionState.Open) openDB();

            cmd = new SqlCommand();
            cmd.Connection = Sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ProcedureName;
            cmd.CommandTimeout = 0;

            String ParameterName;
            Object ParameterValue;
            Int32 i;
            for (i = 0; i <= (ParametersName.Length) / 2 - 1; i++)
            {
                ParameterName = ParametersName[i, 0].ToString();
                ParameterValue = ParametersName[i, 1];
                cmd.Parameters.AddWithValue(ParameterName, ParameterValue);
            }

            int id = cmd.ExecuteNonQuery();
            cmd.CommandText = "";


            if (id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet ExecuteQuery(string ProcedureName, object[,] ParametersName )
        {

          

            if (Sqlcon.State != ConnectionState.Open) openDB();

            cmd = new SqlCommand();
            cmd.Connection = Sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ProcedureName;

            cmd.CommandTimeout = 0;
            String ParameterName;
            Object ParameterValue;
            Int32 i;
            for (i = 0; i <= (ParametersName.Length) / 2 - 1; i++)
            {
                ParameterName = ParametersName[i, 0].ToString();
                ParameterValue = ParametersName[i, 1];
                cmd.Parameters.AddWithValue(ParameterName, ParameterValue);
            }

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
             DA.Fill(ds);
          cmd.CommandText = "";

            return ds;
        }
       public  DataSet ExecuteQuery_SP(string ProcedureName)
        {

            SqlDataAdapter DA = new SqlDataAdapter();   
            DataSet ds = new DataSet();
            try {
                if (Sqlcon.State != ConnectionState.Open) openDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ProcedureName;
                cmd.CommandTimeout = 0;
              //  cmd.Transaction = SqlTrans;
                DA = new SqlDataAdapter(cmd);

                DA.Fill(ds);
                cmd.CommandText = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            finally
            {
                closeDB();
            }
            return ds;
        }
        public object ExecuteScalar(string ProcedureName, object[,] ParametersName)
        {

         
            if (Sqlcon.State != ConnectionState.Open) openDB();

            cmd = new SqlCommand();
            cmd.Connection = Sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ProcedureName;

            cmd.CommandTimeout = 0;
            String ParameterName;
            Object ParameterValue;
            Int32 i;
            for (i = 0; i <= (ParametersName.Length) / 2 - 1; i++)
            {
                ParameterName = ParametersName[i, 0].ToString();
                ParameterValue = ParametersName[i, 1];
                cmd.Parameters.AddWithValue(ParameterName, ParameterValue);
            }

            object id = cmd.ExecuteScalar();
            cmd.CommandText = "";


            return id;
        }

       

    }
}
