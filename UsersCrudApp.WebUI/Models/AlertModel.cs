using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersCrudApp.WebUI.Models
{
    public class AlertModel
    {
        public AlertModel(string message, string css)
        {
            Message = message;
            cssClass = css;
        }
        public readonly string Message;
        public readonly string cssClass;
    }
}