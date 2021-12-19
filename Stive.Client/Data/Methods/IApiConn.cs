using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Methods
{
    public interface IApiConn
    {
        public object Add();
        public object Remove();
        public object Update();
        public object Delete();
    }
}
