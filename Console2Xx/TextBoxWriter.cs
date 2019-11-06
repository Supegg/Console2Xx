using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console2Xx
{
    public class TextBoxWriter : System.IO.TextWriter
    {
        ListBox lstBox;
        delegate void VoidAction(string value);
        VoidAction action;

        public TextBoxWriter(ListBox box)
        {
            lstBox = box;

            action = (value)=>
            {
                lstBox.Items.Insert(0, string.Format("[{0:HH:mm:ss}]{1}", DateTime.Now, value));
            };
        }

        public override void Write(string value)
        {
            lstBox.BeginInvoke(action, value);
        }

        public override void WriteLine(string value)
        {
            //VoidAction action = delegate
            //{
            //    lstBox.Items.Insert(0, string.Format("[{0:HH:mm:ss}]{1}", DateTime.Now, value));
            //};
            lstBox.BeginInvoke(action, value);
        }

        public override System.Text.Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
