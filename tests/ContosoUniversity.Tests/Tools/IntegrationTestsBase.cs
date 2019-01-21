using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Tests.Tools
{
    public abstract class IntegrationTestsBase
    {
        private readonly string dbLocation;
        private readonly string dbFilename;
        private readonly string dbTargetFilename;
        private readonly string dbLogTargetFilename;
        private readonly SqlConnectionStringBuilder connectionStringBuilder;

        public string ConnectionString { get; private set; }

        public IntegrationTestsBase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["IntegrationTests"].ConnectionString;
            dbLocation = ConfigurationManager.AppSettings["dbLocation"];
            dbFilename = ConfigurationManager.AppSettings["dbFileName"];
            dbTargetFilename = ConfigurationManager.AppSettings["dbTargetFilename"];
            dbLogTargetFilename = ConfigurationManager.AppSettings["dbLogTargetFilename"];
            connectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
        }

        [OneTimeSetUp]
        public void SettingUpTests()
        {
            CleaningUpPreviousDb();
            SetupUpNewDb();
            ConnectionString = connectionStringBuilder.ConnectionString;
        }

        private void CleaningUpPreviousDb()
        {
            Microsoft.SqlServer.Management.Smo.Server server = new Microsoft.SqlServer.Management.Smo.Server(connectionStringBuilder.DataSource);
            if (server.Databases.Contains(connectionStringBuilder.InitialCatalog))
            {
                server.KillAllProcesses(connectionStringBuilder.InitialCatalog);
                server.DetachDatabase(connectionStringBuilder.InitialCatalog, true);
            }
        }

        private void SetupUpNewDb()
        {
            string currentDirectory = TestContext.CurrentContext.WorkDirectory;
            string path = Path.Combine(currentDirectory, dbLocation, dbFilename);
            string targetPath = Path.Combine(currentDirectory, dbLocation, dbTargetFilename);
            File.Copy(path, targetPath, true);
            File.Delete(Path.Combine(currentDirectory, dbLocation, dbLogTargetFilename));
            connectionStringBuilder.AttachDBFilename = targetPath;
        }

        [OneTimeTearDown]
        public void CleaningUpTests()
        {

        }
    }
}
