using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WrapPanel
{
    /// <summary>
    /// Summary description for ContentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class ContentService : System.Web.Services.WebService
    {
        private static readonly Random Random = new System.Random();

        [WebMethod]
        public List<ContentItem> GetContent()
        {
            var items = new List<ContentItem>();

            for (var i = 0; i < 100; i++)
            {
                var item = new ContentItem();

                var count = Random.Next(10, 400);

                for (var j = 0; j < count; j++)
                {
                    item.Html += j + " ";
                }

                items.Add(item);
            }

            return items;
        }
    }
    
    [Serializable]
    public class ContentItem
    {
        public String Html { set; get; }
    }
}
