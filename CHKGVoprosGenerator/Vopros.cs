using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace CHKGVoprosGenerator
{
    public class Vopros
    {
        int number;
        string vopross;
        string picName;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Vopross
        {
            get { return vopross; }
            set { vopross = value; }
        }

        public string PicName
        {
            get { return picName; }
            set { picName = value; }
        }

        public Vopros(int Number, string Vopross, string PicName)
        {
            number = Number;
            vopross = Vopross;
            picName = PicName;
        }
    }
}
