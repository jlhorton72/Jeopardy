using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Name:       James Horton
/// Date:       12/13/2018
/// Assignment: Final Hands On
/// File:       FinalHandsOnJeapordy Jim Horton
/// </summary>

namespace FinalHandsOnJeapordy_Jim_Horton
{
    public partial class OptionsForm : Form
    {
        //Just like a class make field
        //Private class fields
        private string testVar = string.Empty;


        //Make properties
        public string TestVar
        {
            get => testVar;
            set => testVar = value;
        }

        public OptionsForm()
        {
            InitializeComponent();
            //This is how to access from options without passing
            //testVar = Splash.testVar;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            lblTest.Text = testVar;
        }

        #region --- accidental double clicked items ---
        private void lblTest_Click(object sender, EventArgs e)
        {
            // not needed
        } // end of lblTestClick

        private void txtBxNumPlyrs_TextChanged(object sender, EventArgs e)
        {
            // not needed
        } // end of txtBxPlyrs_TextChanged

        private void lblPlyr2_Click(object sender, EventArgs e)
        {
            // not needed
        } // end of lblPlyr2_Click

        #endregion -- ooppssies --

        private void btnNumPlayers_Click(object sender, EventArgs e)
        {
            #region -- try catch for num players --
            try
            {
                int i = int.Parse(txtBxNumPlyrs.Text);
                switch (i)
                {
                    case 1:
                        {
                            lblPlyr1.Visible = true;
                            txtBxPlyr1.Visible = true;
                            txtBxPlyr1.Focus();
                            button1.Visible = true;
                            break;
                        } // end of case 1
                    case 2:
                        {
                            lblPlyr1.Visible = true;
                            txtBxPlyr1.Visible = true;
                            txtBxPlyr1.Focus();
                            lblPlyr2.Visible = true;
                            txtBxPlyr2.Visible = true;
                            button1.Visible = true;
                            break;
                        } // end of case 2
                    case 3:
                        {
                            lblPlyr1.Visible = true;
                            txtBxPlyr1.Visible = true;
                            txtBxPlyr1.Focus();
                            lblPlyr2.Visible = true;
                            txtBxPlyr2.Visible = true;
                            lblPlyr3.Visible = true;
                            txtBxPlyr3.Visible = true;
                            button1.Visible = true;
                            break;
                        } // end of case 3
                    default:
                        {
                            lblTest.Text = "Must enter a number";
                            break;
                        } // end of default
                } // end of switch

            } // end of try
            catch
            {
                lblTest.Text = "Must enter a number";
                txtBxNumPlyrs.Focus();
                txtBxNumPlyrs.Clear();
            } // end of catch
            #endregion  -- try catch --


        } // end of btnNumPlayers-Click

        private void button1_Click(object sender, EventArgs e)
        {
            // need to take the names and send to the next form
            GameBoardForm GameBoard = new GameBoardForm();
            int i = int.Parse(txtBxNumPlyrs.Text);
            switch (i)
            {
                case 1:
                    {
                        GameBoard.Player1 = txtBxPlyr1.Text;
                        GameBoard.Players = i;
                        //GameBoard.Player2 = txtBxPlyr2.Text;
                        //GameBoard.Player3 = txtBxPlyr3.Text;
                        break;
                    } // end of case 1
                case 2:
                    {
                        GameBoard.Player1 = txtBxPlyr1.Text;
                        GameBoard.Player2 = txtBxPlyr2.Text;
                        GameBoard.Players = i;
                        //GameBoard.Player3 = txtBxPlyr3.Text;
                        break;
                    } // end of case 2
                case 3:
                    {
                        GameBoard.Player1 = txtBxPlyr1.Text;
                        GameBoard.Player2 = txtBxPlyr2.Text;
                        GameBoard.Player3 = txtBxPlyr3.Text;
                        GameBoard.Players = i;
                        break;
                    } // end of case 3
                
            } // end of switch        
            GameBoard.Show();
            this.Hide();
        } // end of  button1_Click

    } // end of form class
} // end of namespace
