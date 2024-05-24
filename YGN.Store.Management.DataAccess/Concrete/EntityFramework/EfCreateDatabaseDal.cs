using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Database;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfCreateDatabaseDal : EfGenericRepositoryBase<DatabaseConfig, YGNContext>, ICreateDatabaseDal
    {
        //public DatabaseConfig CreateDatabase()
        //{
        //    DatabaseConfig result = new DatabaseConfig();

        //    try
        //    {
        //        string serverName = ConfigurationManager.AppSettings["ServerName"];
        //        string databaseName = ConfigurationManager.AppSettings["DatabaseName"];
        //        string databaseUserName = ConfigurationManager.AppSettings["DatabaseUserName"];
        //        string databasePassword = ConfigurationManager.AppSettings["DatabasePassword"];

        //        string connectionString = $"Server={serverName}; User Id={databaseUserName}; Password={databasePassword}";

        //        string dbInit = string.Format(Resource1.DbInit, databaseName);
        //        string dbTools = string.Format(Resource1.DB_INIT_2,databaseName);

        //       using (var connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            SqlCommand cmd = new SqlCommand(dbInit, connection);
        //            cmd.ExecuteNonQuery();
        //        }
        //        using (var connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            SqlCommand cmd = new SqlCommand(dbTools, connection);
        //            cmd.ExecuteNonQuery();
        //            connection.Dispose();
        //            result.Status = true;
        //            result.Message = "Veritabanı Başarıyla Oluşturuldu.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Status = false;
        //        result.Message = $"Veritabanı Oluşturulurken Hata Meydana Geldi: {ex.Message}";
        //    }

        //    return result;
        //}
        public class DatabaseConfig2
        {
            public string ConnectionString { get; set; }
            public string DatabaseName { get; set; }
            public string Message { get; set; }
        }
        public DatabaseConfig CreateDatabase()
        {
            string serverName = ConfigurationManager.AppSettings["ServerName"];
            string databaseName = ConfigurationManager.AppSettings["DatabaseName"];
            string databaseUserName = ConfigurationManager.AppSettings["DatabaseUserName"];
            string databasePassword = ConfigurationManager.AppSettings["DatabasePassword"];
            string connectionString = $"Server={serverName}; User Id={databaseUserName}; Password={databasePassword}";

            string dbInit = string.Format(Resource1.DbInit, databaseName);
            string dbTools = string.Format(Resource1.DB_INIT_2, databaseName);

            var result = new DatabaseConfig { DatabaseName = databaseName, ConnectionString = connectionString };
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    //var createDbCommand = $"CREATE DATABASE [{databaseName}] {dbTools}";
                    using (var command = new SqlCommand(dbInit, connection))
                    {
                        command.ExecuteNonQuery();

                    }

                }
                using (var connection = new SqlConnection(connectionString))
                {
                    string str = string.Format("USE {0}\r\n\r\n/****** Object:  Table [dbo].[Clients]    Script Date: 18.05.2024 17:11:18 ******/\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\nCREATE TABLE [dbo].[Clients](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[ClientCode] [nvarchar](100) NULL,\r\n\t[ClientName] [nvarchar](100) NOT NULL,\r\n\t[ClientSurname] [nvarchar](100) NULL,\r\n\t[Address] [nvarchar](200) NULL,\r\n\t[TelNr1] [nvarchar](50) NULL,\r\n\t[TelNr2] [nvarchar](50) NULL,\r\n\t[FirmDescription] [nvarchar](150) NULL,\r\n\t[TaxIdentificationNumber] [nvarchar](50) NULL,\r\n CONSTRAINT [PK_dbo.Clients] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\n\r\n/****** Object:  Table [dbo].[Items]    Script Date: 18.05.2024 17:11:18 ******/\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\nCREATE TABLE [dbo].[Items](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[ItemCode] [nvarchar](100) NULL,\r\n\t[ItemName] [nvarchar](150) NULL,\r\n\t[UnitPrice] [float] NULL,\r\n\t[Brand] [nvarchar](100) NULL,\r\n\t[Amount] [int] NULL,\r\n CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\n\r\n/****** Object:  Table [dbo].[OrderLines]    Script Date: 18.05.2024 17:11:18 ******/\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\nCREATE TABLE [dbo].[OrderLines](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[ItemId] [int] NOT NULL,\r\n\t[Amount] [int] NOT NULL,\r\n\t[DateTime] [datetime] NOT NULL,\r\n\t[LineTotal] [decimal](18, 2) NOT NULL,\r\n\t[OrderId] [int] NOT NULL,\r\n\t[IOCode] [int] NOT NULL,\r\n CONSTRAINT [PK_dbo.OrderLines] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nGO\r\n/****** Object:  Table [dbo].[Orders]    Script Date: 18.05.2024 17:11:18 ******/\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\n\r\nCREATE TABLE [dbo].[Orders](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[DateTime] [datetime] NOT NULL,\r\n\t[TotalPrice] [decimal](18, 2) NOT NULL,\r\n\t[IOCode] [int] NOT NULL,\r\n\t[ClientId] [int] NOT NULL,\r\n CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\n\r\n/****** Object:  Table [dbo].[Reports]    Script Date: 18.05.2024 17:11:18 ******/\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\nCREATE TABLE [dbo].[Reports](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[ReportName] [nvarchar](100) NULL,\r\n\t[ReportBinaryData] [nvarchar](max) NULL,\r\n CONSTRAINT [PK_dbo.Reports] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\n\r\n/****** Object:  Table [dbo].[Users]    Script Date: 18.05.2024 17:11:18 ******/\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\nCREATE TABLE [dbo].[Users](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[UserName] [nvarchar](max) NULL,\r\n\t[Password] [nvarchar](max) NULL,\r\n\t[NameSurname] [nvarchar](max) NULL,\r\n\t[Email] [nvarchar](max) NULL,\r\n\t[Gender] [nvarchar](max) NULL,\r\n\t[BirthDate] [date] NULL,\r\n\t[CreatedDate] [date] NULL,\r\n\t[TelNr1] [nvarchar](max) NULL,\r\n\t[TelNr2] [nvarchar](max) NULL,\r\n CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\nGO\r\nALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OrderLines_dbo.Items_ItemId] FOREIGN KEY([ItemId])\r\nREFERENCES [dbo].[Items] ([Id])\r\nON DELETE CASCADE\r\nGO\r\nALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_dbo.OrderLines_dbo.Items_ItemId]\r\nGO\r\nALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OrderLines_dbo.Orders_OrderId] FOREIGN KEY([OrderId])\r\nREFERENCES [dbo].[Orders] ([Id])\r\nON DELETE CASCADE\r\nGO\r\nALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_dbo.OrderLines_dbo.Orders_OrderId]\r\n\r\n/****** Object:  StoredProcedure [dbo].[TEST_TOTALPRICE]    Script Date: 18.05.2024 17:11:18 ******/\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\nGO",databaseName);

                    connection.Open();
                    //var createDbCommand = $"CREATE DATABASE [{databaseName}] {dbTools}";
                    using (var command = new SqlCommand(str, connection))
                    {
                        command.ExecuteNonQuery();   
                    }

                }
                result.Status = true;
                result.Message = "Database created successfully.";

                // Create tables and procedures
                //CreateTablesAndProcedures(result);

            }
            catch (Exception ex)
            {
                result.Message = $"Error creating database: {ex.Message}";
            }
            return result;
        }

        private void CreateTablesAndProcedures(DatabaseConfig config)
        {
            string serverName = ConfigurationManager.AppSettings["ServerName"];
            string databaseName = ConfigurationManager.AppSettings["DatabaseName"];
            string databaseUserName = ConfigurationManager.AppSettings["DatabaseUserName"];
            string databasePassword = ConfigurationManager.AppSettings["DatabasePassword"];
            string connectionString = $"Server={serverName}; User Id={databaseUserName}; Password={databasePassword}";
            string dbInit = string.Format(Resource1.DbInit, databaseName);
            string dbTools = string.Format(Resource1.DB_INIT_2, databaseName);

            var createTableScripts = dbTools;

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(createTableScripts, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                config.Message += " Tables and procedures created successfully.";
            }
            catch (Exception ex)
            {
                config.Message += $" Error creating tables/procedures: {ex.Message}";
            }
        }
    }
}
