#pragma checksum "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a117be5fffb344234aaf1efc5bd3ac05286a9e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_ApiControllerWithContext), @"mvc.1.0.view", @"/Templates/ControllerGenerator/ApiControllerWithContext.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a117be5fffb344234aaf1efc5bd3ac05286a9e6", @"/Templates/ControllerGenerator/ApiControllerWithContext.cshtml")]
    public class Templates_ControllerGenerator_ApiControllerWithContext : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.AspNetCore.Http;\r\nusing Microsoft.AspNetCore.Mvc;\r\nusing Microsoft.EntityFrameworkCore;\r\n");
#nullable restore
#line 9 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
  
    foreach (var namespaceName in Model.RequiredNamespaces)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("using ");
#nullable restore
#line 12 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
   Write(namespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 13 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nnamespace ");
#nullable restore
#line 16 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
     Write(Model.ControllerNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n");
#nullable restore
#line 18 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
  
    string routePrefix = "api/" + Model.ControllerRootName;
    var entitySetName = Model.ModelMetadata.EntitySetName;
    var primaryKeyName = Model.ModelMetadata.PrimaryKeys[0].PropertyName;
    var primaryKeyShortTypeName = Model.ModelMetadata.PrimaryKeys[0].ShortTypeName;
    var primaryKeyType = Model.ModelMetadata.PrimaryKeys[0].TypeName;
    var primaryKeyIsAutoGenerated = Model.ModelMetadata.PrimaryKeys[0].IsAutoGenerated;

#line default
#line hidden
#nullable disable
            WriteLiteral("    [Route(\"api/[controller]\")]\r\n    [ApiController]\r\n    public class ");
#nullable restore
#line 28 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
            Write(Model.ControllerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ControllerBase\r\n    {\r\n        private readonly ");
#nullable restore
#line 30 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                    Write(Model.ContextTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" _context;\r\n\r\n        public ");
#nullable restore
#line 32 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
           Write(Model.ControllerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("(");
#nullable restore
#line 32 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                  Write(Model.ContextTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" context)\r\n        {\r\n            _context = context;\r\n        }\r\n\r\n        // GET: ");
#nullable restore
#line 37 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
           Write(routePrefix);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        [HttpGet]\r\n        public async Task<ActionResult<IEnumerable<");
#nullable restore
#line 39 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                               Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(">>> Get");
#nullable restore
#line 39 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                            Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral("()\r\n        {\r\n            return await _context.");
#nullable restore
#line 41 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                              Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".ToListAsync();\r\n        }\r\n\r\n        // GET: ");
#nullable restore
#line 44 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
           Write(routePrefix);

#line default
#line hidden
#nullable disable
            WriteLiteral("/5\r\n        [HttpGet(\"{id}\")]\r\n        public async Task<ActionResult<");
#nullable restore
#line 46 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                   Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(">> Get");
#nullable restore
#line 46 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                               Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("(");
#nullable restore
#line 46 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                                     Write(primaryKeyShortTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" id)\r\n        {\r\n            var ");
#nullable restore
#line 48 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
           Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = await _context.");
#nullable restore
#line 48 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                  Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".FindAsync(id);\r\n\r\n            if (");
#nullable restore
#line 50 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
           Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == null)\r\n            {\r\n                return NotFound();\r\n            }\r\n\r\n            return ");
#nullable restore
#line 55 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
              Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        }\r\n\r\n        // PUT: ");
#nullable restore
#line 58 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
           Write(routePrefix);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut(""{id}"")]
        public async Task<IActionResult> Put");
#nullable restore
#line 62 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                        Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("(");
#nullable restore
#line 62 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                              Write(primaryKeyShortTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" id, ");
#nullable restore
#line 62 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                                           Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 62 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                                                                Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        {\r\n            if (id != ");
#nullable restore
#line 64 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                  Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 64 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                        Write(primaryKeyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            {\r\n                return BadRequest();\r\n            }\r\n\r\n            _context.Entry(");
#nullable restore
#line 69 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                      Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(").State = EntityState.Modified;\r\n\r\n            try\r\n            {\r\n                await _context.SaveChangesAsync();\r\n            }\r\n            catch (DbUpdateConcurrencyException)\r\n            {\r\n                if (!");
#nullable restore
#line 77 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                 Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: ");
#nullable restore
#line 90 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
            Write(routePrefix);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        // To protect from overposting attacks, enable the specific properties you want to bind to, for\r\n        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.\r\n        [HttpPost]\r\n        public async Task<ActionResult<");
#nullable restore
#line 94 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                   Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(">> Post");
#nullable restore
#line 94 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("(");
#nullable restore
#line 94 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                                      Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 94 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                                                           Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        {\r\n            _context.");
#nullable restore
#line 96 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                 Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Add(");
#nullable restore
#line 96 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                     Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n");
#nullable restore
#line 97 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
  
    if (primaryKeyIsAutoGenerated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("await _context.SaveChangesAsync();\r\n");
#nullable restore
#line 101 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("try\r\n            ");
            WriteLiteral("{\r\n                ");
            WriteLiteral("await _context.SaveChangesAsync();\r\n            ");
            WriteLiteral("}\r\n            ");
            WriteLiteral("catch (DbUpdateException)\r\n            ");
            WriteLiteral("{\r\n                ");
            WriteLiteral("if (");
#nullable restore
#line 110 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                  Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("Exists(");
#nullable restore
#line 110 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                               Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 110 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                     Write(primaryKeyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("))\r\n                ");
            WriteLiteral("{\r\n                    ");
            WriteLiteral("return Conflict();\r\n                ");
            WriteLiteral("}\r\n                ");
            WriteLiteral("else\r\n                ");
            WriteLiteral("{\r\n                    ");
            WriteLiteral("throw;\r\n                ");
            WriteLiteral("}\r\n            ");
            WriteLiteral("}\r\n");
#nullable restore
#line 119 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            return CreatedAtAction(\"Get");
#nullable restore
#line 122 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                   Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", new { id = ");
#nullable restore
#line 122 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                       Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 122 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                                             Write(primaryKeyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" }, ");
#nullable restore
#line 122 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                                                                Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n        }\r\n\r\n        // DELETE: ");
#nullable restore
#line 125 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
              Write(routePrefix);

#line default
#line hidden
#nullable disable
            WriteLiteral("/5\r\n        [HttpDelete(\"{id}\")]\r\n        public async Task<ActionResult<");
#nullable restore
#line 127 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                   Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(">> Delete");
#nullable restore
#line 127 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                  Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("(");
#nullable restore
#line 127 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                                                        Write(primaryKeyShortTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" id)\r\n        {\r\n            var ");
#nullable restore
#line 129 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
           Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = await _context.");
#nullable restore
#line 129 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                  Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".FindAsync(id);\r\n            if (");
#nullable restore
#line 130 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
           Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == null)\r\n            {\r\n                return NotFound();\r\n            }\r\n\r\n            _context.");
#nullable restore
#line 135 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                 Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Remove(");
#nullable restore
#line 135 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                        Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            await _context.SaveChangesAsync();\r\n\r\n            return ");
#nullable restore
#line 138 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
              Write(Model.ModelVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        }\r\n\r\n        private bool ");
#nullable restore
#line 141 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                 Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("Exists(");
#nullable restore
#line 141 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                             Write(primaryKeyShortTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" id)\r\n        {\r\n            return _context.");
#nullable restore
#line 143 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                        Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Any(e => e.");
#nullable restore
#line 143 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Templates\ControllerGenerator\ApiControllerWithContext.cshtml"
                                                   Write(primaryKeyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == id);\r\n        }\r\n    }\r\n}\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
