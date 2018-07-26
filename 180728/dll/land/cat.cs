using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals.land {
    public class CAT : animal {
        public CAT(String name, String color) : base("貓",name, color) {

        }
        public override string ToString() {
            return String.Format("來自CAT {0},{1},{2}",Type, Name, Color);
        }
    }
}
