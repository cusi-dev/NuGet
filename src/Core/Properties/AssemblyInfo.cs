using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: AssemblyTitle("NuGet.Core")]
[assembly: AssemblyDescription("Core API for NuGet")]
[assembly: CLSCompliant(true)]

[assembly: InternalsVisibleTo("NuGet.Test")]
[assembly: InternalsVisibleTo("NuGet.Test.Utility")]
[assembly: InternalsVisibleTo("NuGet.VisualStudio.Test")]
[assembly: InternalsVisibleTo("NuGet.Cmdlets.Test")]

#if !CODE_COVERAGE
[assembly: SecurityTransparent]
#endif
