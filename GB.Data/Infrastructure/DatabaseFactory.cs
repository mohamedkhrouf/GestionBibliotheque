using GB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IdatabaseFactory
    {//instantiation de GPContext
        private Context dataContext = null;
        public Context MyContext { get { return dataContext; } }
        public DatabaseFactory()
        {
            dataContext = new Context();
        }
        //libération de GPContext

        protected override void DisposeCore()
        {
            if (dataContext != null) dataContext.Dispose();
        }
    }
}

