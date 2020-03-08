using CXO.ProgrammingAssignments.ORM.Interfaces;

namespace CXO.ProgrammingAssignments.ORM
{
    /// <summary>
    /// Database type factory class
    /// </summary>
    public class DatabaseTypeFactory
    {
        /// <summary>
        /// Get the database type based on factory pattern
        /// </summary>
        /// <param name="type">IDatabaseTypes</param>
        /// <returns>DatabaseTypes object</returns>
        public static DatabaseQuery GetDatabaseType(IDatabaseTypes type)
        {
            return type.GetDatabaseType();
        }
    }
}
