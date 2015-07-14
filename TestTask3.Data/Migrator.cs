using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;
using FluentMigrator.Runner.Processors.SqlServer;

namespace TestTask3.Data
{
    /// <summary>
    /// Database migration
    /// </summary>
    public class Migrator
    {
        readonly string _connectionString;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="connectionString">Connection string</param>
        public Migrator(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Migration options
        /// </summary>
        private class MigrationOptions : IMigrationProcessorOptions
        {
            public bool PreviewOnly { get; set; }
            public int Timeout { get; set; }
            public string ProviderSwitches { get; set; }
        }

        /// <summary>
        /// Load migrations, run migrations
        /// </summary>
        /// <param name="runnerAction">Action (Up/Down)</param>
        public void Migrate(Action<IMigrationRunner> runnerAction)
        {
            var options = new MigrationOptions { PreviewOnly = false, Timeout = 0 };
            var factory = new SqlServer2012ProcessorFactory(); ;
            var assembly = Assembly.GetExecutingAssembly();

            var announcer = new TextWriterAnnouncer(s => Debug.WriteLine(s));
            var migrationContext = new RunnerContext(announcer);
            var processor = factory.Create(_connectionString, announcer, options);
            var runner = new MigrationRunner(assembly, migrationContext, processor);
            runnerAction(runner);
        }
    }
}
