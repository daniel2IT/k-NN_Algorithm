using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
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
using SeriesCollection = LiveCharts.SeriesCollection;

namespace Nearest_Neighbors
{
    public partial class Form1 : Form
    {

       public static List<Connection> objektaiKlas = Connection.GetObjektaiKlasifikavimui();
       public static List<Connection> mokymoImtis;
       public static List<Point2D> sort_By_k_NN_Results;
       public static List<Point2D> sort_By_k_NN_Results2;

        ChartValues<ObservablePoint> ChartValuesWithMinus = new ChartValues<ObservablePoint>();
        ChartValues<ObservablePoint> ChartValuesWithPlus = new ChartValues<ObservablePoint>();
        ChartValues<ObservablePoint> ChartTaskValues = new ChartValues<ObservablePoint>();



        public Form1()
        {
            InitializeComponent();
            Connection.Initialize();
       

            listView2.Items.Clear();

            foreach (Connection u in objektaiKlas)
            {
                
                ListViewItem item = new ListViewItem(new String[] { u.x, u.y, u.z });
                item.Tag = u;

                listView2.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "K-Nearest Neighbour (KNN) ->> X",
              /*  Labels = new[] {"1", "2" , "3" }, */
            });

            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "K-Nearest Neighbour (KNN) ->> Y",
                /*  Labels = new[] {"1", "2" , "3" }, */
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadAll()
        {
            if(mokymoImtis != null)
            {
                mokymoImtis.Clear();
            }

            List<Connection> users = Connection.GetUsers();
            mokymoImtis = users;

            listView1.Items.Clear();

            foreach (Connection u in mokymoImtis)
            {
                ListViewItem item = new ListViewItem(new String[] { u.x, u.y, u.z } );
                item.Tag = u;

                listView1.Items.Add(item);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoadAll();

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox4.Items.Clear();


            // Get the number of rows and columns (Mokymo Imtis ) 
            int num_rows = listView1.Items.Count;
            int num_cols = 0;
            for (int i = 0; i < num_rows; i++)
            {
                if (num_cols < listView1.Items[i].SubItems.Count)
                    num_cols = listView1.Items[i].SubItems.Count;
            }

            // Make the array.
            string[,] results = new string[num_rows, num_cols];

            // Populate the array.
            // Note that SubItems includes the items, too.
            for (int r = 0; r < num_rows; r++)
            {
                for (int c = 0; c < num_cols; c++)
                    results[r, c] = listView1.Items[r].SubItems[c].Text;
            }




            //*********************************************************************//
            // Objekto Klasifikavimui NR 1
            var trains = new Point2D[6]{
                new Point2D(Convert.ToDouble(results[0,0]),
                Convert.ToDouble(results[0,1]), results[0,2]), 

                new Point2D(Convert.ToDouble(results[1,0]),
                Convert.ToDouble(results[1,1]), results[1,2]),
                
                new Point2D(Convert.ToDouble(results[2,0]),
                Convert.ToDouble(results[2,1]), results[2,2]),

                new Point2D(Convert.ToDouble(results[3,0]),
                Convert.ToDouble(results[3,1]), results[3,2]),

                new Point2D(Convert.ToDouble(results[4,0]),
                Convert.ToDouble(results[4,1]), results[4,2]),

                new Point2D(Convert.ToDouble(results[5,0]),
                Convert.ToDouble(results[5,1]), results[5,2])
            };

     
            // OBject To Observe , For FInd (Objektai klasifikavimui)
            var test = new Point2D(1, 2, "");
      


            // Find neadrestNeighbor for object : 
            var nearestNeighbor = trains.OrderBy(p => p.DistanceSquare(test, this)).First();
                
            // Duplicate Finder
            StringBuilder sb = new StringBuilder();
    for (int i = 0; i < listBox1.Items.Count; i++)
    {
        for (int j = 1; j < listBox1.Items.Count; j++)
        {
            if (i != j)
            {
                if (listBox1.Items[i].ToString() == listBox1.Items[j].ToString())
                {
                    sb.AppendLine(listBox1.Items[j].ToString());
                    trains[j].Class = "Neaisku";
                }
            }
        }
    }

            // Sort K-NN Classes
            sort_By_k_NN_Results = trains.ToList();

            listBox3.Items.Clear();
            listBox1.Items.Clear();

            List<Point2D> SortedList = sort_By_k_NN_Results.OrderBy(o => o.DistanceSquare(test, this)).ToList();


            foreach (Point2D item in SortedList)
            {
                listBox4.Items.Add(item.Class);
            }


          

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {

            // Init Data
            cartesianChart1.Series.Clear();

            ////////////////////////////////////////////////////////////////
            // Get the number of rows and columns DEFAULT VALUES
            int num_rows = listView1.Items.Count;
            int num_cols = 0;
            for (int i = 0; i < num_rows; i++)
            {
                if (num_cols < listView1.Items[i].SubItems.Count)
                    num_cols = listView1.Items[i].SubItems.Count;
            }

            // Make the array.
            string[,] results = new string[num_rows, num_cols];

            // Populate the array.
            // Note that SubItems includes the items, too.
            for (int r = 0; r < num_rows; r++)
            {
                for (int c = 0; c < num_cols; c++)
                    results[r, c] = listView1.Items[r].SubItems[c].Text;
            }

            ////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////
            // Get the number of rows and columns TASK VALUES
            int num_rows2 = listView2.Items.Count;
            int num_cols2 = 0;
            for (int i = 0; i < num_rows2; i++)
            {
                if (num_cols2 < listView2.Items[i].SubItems.Count)
                    num_cols2 = listView2.Items[i].SubItems.Count;
            }

            // Make the array.
            string[,] resultsTask = new string[num_rows2, num_cols2];

            // Populate the array.
            // Note that SubItems includes the items, too.
            for (int r = 0; r < num_rows2; r++)
            {
                for (int c = 0; c < num_cols2; c++)
                    resultsTask[r, c] = listView2.Items[r].SubItems[c].Text;
            }


            ////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////


            // FOR TASK DATA
            // Get Data
            for (int r = 0; r < num_rows2; r++)
            {
                    ChartTaskValues.Add(new ObservablePoint
                    {
                        X = Convert.ToDouble(resultsTask[r, 0]),
                        Y = Convert.ToDouble(resultsTask[r, 1])
                    });
            }


            // FOR DEFAULT DATA NOT TASK
            // Only Plus +
            for (int r = 0; r < num_rows; r++)
            {
                if (results[r, 2].Equals("+"))
                {
                    ChartValuesWithPlus.Add(new ObservablePoint
                    {
                        X = Convert.ToDouble(results[r, 0]),
                        Y = Convert.ToDouble(results[r, 1])
                    });
                }
            }

            // FOR DEFAULT DATA NOT TASK
            // Only Minus -
            for (int r = 0; r < num_rows; r++)
            {
                if (results[r, 2].Equals("-"))
                {
                    ChartValuesWithMinus.Add(new ObservablePoint
                    {
                        X = Convert.ToDouble(results[r, 0]),
                        Y = Convert.ToDouble(results[r, 1])
                    });
                }
            }



            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                   Values = ChartValuesWithPlus,
                   PointGeometrySize = 15,
                   Title = "+ Kordinates"

                },
                  new LineSeries
                {
                   Values = ChartValuesWithMinus,
                   PointGeometrySize = 15,
                    Title = "- Kordinates"
                },
                  new LineSeries
                {
                   Values = ChartTaskValues,
                   PointGeometrySize = 15,
                    Title = "Klasifikavimui"
                },
            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void revenueBindingSource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void revenueBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox6.Items.Clear();
            listBox2.Items.Clear();


            // Get the number of rows and columns (Mokymo Imtis ) 
            int num_rows = listView1.Items.Count;
            int num_cols = 0;
            for (int i = 0; i < num_rows; i++)
            {
                if (num_cols < listView1.Items[i].SubItems.Count)
                    num_cols = listView1.Items[i].SubItems.Count;
            }

            // Make the array.
            string[,] results = new string[num_rows, num_cols];

            // Populate the array.
            // Note that SubItems includes the items, too.
            for (int r = 0; r < num_rows; r++)
            {
                for (int c = 0; c < num_cols; c++)
                    results[r, c] = listView1.Items[r].SubItems[c].Text;
            }


            //*********************************************************************//
            // Objekto Klasifikavimui NR 2
            var trains2 = new Point2D[7]{
                new Point2D(Convert.ToDouble(results[0,0]),
                Convert.ToDouble(results[0,1]), results[0,2]),

                new Point2D(Convert.ToDouble(results[1,0]),
                Convert.ToDouble(results[1,1]), results[1,2]),

                new Point2D(Convert.ToDouble(results[2,0]),
                Convert.ToDouble(results[2,1]), results[2,2]),

                new Point2D(Convert.ToDouble(results[3,0]),
                Convert.ToDouble(results[3,1]), results[3,2]),

                new Point2D(Convert.ToDouble(results[4,0]),
                Convert.ToDouble(results[4,1]), results[4,2]),

                new Point2D(Convert.ToDouble(results[5,0]),
                Convert.ToDouble(results[5,1]), results[5,2]),

                new Point2D(Convert.ToDouble(results[6,0]),
                Convert.ToDouble(results[6,1]), results[6,2])

            };

            // OBject To Observe , For FInd (Objektai klasifikavimui)
            var test2 = new Point2D(0, 2, "");

            // Find nearestNeighbor for object : 
            var nearestNeighbor2 = trains2.OrderBy(p => p.DistanceSquare(test2, this)).First();

            // Duplicate Finder

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                for (int j = 0; j < listBox2.Items.Count; j++)
                {
                    if (i != j)
                    {
                        if (listBox2.Items[i].ToString() == listBox2.Items[j].ToString())
                        {
                            trains2[j].Class = "Neaisku";
                           
                        }
                    }
                }
            }


  /*          for (int i = 0; i < listBox2.Items.Count; i++)
            {
                for (int j = 1; j < listBox2.Items.Count; j++)
                {
                    if (i != j)
                    {
                        try
                        {
                            if (listBox2.Items[i].ToString() == listBox2.Items[j].ToString())
                            {
                                trains2[j].Class = "Neaisku";
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }*/

            // Sort K-NN Classes
            sort_By_k_NN_Results2 = trains2.ToList();

            listBox5.Items.Clear();
            listBox2.Items.Clear();

            List<Point2D> SortedList2 = sort_By_k_NN_Results2.OrderBy(o => o.DistanceSquare(test2, this)).ToList();


            foreach (Point2D item in SortedList2)
            {
                listBox6.Items.Add(item.Class);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                Connection.AddUsers(listBox4.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("Priskirkite k - NN naujam objektui");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection.DeleteUser();
        }
    }
}
