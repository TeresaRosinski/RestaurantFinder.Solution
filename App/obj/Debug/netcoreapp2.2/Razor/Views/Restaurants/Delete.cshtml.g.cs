#pragma checksum "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64139634500f909a3053ec4bc522b0acb5fe1480"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Delete), @"mvc.1.0.view", @"/Views/Restaurants/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Delete.cshtml", typeof(AspNetCore.Views_Restaurants_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64139634500f909a3053ec4bc522b0acb5fe1480", @"/Views/Restaurants/Delete.cshtml")]
    public class Views_Restaurants_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodFinder.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 55, true);
            WriteLiteral("\n<h2>Are you sure want to remove this restaurant?<h2>\n\n");
            EndContext();
            BeginContext(120, 40, false);
#line 9 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(160, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(163, 36, false);
#line 9 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(199, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(228, 41, true);
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Delete.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodFinder.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
