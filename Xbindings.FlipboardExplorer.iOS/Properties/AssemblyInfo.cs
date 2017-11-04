using System.Reflection;
using System.Runtime.CompilerServices;

using Foundation;

// This attribute allows you to mark your assemblies as “safe to link”. 
// When the attribute is present, the linker—if enabled—will process the assembly 
// even if you’re using the “Link SDK assemblies only” option, which is the default for device builds.

[assembly: LinkerSafe]

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Xbindings.FlipboardExplorer.iOS")]
[assembly: AssemblyDescription("Xamarin.iOS binding library - Flipboard Explorer (FLEX)")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("XBindings")]
[assembly: AssemblyProduct("XBindings")]
[assembly: AssemblyCopyright("Copyright (c) 2017 XBindings")]
[assembly: AssemblyTrademark("XBindings")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("2.4.0")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
