﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace netOpenShop.Masters
{
    public partial class Generic : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            form1.Action = Request.RawUrl;
        }
    }
}