using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            
            if (MainTextBox.Enabled == false)
            {
                MainTextBox.Enabled = true;
                MainTextBox.Text = "";
                CapitalLabel.Text = "";
                SubmitButton.Text = "Submit";
            }
            else
            {
                int capitals;

                MainTextBox.Enabled = false;

                capitals = TextAnalyzer.GetNumberOfCapitals(MainTextBox.Text);

                //Render capital in CapitalLabel.
                CapitalLabel.Text = String.Format("Det är {0} versaler i denna texten.", capitals.ToString());

                SubmitButton.Text = "Clear";
            }
            

        }
    }
}