using FluentMigrator;

namespace TestTask3.Data.Migrations
{
    /// <summary>
    /// Создание структуры базы
    /// </summary>
    [Migration(1)]
    public class InitialCreate : Migration
    {
        public override void Up()
        {
            // Подразделения
            Create.Table("Departments")
                .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString().NotNullable();

            // Должности
            Create.Table("Positions")
                .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString().NotNullable();

            // Сотрудники
            Create.Table("Employees")
                .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString().NotNullable();

            // Отчет
            Create.Table("Report")
                .WithColumn("Employee").AsString().Nullable() // Полное имя
                .WithColumn("Date").AsDate().Nullable() // Дата
                .WithColumn("Department").AsString().Nullable() // Отдел
                .WithColumn("Position").AsString().Nullable() // Должность
                .WithColumn("PlanStart").AsString().Nullable() // Начало смены
                .WithColumn("Norm").AsString().Nullable() // Норма
                .WithColumn("WorkedOut").AsString().Nullable() // Отработано
                .WithColumn("Late").AsString().Nullable() // Опоздание
                .WithColumn("Details").AsString().Nullable();  // Детали
        }

        public override void Down()
        {
            Delete.Table("Report");
        }
    }
}
