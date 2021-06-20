#pragma checksum "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "457bfd3e8873c8296aa677804cc7d8a27f07f906"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPlay.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using BlazorPlay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using BlazorPlay.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using BlazorPlay.Data;

#line default
#line hidden
#nullable disable
    public partial class TaskList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 2 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
     Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, "\'s TaskList");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
 if(taskList.Count>0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "progress my-2");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "progress-bar");
            __builder.AddAttribute(10, "role", "progressbar");
            __builder.AddAttribute(11, "style", "width:" + (
#nullable restore
#line 8 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
                            percentDone

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(12, "aria-valuemin", "0");
            __builder.AddAttribute(13, "aria-valuemax", "100");
            __builder.AddContent(14, 
#nullable restore
#line 9 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
                                                     percentDone

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "%\r\n           \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 13 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "class", "form-inline my-2");
            __builder.AddAttribute(21, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
                                           newTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
                                                                   AddTask

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "class", "form-control mx-2");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
                                                      newTask.Task

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTask.Task = __value, newTask.Task))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTask.Task));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.AddMarkupContent(31, "<button class=\"btn btn-outline-primary\" type=\"submit\">Add Task</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "ul");
            __builder.AddAttribute(34, "class", "list-group");
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 21 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
     foreach (var task in taskList)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
         if (task.IsComplete)//toggle taskcomplete
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "list-group-item list-group-item-secondary my-1");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
                          (() => task.IsComplete = !task.IsComplete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "del");
            __builder.AddContent(42, 
#nullable restore
#line 27 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
                      task.Task

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 29 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "            ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "list-group-item list-group-item-success my-1");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
                          (() => task.IsComplete = !task.IsComplete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.AddContent(50, 
#nullable restore
#line 34 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
                 task.Task

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 36 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
         

     }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\TaskList.razor"
       
    private List<TaskModel> taskList = new List<TaskModel>();
    private TaskModel newTask = new TaskModel();

    [Parameter]
    public string Name { get; set; }

    private int percentDone
    {
        get
        {
            return (taskList.Count(x => x.IsComplete) * 100) / taskList.Count;
        }
    }

    private void AddTask()
    {
        taskList.Add(newTask);
        newTask = new TaskModel();

        //Todo: hook to DB to store values or load values
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
