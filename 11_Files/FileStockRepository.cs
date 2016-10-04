using System;
using System.Collections;
using System.IO;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository
    {
        private DirectoryInfo repositoryDir;

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public ICollection FindAllStocks()
        {
            throw new NotImplementedException();
        }

        public Stock LoadStock(long id)
        {
            throw new NotImplementedException();
        }

        public long NextId()
        {
            throw new NotImplementedException();
        }

        public void SaveStock(Stock yhoo)
        {
            throw new NotImplementedException();
        }
    }
}