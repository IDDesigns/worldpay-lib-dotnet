﻿using System;
using System.Web.UI.WebControls;

namespace Worldpay.Sdk.Examples
{
    public partial class APMFailure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            onAuthorizeOrder(this, null);
        }

        protected void onAuthorizeOrder(object sender, CommandEventArgs e)
        {
            string orderCode = (string)Session["orderCode"];
            OrderResponse.Text = "There was an error authorizing the APM Order <span id='order-code'>" + orderCode + "</span><br />";
        }
    }
}