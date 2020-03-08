using System.Collections.Generic;
using CXO.ProgrammingAssignments.ORM.Interfaces;

namespace CXO.ProgrammingAssignments.ORM.Tests
{
    public class TestDbConnection : IDbConnection
    {
        public List<string> ExecutedCommands { get; } = new List<string>();

        public void Execute(string sql)
        {
            ExecutedCommands.Add(sql);
        }
    }
}
