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
            int pointsScored = 0, pointsAllowed = 0, numOfSpecs = 0, averageSpecs = 0, diffInPoints = 0, gamesWon = 0, gamesLost = 0;
            double winningPerc = 0;
            Boolean invalidInput = true, validation = true;
            lblSummary.Text = "";
            lblErrors.Text = "";
            lblAllowedPoints.Text = "";
            lblAverageSpec.Text = "";
            lblDifference.Text = "";
            lblGamesLost.Text = "";
            lblGamesWon.Text = "";
            lblWinningPerc.Text = "";
            lblTotalPoints.Text = "";
            lblErrors.Text = "";
            pnlErrors.Visible = true;
            pnlInfo.Visible = true;
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

            //checking if any fields are blank
            if (gameControl1.returnPointsScored == "" || gameControl2.returnPointsScored == "" || gameControl3.returnPointsScored == "" || gameControl4.returnPointsScored == "")
            {
                lblErrors.Text += "Please Fill In The Points Scored Field In all Games !\n";
                invalidInput = false;
            }
            if (gameControl1.returnPointsAllowed == "" || gameControl2.returnPointsAllowed == "" || gameControl3.returnPointsAllowed == "" || gameControl4.returnPointsAllowed == "")
            {
                lblErrors.Text += "Please Fill In The Points Allowed Field In all Games !\n";
                invalidInput = false;
            }
            if (gameControl1.returnSpectators == "" || gameControl2.returnSpectators == "" || gameControl3.returnSpectators == "" || gameControl4.returnSpectators == "")
            {
                lblErrors.Text += "Please Fill In The Spectator Field In all Games !\n";
                invalidInput = false;
            }

            //If all inputs are validated correctly parse the numbers
            if (invalidInput)
            {
                pointsScored = int.Parse(gameControl1.returnPointsScored) + int.Parse(gameControl2.returnPointsScored) + int.Parse(gameControl3.returnPointsScored) + int.Parse(gameControl4.returnPointsScored);
                pointsAllowed = int.Parse(gameControl1.returnPointsAllowed) + int.Parse(gameControl2.returnPointsAllowed) + int.Parse(gameControl3.returnPointsAllowed) + int.Parse(gameControl4.returnPointsAllowed);
                numOfSpecs = int.Parse(gameControl1.returnSpectators) + int.Parse(gameControl2.returnSpectators) + int.Parse(gameControl3.returnSpectators) + int.Parse(gameControl4.returnSpectators);

                //after getting numeric inputs check if any are negative
                if (int.Parse(gameControl1.returnPointsScored) < 0 || int.Parse(gameControl2.returnPointsScored) < 0 || int.Parse(gameControl3.returnPointsScored) < 0 || int.Parse(gameControl4.returnPointsScored) < 0)
                {
                    lblErrors.Text += "Points Scored must be greater or equal to zero\n";
                    validation = false;
                }
                else if (int.Parse(gameControl1.returnPointsAllowed) < 0 || int.Parse(gameControl2.returnPointsAllowed) < 0 || int.Parse(gameControl3.returnPointsAllowed) < 0 || int.Parse(gameControl4.returnPointsAllowed) < 0)
                {
                    lblErrors.Text += "Points Allowed must be greater or equal to zero\n";
                    validation = false;
                }
                else if (int.Parse(gameControl1.returnSpectators) < 0 || int.Parse(gameControl2.returnSpectators) < 0 || int.Parse(gameControl3.returnSpectators) < 0 || int.Parse(gameControl4.returnSpectators) < 0)
                {
                    lblErrors.Text += "# of Spectators must be greater or equal to zero\n";
                    validation = false;
                }

                //if all numbers are positive check if points allowed is more than points scored
                if(int.Parse(gameControl1.returnPointsAllowed) - int.Parse(gameControl1.returnPointsScored) <= 0)
                {
                    lblErrors.Text += "Points Scored must be less than Points Allowed";
                    gameControl1.FindControl("txtPointsScored").Focus();
                    validation = false;
                } 
                else if(int.Parse(gameControl2.returnPointsAllowed) - int.Parse(gameControl2.returnPointsScored) <= 0)
                {
                    lblErrors.Text += "Points Scored must be less than Points Allowed";
                    gameControl2.FindControl("txtPointsScored").Focus();
                    validation = false;
                } 
                else if(int.Parse(gameControl3.returnPointsAllowed) - int.Parse(gameControl3.returnPointsScored) <=0)
                {
                    lblErrors.Text += "Points Scored must be less than Points Allowed";
                    gameControl3.FindControl("txtPointsScored").Focus();
                    validation = false;
                }
                else if(int.Parse(gameControl4.returnPointsAllowed) - int.Parse(gameControl4.returnPointsScored) <=0)
                {
                    lblErrors.Text += "Points Scored must be less than Points Allowed";
                    gameControl4.FindControl("txtPointsScored").Focus();
                    validation = false;
                }

                //if all conditions are met, do the calculations and print the summary
                if (validation)
                { 
                averageSpecs = numOfSpecs / 4;
                diffInPoints = pointsAllowed - pointsScored;
                winningPerc = (((Double) gamesWon / 4) * 100);

                //print summary info
                lblSummary.Text = "Summary Of Games";
                lblGamesWon.Text = "Games Won: " + gamesWon;
                lblGamesLost.Text = "Games Lost: " + gamesLost;
                lblWinningPerc.Text = "Winning Percentage: " + winningPerc + "%";
                lblTotalPoints.Text = "Total Points Scored: " + pointsScored;
                lblAllowedPoints.Text = "Total Points Allowed: " + pointsAllowed;
                lblSpectators.Text = "# of Spectators: " + numOfSpecs;
                lblAverageSpec.Text = "Average # of Spectators: " + averageSpecs;
                lblDifference.Text = "Point Difference: " + diffInPoints;
            }// end of if for calculations
            }//end of if for validation

        }//end of submit button method  

        }//end of class
    }//end of namespace
