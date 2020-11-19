using CsvHelper;
using Excellence.Ims.DataAccess.Definition;
using Excellence.Ims.DataAccess.Tables;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Excellence.Ims.DataAccess
{
    public class DbInitializer
    {
        private string _path = Directory.GetCurrentDirectory(); // TODO: get path of Data project/Csv folder

        private readonly DatabaseContext _context;

        readonly List<string> Categories = new List<string>
        {
            "Includes",
            "Lighting",
            "Controller",
            "Power Supply",
            "Fixture",
        };

        readonly List<string> Type = new List<string>
        {
             "Simple",
             "Variable" ,
             "Variation",
        };
        readonly List<string> ShippingClass = new List<string>
        {
            "Small",
            "Standard",
            "Large",
        };

        public DbInitializer(DatabaseContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            _context.Database.EnsureCreated();

            //InitializeProperties();
            //InitializeRetail();
            //InitializeStorage();

            LoadCsv();

            _context.SaveChanges();
        }

        private void LoadCsv()
        {
            CsvLoader loader = new CsvLoader(_context, _path);
            loader.LoadData(DataTypes.Types);
        }

        private void InitializeProperties()
        {
            Categories.ForEach(x => _context.Category.Add(new Category() { Name = x }));

            _context.AttributeKey.AddRange(new AttributeKey[]
            {

            });

            _context.Category.AddRange(new Category[]
            {

            });
        }

        private void InitializeRetail()
        {
            // Type
            // Type.ForEach(x => _context.Type.Add(new Type() { Name = x }));

            // ShippingClass
            ShippingClass.ForEach(x => _context.ShippingClass.Add(new ShippingClass() { Name = x }));

            // Warranty
            Enumerable.Range(1, 5).ToList().ForEach(x => _context.Warranty.Add(new Warranty { Name = x + " Year Warranty", Years = x }));
        }

        private void InitializeStorage()
        {
            // Location (Toolboxes)
            Enumerable.Range(1, 3).ToList().ForEach(x => _context.Location.Add(new Location { Name = "ToolBox1" }));

            // Location (Organizers)
            Enumerable.Range(1, 3).ToList().ForEach(x =>
            {
                var parent = new Location { Name = "Organizer" + x };
                _context.Location.Add(parent);

                Enumerable.Range(1, 10).ToList().ForEach(x => _context.Location.Add(new Location { Name = "Compartment" + x, Parent = parent }));
            });
        }
    }
}
