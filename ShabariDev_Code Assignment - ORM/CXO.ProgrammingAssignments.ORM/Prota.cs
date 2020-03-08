using CXO.ProgrammingAssignments.ORM.Interfaces;
using CXO.ProgrammingAssignments.ORM.Model;

namespace CXO.ProgrammingAssignments.ORM
{
    /// <summary>
    /// Database type - Prota class
    /// </summary>
    public class Prota : DatabaseQuery
    {
        private EntityModel _model = new EntityModel();

        /// <summary>
        /// Form the insert query for database type - Prota
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>Insert string sql</returns>
        public override string InsertQuery(object obj)
        {
            return string.Format($"Insert into { obj } ({ nameof(_model.Id) }, { nameof(_model.Name) }) values(@Id, @Name)");
        }

        /// <summary>
        /// Form the update query for database type - Prota
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>Update string sql</returns>
        public override string UpdateQuery(object obj)
        {
            return string.Format($"update { obj } set { nameof(_model.Name) } = @Name where { nameof(_model.Id) } = @Id");
        }
    }
}
