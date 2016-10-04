using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository
    {
        Dictionary<long, Stock> repositoryDir = new Dictionary<long, Stock>();

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            
        }

        public int nextId { get; private set; } 
        public Stock stock { get; private set; }

        public void Clear()
        {
            repositoryDir.Clear();
        }

        public ICollection FindAllStocks()
        {
            return repositoryDir;
        }

        public Stock LoadStock(long id)
        {
            if (repositoryDir.ContainsKey(id)) return repositoryDir[id];
            else return null;
        }

        public long NextId()
        {
            nextId++;
            return nextId;
        }

        public void SaveStock(Stock yhoo)
        {
            repositoryDir.Add(nextId, stock);
            NextId();
        }
    }
}