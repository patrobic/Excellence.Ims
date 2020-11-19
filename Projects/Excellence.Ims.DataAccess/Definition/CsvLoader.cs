using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Excellence.Ims.DataAccess.Definition
{
    public class CsvLoader
    {
        private readonly string _path;
        private readonly DatabaseContext _context;

        public CsvLoader(DatabaseContext context, string path)
        {
            _path = path;
            _context = context;
        }

        public void LoadData(List<Type> types)
        {
            types.ForEach(type =>
            {
                using var reader = new StreamReader(Path.Combine(_path, type.Name + ".csv"));
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                var records = csv.GetRecords(type);
                _context.GetType().GetProperty(type.Name).SetValue(_context, records);
            });

            //foreach (var type in _types)
            //{
            //    string name = type.Name;

            //    using (var reader = new StreamReader(name + ".csv"))
            //    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //    {
            //        var records = csv.GetRecords(type);

            //        _context.GetType().GetProperty(name).SetValue(_context, records);
            //    }
            //}
        }

    }
}
