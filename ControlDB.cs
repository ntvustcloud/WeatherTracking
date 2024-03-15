using System.Data.SqlClient;
using System.Data;


namespace P3_TanVu_Nguyen
{
    public class ControlDB
    {
        public ControlDB() { }

        // a connection string to the database file
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "P3_TanVu_Nguyen.mdf" + ";Integrated Security = True;";

        // a method to connect database with connection string 
        // read data from database and put into temperature datatable
        public DataTable getDataFromDB()
        {
            // create a connection to database thoguht connection string
            SqlConnection connection = new SqlConnection(connectionString);

            // create a temporate Datatabale to hold all data
            DataTable tempDataTable = new DataTable();
            try
            {
                // a string to specify the query to get data from table tbl_WeatherInformation
                string sqlQuery = "select * from [dbo].tbl_WeatherInformation";

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);

                connection.Open();
                sqlAdapter.Fill(tempDataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception catching", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
            return tempDataTable;
        }

        // a method to insert a row data into database table
        public bool insertRow(WeatherInfo tempRow)
        {
            bool successFlag = false;

            // create a connection to database thoguht connection string
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // a string to insert a row into table tbl_WeatherInformation
                string sqlQueryInsert = "INSERT INTO [dbo].tbl_WeatherInformation ([State], [City] , [Date], [Temperature] , [Humidity] , [Sunrise] , [Sunset] , [Cloudy] , [Windy] , [Rainy]) VALUES (@State, @City, @Date, @Temperature, @Humidity, @Sunrise, @Sunset, @Cloudy, @Windy, @Rainy);";

                SqlCommand sqlCommandInsert = new SqlCommand(sqlQueryInsert, connection);

                sqlCommandInsert.Parameters.AddWithValue("@State", tempRow.state);
                sqlCommandInsert.Parameters.AddWithValue("@City", tempRow.city);
                sqlCommandInsert.Parameters.AddWithValue("@Date", tempRow.date);
                sqlCommandInsert.Parameters.AddWithValue("@Temperature", tempRow.temperature);
                sqlCommandInsert.Parameters.AddWithValue("@Humidity", tempRow.humidity);
                sqlCommandInsert.Parameters.AddWithValue("@Sunrise", tempRow.sunrise);
                sqlCommandInsert.Parameters.AddWithValue("@Sunset", tempRow.sunset);
                sqlCommandInsert.Parameters.AddWithValue("@Cloudy", tempRow.cloudy);
                sqlCommandInsert.Parameters.AddWithValue("@Windy", tempRow.windy);
                sqlCommandInsert.Parameters.AddWithValue("@Rainy", tempRow.rainy);

                connection.Open();

                int rows = sqlCommandInsert.ExecuteNonQuery();

                if (rows > 0)
                {
                    successFlag = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception catching", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }

            return successFlag;
        }

        // a method to delete a row from database table
        public bool deteteRow(int selectedId) 
        {
            bool successFlag = false;

            // create a connection to database thoguht connection string
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // a string to insert a row into table tbl_WeatherInformation
                string sqlQueryDelete = "Delete from [dbo].tbl_WeatherInformation where id = @id";

                SqlCommand sqlCommandDelete = new SqlCommand(sqlQueryDelete, connection);

                sqlCommandDelete.Parameters.AddWithValue("@id", selectedId);

                connection.Open();

                int rows = sqlCommandDelete.ExecuteNonQuery();

                if (rows > 0)
                {
                    successFlag = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception catching", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }

            return successFlag;
        }

        public bool updateRow(WeatherInfo tempRow) 
        { 
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // create sql query to update a record in table with the ID is equal with ID of contact choosen in datagridview
                string sqlUpdate = "UPDATE [dbo].tbl_WeatherInformation SET State=@State, City=@City, Date=@Date, Temperature=@Temperature, Humidity=@Humidity, Sunrise=@Sunrise, Sunset=@Sunset, Cloudy=@Cloudy, Windy=@Windy, Rainy=@Rainy WHERE Id=@Id";

                //create sql command to update
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, connection);
                cmdUpdate.Parameters.AddWithValue("@State", tempRow.state);
                cmdUpdate.Parameters.AddWithValue("@City", tempRow.city);
                cmdUpdate.Parameters.AddWithValue("@Date", tempRow.date);
                cmdUpdate.Parameters.AddWithValue("@Temperature", tempRow.temperature);
                cmdUpdate.Parameters.AddWithValue("@Humidity", tempRow.humidity);
                cmdUpdate.Parameters.AddWithValue("@Sunrise", tempRow.sunrise);
                cmdUpdate.Parameters.AddWithValue("@Sunset", tempRow.sunset);
                cmdUpdate.Parameters.AddWithValue("@Cloudy", tempRow.cloudy);
                cmdUpdate.Parameters.AddWithValue("@Windy", tempRow.windy);
                cmdUpdate.Parameters.AddWithValue("@Rainy", tempRow.rainy);
                cmdUpdate.Parameters.AddWithValue("@Id", tempRow.id);

                //open connection with database
                connection.Open();
                int rows = cmdUpdate.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true; // change it into true when update successfull 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception catching", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally 
            {
                connection.Close();
            }
            return isSuccess;
        }
       
        
    }
}
