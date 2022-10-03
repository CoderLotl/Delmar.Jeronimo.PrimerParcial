﻿using Library;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{

    public partial class FrmLogin : Form
    {
        //******************************************************

        // Here go all the lists the program is going to use during its running time.
        // Why here? Because this makes them prevail the user off-logging. Any changes performed for one user exist for all the users.

        // HEADER
        List<Destination> destinations; // LIST OF DESTINATIONS AS OBJECTS. WILL SERVE TO SEE THE AMOUNT OF PASSENGERS THEY RECEIVE AND HOW MUCH THEY EARN.
        List<Agent> users; // LIST OF REGISTERED USERS THAT WILL OPERATE THE PLATFORM.
        List<Flight> flights; // LIST OF CURRENTLY ON-GOING FLIGHTS
        List<Flight> history; // HISTORY OF FLIGHTS
        List<Airplane> airplanes; // LIST OF CURRENT PLANES
        List<Airplane> inTheAir; // LIST OF PLANES IN THE AIR
        List<Passenger> clients; // LIST OF CLIENTS. THEY CAN BECOME PASSENGERS.
        float[] earnedTotal; // TOTAL OF EARNED MONEY
        float[] earnedNational; // TOTAL OF EARNED MONEY IN NATIONAL FLIGHTS
        float[] earnedInternational; // TOTAL OF EARNED MONEY IN INTERNATIONAL FLIGHTS

        //******************************************************

        public FrmLogin()
        {
            InitializeComponent();

            users = new List<Agent> { new Agent("1", "2","Pepe")};
            destinations = Destination.PopulateDestinations();
            flights = new List<Flight>();
            airplanes = Fleet.airplanes;
            inTheAir = new List<Airplane>();
            clients = new List<Passenger>();
            history = new List<Flight>();
            earnedTotal = new float[1];
            earnedTotal[0] = 0;
            earnedNational = new float[1];
            earnedNational[0] = 0;
            earnedInternational = new float[1];
            earnedInternational[0] = 0;
            UpdatePlanes();
            RandomFlights(); 
        }

        //------------------------------------------------------------
        //-------------------------------------------[ BUTTONS ]
        //------------------------------------------------------------

        ///
        private void Btn_Login_Login_Click(object sender, EventArgs e)
        {            
            int error = 0; // ERROR PARAM.

            foreach(Agent agent in users) // WHEN THE BUTTON IS PRESSED, IT ITERATES THROUGH ALL THE AGENTS.
            {
                if(agent.LoginCheck(txtBox_Login_User.Text,txtBox_Login_Password.Text) == true) // IF THE CONTENT OF THE BOXES MATCHES SOME AGENT'S DATA...
                {
                    FrmMain main = new FrmMain(this,flights, history, agent, airplanes,inTheAir,1,clients,earnedTotal,earnedNational,earnedInternational,destinations);
                    main.Show();
                    this.Hide();  // LOG.
                }
                else // ELSE, ERROR.
                {
                    error = 1;
                }
            }
            if (error == 1) // IF THERE'S AN ERROR, SHOW THE ERROR MESSAGE LABEL THAT'S HIDDEN.
            {                
                this.txtBox_Login_User.Text = string.Empty;
                this.txtBox_Login_Password.Text = string.Empty;
                Lbl_LoginError.Visible = true;
            }
        }

        //***********************************************

        private void LnkLbl_CreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNewAgent newAgent = new FrmNewAgent();
            
            if(newAgent.ShowDialog() == DialogResult.OK)
            {
                users.Add(newAgent.Agent);                
            }
        }

        //***********************************************

        private void Btn_LoginExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //------------------------------------------------------------
        //-------------------------------------------[ EVENTS ]
        //------------------------------------------------------------

        /// <summary>
        /// THIS METHOD HARDCODES A TEST FLIGHT.
        /// </summary>
        private void UpdatePlanes()
        {
            int index = 0;

            Airplane airplaneToGo = airplanes[index]; // CREATES AN AIRPLANE...
            SortedDictionary<int, Passenger> tourist = new SortedDictionary<int, Passenger>(); // WITH THE LISTS OF PASSENGERS...
            SortedDictionary<int, Passenger> premium = new SortedDictionary<int, Passenger>();

            List<Luggage> luggage = new List<Luggage>(); // ADDS SOME CARGO LIST...

            Flight flightToGo = new Flight(airplaneToGo, "Santa Rosa", "Jujuy", tourist, premium,luggage,
                200.50f, "72 hours", "20/9/2056 12:00:00 AM", "23/9/2056 12:00:00 AM"); // THE DATA IS SET...

            flightToGo.IsNational = true; // SETS THE FLIGHT AS NATIONAL...

            Passenger tester = new Passenger("Test", "Tester", "Male", "123", 30); // CREATES A TEST PASSENGER
            flightToGo.Tourist.Add(1,tester);
            flightToGo.Tourist.Add(2,tester);
            flightToGo.Tourist.Add(3,tester);            // AND ADDS IT THRICE
            
            flights.Add(flightToGo);// ADDS THE FLIGHT
            airplanes.RemoveAt(index); // REMOVES THE PPLANE FROM THE AVAILABLE PLANES
            inTheAir.Add(airplaneToGo);            // AND ADDS THE PLANE TO A BACKGROUND LIST.
        }

        /// <summary>
        /// HARDCODES A FULLY RANDOM LIST OF PAST FLIGHTS AND ADDS A POOL OF PAST PASSENGERS WITH ALL THEIR STATS.
        /// </summary>
        private void RandomFlights()
        {
            Library.Extras.HardcodingFlights(clients, history,earnedTotal,earnedNational,earnedInternational,destinations);
        }

        //***********************************************

        private void txtBox_Login_User_TextChanged(object sender, EventArgs e)
        {
            Lbl_LoginError.Visible = false;
        }

        //***********************************************

        private void txtBox_Login_Password_TextChanged(object sender, EventArgs e)
        {
            Lbl_LoginError.Visible = false;
        }

        //------------------------------------------------------------
        //-------------------------------------------[ TOOLTIP SECTION ]
        //------------------------------------------------------------

        private void txtBox_Login_User_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Here goes the user name.", txtBox_Login_User);
        }

        //***********************************************

        private void txtBox_Login_Password_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Here goes the password.", txtBox_Login_Password);
        }

        //***********************************************

        private void btn_Login_Login_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Pressing here you will log into the program.\n\nIf the combination of User/Password is wrong, you won't be able to.", btn_Login_Login);
        }

        //***********************************************

        private void Btn_LoginExit_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This button terminates the program.", Btn_LoginExit);
        }

        //***********************************************

        private void lnkLbl_CreateAccount_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Following this link you will be able to create your own user and password.", lnkLbl_CreateAccount);
        }
    }
}
