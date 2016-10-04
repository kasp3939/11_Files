using System;
using System.Collections;
using System.Collections.Generic;

namespace _11_Files
{
    internal class Stock : IStockRepository
    {
        private object obj;
        Dictionary<long, Stock> database = new Dictionary<long, Stock>();
        public Stock()
        {

        }

        public Stock(string v1, double v2, int v3)
        {
            Symbol = v1;
            PricePerShare = v2;
            NumShares = v3;

        }

        public Stock(object obj)
        {
            this.obj = obj;
        }

        public double NumShares
        {
            get;
            internal set;
        }
        public double PricePerShare

        {
            get;
            internal set;
        }

        public string Symbol
        {
            get;
            internal set;
        }
        public int Id { get; internal set; }
        public int nextId { get; private set; }
        public Stock stock { get; private set; }

        public double GetValue()
        {

            return NumShares * PricePerShare;
        }

        internal static double TotalValue(Stock[] stocks)
        {

            double sum = 0;

            foreach
                (Stock stock in stocks)
            { sum += stock.GetValue(); }

            return sum;
        }

        public override string ToString()
        {
            return "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare
                + ",numShares=" + NumShares + "]";
        }

        public override bool Equals(object obj)
        {
            Stock s = (Stock)obj;

            return
                (Symbol == s.Symbol) &&
                (PricePerShare == s.PricePerShare) &&
                (NumShares == s.NumShares);
        }

        

        public string GetName()
        {
            return Symbol;
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