using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name:       James Horton
/// Date:       12/13/2018
/// Assignment: Final Hands On
/// File:       FinalHandsOnJeapordy Jim Horton
/// </summary>

namespace FinalHandsOnJeapordy_Jim_Horton
{
    class Player
    {
        #region --- Private ---
        private string name;
        private double score;
        #endregion -- Privates --

        #region --- Public Fileds ---
        public string Name { get => name; set => name = value; }
        public double Score { get => score; set => score = value; }
        #endregion --- purlics ---

        #region --- Constructors ---

        public Player(string name)
        {
            this.name = name;
        } // end of string construct

        public Player (string name, double score)
        {
            this.name = name;
            this.score = score;
        } // end of full constructor

        #endregion -- constructs --

        #region --- Methods ---

        public void updateScore(double amnt)
        {
            this.score = score + amnt;
        } // end of update score

        #endregion -- methods --

    } // end of class player
} // end of namespace
