#pragma checksum "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18e0c561196c9307ea3979d344f0dfe2721e696b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\VS2019 Projects\BlazorServerApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ResetPassword")]
    public partial class ResetPassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Reset Password</h3>\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    Please enter a new Password bellow;\r\n</div>\r\n<br>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 27 "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor"
                  validatePasswordModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 27 "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor"
                                                         SetResetPassword

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "field");
                __builder2.AddMarkupContent(12, "<label class=\"label\">Password</label>\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "control");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "password");
                __builder2.AddAttribute(17, "class", "input");
                __builder2.AddAttribute(18, "type", "password");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor"
                                                                                 validatePasswordModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => validatePasswordModel.Password = __value, validatePasswordModel.Password))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => validatePasswordModel.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "field");
                __builder2.AddMarkupContent(25, "<label class=\"label\">Confirm password</label>\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "control");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "cpassword");
                __builder2.AddAttribute(30, "class", "input");
                __builder2.AddAttribute(31, "type", "password");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor"
                                                                                  validatePasswordModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => validatePasswordModel.ConfirmPassword = __value, validatePasswordModel.ConfirmPassword))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => validatePasswordModel.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.AddMarkupContent(36, "<div class=\"field\"><div class=\"control\"><button type=\"submit\" class=\"button is-primary\">Set Password</button></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n<br>\r\n");
            __builder.AddMarkupContent(38, "<a href=\"/\">Back</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "F:\VS2019 Projects\BlazorServerApp\Pages\ResetPassword.razor"
       

    InputModel requestPasswordModel = new InputModel();
    ResetPasswordModel validatePasswordModel = new ResetPasswordModel();

    string email = "";
    string token = "";

    bool IsResetSend = false;
    bool IsResetToken = false;

    protected override void OnInitialized()
    {

        //GetHttpParameters();

    }

    //public void GetHttpParameters()
    //{
    //    var uriBuilder = new UriBuilder(navigationManager.Uri);
    //    var httpQuery = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);

    //    email = httpQuery["email"] ?? "";
    //    token = httpQuery["token"] ?? "";

    //    if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(token))
    //    {
    //        IsResetToken = true;

    //    }
    //}

    //public async void SendResetPassword()
    //{
    //    List<string> mailTo = new List<string>();

    //    string passwordResetToken;
    //    string passwordResetUrl;

    //    var user = await userManager.FindByEmailAsync(requestPasswordModel.Email);

    //    if (user != null)
    //    {
    //        passwordResetUrl = navigationManager.BaseUri;

    //        passwordResetToken = await userManager.GeneratePasswordResetTokenAsync(user);

    //        passwordResetToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(passwordResetToken));

    //        passwordResetUrl = "https://localhost:44384/ResetPassword?email=" + user.Email + "&token=" + passwordResetToken;

    //        mailTo.Add(requestPasswordModel.Email);

    //        //Send mail with the relevant token
    //        //Webco.Email.Entities.EmailObject emailObject = new Webco.Email.Entities.EmailObject();
    //        //emailObject.Email_To = mailTo;
    //        //emailObject.Email_Subject = "Password Reset Webco !";
    //        //emailObject.Email_Message = $"Hy There, <br> Please click this link to reset your password : <br><a href='{HtmlEncoder.Default.Encode(passwordResetUrl)}'> clikcing here </a>.";
    //        //emailObject.SendEmail(emailObject);

    //        IsResetSend = true;
    //    }
    //    else
    //    {
    //        //it's a lie
    //        IsResetSend = true;
    //    }
    //}

    public async void SetResetPassword()
    {
        //List<string> mailTo = new List<string>();

        //var user = await userManager.FindByEmailAsync(email);

        //if (user != null)
        //{
        //    token = System.Text.Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));

        //    var result = await userManager.ResetPasswordAsync(user, token, validatePasswordModel.ConfirmPassword);

        //    if (result.Succeeded)
        //    {

        //        mailTo.Add(email);

        //        //Send mail with the relevant token
        //        //Webco.Email.Entities.EmailObject emailObject = new Webco.Email.Entities.EmailObject();
        //        //emailObject.Email_To = mailTo;
        //        //emailObject.Email_Subject = "Password Reset Webco !";
        //        //emailObject.Email_Message = $"Hy There, <br> You password was just reset at webco. Not you ? <br> Contact webco for support.";
        //        //emailObject.SendEmail(emailObject);

        //        navigationManager.NavigateTo("/LoginUserResetPasswordComplete", true);
        //    }
        //    else
        //    {
        //        navigationManager.NavigateTo("/LoginUserResetPasswordError", true);
        //    }
        //}
        //else
        //{
        //    navigationManager.NavigateTo("/LoginUserResetPasswordError", true);
        //}

    }

    public class InputModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

    public class ResetPasswordModel
    {
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591