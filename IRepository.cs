using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindOfAnInventorySystem.Model
{
    public interface IRepository
    {
        void Create();
        void Read();
        void Update();
        void Delete();
        void Search();
    }
}
