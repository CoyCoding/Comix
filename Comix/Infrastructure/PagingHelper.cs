using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Comix.Infrastructure
{
    public static class PagingHelper
    {
        public static MvcHtmlString PagingLinks(this HtmlHelper html, PageModel pageInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= pageInfo.TotalPages; i++)
            {
                TagBuilder htmlTag = new TagBuilder("a");
                htmlTag.MergeAttribute("href", pageUrl(i));
                htmlTag.InnerHtml = i.ToString();
                if (i == pageInfo.CurrentPage)
                {
                    htmlTag.AddCssClass("btn-info btn btn-default active");
                }
                else
                {
                    htmlTag.AddCssClass("btn btn-default btn-outline-info");
                }

                result.Append(htmlTag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}
