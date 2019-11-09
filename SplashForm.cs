using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
    
    public partial class Splash : Form
    {
              
        public Splash()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Instance of new form
            OptionsForm OptionsForm = new OptionsForm();

            //Use property of form being passed to!
                //OptionsForm.TestVar = "iiii";
            //Show new form, hide first form
            OptionsForm.Show();
            this.Hide();

        } // end of btnStart_Click

        private void Splash_Load(object sender, EventArgs e)
        {
            // not sure if needed so hiding it 
        } // end of SPlash_Load


    } // end of form
} // end of namspace
