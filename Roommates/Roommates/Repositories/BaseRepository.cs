using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roommates.Repositories
{
    public class BaseRepository
    {
        /// <summary>
        ///  A "connection string" is the address of the database.
        /// </summary>
        private string _connectionString;


        /// <summary>
        ///  This constructor will be invoked by subclasses.
        ///  It will save the connection string for later use.
        /// </summary>
        public BaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        /// <summary>
        ///  Represents a connection to the database.
        ///   This is a "tunnel" to connect the application to the database.
        ///   All communication between the application and database passes through this connection.
        /// </summary>
        protected SqlConnection Connection => new SqlConnection(_connectionString);
    }
}
