#pragma checksum "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a90c3123d30794717b4abc41ec358f71cf878561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Edit), @"mvc.1.0.view", @"/Views/Restaurants/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Edit.cshtml", typeof(AspNetCore.Views_Restaurants_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a90c3123d30794717b4abc41ec358f71cf878561", @"/Views/Restaurants/Edit.cshtml")]
    public class Views_Restaurants_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodFinder.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 36, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this task: ");
            EndContext();
            BeginContext(101, 36, false);
#line 9 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(137, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(175, 35, false);
#line 13 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml"
Write(Html.HiddenFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(215, 34, false);
#line 15 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(253, 35, false);
#line 16 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(293, 37, false);
#line 18 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(334, 30, false);
#line 19 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml"
Write(Html.DropDownList("CuisineId"));

#line default
#line hidden
            EndContext();
            BeginContext(366, 39, true);
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 22 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Restaurants/Edit.cshtml"
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
