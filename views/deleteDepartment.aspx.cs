﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HR;
namespace HR_SYSTEM.views
{
    public partial class deleteDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);

            int check = Department.delete(id);

            if (check == 1)
            {
                Response.Redirect("departments.aspx");
            }
            else {
                header1.showAlert("Something went wrong");
            }
        }
    }
}