#if false //stay within free-quota limit
using ServiceStack;
using ServiceStack.Script;

namespace SharpScript
{
    [Route("/products/view")]
    public class ViewProducts
    {
        public string Id { get; set; }
    }

    public class ProductsServices : Service
    {
        public object Any(ViewProducts request) =>
            new PageResult(Request.GetCodePage("products")) {
                Args = {
                    ["products"] = TemplateQueryData.Products
                }
            };
    }
}
#endif