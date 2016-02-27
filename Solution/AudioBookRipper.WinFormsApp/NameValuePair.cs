using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioBookRipper.WinFormsApp
{
    public class NameValuePair<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
