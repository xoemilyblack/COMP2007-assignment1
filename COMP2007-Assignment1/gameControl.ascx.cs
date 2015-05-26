using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007_Assignment1
{
    public partial class gameControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public string returnRadio
        {
            get
            {
                return rblResults.SelectedValue;
            }
        }
        public string returnPointsScored
        {
            get
            {
                return txtPointsScored.Text;
            }
        }
        public string returnPointsAllowed
        {
            get
            {
                return txtPointAllowed.Text;
            }
        }
        public string returnSpectators
        {
            get
            {
                return txtSpectators.Text;
            }
        }
    }
}