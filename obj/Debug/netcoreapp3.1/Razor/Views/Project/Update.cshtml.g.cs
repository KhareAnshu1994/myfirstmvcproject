#pragma checksum "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d1a345c966f2515a342254be0610fe76ed891f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Update), @"mvc.1.0.view", @"/Views/Project/Update.cshtml")]
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
#line 1 "C:\Users\SKC\Downloads\Assesment\Views\_ViewImports.cshtml"
using Assesment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SKC\Downloads\Assesment\Views\_ViewImports.cshtml"
using Assesment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d1a345c966f2515a342254be0610fe76ed891f1", @"/Views/Project/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d52ec4dd9cfe45810cb06fdad79114cff8e8c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assesment.Models.ProjectDatamodel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "completed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "progress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "pending", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
  


    Layout = "~/Views/Shared/_Layoutindex.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<style>
    #content {
        margin: 0 auto;
        width: 960px;
        background-color: greenyellow
    }

        #content h1 {
            text-align: center;
            text-decoration: underline;
        }

    table {
        width: 100%;
        height: 40%;
    }

        table tr td {
            width: 40%;
            text-align: center;
        }

    #errorDiv {
        background-color: red;
        color: #FFFFFF;
        padding-left: 30px;
    }
</style>





<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://momentjs.com/downloads/moment.js""></script>


<script type=""text/javascript"">

    function update() {

        var name = document.getElementById(""Name"").value;
        var decr = document.getElementById(""Description"").value;
        var status = document.getElementById(""Status"").value;
        var date = document.getElementById(""Completed"").value;
        var projectid");
            WriteLiteral(@" = document.getElementById(""projectid"").value;


        frmData = new FormData();
        frmData.append(""Id"", projectid);
        frmData.append(""Project_Name"", name);
        frmData.append(""Project_Description"", decr);
        frmData.append(""Project_Status"", status);
        frmData.append(""Project_Completed"", date);

        $.ajax({
            url: ""/Project/UpdateProject"",
            type: ""put"",
            data: frmData,
            processData: false,
            contentType: false,
            dataType: ""json"",
            success: function (result) {

                if (result[""status""] == true) {
                    document.getElementById(""updated"").innerHTML = ""status:true"";
                    document.getElementById(""updated"").innerHTML = result[""message""];


                }
                else {
                    document.getElementById(""updated"").innerHTML = ""status:true"";
                    document.getElementById(""updated"").innerHTML = result[""message""");
            WriteLiteral(@"]

                }


            },
            error: function () {

                alert(""Please Fill the form Correctly"");
            }



        });
    }
</script>




<div id=""content"">
    <h1>Project Details</h1>
    <div id=""errorDiv""></div>
    <table>
        <tr>
            <td>Project Name:-</td>
            <td><input type=""text"" placeholder="" Mention your Project"" id=""Name""");
            BeginWriteAttribute("value", " value=\"", 2580, "\"", 2607, 1);
#nullable restore
#line 111 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
WriteAttributeValue("", 2588, Model.Project_Name, 2588, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div id=\"div1\"></div></td>\r\n        </tr>\r\n        <tr>\r\n\r\n            <td>Project Status: -</td>\r\n            <td>\r\n                <select id=\"Status\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1a345c966f2515a342254be0610fe76ed891f17606", async() => {
                WriteLiteral("Select an Option");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 119 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
                     if (Model.Project_Status == "completed")
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1a345c966f2515a342254be0610fe76ed891f19061", async() => {
                WriteLiteral("completed");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 123 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
                    }
                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1a345c966f2515a342254be0610fe76ed891f110806", async() => {
                WriteLiteral("completed");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 128 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
                     if (Model.Project_Status == "progress")
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1a345c966f2515a342254be0610fe76ed891f112422", async() => {
                WriteLiteral("progress");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 134 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
                    }
                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1a345c966f2515a342254be0610fe76ed891f114167", async() => {
                WriteLiteral("progress");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
                     if (Model.Project_Status == "pending")
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1a345c966f2515a342254be0610fe76ed891f115781", async() => {
                WriteLiteral("pending");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 145 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"

                    }

                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1a345c966f2515a342254be0610fe76ed891f117529", async() => {
                WriteLiteral("pending");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 152 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </select> <div id=\"div2\"></div>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Project Completed:-</td>\r\n\r\n            <td><input type=\"date\" id=\"Completed\"");
            BeginWriteAttribute("value", " value=\"", 4015, "\"", 4056, 1);
#nullable restore
#line 160 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
WriteAttributeValue("", 4023, Model.Project_Completed_formated, 4023, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"> <div id=""div3""></div></td>
        </tr>
        <tr>
            <br />
            <td>Project Description:-</td>
            <td>
                <textarea rows=""4"" cols=""50"" name=""comment"" id=""Description"" style="" margin-left:150px; margin-top;"">");
#nullable restore
#line 166 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
                                                                                                                Write(Model.Project_Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                <div id=\"div4\"></div>\r\n            </td>\r\n        </tr>\r\n\r\n        <input type=\"hidden\" id=\"projectid\"");
            BeginWriteAttribute("value", " value=\"", 4472, "\"", 4489, 1);
#nullable restore
#line 171 "C:\Users\SKC\Downloads\Assesment\Views\Project\Update.cshtml"
WriteAttributeValue("", 4480, Model.Id, 4480, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <tr>\r\n            <div id=\"updated\">\r\n            <td colspan=\"2\"><input type=\"button\" id=\"Message\" value=\"Update\" onclick=\"update()\">  </td>\r\n</div>\r\n\r\n        </tr>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assesment.Models.ProjectDatamodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
