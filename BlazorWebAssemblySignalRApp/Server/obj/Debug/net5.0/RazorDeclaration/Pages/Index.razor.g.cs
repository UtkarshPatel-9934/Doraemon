// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebAssemblySignalRApp.Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "/Users/utkarsh/Downloads/SignalR/BlazorWebAssemblySignalRApp/Server/Pages/Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/Users/utkarsh/Downloads/SignalR/BlazorWebAssemblySignalRApp/Server/Pages/Index.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
		var encodedMsg = "Anonymous";
		if(String.IsNullOrEmpty(messageInput) && String.IsNullOrEmpty(userInput)){
			
		}
		else{
            		encodedMsg = $"{user}: {message}";
		}
			messages.Add(encodedMsg);
		userInput = string.Empty;
		messageInput = string.Empty;
		StateHasChanged();


	    // encodedMsg = user + ": " + message;
	    // `S{user}: ${message}`
	    // Utkarsh: Whatever the message
        });

        await hubConnection.StartAsync();
    }

    async Task Send() {
        await hubConnection.SendAsync("SendMessage", userInput, messageInput);
	// Some other synchronous code here
    }
    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected; //HubConnectionState is a class - enumerable
	// for eg: HubConnectionState.Connected = 1, HubConnectionState.Disconnected = -1, HubConnectionState.connecting = 2

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
