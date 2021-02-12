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
       public static List<Point2D> sort_By_k_NN_Footbal_Results;
       public static List<Point2D> sort_By_k_NN_Basketball_Results;

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
                
                ListViewItem item = new ListViewItem(new String[] { u.Idd ,u.x, u.y, u.z, u.pozicija });
                item.Tag = u;

                listView2.Items.Add(item);
            }

            //LV properties
            listView2.View = View.Details;
            listView2.FullRowSelect = true;
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
                ListViewItem item = new ListViewItem(new String[] { u.x, u.y, u.z , u.pozicija} );
                ListViewItem item2 = new ListViewItem(new String[] { u.x, u.y, u.z , u.pozicija} );
                ListViewItem item3 = new ListViewItem(new String[] { u.x, u.y, u.z , u.pozicija} );
                item.Tag = u;

                listView1.Items.Add(item);

                if (u.z.Contains("Krepšinis"))
                {
                    listView4.Items.Add(item2);
                }
                if (u.z.Contains("Futbolas"))
                {
                    listView3.Items.Add(item3);
                }

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
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();



            // Get the number of rows and columns (Klasifikavimui) 
            int num_rows_klasifikavimo = listView2.Items.Count;
            int num_cols_klasifikavimo = 0;
            for (int i = 0; i < num_rows_klasifikavimo; i++)
            {
                if (num_cols_klasifikavimo < listView2.Items[i].SubItems.Count)
                    num_cols_klasifikavimo = listView2.Items[i].SubItems.Count;
            }

            // Make the array.
            string[,] results_klasifikavimo = new string[num_rows_klasifikavimo, num_cols_klasifikavimo];

            // Populate the array.
            // Note that SubItems includes the items, too.
            for (int r = 0; r < num_rows_klasifikavimo; r++)
            {
                for (int c = 0; c < num_cols_klasifikavimo; c++)
                    results_klasifikavimo[r, c] = listView2.Items[r].SubItems[c].Text;
            }

            // KLASIFIKAVIMO OBjektai
            var klasifikavimo = new Point2D[2]{ 

                new Point2D(results_klasifikavimo[0,0],Convert.ToDouble(results_klasifikavimo[0,1]),
                Convert.ToDouble(results_klasifikavimo[0,2]), results_klasifikavimo[0,3], results_klasifikavimo[0,4]),

                new Point2D(results_klasifikavimo[0,0],Convert.ToDouble(results_klasifikavimo[1,1]),
                Convert.ToDouble(results_klasifikavimo[1,2]), results_klasifikavimo[1,3], results_klasifikavimo[1,4]),

            };

           


            // Football ////////////////////////////////////
            // Get the number of rows and columns (Mokymo Imtis ) 
            int num_rows_football = listView3.Items.Count;
            int num_cols_football = 0;
            for (int MokymoI = 0; MokymoI < num_rows_football; MokymoI++)
            {
                if (num_cols_football < listView3.Items[MokymoI].SubItems.Count)
                    num_cols_football = listView3.Items[MokymoI].SubItems.Count;
            }

            // Make the array.
            string[,] resultsFootbal = new string[num_rows_football, num_cols_football];

            // Populate the array.
            // Note that SubItems includes the items, too.
            for (int r = 0; r < num_rows_football; r++)
            {
                for (int c = 0; c < num_cols_football; c++)
                    resultsFootbal[r, c] = listView3.Items[r].SubItems[c].Text;
            }


            // Krepsinis ////////////////////////////////////
            // Get the number of rows and columns (Mokymo Imtis ) 
            int num_rows_basketball = listView4.Items.Count;
            int num_cols_basketball = 0;
            for (int MokymoI = 0; MokymoI < num_rows_basketball; MokymoI++)
            {
                if (num_cols_basketball < listView4.Items[MokymoI].SubItems.Count)
                    num_cols_basketball = listView4.Items[MokymoI].SubItems.Count;
            }

            // Make the array.
            string[,] resultsBasketball = new string[num_rows_basketball, num_cols_basketball];

            // Populate the array.
            // Note that SubItems includes the items, too.
            for (int r = 0; r < num_rows_basketball; r++)
            {
                for (int c = 0; c < num_cols_basketball; c++)
                    resultsBasketball[r, c] = listView4.Items[r].SubItems[c].Text;
            }

            ///////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < klasifikavimo.Count(); i++)
            {

                // Get the number of rows and columns (Mokymo Imtis ) 
                int num_rows = listView1.Items.Count;
                int num_cols = 0;
                for (int MokymoI = 0; MokymoI  < num_rows; MokymoI++)
                {
                    if (num_cols < listView1.Items[MokymoI].SubItems.Count)
                        num_cols = listView1.Items[MokymoI].SubItems.Count;
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



              

                // DEFAULT OBJEKTAI
                var trains = new Point2D[16]{ // 
                    new Point2D(Convert.ToDouble(results[0,0]),
                    Convert.ToDouble(results[0,1]), results[0,2], results[0,3]),

                    new Point2D(Convert.ToDouble(results[1,0]),
                    Convert.ToDouble(results[1,1]), results[1,2], results[1,3]),

                    new Point2D(Convert.ToDouble(results[2,0]),
                    Convert.ToDouble(results[2,1]), results[2,2], results[2,3]),

                    new Point2D(Convert.ToDouble(results[3,0]),
                    Convert.ToDouble(results[3,1]), results[3,2], results[3,3]),

                    new Point2D(Convert.ToDouble(results[4,0]),
                    Convert.ToDouble(results[4,1]), results[4,2], results[4,3]),

                    new Point2D(Convert.ToDouble(results[5,0]),
                    Convert.ToDouble(results[5,1]), results[5,2], results[5,3]),

                     new Point2D(Convert.ToDouble(results[6,0]),
                    Convert.ToDouble(results[6,1]), results[6,2], results[6,3]),

                    new Point2D(Convert.ToDouble(results[7,0]),
                    Convert.ToDouble(results[7,1]), results[7,2], results[7,3]),

                    new Point2D(Convert.ToDouble(results[8,0]),
                    Convert.ToDouble(results[8,1]), results[8,2], results[8,3]),

                    new Point2D(Convert.ToDouble(results[9,0]),
                    Convert.ToDouble(results[9,1]), results[9,2], results[9,3]),

                    new Point2D(Convert.ToDouble(results[10,0]),
                    Convert.ToDouble(results[10,1]), results[10,2], results[10,3]),

                     new Point2D(Convert.ToDouble(results[11,0]),
                    Convert.ToDouble(results[11,1]), results[11,2], results[11,3]),

                    new Point2D(Convert.ToDouble(results[12,0]),
                    Convert.ToDouble(results[12,1]), results[12,2], results[12,3]),

                    new Point2D(Convert.ToDouble(results[13,0]),
                    Convert.ToDouble(results[13,1]), results[13,2], results[13,3]),

                    new Point2D(Convert.ToDouble(results[14,0]),
                    Convert.ToDouble(results[14,1]), results[14,2], results[14,3]),

                    new Point2D(Convert.ToDouble(results[15,0]),
                    Convert.ToDouble(results[15,1]), results[15,2], results[15,3]),

                };

               


                if (klasifikavimo[i].Class.Contains("???"))
                {

                    if (klasifikavimo[i].X == 185)
                    {
                        listBox1.Items.Clear();
                        listBox4.Items.Clear();
                    }
                    else
                    {
                        listBox2.Items.Clear();
                        listBox6.Items.Clear();
                    }

                    // Find neadrestNeighbor for object : 
                    var nearestNeighbor = trains.OrderBy(p => p.DistanceSquare(klasifikavimo[i], this, "???")).First();

                    if (klasifikavimo[i].X == 185)
                    {
                        // Duplicate Finder
                        StringBuilder sb = new StringBuilder();
                        for (int ii = 0; ii < listBox1.Items.Count; ii++)
                        {
                            for (int j = 1; j < listBox1.Items.Count; j++)
                            {
                                if (ii != j)
                                {
                                    if (listBox1.Items[ii].ToString() == listBox1.Items[j].ToString())
                                    {


                                        sb.AppendLine(listBox1.Items[j].ToString());
                                        trains[j].Class = "Neaisku";

                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Duplicate Finder
                        StringBuilder sb = new StringBuilder();
                        for (int ii = 0; ii < listBox2.Items.Count; ii++)
                        {
                            for (int j = 1; j < listBox2.Items.Count; j++)
                            {
                                if (ii != j)
                                {
                                    if (listBox2.Items[ii].ToString() == listBox2.Items[j].ToString())
                                    {


                                        sb.AppendLine(listBox2.Items[j].ToString());
                                        trains[j].Class = "Neaisku";

                                    }
                                }
                            }
                        }
                    }

                    // Sort K-NN Classes
                    sort_By_k_NN_Results = trains.ToList();

             /*    int repeat = 0; 
                    if(i == 0)
                    {
                        listBox1.Items.Clear();
                        listBox6.Items.Clear();
                        listBox3.Items.Clear();
                        repeat++;
                    }


                    listBox2.Items.Clear();*/




                    List<Point2D> SortedList = sort_By_k_NN_Results.OrderBy(o => o.DistanceSquare(klasifikavimo[i], this, "???")).ToList();

                    if (klasifikavimo[i].X == 185)
                    {
                      
                        foreach (Point2D item in SortedList)
                        {
                            listBox4.Items.Add(item.Class);
                        }
                    }
                    else
                    {
                        foreach (Point2D item in SortedList)
                        {
                            listBox6.Items.Add(item.Class);
                        }
                    }
                   
                }
                else
                {

                    if (klasifikavimo[i].Class.Contains("Futbolas"))
                    {

                        if (klasifikavimo[i].X == 185)
                        {
                            listBox1.Items.Clear();
                            listBox4.Items.Clear();
                        }
                        else
                        {
                            listBox2.Items.Clear();
                            listBox6.Items.Clear();
                        }

                            // DEFAULT OBJEKTAI Futbolas
                            var trainsFootball = new Point2D[9] {

                                new Point2D(Convert.ToDouble(resultsFootbal[0,0]),
                                Convert.ToDouble(resultsFootbal[0,1]), resultsFootbal[0,2], resultsFootbal[0,3]),

                                new Point2D(Convert.ToDouble(resultsFootbal[1,0]),
                                Convert.ToDouble(resultsFootbal[1,1]), resultsFootbal[1,2], resultsFootbal[1,3]),

                                new Point2D(Convert.ToDouble(resultsFootbal[2,0]),
                                Convert.ToDouble(resultsFootbal[2,1]), resultsFootbal[2,2], resultsFootbal[2,3]),

                                new Point2D(Convert.ToDouble(resultsFootbal[3,0]),
                                Convert.ToDouble(resultsFootbal[3,1]), resultsFootbal[3,2], resultsFootbal[3,3]),

                                new Point2D(Convert.ToDouble(resultsFootbal[4,0]),
                                Convert.ToDouble(resultsFootbal[4,1]), resultsFootbal[4,2], resultsFootbal[4,3]),

                                new Point2D(Convert.ToDouble(resultsFootbal[5,0]),
                                Convert.ToDouble(resultsFootbal[5,1]), resultsFootbal[5,2], resultsFootbal[5,3]),

                                 new Point2D(Convert.ToDouble(resultsFootbal[6,0]),
                                Convert.ToDouble(resultsFootbal[6,1]), resultsFootbal[6,2], resultsFootbal[6,3]),


                                 new Point2D(Convert.ToDouble(resultsFootbal[6,0]),
                                Convert.ToDouble(resultsFootbal[6,1]), resultsFootbal[6,2], resultsFootbal[6,3]),


                                 new Point2D(Convert.ToDouble(resultsFootbal[6,0]),
                                Convert.ToDouble(resultsFootbal[6,1]), resultsFootbal[6,2], resultsFootbal[6,3]),

                                };


                        // Find neadrestNeighbor for object : 
                        var nearestNeighbor = trainsFootball.OrderBy(p => p.DistanceSquare(klasifikavimo[i], this, "Futbolas")).First();

                        if (klasifikavimo[i].X == 185)
                        {
                            // Duplicate Finder
                            StringBuilder sb = new StringBuilder();
                            for (int ii = 0; ii < listBox1.Items.Count; ii++)
                            {
                                for (int j = 1; j < listBox1.Items.Count; j++)
                                {
                                    if (ii != j)
                                    {
                                        if (listBox1.Items[ii].ToString() == listBox1.Items[j].ToString())
                                        {


                                            sb.AppendLine(listBox1.Items[j].ToString());
                                            trainsFootball[j].Pozicija = "Neaisku";

                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Duplicate Finder
                            StringBuilder sb = new StringBuilder();
                            for (int ii = 0; ii < listBox2.Items.Count; ii++)
                            {
                                for (int j = 1; j < listBox2.Items.Count; j++)
                                {
                                    if (ii != j)
                                    {
                                        if (listBox2.Items[ii].ToString() == listBox2.Items[j].ToString())
                                        {


                                            sb.AppendLine(listBox2.Items[j].ToString());
                                            trainsFootball[j].Pozicija = "Neaisku";

                                        }
                                    }
                                }
                            }
                        }

                        // Sort K-NN Classes
                        sort_By_k_NN_Footbal_Results = trainsFootball.ToList();

                        int repeat = 0;
                        if (i == 0)
                        {
                            listBox1.Items.Clear();
                            listBox6.Items.Clear();
                            listBox3.Items.Clear();
                            repeat++;
                        }


                        listBox2.Items.Clear();




                        List<Point2D> SortedList = sort_By_k_NN_Footbal_Results.OrderBy(o => o.DistanceSquare(klasifikavimo[i], this, "???")).ToList();

                        if (klasifikavimo[i].X == 185)
                        {

                            foreach (Point2D item in SortedList)
                            {
                                listBox4.Items.Add(item.Pozicija);
                            }
                        }
                        else
                        {
                            foreach (Point2D item in SortedList)
                            {
                                listBox6.Items.Add(item.Pozicija);
                            }
                        }
                        // 9 


                    }
                    else if(klasifikavimo[i].Class.Contains("Krepšinis") ||
                        klasifikavimo[i].Class.Contains("Krepsinis"))
                    {

                        if (klasifikavimo[i].X == 185)
                        {
                            listBox1.Items.Clear();
                            listBox4.Items.Clear();
                        }
                        else
                        {
                            listBox2.Items.Clear();
                            listBox6.Items.Clear();
                        }

                        // DEFAULT OBJEKTAI KREPSINIS
                        var trainsBasketball = new Point2D[7] {

                                new Point2D(Convert.ToDouble(resultsBasketball[0,0]),
                                Convert.ToDouble(resultsBasketball[0,1]), resultsBasketball[0,2], resultsBasketball[0,3]),

                                new Point2D(Convert.ToDouble(resultsBasketball[1,0]),
                                Convert.ToDouble(resultsBasketball[1,1]), resultsBasketball[1,2], resultsBasketball[1,3]),

                                new Point2D(Convert.ToDouble(resultsBasketball[2,0]),
                                Convert.ToDouble(resultsBasketball[2,1]), resultsBasketball[2,2], resultsBasketball[2,3]),

                                new Point2D(Convert.ToDouble(resultsBasketball[3,0]),
                                Convert.ToDouble(resultsBasketball[3,1]), resultsBasketball[3,2], resultsBasketball[3,3]),

                                new Point2D(Convert.ToDouble(resultsBasketball[4,0]),
                                Convert.ToDouble(resultsBasketball[4,1]), resultsBasketball[4,2], resultsBasketball[4,3]),

                                new Point2D(Convert.ToDouble(resultsBasketball[5,0]),
                                Convert.ToDouble(resultsBasketball[5,1]), resultsBasketball[5,2], resultsBasketball[5,3]),

                                 new Point2D(Convert.ToDouble(resultsBasketball[6,0]),
                                Convert.ToDouble(resultsBasketball[6,1]), resultsBasketball[6,2], resultsBasketball[6,3]),

                                };

                        // Find neadrestNeighbor for object : 
                        var nearestNeighbor = trainsBasketball.OrderBy(p => p.DistanceSquare(klasifikavimo[i], this, "Futbolas")).First();

                        if (klasifikavimo[i].X == 185)
                        {
                            // Duplicate Finder
                            StringBuilder sb = new StringBuilder();
                            for (int ii = 0; ii < listBox1.Items.Count; ii++)
                            {
                                for (int j = 1; j < listBox1.Items.Count; j++)
                                {
                                    if (ii != j)
                                    {
                                        if (listBox1.Items[ii].ToString() == listBox1.Items[j].ToString())
                                        {


                                            sb.AppendLine(listBox1.Items[j].ToString());
                                            trainsBasketball[j].Pozicija = "Neaisku";

                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Duplicate Finder
                            StringBuilder sb = new StringBuilder();
                            for (int ii = 0; ii < listBox2.Items.Count; ii++)
                            {
                                for (int j = 1; j < listBox2.Items.Count; j++)
                                {
                                    if (ii != j)
                                    {
                                        if (listBox2.Items[ii].ToString() == listBox2.Items[j].ToString())
                                        {


                                            sb.AppendLine(listBox2.Items[j].ToString());
                                            trainsBasketball[j].Pozicija = "Neaisku";

                                        }
                                    }
                                }
                            }
                        }

                        // Sort K-NN Classes
                        sort_By_k_NN_Basketball_Results = trainsBasketball.ToList();

                        int repeat = 0;
                        if (i == 0)
                        {
                            listBox1.Items.Clear();
                            listBox6.Items.Clear();
                            listBox3.Items.Clear();
                            repeat++;
                        }


                        listBox2.Items.Clear();




                        List<Point2D> SortedList = sort_By_k_NN_Basketball_Results.OrderBy(o => o.DistanceSquare(klasifikavimo[i], this, "???")).ToList();

                        if (klasifikavimo[i].X == 185)
                        {

                            foreach (Point2D item in SortedList)
                            {
                                listBox4.Items.Add(item.Pozicija);
                            }
                        }
                        else
                        {
                            foreach (Point2D item in SortedList)
                            {
                                listBox6.Items.Add(item.Pozicija);
                            }
                        }

                        // 7 itemow
                    }
                    else
                    {
                        MessageBox.Show("Tokios Sporto Sakos Nera");
                    }


                } // else pabaiga
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
                        X = Convert.ToDouble(resultsTask[r, 1]),
                        Y = Convert.ToDouble(resultsTask[r, 2])
                    });
            }


            // FOR DEFAULT DATA NOT TASK
            for (int r = 0; r < num_rows; r++)
            {
                if (results[r, 2].Equals("Futbolas"))
                {
                    ChartValuesWithPlus.Add(new ObservablePoint
                    {
                        X = Convert.ToDouble(results[r, 0]),
                        Y = Convert.ToDouble(results[r, 1])
                    });
                }
            }

            // FOR DEFAULT DATA NOT TASK
            for (int r = 0; r < num_rows; r++)
            {
                if (results[r, 2].Equals("Krepšinis"))
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
                   Title = "Futbolas"

                },
                  new LineSeries
                {
                   Values = ChartValuesWithMinus,
                   PointGeometrySize = 15,
                    Title = "Krepšinis"
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

          
        }

        private void button5_Click(object sender, EventArgs e)
        {

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            update();
        }
        
        private void update()
        {
            listView2.SelectedItems[0].SubItems[1].Text = UgisTxt.Text;
            listView2.SelectedItems[0].SubItems[2].Text = SvorisTxt.Text;
            listView2.SelectedItems[0].SubItems[3].Text = SportoSakaTxt.Text;
            listView2.SelectedItems[0].SubItems[4].Text = PozicijaTxt.Text;


        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            //Clear
            UgisTxt.Text = "";
            SvorisTxt.Text = "";
            SportoSakaTxt.Text = "";
            PozicijaTxt.Text = "";

            UgisTxt.Text = listView2.SelectedItems[0].SubItems[1].Text;
            SvorisTxt.Text = listView2.SelectedItems[0].SubItems[2].Text;
            SportoSakaTxt.Text = listView2.SelectedItems[0].SubItems[3].Text;
            PozicijaTxt.Text = listView2.SelectedItems[0].SubItems[4].Text;
        
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
