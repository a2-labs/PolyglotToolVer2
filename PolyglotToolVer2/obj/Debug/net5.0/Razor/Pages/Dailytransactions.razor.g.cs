#pragma checksum "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9408bfd4a0d4438ab5b2c4b49081b2c35b3759d"
// <auto-generated/>
#pragma warning disable 1591
namespace PolyglotToolVer2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/_Imports.razor"
using PolyglotToolVer2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/_Imports.razor"
using PolyglotToolVer2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
using PolyglotToolVer2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dailytransactions")]
    public partial class Dailytransactions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(2);
                __builder2.AddAttribute(3, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudPaper>(6);
                    __builder3.AddAttribute(7, "Class", "pa-16 ma-2");
                    __builder3.AddAttribute(8, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                                                3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudDateRangePicker>(10);
                        __builder4.AddAttribute(11, "Label", "Επιλέξτε διάστημα");
                        __builder4.AddAttribute(12, "DateFormat", "dd/MM/yyyy");
                        __builder4.AddAttribute(13, "DateRange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DateRange>(
#nullable restore
#line 16 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                                                                                          _dateRange

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "DateRangeChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MudBlazor.DateRange>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MudBlazor.DateRange>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dateRange = __value, _dateRange))));
                        __builder4.AddAttribute(15, "PickerActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudButton>(16);
                            __builder5.AddAttribute(17, "Class", "mr-auto align-self-start");
                            __builder5.AddAttribute(18, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                                                                           () => _picker.Clear()

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(20, "Καθαρισμος");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(21, "\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudButton>(22);
                            __builder5.AddAttribute(23, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                                          () => _picker.Close(false)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(25, "Ακυρωση");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(26, "\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudButton>(27);
                            __builder5.AddAttribute(28, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 20 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                                      Color.Primary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(29, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                                                                () => _picker.Close()

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(31, "Επιλογη");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.AddComponentReferenceCapture(32, (__value) => {
#nullable restore
#line 16 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                                      _picker = (MudBlazor.MudDateRangePicker)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(34);
                    __builder3.AddAttribute(35, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 24 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 24 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                                                   Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                                                                           showTransactions

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(39, "ΕΜΦΑΝΙΣΗ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(41);
                __builder2.AddAttribute(42, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Dailytransactions.razor"
       
    private const string companyId = "1";

    //int selectedValue { get; set; } = 1;

    List<Dictionary<string, object>> Data { get; set; } = new List<Dictionary<string, object>>();
    int Total { get; set; }
    bool ExportAllPages { get; set; } = true;

    MudDateRangePicker _picker;
    DateRange _dateRange = new DateRange(DateTime.Now.Date, DateTime.Now.Date);
    DataTable tableTransactions { get; set; }

    private void showTransactions()
    {
        DateTime fromDate = _dateRange.Start.Value;
        DateTime toDate = _dateRange.End.Value;

        string fiscalId = findFiscalID(fromDate.ToString("yyyy"));
        string emp013 = $"E{companyId}_Emp013_{fiscalId}";
        string emp016 = $"E{companyId}_Emp016_{fiscalId}";
        string emp017 = $"E{companyId}_Emp017_{fiscalId}";
        string emp123 = $"E{companyId}_Emp123_{fiscalId}";


        Snackbar.Add($"Από Ημερομηνία {fromDate.ToString("dd-MM-yyyy")} έως {toDate.ToString("dd-MM-yyyy")}");

        string query = $"SELECT DISTINCT ΗΜΕΡΟΜΗΝΙΑ, ΚΩΔΙΚΟΣ, ΠΕΡΙΓΡΑΦΗ, ΠΡΟΜΗΘΕΥΤΗΣ, ΕΚΔΟΤΗΣ, " +
"                             (SELECT        SUM(quantity) AS Expr1 " +
"                               FROM            (SELECT        Emp016.DatePar AS ΗΜΕΡΟΜΗΝΙΑ, Emp013.Kwd AS ΚΩΔΙΚΟΣ, Emp013.Perigrafh AS ΠΕΡΙΓΡΑΦΗ, Emp013.PromCompany AS ΠΡΟΜΗΘΕΥΤΗΣ, " +
"                                                                                    Emp123.CustomField_2 AS ΕΚΔΟΤΗΣ, CASE WHEN [Emp017].[Apo] = '-' THEN [Emp017].[Posothta] WHEN [Emp017].[Apo] = '+' THEN (- 1)  " +
"                                                                                   * [Emp017].[Posothta] END AS quantity " +
$"                                                         FROM            dbo.{emp016} AS Emp016 INNER JOIN " +
$"                                                                                   dbo.{emp017} AS Emp017 ON Emp016.Kwd = Emp017.Kwd INNER JOIN " +
$"                                                                                   dbo.{emp013} AS Emp013 ON Emp017.KwdEidous = Emp013.Kwd INNER JOIN " +
$"                                                                                   dbo.{emp123} AS Emp123 ON Emp013.ApoID = Emp123.IdRec " +
"                                                         WHERE        (Emp017.Apo <> N'0') AND (Emp016.KwdPar <> 999) AND (Emp016.CheckPoint2 <> N'A') AND (Emp016.EidosTimologhshs < 3) AND  " +
$"                                                                                  (CAST(Emp016.DatePar AS date) >= CAST('{fromDate.ToString("yyyy-MM-dd")}' AS date) AND" +
$"                                                                                  (CAST(Emp016.DatePar AS date) <= CAST('{toDate.ToString("yyyy-MM-dd")}' AS date) " +
"))) AS aaa " +
"                               WHERE        (ΚΩΔΙΚΟΣ = tmp.ΚΩΔΙΚΟΣ)) AS ΠΟΣΟΤΗΤΑ, STOCK " +
"FROM            (SELECT        Emp016.DatePar AS ΗΜΕΡΟΜΗΝΙΑ, Emp013.Kwd AS ΚΩΔΙΚΟΣ, Emp013.Perigrafh AS ΠΕΡΙΓΡΑΦΗ, Emp013.PromCompany AS ΠΡΟΜΗΘΕΥΤΗΣ,  " +
"                                                    Emp123.CustomField_2 AS ΕΚΔΟΤΗΣ, CASE WHEN [Emp017].[Apo] = '-' THEN [Emp017].[Posothta] WHEN [Emp017].[Apo] = '+' THEN (- 1)  " +
"                                                    * [Emp017].[Posothta] END AS quantity, Emp013.PrYpol + Emp013.Ypoloipo AS STOCK " +
$"                          FROM            dbo.{emp016} AS Emp016 INNER JOIN " +
$"                                                    dbo.{emp017} AS Emp017 ON Emp016.Kwd = Emp017.Kwd INNER JOIN " +
$"                                                    dbo.{emp013} AS Emp013 ON Emp017.KwdEidous = Emp013.Kwd INNER JOIN " +
$"                                                    dbo.{emp123} AS Emp123 ON Emp013.ApoID = Emp123.IdRec " +
"                          WHERE        (Emp017.Apo <> N'0') AND (Emp016.KwdPar <> 999) AND (Emp016.CheckPoint2 <> N'A') AND (Emp016.EidosTimologhshs < 3) AND  " +
$"                                                    (CAST(Emp016.DatePar AS date) >= CAST('{fromDate.ToString("yyyy-MM-dd")}' AS date) AND  " +
$"                                                    (CAST(Emp016.DatePar AS date) <= CAST('{toDate.ToString("yyyy-MM-dd")}' AS date) " +
"))) AS tmp ";
        tableTransactions = sql.readTableFromSql(query);
    }

    private string findFiscalID(string year)
    {
        string result = null;
        string query = $"Select id from emp998 where idEtairias = 1 and name = '{year}'";
        result = sql.findField(query);
        return result;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PolyglotToolVer2.Data.classSQL sql { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
#pragma warning restore 1591