using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace TestTask3.Data.Migrations
{
    [Migration(2)]
    public class InitialDataData : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Departments").Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Компания"
            });

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

            Insert.IntoTable("Report").Row(new
            {
                Employee = "Акимов Андрей",
                Date = new DateTime(2015, 7, 10),
                Department = "Отдел"
            });
        }

        public override void Down()
        {
            Delete.FromTable("Report");
        }
    }
}