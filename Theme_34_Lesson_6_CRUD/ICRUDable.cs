using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_34_Lesson_6_CRUD
{
    public interface ICRUDable
    {
        public void Add();
        public void Read();
        public void Find();
        public void Update();
        public void Delete();
    }
}
