using System;
using System.Collections;

namespace _11_Files
{
    internal class Stock : IStockRepository
    {
        private int v1;
        private double v2;
        private int v3;

        public Stock(int v1, double v2, int v3)
        {
            Id = v1;
            PricePerShare = v2;
            NumShares = v3;

        }


        public int Id { get; internal set; }
        public int NumShares { get; internal set; }
        public double PricePerShare { get; private set; }

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