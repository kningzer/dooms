using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dooms
{
    class Element
    {

        public string ElementType;

        public float x;
        public float y;
        public float z;


        public float posX;
        public float posY;
        public float posZ;

        public string field1;
        public string field2;
        public string field3;
        public string field4;

        public Element(string _ElType, float _x, float _y, float _z, float _xpos, float _ypos, float _zpos, string _f1 = "", string _f2 = "", string _f3 = "", string _f4 = "")
        {
            ElementType = _ElType;
            x = _x;
            y = _y;
            z = _z;
            posX = _xpos;
            posY = _ypos;
            posZ = _zpos;
            field1 = _f1;
            field2 = _f2;
            field3 = _f3;
            field4 = _f4;
        }
    }
}
