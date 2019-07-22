# ProfileWpfApp1
A custom WPF app that sits ontop of Intrahealth Profile EMR product.

# Building
Using Visual Studio 2017 or greater with .net 4 SDK installed you can do a normal build.
- Update the reference to your Intrahealth.Common.IHProfBL.Interop.dll
- Copy the additional assemblies for the WPF app into the same location, details below.
- Either set the build path to the same BIN directory where Profile.exe is running or copy the built assembly there after successful builds.
- Import the macros or create your own in Profile.

## additional references needed
In the Profile macros proper references are required to load a WPF application and call the ShowDialog method.  These assemblies will need to be copied to where Profile.exe is as well.  
// #reference=WindowsBase.dll  
// #reference=PresentationCore.dll  
// #reference=PresentationFramework.dll  
  
The default path where to find these assembly files are: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\  

# Namespace  
When developing your application inside and outside of Profile you can use the same namespace declaration to make it a bit easier to develop.

