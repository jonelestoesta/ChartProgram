using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LineChart.ChartAreas[0].AxisX.Minimum = 100;
            LineChart.ChartAreas[0].AxisY.Minimum = -30;
            LineChart.ChartAreas[0].AxisY.Maximum = 30;
            LineChart.ChartAreas[0].AxisY2.Minimum = 0;
            LineChart.ChartAreas[0].AxisY2.Maximum = 1;
           
            this.dataGridView1.Rows.Add(60,60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60);
            this.dataGridView1.Rows.Add(-20,-10,-20,-10,-30,-7,-8,-9,-10,-10,-10,-10,-4,-8,-9,-10,-9,-20,-10,-10,-19,-5,-3,-20);
            this.dataGridView1.Rows.Add(80, 100, 70, 50, 60, 70, 80, 90, 100, 100, 100, 100, 70, 80, 90, 100, 90, 60, 100, 100, 70, 50, 85, 80);
            
            LineChart.DataBind();
            FillData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LineChart.DataBind();
            FillData();
        }

        private void FillData()
        {
            //LineChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            LineChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            LineChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            LineChart.ChartAreas[0].AxisX.ScaleView.Zoom(0, 1500);
            List<double> xvalues = new List<double>();
            List<double> yvalues = new List<double>();
            List<double> y2values = new List<double>();
            List<double> xval2 = new List<double>();
            //List<int> yval2 = new List<int>();
            double counter = 0;
            double counter2 = 1;
            double count2 = 100;
            double value = 0;
            //double add = 0;
            foreach (DataGridViewRow xval in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in xval.Cells)
                {
                    value = Convert.ToDouble(cell.Value.ToString());
                    if(counter <= 23)
                    {
                        //if (value > 60)
                        //{
                        value = (value / 60) * count2;
                        //}
                        //if(counter == 0)
                        //{
                        //    xvalues.Add(1);
                        //}
                       xvalues.Add(value);        
                       counter++;
                       count2 += 100;

                    }
                    else if (counter > 23 && counter <= 47)
                    {
                        yvalues.Add(value);
                       // LineChart.Series["Temperature"].Points.;
                      //  LineChart.Series["Temperature"].YValueMembers = value.ToString();
                       // LineChart.Series["Temperature"].Points.AddXY(0, value);
                        counter++;
                       // LineChart.DataSource = dataGridView1.DataSource;
                        //LineChart.Update();
                    }       
                    else if (counter > 47)
                    {
                        value = value / 100;
                        y2values.Add(value);
                        counter++;
                    }
                    //label1.Text = value;
                }

               
              // LineChart.Series["Temperature"].Points.AddY(0, yvalues);
                
              // LineChart.Series["Temperature"].Points.DataBindXY(xvalues, yvalues);
                if(xvalues.Count > 0 && yvalues.Count > 0 && y2values.Count > 0)
                {
                   
                    //xval2.Add(1);
                    //xval2.Add(xvalues[0]);
                    //xval2.Add(xvalues[1]);
                    //xval2.Add(xvalues[2]);
                    //xval2.Add(xvalues[3]);
                    //xval2.Add(xvalues[4]);
                    //xval2.Add(xvalues[5]);
                    //xval2.Add(xvalues[6]);
                    //xval2.Add(xvalues[7]);
                    //xval2.Add(xvalues[8]);
                    //xval2.Add(xvalues[9]);
                    //xval2.Add(xvalues[10]);
                    //xval2.Add(xvalues[11]);
                    //xval2.Add(xvalues[12]);
                    //xval2.Add(xvalues[13]);
                    //xval2.Add(xvalues[14]);
                    //xval2.Add(xvalues[15]);
                    //xval2.Add(xvalues[16]);
                    //xval2.Add(xvalues[17]);
                    //xval2.Add(xvalues[18]);
                    //xval2.Add(xvalues[19]);
                    //xval2.Add(xvalues[20]);
                    //xval2.Add(xvalues[21]);
                    //xval2.Add(xvalues[22]);
                    //xval2.Add(xvalues[23]);
                    //xval2.Remove(xval2[24]);

                    //LineChart.ChartAreas[0].AxisX.Interval = 2;   
                    LineChart.Series["Temperature"].Points.DataBindXY(xvalues, yvalues);
                    LineChart.Series["Humidity"].Points.DataBindXY(xvalues, y2values);
                   
                    //if (LineChart.ChartAreas[0].AxisX.Maximum == 10)
                    //{
                    //    //chart1.ChartAreas["Area1"].AxisY.ScrollBar.Size = 10;
                    
                    //    //get the current maximum of the axis
                    //    double ymax = LineChart.ChartAreas[0].AxisY.Maximum;
                    //    //Add the new data

                    //    //set the zoom size to the exisiting scale values other wise nothing happens
                    //    LineChart.ChartAreas[0].AxisY.ScaleView.Zoom(0, ymax);
                    //}
                    return;
                }
                
           }
            
           // LineChart.Series["Temperature"].XValueMember = dataGridView1.Columns[0].DataPropertyName;
          // LineChart.Series["Temperature"].YValueMembers = dataGridView1.Columns[1].DataPropertyName; //.DataPropertyName
            //object check = dataGridView1.Rows[0].Cells;
            //object check2 = dataGridView1.Rows[1].Cells;
   
            //
           // LineChart.DataSource = dataGridView1.DataSource;
            //LineChart.Update();         
        }
    }
}
