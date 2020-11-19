using Excellence.Ims.DataAccess;
using Excellence.Ims.DataAccess.Definition;
using Excellence.Ims.DataAccess.Tables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Type = Excellence.Ims.DataAccess.Tables.Type;

namespace Excellence.Ims.Test
{
    public class DbInitializerTest
    {
        private DatabaseContext dbContext = new DatabaseContext();

        private DbInitializer dbInitializer;

        private CsvLoader csvLoader;

        private string testCsvFolder = Directory.GetCurrentDirectory();

        public DbInitializerTest()
        {
            dbInitializer = new DbInitializer(dbContext);

            csvLoader = new CsvLoader(dbContext);
        }

        [Fact]
        public void DbInitializeTest()
        {
            dbInitializer.Initialize();
        }

        [Fact]
        public void CsvLoaderTest()
        {
            csvLoader.LoadData(new List<System.Type> { typeof(ShippingClass), typeof(Warranty) });

            Assert.True(dbContext.ShippingClass.Count() == 3);
            Assert.True(dbContext.Warranty.Count() == 3);
        }
    }
}
