#pragma checksum "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7eaaea708cd975a0a7b0cd374d9767a8143bc4"
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
#line 1 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
using PolyglotToolVer2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newvoucher")]
    public partial class Newvoucher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(2);
                __builder2.AddAttribute(3, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDatePicker>(7);
                    __builder3.AddAttribute(8, "Label", "Ημερομήνία Παραστατικών");
                    __builder3.AddAttribute(9, "DateFormat", "dd/MM/yyyy");
                    __builder3.AddAttribute(10, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 16 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                   date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => date = __value, date))));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(13);
                __builder2.AddAttribute(14, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(18);
                    __builder3.AddAttribute(19, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 19 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                   Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                           showTransactions

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(23, "ΕΜΦΑΝΙΣΗ");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 20 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
         if (Elements.Count != 0)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudButton>(24);
                    __builder3.AddAttribute(25, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 22 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 22 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                       Color.Tertiary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                                clearGrid

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(29, "Καθαρισμός");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(31);
                    __builder3.AddAttribute(32, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 23 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                       Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                                 sendVoucher

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(36, "Αποστολή Voucher");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 24 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 29 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
 if (Elements.Count != 0)
{

#line default
#line hidden
#nullable disable
            __Blazor.PolyglotToolVer2.Pages.Newvoucher.TypeInference.CreateMudTable_0(__builder, 37, 38, 
#nullable restore
#line 31 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                  Elements

#line default
#line hidden
#nullable disable
            , 39, 
#nullable restore
#line 31 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                   true

#line default
#line hidden
#nullable disable
            , 40, 
#nullable restore
#line 31 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                   true

#line default
#line hidden
#nullable disable
            , 41, 
#nullable restore
#line 31 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                  true

#line default
#line hidden
#nullable disable
            , 42, 
#nullable restore
#line 31 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
            , 43, 
#nullable restore
#line 31 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                                                new Func<PolyglotToolVer2.Data.Models.Sales,bool>(FilterFunc)

#line default
#line hidden
#nullable disable
            , 44, 
#nullable restore
#line 31 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                                                                                                                                   selectedItem

#line default
#line hidden
#nullable disable
            , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem = __value, selectedItem)), 46, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(47);
                __builder2.AddAttribute(48, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 33 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "Λίστα Παραστατικών της ");
                    __builder3.AddContent(51, 
#nullable restore
#line 33 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                        documentsDate.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudToolBarSpacer>(53);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\n        ");
                __Blazor.PolyglotToolVer2.Pages.Newvoucher.TypeInference.CreateMudTextField_1(__builder2, 55, 56, "Αναζήτηση", 57, 
#nullable restore
#line 35 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                                    Adornment.Start

#line default
#line hidden
#nullable disable
                , 58, 
#nullable restore
#line 35 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                                                                     Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 59, 
#nullable restore
#line 35 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                                                                                                             Size.Medium

#line default
#line hidden
#nullable disable
                , 60, "mt-0", 61, 
#nullable restore
#line 35 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                   searchString

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString = __value, searchString)));
            }
            , 63, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(64);
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "Επιλογή");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(68);
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(70, "Παραστατικό");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(72);
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(74, "Αριθμός");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(76);
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(78, "Επωνυμία");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(80);
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(82, "Σύνολο");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(84);
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(86, "Τρόπος Πληρωμής");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(88);
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(90, "Voucher");
                }
                ));
                __builder2.CloseComponent();
            }
            , 91, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(92);
                __builder2.AddAttribute(93, "DataLabel", "Επιλογή");
                __builder2.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.PolyglotToolVer2.Pages.Newvoucher.TypeInference.CreateMudCheckBox_2(__builder3, 95, 96, 
#nullable restore
#line 48 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                    , 97, 
#nullable restore
#line 48 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                                                                        false

#line default
#line hidden
#nullable disable
                    , 98, 
#nullable restore
#line 48 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                         context.check

#line default
#line hidden
#nullable disable
                    , 99, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.check = __value, context.check)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(101);
                __builder2.AddAttribute(102, "DataLabel", "Παραστατικό");
                __builder2.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(104, 
#nullable restore
#line 50 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                        context.document

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(106);
                __builder2.AddAttribute(107, "DataLabel", "Αριθμός");
                __builder2.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(109, 
#nullable restore
#line 51 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                    context.number

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(111);
                __builder2.AddAttribute(112, "DataLabel", "Επωνυμία");
                __builder2.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(114, 
#nullable restore
#line 52 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                     context.name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(116);
                __builder2.AddAttribute(117, "DataLabel", "Σύνολο");
                __builder2.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(119, 
#nullable restore
#line 53 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                   context.total

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(120, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(121);
                __builder2.AddAttribute(122, "DataLabel", "Τρόπος Πληρωμής");
                __builder2.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(124, 
#nullable restore
#line 54 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                            context.payment

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(125, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(126);
                __builder2.AddAttribute(127, "DataLabel", "Voucher");
                __builder2.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(129, 
#nullable restore
#line 55 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
                                    context.voucher

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            , 130, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(131);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 61 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "/Users/arisskamagakis/Projects/PolyglotToolVer2/PolyglotToolVer2/Pages/Newvoucher.razor"
       
    DateTime? date = DateTime.Today;
    DateTime documentsDate;
    private string searchString = "";
    private const string companyId = "1";
    private PolyglotToolVer2.Data.Models.Sales selectedItem = null;
    private HashSet<PolyglotToolVer2.Data.Models.Sales> selectedItems = new HashSet<PolyglotToolVer2.Data.Models.Sales>();
    private List<PolyglotToolVer2.Data.Models.Sales> Elements = new List<PolyglotToolVer2.Data.Models.Sales>();

    private bool FilterFunc(PolyglotToolVer2.Data.Models.Sales element)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.document.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.payment.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if ($"{element.number} {element.total} {element.voucher}".Contains(searchString))
            return true;
        return false;
    }

    private void clearGrid()
    {
        date = DateTime.Today;
        Elements.Clear();
    }

    private void sendVoucher()
    {
        int selectedVoucher = 0;
        foreach (var item in Elements)
        {
            if (item.check == true)
            {
                selectedVoucher++;
            }
        }
        if (selectedVoucher == 0)
        {
            Snackbar.Add("Δεν έχετε επιλέξει κανένα παραστατικό", Severity.Warning);
            return;
        }
        Snackbar.Add($"Έχετε επιλέξει {selectedVoucher} παραστατικά", Severity.Normal);


        foreach (var item in Elements)
        {
            if (item.check == true)
            {
                string voucher = item.voucher;
                if (string.IsNullOrEmpty(voucher))
                {
                    string ReceiverName = item.name;
                    string ReceiverAddress = item.AddressPel;
                    string ReceiverCity = item.CityPel;
                    string ReceiverPostal = item.ZipPel;
                    string ReceiverTelephone = item.TelPel;
                    string Notes = item.notes;
                    string OrderID = item.number.ToString();
                    string Cod = "";
                    if (item.payment == "Πληρωμή με αντικαταβολή")
                    {
                        Cod = item.total.ToString().Replace(",", ".");
                    }
                    string weight = "1";

                    if (ReceiverName.Length > 150) ReceiverName = ReceiverName.Substring(0, 150);
                    if (ReceiverAddress.Length > 150) ReceiverAddress = ReceiverAddress.Substring(0, 150);
                    if (ReceiverCity.Length > 40) ReceiverCity = ReceiverCity.Substring(0, 40);
                    if (ReceiverPostal.Length > 5) ReceiverPostal = ReceiverPostal.Substring(0, 5);
                    if (ReceiverTelephone.Length > 10) ReceiverTelephone = ReceiverTelephone.Substring(0, 10);
                    if (Notes.Length > 100) Notes = Notes.Substring(0, 100);
                    if (OrderID.Length > 13) OrderID = OrderID.Substring(0, 13);

                }
            }
        }
    }

    private void showTransactions()
    {
        Elements.Clear();
        documentsDate = date ?? DateTime.Now;
        string fiscalId = findFiscalID(documentsDate.ToString("yyyy"));
        string emp016 = $"E{companyId}_Emp016_{fiscalId}";

        string query = $"select kwd,DatePar,PerigrafhPar ,ArPar, PerPel ,SynTeliko ,PerPlhromis ,parat3,AddressPel,CityPel,ZipPel,TelPel from {emp016} where EidosTimologhshs < 3 and kwdpar in (1,2,14) and datepar = '{documentsDate.ToString("yyyy-MM-dd")}' Order by kwd desc";
        DataTable documentsList = sql.readTableFromSql(query);
        if (documentsList == null || documentsList.Rows.Count == 0)
        {
            Snackbar.Add($"Δεν υπάρχουν κινήσεις {documentsDate.ToString("dd/MM/yyyy")}", Severity.Warning);
            return;
        }
        Snackbar.Add($"Βρέθηκαν {documentsList.Rows.Count} Κινήσεις", Severity.Normal);

        for (int i = 0; i < documentsList.Rows.Count; i++)
        {
            PolyglotToolVer2.Data.Models.Sales sale = new Data.Models.Sales();
            sale.kwd = documentsList.Rows[i]["kwd"].ToString();
            sale.date = Convert.ToDateTime(documentsList.Rows[i]["DatePar"].ToString());
            sale.document = documentsList.Rows[i]["PerigrafhPar"].ToString();
            sale.number = Convert.ToInt32(documentsList.Rows[i]["ArPar"].ToString());
            sale.name = documentsList.Rows[i]["PerPel"].ToString();
            sale.total = Convert.ToDouble(documentsList.Rows[i]["SynTeliko"].ToString());
            sale.payment = documentsList.Rows[i]["PerPlhromis"].ToString();
            sale.AddressPel = documentsList.Rows[i]["AddressPel"].ToString();
            sale.CityPel = documentsList.Rows[i]["CityPel"].ToString();
            sale.ZipPel = documentsList.Rows[i]["ZipPel"].ToString();
            sale.TelPel = documentsList.Rows[i]["TelPel"].ToString();
            sale.notes = documentsList.Rows[i]["parat1"].ToString();
            sale.voucher = documentsList.Rows[i]["parat3"].ToString();
            Elements.Add(sale);
        }


    }

    private string findFiscalID(string year)
    {
        string result = null;
        string query = $"Select id from emp998 where idEtairias = {companyId} and name = '{year}'";
        result = sql.findField(query);
        return result;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private classSQL sql { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
namespace __Blazor.PolyglotToolVer2.Pages.Newvoucher
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Func<T, global::System.Boolean> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment __arg11)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Bordered", __arg2);
        __builder.AddAttribute(__seq3, "Striped", __arg3);
        __builder.AddAttribute(__seq4, "ReadOnly", __arg4);
        __builder.AddAttribute(__seq5, "Filter", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItem", __arg6);
        __builder.AddAttribute(__seq7, "SelectedItemChanged", __arg7);
        __builder.AddAttribute(__seq8, "ToolBarContent", __arg8);
        __builder.AddAttribute(__seq9, "HeaderContent", __arg9);
        __builder.AddAttribute(__seq10, "RowTemplate", __arg10);
        __builder.AddAttribute(__seq11, "PagerContent", __arg11);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudCheckBox_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "ReadOnly", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591