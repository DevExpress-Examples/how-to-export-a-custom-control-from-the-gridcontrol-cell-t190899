using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dxSampleGrid {
    public class SomeClass {
        public SomeClass(int j) {
            Id = j;
            Name = "Name" + j.ToString();
        }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
