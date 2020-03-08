using CXO.ProgrammingAssignments.ORM.Interfaces;

namespace CXO.ProgrammingAssignments.ORM
{
    /// <summary>
    /// Database type Defteros factory class
    /// </summary>
    public class DefterosFactory : IDatabaseTypes
    {
        /// <summary>
        /// Creates an instance of database type - Defteros
        /// </summary>
        /// <returns>DatabaseType</returns>
        public DatabaseQuery GetDatabaseType()
        {
            return new Defteros();
        }
    }
}
