using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: Guid("8e2f6efc-6faf-4fc1-a96d-74c377737bf5")]
[assembly: CLSCompliant(true)]

[assembly: InternalsVisibleTo("Hangfire.SqlServer.Msmq.Tests")]
// Allow the generation of mocks for internal types
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]