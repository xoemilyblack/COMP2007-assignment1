using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace COMP2007_Assignment1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Variable Declarations
            int pointsScored = 0,
                pointsAllowed = 0,
                numOfSpecs = 0,
                averageSpecs = 0,
                diffInPoints = 0,
                gamesWon = 0,
                gamesLost = 0;
            double winningPerc = 0;

            lblAllowedPoints.Text = "";
            lblAverageSpec.Text = "";
            lblSpectators.Text = "";
            lblDifference.Text = "";
            lblGamesLost.Text = "";
            lblGamesWon.Text = "";
            lblWinningPerc.Text = "";
            lblTotalPoints.Text = "";
            pnlInfo.Visible = false;


            //Counting the # of games won and lost
            if (gameControl1.returnRadio == "Win")
            {
                gamesWon++;
            }
            else
            {
                gamesLost++;
            }
            if (gameControl2.returnRadio == "Win")
            {
                gamesWon++;
            }
            else
            {
                gamesLost++;
            }
            if(gameControl3.returnRadio == "Win")
            {
                gamesWon++;
            }
            else
            {
                gamesLost++;
            }
            if (gameControl4.returnRadio == "Win")
            {
                gamesWon++;
            }
            else
            {
                gamesLost++;
            }
           
                pointsScored = int.Parse(gameControl1.returnPointsScored) + int.Parse(gameControl2.returnPointsScored) + int.Parse(gameControl3.returnPointsScored) + int.Parse(gameControl4.returnPointsScored);
                pointsAllowed = int.Parse(gameControl1.returnPointsAllowed) + int.Parse(gameControl2.returnPointsAllowed) + int.Parse(gameControl3.returnPointsAllowed) + int.Parse(gameControl4.returnPointsAllowed);
                numOfSpecs = int.Parse(gameControl1.returnSpectators) + int.Parse(gameControl2.returnSpectators) + int.Parse(gameControl3.returnSpectators) + int.Parse(gameControl4.returnSpectators);
 
                averageSpecs = numOfSpecs / 4;
                diffInPoints = pointsAllowed - pointsScored;
                winningPerc = (((Double) gamesWon / 4) * 100);
                pnlInfo.Visible = true;
               
                //print summary info
                lblGamesWon.Text = "Games Won: " + gamesWon;
                lblGamesLost.Text = "Games Lost: " + gamesLost;
                lblWinningPerc.Text = "Winning Percentage: " + winningPerc.ToString("F") + "%";
                lblTotalPoints.Text = "Total Points Scored: " + pointsScored;
                lblAllowedPoints.Text = "Total Points Allowed: " + pointsAllowed;
                lblSpectators.Text = "# of Spectators: " + numOfSpecs;
                lblAverageSpec.Text = "Average # of Spectators: " + averageSpecs;
                lblDifference.Text = "Point Difference: " + diffInPoints;
          
        }//end of submit button method  
      }//end of class
    }//end of namespace
