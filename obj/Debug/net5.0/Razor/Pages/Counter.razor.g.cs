#pragma checksum "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f9e0c644af7e04739744e294e441177a63debb"
// <auto-generated/>
#pragma warning disable 1591
namespace SumaMultRestaBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using SumaMultRestaBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\_Imports.razor"
using SumaMultRestaBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Suma, Resta, Multiplicación </h1>\r\n");
            __builder.AddMarkupContent(1, "<p>Primer número: 10, Segundo número: 10 </p>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Suma: ");
            __builder.AddContent(4, 
#nullable restore
#line 6 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\Pages\Counter.razor"
          Suma

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Resta: ");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\Pages\Counter.razor"
           Resta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "p");
            __builder.AddMarkupContent(11, "Multiplicación: ");
            __builder.AddContent(12, 
#nullable restore
#line 8 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\Pages\Counter.razor"
                    Multiplicar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\Pages\Counter.razor"
                                          Calcular

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Calcular");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Victor\Desktop\1-2021\Programacion Aplicada II\SumaMultRestaBlazor\Pages\Counter.razor"
       
   
    float PrimerNumero = 10, SegundoNumero = 2, Suma = 0, Resta = 0, Multiplicar = 0;

    private void Calcular()
    {
        Math.Round(Suma = PrimerNumero + SegundoNumero, 2);
        Math.Round(Resta = PrimerNumero - SegundoNumero, 2);
        Math.Round(Multiplicar = PrimerNumero * SegundoNumero, 2);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
