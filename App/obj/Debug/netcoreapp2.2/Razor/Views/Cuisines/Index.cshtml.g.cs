#pragma checksum "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e0d11aa4b747ad490156cb225a3fbbb18c9b485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Index), @"mvc.1.0.view", @"/Views/Cuisines/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Index.cshtml", typeof(AspNetCore.Views_Cuisines_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 5 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Index.cshtml"
using FoodFinder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e0d11aa4b747ad490156cb225a3fbbb18c9b485", @"/Views/Cuisines/Index.cshtml")]
    public class Views_Cuisines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FoodFinder.Models.Cuisine>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(95, 20, true);
            WriteLiteral("\n<h1>Cuisines</h1>\n\n");
            EndContext();
#line 10 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(141, 59, true);
            WriteLiteral("  <h3>No Cuisines have been added yet, add a cuisine!</h3>\n");
            EndContext();
#line 13 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Index.cshtml"
}

#line default
#line hidden
            BeginContext(202, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Index.cshtml"
 foreach(Cuisine cuisine in Model)
{

#line default
#line hidden
            BeginContext(240, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(247, 75, false);
#line 17 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Index.cshtml"
 Write(Html.ActionLink($"{cuisine.Type}", "Details", new {id = cuisine.CuisineId}));

#line default
#line hidden
            EndContext();
            BeginContext(322, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FoodFinder.Models.Cuisine>> Html { get; private set; }
    }
}
#pragma warning restore 1591