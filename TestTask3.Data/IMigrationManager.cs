namespace TestTask3.Data
{
    /// <summary>
    /// Интерфейс менеджера миграций
    /// </summary>
    public interface IMigrationManager
    {
        /// <summary>
        /// Запуск миграций
        /// </summary>
        void Start();
    }
}