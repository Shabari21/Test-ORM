namespace CXO.ProgrammingAssignments.ORM.Interfaces
{
    /// <summary>
    /// Database query class with Insert and Update query abstarct methods.
    /// </summary>
    public abstract class DatabaseQuery
    {
        public abstract string InsertQuery(object _model);
        public abstract string UpdateQuery(object _model);
    }
}
