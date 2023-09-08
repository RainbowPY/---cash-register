using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shouyinDAL
{
    public class SysqlHelp
    {

        //数据库连接  注意各个主机的数据库ip地址不一样  改一下数据库连接地址
        //数据库连接  注意各个主机的数据库ip地址不一样  改一下数据库连接地址
        //数据库连接  注意各个主机的数据库ip地址不一样  改一下数据库连接地址
        //数据库连接  注意各个主机的数据库ip地址不一样  改一下数据库连接地址
        //数据库连接  注意各个主机的数据库ip地址不一样  改一下数据库连接地址
       


            private SqlConnection con = null;
            private void opensqlconnection()
            {
            // string connectionString = "Data Source=192.168.12.19;Initial Catalog=Cashier;User ID=sa;Password=123456";
            string connectionString = "Data Source=127.0.0.1;Initial Catalog=Cashier;Persist Security Info=True;User ID=sa;Password=123456";
                //打开数据库
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                else if (con.State == ConnectionState.Broken)
                {
                    con.Close();
                    con.Open();
                }


            }


            //关闭数据库
            private void CloseSqlConnection()
            {

                if (con != null)
                {

                    if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
                    {
                        con.Close();

                    }
                }

            }

            //处理数据库的各种插入  删除  修改操作

            public bool zengaishan(string sql)
            {

                try
                {

                    //打开数据库
                    opensqlconnection();
                    SqlCommand cmd = new SqlCommand(sql, con);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        return true;

                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("执行sql命令出错");


                }
                finally
                {

                    CloseSqlConnection();//关闭数据库

                }
                return false;
            }

            //处理数据库的各种查询
            public DataSet sql_DataSet(string sql)
            {
                try
                {


                    //打开数据库
                    opensqlconnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tables");
                    return ds;
                }
                catch (Exception)
                {

                    Console.WriteLine("执行sql语句错误了！");

                }
                finally
                {

                    CloseSqlConnection();
                }



                return null;

            }

        }





    }

