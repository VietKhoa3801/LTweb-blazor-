#pragma checksum "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Greeting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b27628b51515a8234d6fd0842ff9a0db2d01a6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using BlazorExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using BlazorExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/greeting")]
    public partial class Greeting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
#nullable restore
#line 2 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Greeting.razor"
__builder.AddContent(1, title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "placeholder", "Your name");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Greeting.razor"
                                                     name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "placeholder", "Your address");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Greeting.razor"
                                                        address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => address = __value, address));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Greeting.razor"
                      Welcome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddContent(31, "Welcome!");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.OpenElement(34, "h3");
#nullable restore
#line 25 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Greeting.razor"
__builder.AddContent(35, greeting);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Greeting.razor"
      
    private string title = "Greeting From Blazor";
    private string name;
    private string address;
    private string greeting;
    private void Welcome()
    {
        if(!string.IsNullOrEmpty(name)&&!string.IsNullOrEmpty(address))
        {
            greeting = $"Hello {name} from {address}. Welcome to My Company!";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
