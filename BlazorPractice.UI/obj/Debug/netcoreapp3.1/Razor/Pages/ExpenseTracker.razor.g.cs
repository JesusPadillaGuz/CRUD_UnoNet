#pragma checksum "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\ExpenseTracker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4dfaff0c30d99fe2a3491c0c01b06e4d0b7f30"
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
#line 1 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\ExpenseTracker.razor"
using BlazorPractice.UI.Components;

#line default
#line hidden
#nullable disable
    public partial class ExpenseTracker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ExpenseTracker</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorPractice.UI.Components.TabControl>(1);
            __builder.AddAttribute(2, "tabTitle", (Microsoft.AspNetCore.Components.RenderFragment<BlazorPractice.UI.Components.TabPage>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n        ");
                __builder2.OpenElement(4, "img");
                __builder2.AddAttribute(5, "src", "/images/" + (
#nullable restore
#line 10 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\ExpenseTracker.razor"
                            context.imgSource

#line default
#line hidden
#nullable disable
                ) + ".png");
                __builder2.AddAttribute(6, "style", "width: 25%;");
                __builder2.CloseElement();
                __builder2.AddContent(7, "  ");
                __builder2.AddContent(8, 
#nullable restore
#line 10 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\ExpenseTracker.razor"
                                                                             context.Text

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(9, "\r\n    ");
            }
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<BlazorPractice.UI.Components.TabPage>(12);
                __builder2.AddAttribute(13, "Text", "Expense");
                __builder2.AddAttribute(14, "imgSource", "menos");
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n          ");
                    __builder3.OpenComponent<BlazorPractice.UI.Pages.ExpenseDetails>(17);
                    __builder3.AddAttribute(18, "ExpenseType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorLib.Model.ExpenseType>(
#nullable restore
#line 15 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\ExpenseTracker.razor"
                                        BlazorLib.Model.ExpenseType.Expense

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenComponent<BlazorPractice.UI.Components.TabPage>(21);
                __builder2.AddAttribute(22, "Text", "Income");
                __builder2.AddAttribute(23, "imgSource", "mas");
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenComponent<BlazorPractice.UI.Pages.ExpenseDetails>(26);
                    __builder3.AddAttribute(27, "ExpenseType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorLib.Model.ExpenseType>(
#nullable restore
#line 18 "D:\Users\Omen\source\repos\BlazorPractice\BlazorPractice.UI\Pages\ExpenseTracker.razor"
                                          BlazorLib.Model.ExpenseType.Income

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
