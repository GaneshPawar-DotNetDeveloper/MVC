using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace HelperClass.Common
{
    public static class CustomHTMLHelper
    {
        // here we can write a extension method
        // in that method we can write a logic
        public static MvcHtmlString Image(this HtmlHelper html,string src)
        {
            TagBuilder image=new TagBuilder("img");
            image.Attributes.Add("src", src);
            return new MvcHtmlString(image.ToString());
        }

    }
}