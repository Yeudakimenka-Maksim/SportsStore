using System;
using System.Text;
using System.Web.Mvc;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            var result = new StringBuilder();
            for (int page = 1; page <= pagingInfo.TotalPages; page++)
            {
                var tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(page));
                tag.InnerHtml = page.ToString();
                if (page == pagingInfo.CurrentPage)
                    tag.AddCssClass("selected");
                result.Append(tag);
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}