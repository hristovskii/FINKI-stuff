using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace internet_tehnologii_lab1_grupa_b
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string subject = Subject.Text;
            string credit = Credit.Text;

            if(credit.Length > 0 && subject.Length > 0)
            {
                ListItem listItem = new ListItem();
                listItem.Text = subject;

                //proveruva dali se vnesuva po vtor pat ist predmet 
                foreach(ListItem item in lbSubjects.Items)
                {
                    if(item.Text == listItem.Text)
                    {
                        return; // ne dozvoluva da se stavi vtor predmet
                    }
                }

                if(subject == "Napredno programiranje")
                {
                    listItem.Value = "Gjorgji Madjarov";
                    lbSubjects.Items.Add(listItem);
                    lbCredits.Items.Add(credit);
                }
                if (subject == "Strukturno programiranje")
                {
                    listItem.Value = "Stefan Andonov";
                    lbSubjects.Items.Add(listItem);
                    lbCredits.Items.Add(credit);
                }
                if (subject == "Objektno programiranje")
                {
                    listItem.Value = "Vlatko Spasev";
                    lbSubjects.Items.Add(listItem);
                    lbCredits.Items.Add(credit);
                }
            }

            Credit.Text = "";
            Subject.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lbSubjects.Items.Remove(lbSubjects.SelectedItem);
            lbCredits.Items.Remove(lbCredits.SelectedItem);
            wantedProfessor.Text = "";
        }

        protected void lbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            wantedProfessor.Text = lbSubjects.SelectedItem.Value;
            int index = lbSubjects.SelectedIndex;
            foreach(ListItem item in lbCredits.Items)
            {
                item.Selected = false;
            }
            lbCredits.Items[index].Selected = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("uspesnoGlasanje.aspx");
        }
    }
}