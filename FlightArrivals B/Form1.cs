using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightArrivals_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Arrays to hold the flight information
        string[] flightNumbers = { "KO421", "ML261", "BA376", "MTH419", "ALK238", "KLM265", "THO132", "ALM145", "THO573" };
        string[] departAirport = { "Athens", "Manchester", "Dublin", "Salzburg", "Dallas", "Glasgow", "Geneva", "London", "Bordeaux" };
        string[] arrivalTimes = { "14:32", "13:25", "13:16", "14:54", "14:18", "14:39", "13:57", "14:40", "15:10" };

        //Declare the List
        List<Flight> arrivalBoard = new List<Flight>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create arrivals and add them to the List
            for (int i = 0; i < flightNumbers.Length; i++)
            {
                Flight newFlight = new Flight(flightNumbers[i], departAirport[i], arrivalTimes[i]);
                arrivalBoard.Add(newFlight);
            }

            //sort the List
            arrivalBoard.Sort();

            //Display current arrivals
            DisplayArrivals(arrivalBoard);
        }

        //Display the List in the list box
        void DisplayArrivals(List<Flight> flight)
        {
            lstArrivals.Items.Clear();

            //for each object in the List
            for (int i = 0; i < flight.Count; i++)
            {
                //get a Flight object and add it to the list box
                Flight aFlight = (Flight)flight[i];

                lstArrivals.Items.Add(aFlight);
            }
        }

        private void lstArrivals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
