# Offline JSON and NativeAOT smoke

This console harness makes no network calls and needs no provider credentials.
It checks request and response round trips, nullable values, enum/array unions,
and nested extension data using the generated serializer context with reflection
disabled. The integration test project runs the same contracts and separately
loads every generated CLR type to detect per-type metadata limits.

Run the validated native profile on Linux x64:

```sh
dotnet publish src/tests/NativeAotSmoke/Vercel.NativeAotSmoke.csproj -c Release -r linux-x64 -o artifacts/native-smoke
./artifacts/native-smoke/Vercel.NativeAotSmoke
```

The publish workflow runs this harness on Linux x64. When tuning the generator's
context partition size, also run `autosdk trim src/libs/Vercel/Vercel.csproj`;
a successful JSON smoke alone does not prove the complete library is trimmable.

The Linux x64 profile disables identical method-body folding in the .NET native
compiler. With the complete generated serializer graph, that optional size
optimization can spend more than 30 minutes in object emission. Code
optimization, trimming diagnostics, warnings-as-errors and the complete JSON
contracts remain enabled. The tradeoff is a larger native executable.

This setting is restricted to Linux x64. A diagnostic Linux ARM64 build with
folding disabled compiled but crashed at startup on .NET 10.0.13; it is not an
accepted ARM64 result. NativeAOT platform coverage must be reported separately
from managed tests and trimming compatibility.
