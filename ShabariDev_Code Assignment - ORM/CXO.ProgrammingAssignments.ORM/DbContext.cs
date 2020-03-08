using CXO.ProgrammingAssignments.ORM.Interfaces;
using System;

namespace CXO.ProgrammingAssignments.ORM
{
    /// <summary>
    /// The database context class
    /// </summary>
    public class DbContext : IDbContext
    {
        private string _insertSql;
        private string _updateSql;
        private DbType _dbtype;
        private IDbConnection _dbConnection;
        private readonly Type _type;
        private readonly DatabaseQuery _dbTypeQuery;

        /// <summary>
        /// DbContext constructor - initializes DBType, IDbConnection and the current database type.
        /// </summary>
        /// <param name="dbType">DbType</param>
        /// <param name="dbConnection">IDbConnection</param>
        public DbContext(DbType dbType, IDbConnection dbConnection)
        {
            _dbtype = dbType;
            _dbConnection = dbConnection;

            _type = Type.GetType(string.Format("{0}.{1}", this.GetType().Namespace, string.Format($"{_dbtype}Factory")), true);
            _dbTypeQuery = DatabaseTypeFactory.GetDatabaseType((IDatabaseTypes)Activator.CreateInstance(_type));
        }

        /// <summary>
        ///  Insert into table based on the database type
        /// </summary>
        /// <param name="obj">object as table name</param>
        public void Insert(object obj)
        {
            _insertSql = _dbTypeQuery.InsertQuery(obj);
            _dbConnection.Execute(_insertSql);
        }

        /// <summary>
        /// Update table based on the database type
        /// </summary>
        /// <param name="obj">object as table name</param>
        public void Update(object obj)
        {
            _updateSql = _dbTypeQuery.UpdateQuery(obj);
            _dbConnection.Execute(_updateSql);
        }
    }
}