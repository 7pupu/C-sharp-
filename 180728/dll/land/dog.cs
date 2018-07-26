using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals.land {
    public class Dog:animal {
        public Dog(String name,String color) : base("狗", name,color) {

        }
        public override string ToString() {
            return String.Format("來自dog {0},{1},{2}",Type,Name,Color); 
        }
    }
}
