namespace TestTask3.Data
{
    /// <summary>
    /// Реализация менеджера миграций
    /// </summary>
    public class MigrationManager : IMigrationManager
    {
        private readonly string _connectionString;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="connectionString">Строка подключения к БД</param>
        public MigrationManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Запуск миграций
        /// </summary>
        public void Start()
        {
            Migrator migrator = new Migrator(_connectionString);
            migrator.Migrate(runner => runner.MigrateUp());
        }
    }
}