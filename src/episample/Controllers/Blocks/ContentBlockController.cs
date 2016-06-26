using System.Web.Mvc;
using EPiServer.Web.Mvc;
using episamplebase.BlockTypes;

namespace episample.Controllers.Blocks
{
    public class ContentBlockController : BlockController<ContentBlock>
    {
        public override ActionResult Index(ContentBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
