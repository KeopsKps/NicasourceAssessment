#pragma checksum "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "840ebb0985033e133a1b418d28b2186f3c715438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Character_Index), @"mvc.1.0.view", @"/Views/Character/Index.cshtml")]
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
#line 1 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\_ViewImports.cshtml"
using NicasourceAssessment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\_ViewImports.cshtml"
using NicasourceAssessment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840ebb0985033e133a1b418d28b2186f3c715438", @"/Views/Character/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38524fea2edbe7594a8ee1fd8c3efe69e3377d73", @"/Views/_ViewImports.cshtml")]
    public class Views_Character_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Character>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
  
    ViewData["Title"] = "Character information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <br/>
    <div class=""container"">
    <div class=""main-body"">
    
          <div class=""row gutters-sm"">
            <div class=""col-md-4 mb-3"">
              <div class=""card"">
                <div class=""card-body"">
                  <div class=""d-flex flex-column align-items-center text-center"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 471, "\"", 492, 1);
#nullable restore
#line 18 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue("", 477, Model.ImageURL, 477, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Admin\"");
            BeginWriteAttribute("class", " class=\"", 505, "\"", 513, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"150\">\r\n                    <div class=\"mt-3\">\r\n                      <h4>");
#nullable restore
#line 20 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                      <p class=\"text-secondary mb-1\">");
#nullable restore
#line 21 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
                                                Write(Model.Appeareance["gender"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                      <p class=\"text-muted font-size-sm\">");
#nullable restore
#line 22 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
                                                    Write(Model.Appeareance["race"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class=""col-md-8"">
              <div class=""card mb-3"">
                <div class=""card-body"">
                  <div class=""row"">
                    <div class=""col-sm-3"">
                      <h6 class=""mb-0"">Full Name</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                      ");
#nullable restore
#line 36 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
                 Write(Model.Biography["full-name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                  </div>
                  <hr>
                  <div class=""row"">
                    <div class=""col-sm-3"">
                      <h6 class=""mb-0"">Alter egos</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                      ");
#nullable restore
#line 45 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
                 Write(Model.Biography["alter-egos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                  </div>
                  <hr>
                  <div class=""row"">
                    <div class=""col-sm-3"">
                      <h6 class=""mb-0"">Place of birth</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                      ");
#nullable restore
#line 54 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
                 Write(Model.Biography["place-of-birth"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                  </div>
                  <hr>
                  <div class=""row"">
                    <div class=""col-sm-3"">
                      <h6 class=""mb-0"">First Appearance</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                      ");
#nullable restore
#line 63 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
                 Write(Model.Biography["first-appearance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                  </div>
                  <hr>
                  <div class=""row"">
                    <div class=""col-sm-3"">
                      <h6 class=""mb-0"">Publisher</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                      ");
#nullable restore
#line 72 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
                 Write(Model.Biography["publisher"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                  </div>
                  <hr>
                </div>
              </div>

              <div class=""row gutters-sm"">
                <div class=""col-sm-6 mb-3"">
                  <div class=""card h-100"">
                    <div class=""card-body"">
                      <h6 class=""d-flex align-items-center mb-3"">Power Statistics</h6>
                      <small>Intelligence</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\'", 3336, "\'", 3385, 3);
            WriteAttributeValue("", 3344, "width:", 3344, 6, true);
#nullable restore
#line 86 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue(" ", 3350, Model.PowerStats["intelligence"], 3351, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3384, "%", 3384, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\'", 3386, "\'", 3435, 1);
#nullable restore
#line 86 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue("", 3402, Model.PowerStats["intelligence"], 3402, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Strength</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\'", 3710, "\'", 3755, 3);
            WriteAttributeValue("", 3718, "width:", 3718, 6, true);
#nullable restore
#line 90 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue(" ", 3724, Model.PowerStats["strength"], 3725, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3754, "%", 3754, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\'", 3756, "\'", 3801, 1);
#nullable restore
#line 90 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue("", 3772, Model.PowerStats["strength"], 3772, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Speed</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\'", 4073, "\'", 4115, 3);
            WriteAttributeValue("", 4081, "width:", 4081, 6, true);
#nullable restore
#line 94 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue(" ", 4087, Model.PowerStats["speed"], 4088, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4114, "%", 4114, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\'", 4116, "\'", 4158, 1);
#nullable restore
#line 94 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue("", 4132, Model.PowerStats["speed"], 4132, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Durability</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\'", 4435, "\'", 4482, 3);
            WriteAttributeValue("", 4443, "width:", 4443, 6, true);
#nullable restore
#line 98 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue(" ", 4449, Model.PowerStats["durability"], 4450, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4481, "%", 4481, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\'", 4483, "\'", 4530, 1);
#nullable restore
#line 98 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue("", 4499, Model.PowerStats["durability"], 4499, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Power</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\'", 4802, "\'", 4844, 3);
            WriteAttributeValue("", 4810, "width:", 4810, 6, true);
#nullable restore
#line 102 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue(" ", 4816, Model.PowerStats["power"], 4817, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4843, "%", 4843, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\'", 4845, "\'", 4887, 1);
#nullable restore
#line 102 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue("", 4861, Model.PowerStats["power"], 4861, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Combat</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar""");
            BeginWriteAttribute("style", " style=\'", 5160, "\'", 5203, 3);
            WriteAttributeValue("", 5168, "width:", 5168, 6, true);
#nullable restore
#line 106 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue(" ", 5174, Model.PowerStats["combat"], 5175, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5202, "%", 5202, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\'", 5204, "\'", 5247, 1);
#nullable restore
#line 106 "C:\Users\50586\Desktop\PersonalData\Proyectos\NicasourceAssessment\Views\Character\Index.cshtml"
WriteAttributeValue("", 5220, Model.PowerStats["combat"], 5220, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                    </div>
                  </div>
                </div>
                </div>
              </div>
            </div>
          </div>

        </div>
    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Character> Html { get; private set; }
    }
}
#pragma warning restore 1591
