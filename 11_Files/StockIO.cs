using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _11_Files
{
    internal class StockIO : IStockRepository

        {

        Dictionary<long, Stock> database = new Dictionary<long, Stock>();
        public int nextId { get; private set; }
        public Stock stock { get; private set; }

        public StockIO()
        {
        }

        internal void WriteStock(StringWriter sw, Stock hp)
        {
            throw new NotImplementedException();
        }

        internal Stock ReadStock(StringReader data)
        {
           throw new NotImplementedException();
        }

        internal void WriteStock(FileInfo output, Stock hp)
        {
            throw new NotImplementedException();
        }

        internal Stock ReadStock(FileInfo output)
        {
            throw new NotImplementedException();
        }

        public long NextId()
        {
            nextId++;
            return nextId;
        }

        public void SaveStock(Stock yhoo)
        {
            database.Add(nextId, stock);
            NextId();
        }

        public Stock LoadStock(long id)
        {
            if (database.ContainsKey(id)) return database[id];
            else return null;
        }

        public void Clear()
        {
            database.Clear();
        }

        public ICollection FindAllStocks()
        {
            return database;
        }
    }
}