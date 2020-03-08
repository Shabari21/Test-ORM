using CXO.ProgrammingAssignments.ORM.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CXO.ProgrammingAssignments.ORM
{
    /// <summary>
    /// The database connection class
    /// </summary>
    public class DbConnection : Interfaces.IDbConnection
    {
        private EntityModel _model;
        private readonly string _connectionString;

        /// <summary>
        /// DbConnection constructor - intitialize EntityModel class
        /// </summary>
        /// <param name="model">EntityModel</param>
        public DbConnection(EntityModel model, string connectionString)
        {
            _model = model;
            _connectionString = connectionString;
        }

        /// <summary>
        /// Executes the sql query and updates the database.
        /// </summary>
        /// <param name="sql">the sql query</param>
        public void Execute(string sql)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand theCommand = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    theCommand.CommandType = CommandType.Text;
                    theCommand.Parameters.Add("@Id", SqlDbType.UniqueIdentifier, 50).Value = _model.Id;
                    theCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = _model.Name;
                    try
                    {
                        theCommand.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
