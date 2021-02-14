using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DI03_2_ClassLibrary
{
    internal class DataAccess
    {
        // connection string para conectarse a la base de datos local AdventureWorks2016
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdventureWorks2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<ProductModel> GetProductModelsById(int modelID)
        {
            // Obtiene los datos del productmodel, con imagen y precio
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 
                string sql =
                    "SELECT pm.ProductModelID AS ProductModelID, pm.Name AS ProductModelName, p.ListPrice AS ListPrice, pp.LargePhoto AS LargePhoto, p.Size AS Size " +
                    "FROM Production.ProductModel pm " +
                    "INNER JOIN Production.Product p ON pm.ProductModelID = p.ProductModelID " +
                    "JOIN Production.ProductProductPhoto ppp ON ppp.ProductID = p.ProductID " +
                    "JOIN Production.ProductPhoto pp ON pp.ProductPhotoID = ppp.ProductPhotoID " +
                    $"WHERE p.ProductModelID = {modelID}";

                return connection.Query<ProductModel>(sql).ToList();
            }
        }

        public List<ProductAndSize> GetProductAndSizes(int modelID)
        {
            // Obtiene los sizes y productId relacionados con el productmodel
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql =
                    "SELECT p.Size AS Size, p.ProductID AS ProductID " +
                    "FROM Production.Product p " +
                    "INNER JOIN Production.ProductModel pm ON pm.ProductModelID = p.ProductModelID " +
                    $"WHERE pm.ProductModelID = {modelID}";

                return connection.Query<ProductAndSize>(sql).ToList();
            }
        }

        public List<int> GetProductModelIDs()
        {
            // Obtiene los productModel en la base de datos que se relacionan con product
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql =
                    "SELECT DISTINCT pm.ProductModelID " +
                    "FROM Production.ProductModel pm " +
                    "INNER JOIN Production.Product p ON pm.ProductModelID = p.ProductModelID " +
                    "ORDER BY pm.ProductModelID ASC";

                return connection.Query<int>(sql).ToList();
            }
        }
    }
}