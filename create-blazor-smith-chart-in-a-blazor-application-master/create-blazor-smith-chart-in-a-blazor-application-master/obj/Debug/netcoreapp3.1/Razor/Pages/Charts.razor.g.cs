#pragma checksum "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Charts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8893ed87c6d5848464b4ef033e4798ef6688cb58"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/charts")]
    public partial class Charts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfChart>(0);
            __builder.AddAttribute(1, "Title", "Monthly Sales Analysis");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryXAxis>(4);
                __builder2.AddAttribute(5, "ValueType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ValueType>(
#nullable restore
#line 5 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Charts.razor"
                                      Syncfusion.Blazor.Charts.ValueType.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Title", "Months");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryYAxis>(8);
                __builder2.AddAttribute(9, "Title", "Sales");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartLegendSettings>(11);
                __builder2.AddAttribute(12, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Charts.razor"
                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartTooltipSettings>(14);
                __builder2.AddAttribute(15, "Enable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Charts.razor"
                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartSeriesCollection>(17);
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(20);
                    __builder3.AddAttribute(21, "Type", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 13 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Charts.razor"
                               ChartSeriesType.Column

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "DataSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Charts.razor"
                                                                    Sales

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "XName", "Month");
                    __builder3.AddAttribute(24, "YName", "SalesValue");
                    __builder3.AddAttribute(25, "Name", "Sales");
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(27, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.ChartMarker>(28);
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(30, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.ChartDataLabel>(31);
                            __builder5.AddAttribute(32, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Charts.razor"
                                             true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(33, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(34, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Viet Khoa\Downloads\create-blazor-smith-chart-in-a-blazor-application-master\create-blazor-smith-chart-in-a-blazor-application-master\Pages\Charts.razor"
       
    public class SalesData
    {
        public string Month { get; set; }
        public double SalesValue { get; set; }
    }

    public List<SalesData> Sales = new List<SalesData> 
    {
        new SalesData { Month = "January", SalesValue = 35 },
        new SalesData { Month = "February", SalesValue = 28 },
        new SalesData { Month = "March", SalesValue = 34 },
        new SalesData { Month = "April", SalesValue = 32 },
        new SalesData { Month = "May", SalesValue = 40 },
        new SalesData { Month = "June", SalesValue = 32 },
        new SalesData { Month = "July", SalesValue = 35 }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591