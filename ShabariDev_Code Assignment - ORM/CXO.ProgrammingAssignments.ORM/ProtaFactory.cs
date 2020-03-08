using CXO.ProgrammingAssignments.ORM.Interfaces;

namespace CXO.ProgrammingAssignments.ORM
{
    /// <summary>
    /// Database type - Prota factory class
    /// </summary>
    public class ProtaFactory : IDatabaseTypes
    {
        /// <summary>
        /// Creates a new instance of the database type - Prota
        /// </summary>
        /// <returns>DatabaseTypes object</returns>
        public DatabaseQuery GetDatabaseType()
        {
            return new Prota();
        }
    }
}
