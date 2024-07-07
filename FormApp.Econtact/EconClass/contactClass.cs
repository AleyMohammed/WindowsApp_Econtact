using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Econtact.EconClass
{
     class contactClass
    {
        public int ContactID { get; set; } // LabelContactID.........

        public string FirstName { get; set; } // LabelFirstName........

        public string LastName { get; set; } // LabelLastName............

        public string ContactNo { get; set; } // LabelContactNo...........

        public string Addresse { get; set; } // LabelImage........


        public string Gender { get; set; } // LabelGender.......

        static readonly string connstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

         public DataTable Select()
        {

            SqlConnection conn = new SqlConnection(connstrng);
            DataTable DataBase = new DataTable();

            try
            {
                string sql = "SELECT * FROM Econpp";
                SqlCommand SqlCommand = new SqlCommand(sql, conn);

                SqlDataAdapter adpater = new SqlDataAdapter(SqlCommand);

                conn.Open();
                adpater.Fill(DataBase);


            }
            catch (Exception myDB)
            {

            }
            finally
            {
                conn.Close();

            }
            return DataBase;

        }
        public bool Insert(contactClass C)
        {
            bool Dataset = false;

            SqlConnection conn = new SqlConnection(connstrng);
            try
            {

                string sql = "INSERT into Econpp (FirstName, LastName, ContactNo, Addresse, Gender) VALUES (@FirstName, @LastName, @ContactNo, @Addresse, @Gender)";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("@FirstName", C.FirstName);

                sqlCommand.Parameters.AddWithValue("@LastName", C.LastName);

                sqlCommand.Parameters.AddWithValue("@ContactNo", C.ContactNo);

                sqlCommand.Parameters.AddWithValue("@Addresse", C.Addresse);

                sqlCommand.Parameters.AddWithValue("@Gender", C.Gender);

                conn.Open();

                int ROWs = sqlCommand.ExecuteNonQuery();

                if (ROWs > 0)
                {
                    Dataset = true;
                }

                else
                {

                    Dataset = false;

                }




            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return Dataset;
        }

        public bool Update(contactClass C)
        {

            bool Dataset = false;
            SqlConnection conn = new SqlConnection(connstrng);

            try
            {

                string sql = "UPDATE Econpp SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Addresse=@Addresse, Gender=@Gender WHERE contactID =@ContactID";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("FirstName", C.FirstName);

                sqlCommand.Parameters.AddWithValue("LastName", C.LastName);

                sqlCommand.Parameters.AddWithValue("ContactNo", C.ContactNo);

                sqlCommand.Parameters.AddWithValue("Addresse", C.Addresse);

                sqlCommand.Parameters.AddWithValue("Gender", C.Gender);

                sqlCommand.Parameters.AddWithValue("ContactID", C.ContactID);

                conn.Open();

                int ROWs = sqlCommand.ExecuteNonQuery();
                if (ROWs > 0)
                {
                    Dataset = true;
                }

                else
                {

                    Dataset = false;

                }




            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return Dataset;



        }

        public bool Delete(contactClass C)
        {
            bool Dataset = false;
            SqlConnection conn = new SqlConnection(connstrng);


            try
            {

                string sql = "DELETE Econpp WHERE contactID =@ContactID";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("@ContactID", C.ContactID);
                conn.Open();
                int ROWs = sqlCommand.ExecuteNonQuery();

                if (ROWs > 0)
                {
                    Dataset = true;
                }

                else
                {

                    Dataset = false;

                }
            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return Dataset;



        }













    }
}

    
