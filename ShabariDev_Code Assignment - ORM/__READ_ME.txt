============= A library that allows to insert and update POCO objects in a database =======================

As a part of the application process you are invited to build a library that is used to insert and update
POCO objects in a database.

The library should support 2 types of the databases:

1) Prota

For this database the field names must not be surrounded with the square brackets. For example,

insert into MyTable (Id, Name) values ('D6309305-925E-4ED5-9786-6771A79588AF', 'My object name')
update MyTable set Name = 'My new name' where Id = 'D6309305-925E-4ED5-9786-6771A79588AF'

2) Defteros

For this database the field names must be surrounded with the square brackets. For example,

insert into [MyTable] ([Id], [Name]) values ('D6309305-925E-4ED5-9786-6771A79588AF', 'My object name')
update [MyTable] set [Name] = 'My new name' where [Id] = 'D6309305-925E-4ED5-9786-6771A79588AF'

Please take into account the following simplifications:

- Object type name and corresponding table name are equal
- Propery names and the corresponding table field names are equal
- Every POCO object must have a property "Id" of type GUID. This field is also used in the database as the primary key.
- Only string, GUID and integer types of fields are supported

You are supposed to implement class DbContext of project CXO.ProgrammingAssignments.ORM which acts like an entry point to the library.
You are allowed to create new projects, tests, interfaces and classes. You should not change the CXO.ProgrammingAssignments.ORM.Interfaces project.

Please note, the code should indicate the quality of the production code you produce.

And happy coding!

CXO-Cockpit Team.
