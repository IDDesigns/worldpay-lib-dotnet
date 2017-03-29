using System;
using Worldpay.Sdk.Models;

namespace Worldpay.Sdk.Examples
{
    public partial class ErrorControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void DisplayError(ApiError apiError)
        {
            ErrorPanel.Visible = true;
            ErrorCode.Text = apiError.customCode;
            HttpStatus.Text = apiError.httpStatusCode.ToString();
            ErrorDescription.Text = apiError.description;
            ErrorMessage.Text = apiError.message;
        }
    }
}