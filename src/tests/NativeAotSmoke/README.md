# Offline JSON and NativeAOT smoke

This console harness makes no network calls and needs no provider credentials.
It checks request and response round trips, nullable values, enum/array unions,
and nested extension data using the generated serializer context with reflection
disabled. The integration test project runs the same contracts and separately
loads every generated CLR type to detect per-type metadata limits.

Run the native profile on Linux x64 or ARM64 (replace `linux-x64` with `linux-arm64`):

```sh
dotnet publish src/tests/NativeAotSmoke/Vercel.NativeAotSmoke.csproj -c Release -r linux-x64 -o artifacts/native-smoke
./artifacts/native-smoke/Vercel.NativeAotSmoke
```

The publish workflow builds and executes this harness on native Linux x64 and ARM64
runners. When tuning the generator's context partition size, also run `autosdk trim src/libs/Vercel/Vercel.csproj`;
a successful JSON smoke alone does not prove the complete library is trimmable.

The Linux profiles disable identical method-body folding in the .NET native
compiler. With the complete generated serializer graph, that optional size
optimization can spend more than 30 minutes in object emission. Code
optimization, trimming diagnostics, warnings-as-errors and the complete JSON
contracts remain enabled. The tradeoff is a larger native executable.

Vercel opts into 2,000 explicit registrations per serializer context. This reduces
repeated transitive metadata expansion while staying below the CLR method limit.
The former 1,000-registration profile compiled on ARM64 but crashed at startup on
.NET 10.0.13; the 2,000-registration profile executes the full offline contracts.
The generator default remains 500 for other SDKs. Always run all CLR type-loading,
JSON, trimming and native execution checks together after changing this value.
