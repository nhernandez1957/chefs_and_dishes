#pragma checksum "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/Home/AllDishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7e3614f4bf7a60ca9597fd474ac3d075c2b34a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllDishes), @"mvc.1.0.view", @"/Views/Home/AllDishes.cshtml")]
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
#nullable restore
#line 1 "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/_ViewImports.cshtml"
using chefs_and_dishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/_ViewImports.cshtml"
using chefs_and_dishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e3614f4bf7a60ca9597fd474ac3d075c2b34a7", @"/Views/Home/AllDishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3c2f18ea2077decb990ca90b4a25e8a6418780c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllDishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<a href=""/add/dish"" class=""btn btn-info float-right"">Add a Dish</a>
<div class=""text-center"">
    <h1 class=""display-2""><a href=""/"">Chefs</a> | Dishes</h1>
    <table class=""table table-hover table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Chef</th>
                <th scope=""col"">Tastiness</th>
                <th scope=""col"">Calories</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 15 "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/Home/AllDishes.cshtml"
         foreach (Dish d in ViewBag.AllDishes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
#nullable restore
#line 18 "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/Home/AllDishes.cshtml"
                           Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 19 "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/Home/AllDishes.cshtml"
               Write(d.Chef.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/Home/AllDishes.cshtml"
                                 Write(d.Chef.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 20 "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/Home/AllDishes.cshtml"
               Write(d.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/Home/AllDishes.cshtml"
               Write(d.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 23 "/Users/nicholashernandez/Desktop/C#/C#_.NETCore/chefs_and_dishes/Views/Home/AllDishes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
