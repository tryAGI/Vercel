# Offline JSON and NativeAOT smoke

This console harness makes no network calls and needs no provider credentials.
It checks request and response round trips, nullable values, enum/array unions,
and nested extension data using the generated serializer context with reflection
disabled. The integration test project runs the same contracts and separately
loads every generated CLR type to detect per-type metadata limits.

Run a native build on Linux (use `linux-arm64` on an ARM64 host):

```sh
dotnet publish src/tests/NativeAotSmoke/Vercel.NativeAotSmoke.csproj -c Release -r linux-x64 -o artifacts/native-smoke
./artifacts/native-smoke/Vercel.NativeAotSmoke
```

The publish workflow runs this harness on Linux x64. When tuning the generator's
context partition size, also run `autosdk trim src/libs/Vercel/Vercel.csproj`;
a successful JSON smoke alone does not prove the complete library is trimmable.
