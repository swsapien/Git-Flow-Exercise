using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgoritms
{
    public interface IAlgoritm
    {
        public int[] GetDisorder(int numberValues);
        public int[] Sort(int[] values);
        public bool Validation(int[] values);
    }
}
