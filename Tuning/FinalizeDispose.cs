using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class FileReader : IDisposable
    {
        FileStream fileStream;
        bool disposed = false;
        // Constructor, opens a file named "temp.dat"
        public FileReader()
        {
            fileStream = new FileStream("temp.dat", FileMode.Create);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    fileStream?.Dispose();
                }
                disposed = true;
            }
        }

        ~FileReader()
        {
            Dispose(false);
        }
    }

    public class FinalizeDispose
    {
        public static void Mainn()
        {
            FileReader file = new FileReader();
            file.Dispose();

        }
    }
}
