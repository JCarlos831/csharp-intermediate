using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("/Users/JuanCMontoya/Desktop/log.txt"));
            dbMigrator.Migrate();
        }
    }
}