using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals {
    public abstract class animal {
        private String type;
        private String name;
        private String color;
        public String Type { get; set; }
        public String Name { get; set; }
        public String Color { get; set; }
        public animal(String type,String name,String color) {
            this.Type = type;
            this.Name = name;
            this.Color = color;
        }
        public override abstract string ToString();
            //{return String.Format("來自anime {0},{1},{2}", Type, Name, Color);}
    }
}
