// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EventsPWA.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using EventsPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/_Imports.razor"
using EventsPWA.Shared;

#line default
#line hidden
#nullable disable
    public partial class Child_login_component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "/Users/utkarsh/Downloads/AlexFile_Projects/Assignment/EventsPWA/Shared/Child_login-component.razor"
       


    public string visibility;
    public string setDisplayAttribute = "none";
    
    [Parameter]
    public bool PasswordVisible { get; set; } = true;
    
    public string userName;
    public string password;
    public string confirmationMessage;

    public void OnLoginCallback(){
	    if((!string.IsNullOrWhiteSpace(userName) && (!string.IsNullOrWhiteSpace(password))))
	    {
		if(PasswordVisible == true){
			visibility = "text";

			confirmationMessage = "Login Successful!";

			setDisplayAttribute = "block";

		}
		else{
			visibility = "password";

			confirmationMessage = "Login Successful!";
			
			setDisplayAttribute = "block";		
		}
	    }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591