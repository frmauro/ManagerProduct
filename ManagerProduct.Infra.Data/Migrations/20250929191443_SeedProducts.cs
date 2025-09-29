using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagerProduct.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO ManagerProductDb.Products(Id, Name, Description, Price, Stock, Image, CategoryId) " +
            "VALUES(1, 'Caderno espiral','Caderno espiral 100 fôlhas',7.45,50,'caderno1.jpg',1)");

            migrationBuilder.Sql("INSERT INTO ManagerProductDb.Products(Id, Name, Description, Price, Stock, Image, CategoryId) " +
            "VALUES(2, 'Estojo escolar','Estojo escolar cinza',5.65,70,'estojo1.jpg',1)");

            migrationBuilder.Sql("INSERT INTO ManagerProductDb.Products(Id, Name, Description, Price, Stock, Image, CategoryId) " +
            "VALUES(3, 'Borracha escolar','Borracha branca pequena',3.25,80,'borracha1.jpg',1)");

            migrationBuilder.Sql("INSERT INTO ManagerProductDb.Products(Id, Name, Description, Price, Stock, Image, CategoryId) " +
            "VALUES(4, 'Calculadora escolar','Calculadora simples',15.39,20,'calculadora1.jpg',2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ManagerProductDb.Products");
        }
    }
}
