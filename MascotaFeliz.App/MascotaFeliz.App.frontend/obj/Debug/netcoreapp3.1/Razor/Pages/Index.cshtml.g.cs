#pragma checksum "C:\Fantastic-Developers\MascotaFeliz.App\MascotaFeliz.App.frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df0b64c5274b69432cb96cab283787f52f01d038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MascotaFeliz.App.frontend.Pages
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
#line 1 "C:\Fantastic-Developers\MascotaFeliz.App\MascotaFeliz.App.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0b64c5274b69432cb96cab283787f52f01d038", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52bc616f57418b8137d1655d8b0e9c04f7f1ee96", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Fantastic-Developers\MascotaFeliz.App\MascotaFeliz.App.frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h3 class=""Titulo""><strong>CUIDEMOS
    LO QUE NOS UNE</strong></h3>
    <p class=""Titulo"">  No te preocupes por los gastos medicos de tus mascotas, con nosotros estan seguras.<br>
        Asegura su salud y bienestar, durante todo un año, de manera rápida, segura, sin papeleos y 100% online.
    </P>
        
</div>

<div class=""MapaG"" width=""500"" >
    <p>
    <h4 class=""MapaGL""><strong>Nuevo Centro de Atencion</strong></h4>
    <p>Cuenta con un equipo de veterinarios <br>
       que se encargan de realizar visitas a domicilio<br>
       durante las cuales se revisan las mascotas y se dan recomendaciones<br>
       para prevenir enfermedades, mejorar la calidad de vida de los peludos<br>
       o en caso de ser necesario (si la mascota se encuentra enferma) <br>
       se realiza el diagnóstico y se formulan medicamentos.
    </p>
   <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d7953.534622768996!2d-74.07719368942801!3d4.6355531973538655");
            WriteLiteral("!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x9aa2e7a8132528c!2sMascota%20Feliz%20Petshop!5e0!3m2!1ses-419!2sco!4v1664481577880!5m2!1ses-419!2sco\" width=\"400\" height=\"250\" style=\"border:6;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1281, "\"", 1299, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" referrerpolicy=""no-referrer-when-downgrade""></iframe>
   
   <iframe class=""VideoY"" width=""450"" height=""255"" src=""https://www.youtube.com/embed/MK2iY0D1JNg"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
   
</div>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
