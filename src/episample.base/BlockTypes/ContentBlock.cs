using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace episamplebase.BlockTypes
{
    [ContentType(DisplayName = "ContentBlock", GUID = "d9f0e538-737a-4c15-be3a-75b26aff8abe", Description = "")]
    public class ContentBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Main Body",
            Description = "Main body",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}