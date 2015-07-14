using System;
using FluentMigrator;

namespace TestTask3.Data.Migrations
{
    /// <summary>
    /// Тестовые данные
    /// </summary>
    [Migration(2)]
    public class InitialDataData : Migration
    {
        public override void Up()
        {
            #region Отделы

            Insert.IntoTable("Departments").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Компания"
            });

            #endregion Отделы

            #region Должности

            Insert.IntoTable("Positions").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Грузчик"
            });

            Insert.IntoTable("Positions").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Кассир"
            });

            Insert.IntoTable("Positions").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Курьер"
            });

            Insert.IntoTable("Positions").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Повар"
            });

            Insert.IntoTable("Positions").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Продавец"
            });

            Insert.IntoTable("Positions").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Руководитель отдела"
            });

            Insert.IntoTable("Positions").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Старший кассир"
            });

            Insert.IntoTable("Positions").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Уборщик"
            });

            #endregion Должности

            #region Сотрудники

            Insert.IntoTable("Employees").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Администратор"
            });

            Insert.IntoTable("Employees").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Акимов Андрей"
            });

            Insert.IntoTable("Employees").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Белинский Борис"
            });

            Insert.IntoTable("Employees").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Васильев Вячеслав"
            });

            Insert.IntoTable("Employees").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Гусев Григорий"
            });

            #endregion Сотрудники

            #region Отчет

            Insert.IntoTable("Report").Row(new
            {
                Employee = "Администратор",
                Date = new DateTime(2015, 7, 10),
                Department = "Компания",
                Position = "Руководитель отдела",
                PlanStart = "9:00",
                Norm = "8:00",
                WorkedOut = "",
                Late = "",
                Details = "Незарегистрированное отсутствие"
            });

            Insert.IntoTable("Report").Row(new
            {
                Employee = "Акимов Андрей",
                Date = new DateTime(2015, 7, 10),
                Department = "Компания",
                Position = "Кассир",
                PlanStart = "9:00",
                Norm = "8:00",
                WorkedOut = "4:25",
                Late = "4:35",
                Details = "13:35 ... 18:00 Отработано"
            });

            Insert.IntoTable("Report").Row(new
            {
                Employee = "Белинский Борис",
                Date = new DateTime(2015, 7, 10),
                Department = "Компания",
                Position = "Грузчик",
                PlanStart = "9:00",
                Norm = "8:00",
                WorkedOut = "1:25",
                Late = "4:35",
                Details = "13:35 ... 15:00 Отработано"
            });

            Insert.IntoTable("Report").Row(new
            {
                Employee = "Акимов Андрей",
                Date = new DateTime(2015, 7, 11),
                Department = "Компания",
                Position = "Кассир",
                PlanStart = "9:00",
                Norm = "8:00",
                WorkedOut = "",
                Late = "",
                Details = "Незарегистрированное отсутствие"
            });

            Insert.IntoTable("Report").Row(new
            {
                Employee = "Акимов Андрей",
                Date = new DateTime(2015, 7, 12),
                Department = "Компания",
                Position = "Кассир",
                PlanStart = "9:00",
                Norm = "8:00",
                WorkedOut = "",
                Late = "",
                Details = "Незарегистрированное отсутствие"
            });

            Insert.IntoTable("Report").Row(new
            {
                Employee = "Акимов Андрей",
                Date = new DateTime(2015, 7, 13),
                Department = "Компания",
                Position = "Кассир",
                PlanStart = "9:00",
                Norm = "8:00",
                WorkedOut = "",
                Late = "",
                Details = "Незарегистрированное отсутствие"
            });

            Insert.IntoTable("Report").Row(new
            {
                Employee = "Акимов Андрей",
                Date = new DateTime(2015, 7, 14),
                Department = "Компания",
                Position = "Кассир",
                PlanStart = "9:00",
                Norm = "8:00",
                WorkedOut = "",
                Late = "",
                Details = "Незарегистрированное отсутствие"
            });

            #endregion Отчет
        }

        public override void Down()
        {
            Delete.FromTable("Report");
        }
    }
}