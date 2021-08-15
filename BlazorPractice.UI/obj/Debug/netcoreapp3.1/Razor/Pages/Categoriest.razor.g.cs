#pragma checksum "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fc3a37f6f20822b6ad5b21d62d44e39adc1e6f9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPractice.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\_Imports.razor"
using BlazorPractice.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\_Imports.razor"
using BlazorPractice.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
using BlazorLib.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class Categoriest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Categorias</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 8 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
    Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 10 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
 if (categories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<table class=\"table\">\r\n        <tbody>\r\n            <tr>\r\n                <td colspan=\"2\"><a href=\"/formulario\">Agregar una Nueva Categoria</a></td>\r\n            </tr>\r\n        </tbody>\r\n\r\n    </table>\r\n    ");
            __builder.OpenElement(8, "table");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<thead>\r\n            <tr><th>Nombre</th></tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 29 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
             foreach (var category in categories)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#nullable restore
#line 32 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
                       category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "/formulario/" + (
#nullable restore
#line 34 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
                                          category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-primary mr-2 ml-2");
            __builder.AddAttribute(25, "role", "button");
            __builder.AddAttribute(26, "aria-pressed", "true");
            __builder.AddContent(27, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "/eliminar/" + (
#nullable restore
#line 37 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
                                        category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "btn btn-danger");
            __builder.AddAttribute(35, "role", "button");
            __builder.AddAttribute(36, "aria-pressed", "true");
            __builder.AddContent(37, "Borrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 40 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 43 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\Categoriest.razor"
       
    public IEnumerable<Categories> categories { get; set; }
    public string Message { get; set; }

    protected async override  Task OnInitializedAsync()
    {
        try
        {
            categories = await CategoryService.GetAllCategories();
        }
        catch(Exception e)
        {
            Message = "Something went wrong..." + e.Message;
        }
       
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
