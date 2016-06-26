using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace episamplebase.ContentTypes
{
    [ContentType(DisplayName = "StartPage", GUID = "822bbc87-787e-488e-9690-d125b6d9c6ae", Description = "My Fist EPiServer Page")]
public class StartPage : PageData
{
    
            [CultureSpecific]
            [Display(
                Name = "Main body",
                Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                GroupName = SystemTabNames.Content,
                Order = 1)]
            public virtual XhtmlString MainBody { get; set; }
        [CultureSpecific]
        [Display(
                Name = "Main Area",
                Description = "Draggable blocks can be placed here",
                GroupName = SystemTabNames.Content,
                Order = 1)]
        public virtual ContentArea MainArea { get; set; }

    }
}