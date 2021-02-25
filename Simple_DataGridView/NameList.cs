using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_DataGridView
{
    public partial class NameList : Form
    {
        private List<Tuple<string, string>> _Names = new List<Tuple<string, string>>();
        public List<Tuple<string, string>> Names
        {
            get { return _Names; }
            set { _Names = value; }
        }

        private BindingSource _source;
        public BindingSource source
        {
            get { return _source; }
            set { _source = value; }
        }
        // 이벤트 정의하는 다른 방법
        private EventHandler _click;
        public event EventHandler Click
        {
            add
            {
                _click += value;
                // _click = value;   // 싱글캐스트
            }
            remove
            {
                _click -= value;
            }
        }

        public NameList()
        {
            InitializeComponent();
        }

        public NameList(List<Tuple<string, string>> names)
        {
            InitializeComponent();

            this.Names = names;

            var bindingList = new BindingList<Tuple<string, string>>(Names);
            source = new BindingSource(bindingList, null);
            
            Legends.DataSource = source;
        }

        public void CellClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
