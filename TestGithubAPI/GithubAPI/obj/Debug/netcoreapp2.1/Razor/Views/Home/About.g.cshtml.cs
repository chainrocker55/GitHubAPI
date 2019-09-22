#pragma checksum "C:\Users\chainrocker\source\repos\TestGithubAPI\GithubAPI\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4da05f420c54fef6835cc1fa0c1297b689b9f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\chainrocker\source\repos\TestGithubAPI\GithubAPI\Views\_ViewImports.cshtml"
using GithubAPI;

#line default
#line hidden
#line 2 "C:\Users\chainrocker\source\repos\TestGithubAPI\GithubAPI\Views\_ViewImports.cshtml"
using GithubAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4da05f420c54fef6835cc1fa0c1297b689b9f8d", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"345bf42da3367081ac91579c7aff3cebce0d3f51", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\chainrocker\source\repos\TestGithubAPI\GithubAPI\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 2667, true);
            WriteLiteral(@"

    <div class=""content "" bis_skin_checked=""1"">
        <br />
        <br />
        <br />
        <h1>GitHub REST API v3</h1>
        <p>This describes the resources that make up the official GitHub REST API v3. If you have any problems or requests, please contact <a href=""https://github.com/contact"">GitHub Support</a>.</p>
        <h1>
            <a id=""understanding-rate-limits-for-github-apps"" class=""anchor"" aria-hidden=""true""><span aria-hidden=""true"" class=""octicon octicon-link""></span></a>Understanding rate limits for GitHub Apps
        </h1>

        <div class=""intro"" bis_skin_checked=""1"">

            <p>Rate limits for GitHub Apps help control the rate of traffic.</p>

        </div>

        <h2>
            <a id=""server-to-server-requests"" class=""anchor"" href=""#server-to-server-requests"" aria-hidden=""true""><span aria-hidden=""true"" class=""octicon octicon-link""></span></a>Server-to-server requests
        </h2>
        
        <p>GitHub Apps making server-to-server requ");
            WriteLiteral(@"ests use the installation's minimum rate limit of 5,000 requests per hour. Organization installations with more than 20 users receive another 50 requests per hour for each user. Installations that have more than 20 repositories receive another 50 requests per hour for each repository. The maximum rate limit for an installation is 12,500 requests per hour.</p>

        <h2>
            <a id=""user-to-server-requests"" class=""anchor"" href=""#user-to-server-requests"" aria-hidden=""true""><span aria-hidden=""true"" class=""octicon octicon-link""></span></a>User-to-server requests
        </h2>

        <p>GitHub Apps can also act <a href=""https://developer.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-and-authorizing-users-for-github-apps"">on behalf of a user</a>, making user-to-server requests. These requests are rate limited at 5,000 requests per hour and per authenticated user. All OAuth applications authorized by that user, all of the user's personal access ");
            WriteLiteral(@"tokens, and all requests authenticated with that user's username and password share the same quota of 5,000 requests per hour for that user.</p>
        <br />
        <p>For more detailed information about rate limits, see ""<a href=""https://developer.github.com/v3/#rate-limiting"">Rate limiting</a>"" for REST API v3 and ""<a href=""https://developer.github.com/v4/guides/resource-limitations/"">Resource limitations</a>"" for GraphQL API v4.</p>
        <h2>This application</h2>
        <p>This application use personal access tokens. These requests are rate limited at 5,000 requests per hour</p>
    </div>



");
            EndContext();
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