#pragma warning disable 1591
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace iPhoneHybrid
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class RazorView : RazorViewBase
{

#line hidden

#line 1 "/git/RazorHybrid/iPhoneHybrid/RazorView.cshtml"
public System.String Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<html>\n\t<head>\n\t\t<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"style.css\"");

WriteLiteral(" />\n\t\t<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
			
			// This javascript method calls C# by setting the browser 
			// to a URL with a custom scheme that is registered in C#.  
			// All values are sent to C# as part of the querystring  
			function InvokeCSharpWithFormValues(elm) {
				var qs = """";
				var elms = elm.form.elements;

				for (var i = 0; i < elms.length;i++) {
					qs += ""&"" + elms[i].name + ""="" + elms[i].value;
				}

				if (elms.length > 0) 
					qs = qs.substring(1);

				location.href = ""hybrid:"" + elm.name + ""?"" + qs;
			}

			// This javascript method is called from C#
			function SetLabelText(text) {
				var elm = document.getElementById('label');
				elm.innerHTML = text;
			}
		</script>
	</head>
	<body>
		<div");

WriteLiteral(" data-role=\"page\"");

WriteLiteral(" data-theme=\"b\"");

WriteLiteral(">\n\t\t\t<form>\n\t\t\t\t\n\t\t\t\t<div");

WriteLiteral(" data-role=\"content\"");

WriteLiteral(">\n\n\t\t\t\t\t<h1");

WriteLiteral(" id=\"label\"");

WriteLiteral(">");


#line 37 "/git/RazorHybrid/iPhoneHybrid/RazorView.cshtml"
               Write(Model);


#line default
#line hidden
WriteLiteral("</h1>\n\n\t\t\t\t\t<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"textbox\"");

WriteLiteral(" name=\"textbox\"");

WriteLiteral(" />\n\n\t\t\t\t\t<input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" name=\"UpdateLabel\"");

WriteLiteral(" value=\"Click\"");

WriteLiteral(" onclick=\"InvokeCSharpWithFormValues(this)\"");

WriteLiteral(" />\n\n\t\t\t\t</div>\n\n\t\t\t</form>\n\t\t</div>\n\t</body>\n</html>");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class RazorViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		///<summary>Executes the template and returns the output as a string.</summary>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		///<summary>Executes the template, writing to the provided text writer.</summary>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		///<summary>Writes literal values to the template output without HTML escaping them.</summary>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		///<summary>Writes values to the template output, HTML escaping them if necessary.</summary>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template uses any Razor helpers, but you may choose to implement it differently
		//
		///<summary>Invokes the action to write directly to the template output.</summary>
		///<remarks>This is used for Razor helpers, which already perform any necessary HTML escaping.</remarks>
		protected void Write (Action<System.IO.TextWriter> write)
		{
			write (__razor_writer);
		}

		// This method is REQUIRED if the template has any Razor helpers, but you may choose to implement it differently
		//
		///<remarks>Used by Razor helpers to HTML escape values.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value != null) {
				writer.Write (System.Web.HttpUtility.HtmlEncode (value.ToString ()));
				// NOTE: better version for .NET 4+, handles pre-escape HTML (IHtmlString)
				// writer.Write (System.Web.HttpUtility.HtmlEncode (value));
			}
		}

		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
