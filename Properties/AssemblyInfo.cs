/*
	Copyright © Bryan Apellanes 2015  
*/
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Naizari")]
[assembly: AssemblyDescription("Naizari Core")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Naizari")]
[assembly: AssemblyProduct("Naizari")]
[assembly: AssemblyCopyright("Copyright © Naizari")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]


[assembly: InternalsVisibleTo("LaoTze")]
[assembly: InternalsVisibleTo("Naizari.Data")]
[assembly: InternalsVisibleTo("Naizari.Data.Tests")]
[assembly: InternalsVisibleTo("Naizari.Data.Queries")]
[assembly: InternalsVisibleTo("Naizari.Data.Serialization")]
[assembly: InternalsVisibleTo("Naizari.Data.Mapping")]
[assembly: InternalsVisibleTo("Naizari.Data.Mgmt")]
[assembly: InternalsVisibleTo("Naizari.Data.Common")]
[assembly: InternalsVisibleTo("Naizari.Data.Classification")]
[assembly: InternalsVisibleTo("Naizari.Configuration")]
[assembly: InternalsVisibleTo("Naizari.QiGong")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e81eca2b-ef46-41fe-a08c-eecc75d8343a")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

