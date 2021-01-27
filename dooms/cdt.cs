using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dooms
{
    class Cdt
    {

        public List<Element> ElementList;
        public float currentXPos;


        public void updateList(ListBox lst)
        {
            foreach (var el in ElementList)
            {
                lst.Items.Add(el.ToStringST());
            }
        }

        public void addElement(Element el)
        {

        }

    }
}
