using GitImprov.Data.Context;

namespace GitImprov.Data.Connection
{
    public class DBConnect
    {
        private readonly static GitImprovContext _dataBase = new();

        public static GitImprovContext DataBase { get => _dataBase; }
    }
}
