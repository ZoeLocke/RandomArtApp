using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using System.Collections.Generic;

namespace RandomArtApp.Data {
    public class RecordService {
        public Task<Models.Record> GetRecordsAsync(string NounType){
            var reader = new StreamReader("data.csv");
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            Models.Record[] records = csv.GetRecords<Models.Record>().ToArray();
            Models.Record[] filtered = records.AsQueryable() .Where(x => x.NounType == NounType).ToArray();
            Random random = new Random();
            int entry = random.Next(0, filtered.Length);
            return Task.FromResult(filtered[entry]);
        }
    }
}