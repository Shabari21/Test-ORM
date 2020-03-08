namespace CXO.ProgrammingAssignments.ORM.Interfaces
{
    /// <summary>
    /// IDatabaseType interface
    /// </summary>
    public interface IDatabaseTypes
    {
        /// <summary>
        /// Get the database query
        /// </summary>
        /// <returns>DatabaseTypes instance</returns>
        DatabaseQuery GetDatabaseType();
    }
}
