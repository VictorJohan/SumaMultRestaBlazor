// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
