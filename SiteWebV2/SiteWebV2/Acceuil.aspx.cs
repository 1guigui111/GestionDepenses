﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Acceuil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rep_data.DataSource = SiteWebV2.CoBD.GetListFacGaz();
        rep_data.DataBind();
    }
}