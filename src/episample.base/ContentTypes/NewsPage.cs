using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace episamplebase.ContentTypes
{
    [ContentType(DisplayName = "NewsPage", GUID = "8d23a83d-0af3-459e-93a6-6c7001b1e4ea", Description = "")]
    public class NewsPage : PageData
    {
      
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         
    }
}