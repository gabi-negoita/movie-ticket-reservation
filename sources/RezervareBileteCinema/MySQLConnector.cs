using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RezervareBileteCinema
{
    class MySQLConnector
    {
        private readonly string server = "localhost";
        private readonly string user = "root";
        private readonly string database = "paoo";
        private readonly int port = 3306;
        private readonly string password = "root";

        public MySqlConnection OpenConnection(MySqlConnection connection)
        {
            connection = new MySqlConnection("server=" + server + ";user=" + user+ ";database=" + database + ";port=" + port + ";password=" + password);

            try
            {
                connection.Open();
                Console.WriteLine("\n::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("Connection opened.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to open connection. Cause: {0}", e.ToString());
            }

            return connection;
        }
        public MySqlDataReader ExecuteQuery(MySqlConnection connection, string query)
        {
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                Console.WriteLine("EXECUTED QUERY:\t{0}\n", query);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to execute query. Cause: {0}", e.ToString());
            }

            return reader;
        }
        public void CloseConnection(MySqlConnection connection)
        {
            try
            {
                connection.Close();
                Console.WriteLine("Connection closed.");
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to close connection. Cause: {0}", e.ToString());
            }
        }

        public List<string> GetTitluFilm()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT film.TITLU " +
                "FROM film";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            List<string> titluFilm = new List<string>();
            try
            {
                while (results.Read())
                {
                    titluFilm.Add(results.GetString(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            // Closing the connection
            CloseConnection(connection);

            return titluFilm;
        }

        public DateTime GetMinDate()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT min(distinct(data)) " +
                "FROM rulare_film";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            DateTime minDate = new DateTime();
            try
            {
                while (results.Read())
                {
                    minDate = results.GetDateTime(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return minDate;
        }
        public int GetYearMinDate()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT year(min(distinct(data))) " +
                "FROM rulare_film";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int yearMinDate = 0;
            try
            {
                while (results.Read())
                {
                    yearMinDate = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return yearMinDate;
        }
        public int GetMonthMinDate()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT month(min(distinct(data))) " +
                "FROM rulare_film";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int monthMinDate = 0;
            try
            {
                while (results.Read())
                {
                    monthMinDate = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return monthMinDate;
        }
        public int GetDayMinDate()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT day(min(distinct(data))) " +
                "FROM rulare_film";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int dayMinDate = 0;
            try
            {
                while (results.Read())
                {
                    dayMinDate = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return dayMinDate;
        }

        public DateTime GetMaxDate()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT max(distinct(data)) " +
                "FROM rulare_film";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            DateTime maxDate = new DateTime();
            try
            {
                while (results.Read())
                {
                    maxDate = results.GetDateTime(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return maxDate;
        }
        public int GetYearMaxDate()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT year(max(distinct(data))) " +
                "FROM rulare_film";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int yearMaxDate = 0;
            try
            {
                while (results.Read())
                {
                    yearMaxDate = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return yearMaxDate;
        }
        public int GetMonthMaxDate()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT month(max(distinct(data))) " +
                "FROM rulare_film";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int monthMaxDate = 0;
            try
            {
                while (results.Read())
                {
                    monthMaxDate = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return monthMaxDate;
        }
        public int GetDayMaxDate()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT day(max(distinct(data))) " +
                "FROM rulare_film";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int dayMaxDate = 0;
            try
            {
                while (results.Read())
                {
                    dayMaxDate = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return dayMaxDate;
        }

        public List<string> GetMovieTitleByDate(DateTime date)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT titlu " +
                "FROM film, rulare_film " +
                "WHERE film.codf = rulare_film.codf " +
                "AND rulare_film.DATA = str_to_date('" + date + "', '%m/%d/%Y %T') " +
                "GROUP BY rulare_film.ORA";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            List<string> filmByDate = new List<string>();
            try
            {
                while (results.Read())
                {
                    filmByDate.Add(results.GetString(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return filmByDate;
        }

        public int GetMovieCodeByTitle(string titlu)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT film.CODF " +
                "FROM film " +
                "WHERE film.TITLU = '" + titlu + "'";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int codf = 0;
            try
            {
                while (results.Read())
                {
                    codf = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return codf;
        }

        public string GetOraFilmByTitleAndDate(string title, DateTime date)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT rulare_film.ORA " +
                "FROM film, rulare_film " +
                "WHERE film.CODF = rulare_film.CODF " +
                "AND film.TITLU = '"+ title +"' " +
                "AND rulare_film.DATA = str_to_date('" + date + "', '%m/%d/%Y %T')";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            string OraFilm = null;
            try
            {
                while (results.Read())
                {
                    OraFilm = results.GetString(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return OraFilm;
        }

        public string GetDurataFilmByTitleAndDate(string title, DateTime date)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT film.DURATA " +
                "FROM film, rulare_film " +
                "WHERE film.CODF = rulare_film.CODF " +
                "AND film.TITLU = '" + title + "' " +
                "AND rulare_film.DATA = str_to_date('" + date + "', '%m/%d/%Y %T')";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            string DurataFilm = null;
            try
            {
                while (results.Read())
                {
                    DurataFilm = results.GetString(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return DurataFilm;
        }

        public int GetStareScaun(int rowNumber, int seatNumber)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT scaun.STARE " +
                "FROM scaun " +
                "WHERE scaun.NR_RAND = " + rowNumber + " " +
                "AND scaun.NR_LOC = " + seatNumber;
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int StareScaun = int.MaxValue;
            try
            {
                while (results.Read())
                {
                    StareScaun = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return StareScaun;
        }

        public void SetStareScaun(int rowNumber, int seatNumber, int stare)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "UPDATE scaun " +
                "SET scaun.STARE = " + stare + " " +
                "WHERE scaun.NR_RAND = " + rowNumber + " " +
                "AND scaun.NR_LOC = " + seatNumber;
            ExecuteQuery(connection, query);

            // Closing the connection
            CloseConnection(connection);
        }

        public string GetUserPassword(string username)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT user.PASSWORD " +
                "FROM user " +
                "WHERE user.USERNAME = '" + username + "'";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            string UserPassword = null;
            try
            {
                while (results.Read())
                {
                    UserPassword = results.GetString(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return UserPassword;
        }

        public void InsertRezervare(string titluFilm, string nume, string telefon, int numarBilete, double pretTotal)
        {
            int codf = GetMovieCodeByTitle(titluFilm);

            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "INSERT INTO rezervare (CODF, NUME, TELEFON, NR_BILETE, PRET_TOTAL) " +
                "VALUES (" + codf + ", " + "'" + nume + "', " + "'" + telefon + "', " + numarBilete + ", " + pretTotal + ")";
            ExecuteQuery(connection, query);

            // Closing the connection
            CloseConnection(connection);
        }

        public int GetLastRezervareCode()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT max(rezervare.CODR) " +
                "FROM rezervare";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int MaxCodr = 0;
            try
            {
                while (results.Read())
                {
                    MaxCodr = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return MaxCodr;
        }
        public int GetScaunCodeByRowAndSeat(int row, int seat)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT scaun.CODS " +
                "FROM scaun " +
                "WHERE scaun.NR_RAND = " + row + " " +
                "AND scaun.NR_LOC = " + seat;
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int Cods = 0;
            try
            {
                while (results.Read())
                {
                    Cods = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return Cods;
        }
        public int GetRulareFilmCodeByTitleAndDate(string title, DateTime date)
        {
            int codf = GetMovieCodeByTitle(title);

            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT rulare_film.CODRF " +
                "FROM rulare_film " +
                "WHERE rulare_film.CODF = " + codf + " " +
                "AND rulare_film.DATA = str_to_date('" + date + "', '%m/%d/%Y %T')";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int Cods = 0;
            try
            {
                while (results.Read())
                {
                    Cods = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return Cods;
        }

        public void InsertRezervareScaun(int row, int seat, string title, DateTime date, int codp)
        {
            int codr = GetLastRezervareCode();
            int cods = GetScaunCodeByRowAndSeat(row, seat);
            int codrf = GetRulareFilmCodeByTitleAndDate(title, date);

            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "INSERT INTO rezervare_scaun (CODR, CODS, CODRF, CODP) " +
                "VALUES (" + codr + ", " + cods + ", " + codrf + ", " + codp + ")";
            ExecuteQuery(connection, query);

            // Closing the connection
            CloseConnection(connection);
        }

        public List<int> GetRezervareCode()
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT rezervare.CODR " +
                "FROM rezervare " +
                "ORDER BY rezervare.CODR";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            List<int> CoduriRezervare = new List<int>();
            try
            {
                while (results.Read())
                {
                    CoduriRezervare.Add(results.GetInt32(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return CoduriRezervare;
        }

        public string GetNumeRezervare(int codr)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT rezervare.NUME " +
                "FROM rezervare " +
                "WHERE rezervare.CODR = " + codr;
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            string NumeRezervare = null;
            try
            {
                while (results.Read())
                {
                    NumeRezervare = results.GetString(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return NumeRezervare;
        }

        public string GetTelefonRezervare(int codr)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT rezervare.TELEFON " +
                "FROM rezervare " +
                "WHERE rezervare.CODR = " + codr;
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            string NumeRezervare = null;
            try
            {
                while (results.Read())
                {
                    NumeRezervare = results.GetString(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return NumeRezervare;
        }

        public string GetTitluFilmRezervare(int codr)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT film.TITLU " +
                "FROM film " +
                "WHERE film.CODF = (" +

                "SELECT rezervare.CODF " +
                "FROM rezervare " +
                "WHERE rezervare.CODR = " + codr + ")";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            string NumeRezervare = null;
            try
            {
                while (results.Read())
                {
                    NumeRezervare = results.GetString(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return NumeRezervare;
        }

        public int GetNumarBileteRezervare(int codr)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT rezervare.NR_BILETE " +
                "FROM rezervare " +
                "WHERE rezervare.CODR = " + codr;
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            int NumarBilete = 0;
            try
            {
                while (results.Read())
                {
                    NumarBilete = results.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return NumarBilete;
        }

        public List<int> GetRandScaunRezervare(int codr)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT scaun.NR_RAND " +
                "FROM scaun " +
                "WHERE scaun.CODS IN (" +

                "SELECT rezervare_scaun.CODS " +
                "FROM rezervare_scaun " +
                "WHERE rezervare_scaun.CODR = " + codr + " " +
                "ORDER BY rezervare_scaun.CODS)";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            List<int> CoduriRezervare = new List<int>();
            try
            {
                while (results.Read())
                {
                    CoduriRezervare.Add(results.GetInt32(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return CoduriRezervare;
        }

        public List<int> GetLocScaunRezervare(int codr)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT scaun.NR_LOC " +
                "FROM scaun " +
                "WHERE scaun.CODS IN (" +

                "SELECT rezervare_scaun.CODS " +
                "FROM rezervare_scaun " +
                "WHERE rezervare_scaun.CODR = " + codr + " " +
                "ORDER BY rezervare_scaun.CODS)";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            List<int> CoduriRezervare = new List<int>();
            try
            {
                while (results.Read())
                {
                    CoduriRezervare.Add(results.GetInt32(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return CoduriRezervare;
        }

        public DateTime GetDataRezervare(int codr)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT rulare_film.DATA " +
                "FROM rulare_film " +
                "WHERE rulare_film.CODF = (" +

                "SELECT rezervare.CODF " +
                "FROM rezervare " +
                "WHERE rezervare.CODR = " + codr + ")";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            DateTime DataRezervare = new DateTime();
            try
            {
                while (results.Read())
                {
                    DataRezervare = results.GetDateTime(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return DataRezervare;
        }

        public string GetOraRezervare(int codr)
        {
            // Opening the connection 
            MySqlConnection connection = null;
            connection = OpenConnection(connection);

            // Executing query
            string query = "SELECT rulare_film.ORA " +
                "FROM rulare_film " +
                "WHERE rulare_film.CODF = (" +

                "SELECT rezervare.CODF " +
                "FROM rezervare " +
                "WHERE rezervare.CODR = " + codr + ")";
            MySqlDataReader results = ExecuteQuery(connection, query);

            // Getting the data
            string OraRezervare = null;
            try
            {
                while (results.Read())
                {
                    OraRezervare = results.GetString(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Closing the connection
            CloseConnection(connection);

            return OraRezervare;
        }
    }
}
