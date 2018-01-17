using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace DAL
{

    public class DataProvider
    {
        public static string strConn = "SERVER = DESKTOP-5HGTV4A; uid = sa; pwd = 12112014; DATABASE = QuanLyKhachSan";
        public static SqlConnection getConnection()
        {
            SqlConnection _conn = new SqlConnection(strConn);
            return _conn;
        }
        public static void openConnection()
        {
            try
            {
                if (getConnection().State == ConnectionState.Closed)
                {
                    getConnection().Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error connected" + ex.Message);
            }

        }
        public static void closeConnection()
        {
            try
            {
                if (getConnection().State == ConnectionState.Open)
                {
                    getConnection().Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error disconnected" + ex.Message);
            }
        }

        public static DataSet fillDataSet(string strSQL)
        {
            DataSet _ds = new DataSet();
            try
            {
                SqlDataAdapter _da = new SqlDataAdapter(strSQL, getConnection());
                _da.Fill(_ds);
                _da.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            return _ds;
        }
        public static DataSet fillDataSet(string strSQL, string table)
        {
            DataSet _ds = new DataSet();
            try
            {
                SqlDataAdapter _da = new SqlDataAdapter(strSQL, getConnection());
                _da.Fill(_ds, table);
                _da.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            return _ds;
        }
        public static DataTable fillDataTable(string strSQL)
        {
            DataTable _dt = new DataTable();
            try
            {
                SqlDataAdapter _da = new SqlDataAdapter(strSQL, getConnection());
                _da.Fill(_dt);
                _da.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            return _dt;
        }
        public static SqlDataReader DataReader(string strQuery, CommandType cmdType, string[] para, object[] value)
        {
            SqlDataReader _dtReader;
            SqlConnection _conn = new SqlConnection();
            _conn = getConnection();
            _conn.Open();

            SqlCommand _cmd = new SqlCommand();
            _cmd.CommandText = strQuery;
            _cmd.CommandType = CommandType.Text;

            _cmd.Connection = _conn;

            SqlParameter _para;
            for (int i = 0; i < para.Length; i++)
            {
                _para = new SqlParameter();
                _para.ParameterName = para[i];
                _para.SqlValue = value[i];
                _cmd.Parameters.Add(_para);
            }
            _dtReader = _cmd.ExecuteReader();

            return _dtReader;
        }
       public DataTable DataReader(string strQuery)
        {
            DataTable _dt;
            try
            {
                SqlCommand _cmd = new SqlCommand(strQuery, getConnection());

                SqlDataReader _dtReader = _cmd.ExecuteReader();

                _dt = new DataTable();

                _dt.Load(_dtReader);

                closeConnection();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Eroor : " + ex.Message);
                return null;
            }
            return _dt;
        }
        public static int ExecuteNonQuery(string strQuery)
       
        {
            SqlConnection _conn = new SqlConnection();
            _conn = getConnection();
            _conn.Open();
            SqlCommand _cmd = new SqlCommand(strQuery, _conn);
            int i = 0;

            try
            {
               i = _cmd.ExecuteNonQuery();
            }
           
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
                return 0;
            }
            return i;
        }
        public static string ExecuteScalar(string strSQL)
        {
            string _value = "";
            try
            {
                SqlConnection _conn = getConnection();
                _conn = getConnection();
                _conn.Open();
                SqlCommand _cmd = new SqlCommand(strSQL, _conn);
                _value = _cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            return _value;
        }
        public static string ExecuteScalar(string strSQL,CommandType cmdType, string[]para,object[]value)
        {
                string effectRecord = "";

                SqlConnection _conn;
                _conn = getConnection();
                _conn.Open();
                

                SqlCommand _cmd = new SqlCommand();
                _cmd.CommandText = strSQL;
                _cmd.CommandType = cmdType;
                _cmd.Connection = _conn;

                SqlParameter _para;
                for (int i = 0; i < para.Length; i++)
                {
                    _para = new SqlParameter();
                    _para.ParameterName = para[i];
                    _para.Value = value[i];
                    _cmd.Parameters.Add(_para);
                }
                
            try
            {
                effectRecord = _cmd.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            
            return effectRecord;
        }

        

    }
}
