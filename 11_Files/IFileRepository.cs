using System.IO;

namespace _11_Files
{
    internal interface IFileRepository
    {
        void SaveStock(Stock yhoo);
        DirectoryInfo StockFileName(Stock yhoo);
        object StockFileName(int v);
    }
}