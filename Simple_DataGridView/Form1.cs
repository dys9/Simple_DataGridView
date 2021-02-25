using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simple_DataGridView
{
    public partial class Form1 : Form
    {
        private List<Result> _ResultList = new List<Result>();
        public List<Result> ResultList
        {
            get { return _ResultList; }
            set { _ResultList = value; }
        }

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
        public Form1()
        {
            InitializeComponent();

            ResultList.Add((new Result(0.1431, 0.1468, 17.91, true)));
            ResultList.Add((new Result(0.2431, 0.2468, 27.91, true)));
            ResultList.Add((new Result(0.3431, 0.3468, 37.91, true)));
            ResultList.Add((new Result(0.4431, 0.4468, 47.91, true)));
            ResultList.Add((new Result(0.5431, 0.5468, 57.91, true)));

            //var chkCol = new DataGridViewCheckBoxColumn
            //{
            //    Name = "Check",
            //    HeaderText = "Check"
            //};
            //dgvResult.Columns.Add(chkCol);

            //dgvResult.EditMode = DataGridViewEditMode.EditOnEnter;
            //dgvResult.DataSource = ResultList;

            var bindingList = new BindingList<Result>(ResultList);
            source = new BindingSource(bindingList, null);
            dgvResult.DataSource = source;

            dgvResult.Columns[0].ReadOnly = true;
            dgvResult.Columns[1].ReadOnly = true;
            dgvResult.Columns[2].ReadOnly = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            source.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dgvResult.Rows.Count; i++)
            {
                if (dgvResult.Rows[i].Selected)
                {
                    source.RemoveAt(i);
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!tbCx.Text.Equals("") && !tbCy.Text.Equals("") && !tbTrans.Text.Equals(""))
            {
                source.Add(new Result(Convert.ToDouble(tbCx.Text), Convert.ToDouble(tbCy.Text), Convert.ToDouble(tbTrans.Text), true));
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            chtResult.ChartAreas.Clear();
            chtResult.Series.Clear();
            chtResult.ChartAreas.Add("Result");

            int cnt = 0;
            foreach(Result item in source)
            {
                if (item.Check)
                {
                    chtResult.Series.Add("Point" + cnt.ToString());
                    chtResult.Series["Point" + cnt.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chtResult.Series["Point" + cnt.ToString()].Points.AddXY(item.Cx, item.Cy);

                    cnt++;
                }
            }
            chtResult.Show();
        }

        private void chtResult_Click(object sender, EventArgs e)
        {
            foreach (Series series in chtResult.Series)
            {
                Names.Add(new Tuple<string, string>(series.Name, ""));
            }

            NameList namelist = new NameList(Names);
            namelist.Show();
        }
    }
}
