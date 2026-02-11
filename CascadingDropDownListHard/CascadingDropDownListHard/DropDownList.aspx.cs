using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace CascadingDropDownListHard
{
    public partial class DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            if (!IsPostBack)
            {
                ddlStates.Enabled = false;
                ddlCities.Enabled = false;
                btnSubmit.Enabled = false;
                var data = new VerifyGetData().VerifyGetCountry();
                if (data is string)
                {
                    lblMessage.Text = data.ToString();
                }
                else
                {
                    ddlCountries.DataSource = data;
                    ddlCountries.DataTextField = "CountryName";
                    ddlCountries.DataValueField = "CountryID";
                    ddlCountries.DataBind();
                    ddlCountries.Items.Insert(0, new ListItem("--Select Country--", "0"));
                }
            }
        }

        protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            ddlStates.Enabled = true;
            ddlCities.Enabled = false;
            var data = new VerifyGetData().VerifyGetState(Convert.ToInt32(ddlCountries.SelectedItem.Value));
            if (data is string)
            {
                lblMessage.Visible = true;
                lblMessage.Text = data.ToString();
            }
            else
            {
                ddlStates.DataSource = data;
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "StateID";
                ddlStates.DataBind();
                ddlStates.Items.Insert(0, new ListItem("--Select State--", "0"));
            }
        }
        protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCities.Enabled = true;
            btnSubmit.Enabled = false;
            var data = new VerifyGetData().VerifyGetCity(Convert.ToInt32(ddlStates.SelectedItem.Value));
            if (data is string)
            {
                lblMessage.Visible = true;
                lblMessage.Text = data.ToString();
            }
            else
            {
                ddlCities.DataSource = data;
                ddlCities.DataTextField = "CityName";
                ddlCities.DataValueField = "CityID";
                ddlCities.DataBind();
                ddlCities.Items.Insert(0, new ListItem("--Select City--", "0"));
            }
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
            lblMessage.Text = ("Country: " + ddlCountries.SelectedItem.Text +
                ", State: " + ddlStates.SelectedItem.Text +
                ", City: " + ddlCities.SelectedItem.Text);
        }
    }
}