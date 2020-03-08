namespace CXO.ProgrammingAssignments.ORM.Interfaces
{
    /// <summary>
    /// The IDbContext interface with Insert and Update methods.
    /// </summary>
    public interface IDbContext
    {
        void Insert(object obj);
        void Update(object obj);
    }
}