// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "F:\VS2019 Projects\BlazorServerApp\Pages\OperationDevice.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VS2019 Projects\BlazorServerApp\Pages\OperationDevice.razor"
using BlazorServerApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OperationService")]
    public partial class OperationDevice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "F:\VS2019 Projects\BlazorServerApp\Pages\OperationDevice.razor"
       
    protected List<OperationDeviceModel> operationDevices = new();
    protected override async Task OnInitializedAsync()
    {
        operationDevices = await OperationService.GetAllOperations();
    }
    void AddOperationDevice(int OperationId)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(AddDeviceDialog.OperationId), OperationId);
        var options = new ModalOptions();
        options.HideHeader = true;
        modal.Show<AddDeviceDialog>("Add Device", parameters, options);
    }
    void DeleteOperation(int OperationId)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(DeleteOperationDevice.OperationId), OperationId);
        var options = new ModalOptions();
        options.HideHeader = true;
        modal.Show<DeleteOperationDevice>("Delete Operation Device", parameters,options);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOperationDeviceService OperationService { get; set; }
    }
}
#pragma warning restore 1591
