// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AssignmentSampleBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using AssignmentSampleBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/_Imports.razor"
using AssignmentSampleBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/Pages/Todo.razor"
       
	private string newTodo;
	private List<TodoItem> todos = new();

	private void AddTodo(){
		if (!string.IsNullOrWhiteSpace(newTodo))
        	{
			TodoItem newItem = new TodoItem{
				Title = newTodo,
				IsDone = false
			};
            		

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/utkarsh/Downloads/AssignmentSampleBlazorApp/Pages/Todo.razor"
                                                                                      
			    todos.Add(newItem);
            		newTodo = string.Empty;
        	}
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
