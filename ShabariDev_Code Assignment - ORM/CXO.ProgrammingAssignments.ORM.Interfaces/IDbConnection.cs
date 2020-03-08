namespace CXO.ProgrammingAssignments.ORM.Interfaces
{
    /// <summary>
    /// The IDbConnection interface with Execute method.
    /// </summary>
    public interface IDbConnection
    {
        void Execute(string sql);
    }
}
