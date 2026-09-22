#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared0dd077d6df470379JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared0dd077d6df470379>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared0dd077d6df470379 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("prId")) __score0++;
            if (__jsonProps.Contains("ref")) __score0++;
            if (__jsonProps.Contains("repoId")) __score0++;
            if (__jsonProps.Contains("sha")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("org")) __score1++;
            if (__jsonProps.Contains("prId")) __score1++;
            if (__jsonProps.Contains("ref")) __score1++;
            if (__jsonProps.Contains("repo")) __score1++;
            if (__jsonProps.Contains("sha")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("host")) __score2++;
            if (__jsonProps.Contains("prId")) __score2++;
            if (__jsonProps.Contains("ref")) __score2++;
            if (__jsonProps.Contains("repoId")) __score2++;
            if (__jsonProps.Contains("sha")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("host")) __score3++;
            if (__jsonProps.Contains("org")) __score3++;
            if (__jsonProps.Contains("prId")) __score3++;
            if (__jsonProps.Contains("ref")) __score3++;
            if (__jsonProps.Contains("repo")) __score3++;
            if (__jsonProps.Contains("sha")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("prId")) __score4++;
            if (__jsonProps.Contains("ref")) __score4++;
            if (__jsonProps.Contains("repoId")) __score4++;
            if (__jsonProps.Contains("sha")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("org")) __score5++;
            if (__jsonProps.Contains("prId")) __score5++;
            if (__jsonProps.Contains("ref")) __score5++;
            if (__jsonProps.Contains("repo")) __score5++;
            if (__jsonProps.Contains("sha")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("prId")) __score6++;
            if (__jsonProps.Contains("projectId")) __score6++;
            if (__jsonProps.Contains("ref")) __score6++;
            if (__jsonProps.Contains("sha")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("prId")) __score7++;
            if (__jsonProps.Contains("ref")) __score7++;
            if (__jsonProps.Contains("repoUuid")) __score7++;
            if (__jsonProps.Contains("sha")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("workspaceUuid")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("owner")) __score8++;
            if (__jsonProps.Contains("prId")) __score8++;
            if (__jsonProps.Contains("ref")) __score8++;
            if (__jsonProps.Contains("sha")) __score8++;
            if (__jsonProps.Contains("slug")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("commitMetadata")) __score9++;
            if (__jsonProps.Contains("commitMetadata.author")) __score9++;
            if (__jsonProps.Contains("commitMetadata.committer")) __score9++;
            if (__jsonProps.Contains("commitMetadata.message")) __score9++;
            if (__jsonProps.Contains("org")) __score9++;
            if (__jsonProps.Contains("prId")) __score9++;
            if (__jsonProps.Contains("ref")) __score9++;
            if (__jsonProps.Contains("repo")) __score9++;
            if (__jsonProps.Contains("repoPushedAt")) __score9++;
            if (__jsonProps.Contains("sha")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("owner")) __score10++;
            if (__jsonProps.Contains("prId")) __score10++;
            if (__jsonProps.Contains("ref")) __score10++;
            if (__jsonProps.Contains("repo")) __score10++;
            if (__jsonProps.Contains("repoId")) __score10++;
            if (__jsonProps.Contains("sha")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("gitUrl")) __score11++;
            if (__jsonProps.Contains("ref")) __score11++;
            if (__jsonProps.Contains("sha")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("org")) __score12++;
            if (__jsonProps.Contains("ref")) __score12++;
            if (__jsonProps.Contains("repo")) __score12++;
            if (__jsonProps.Contains("repoId")) __score12++;
            if (__jsonProps.Contains("sha")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("host")) __score13++;
            if (__jsonProps.Contains("org")) __score13++;
            if (__jsonProps.Contains("ref")) __score13++;
            if (__jsonProps.Contains("repo")) __score13++;
            if (__jsonProps.Contains("repoId")) __score13++;
            if (__jsonProps.Contains("sha")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("org")) __score14++;
            if (__jsonProps.Contains("ref")) __score14++;
            if (__jsonProps.Contains("repo")) __score14++;
            if (__jsonProps.Contains("repoId")) __score14++;
            if (__jsonProps.Contains("sha")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("projectId")) __score15++;
            if (__jsonProps.Contains("ref")) __score15++;
            if (__jsonProps.Contains("sha")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("owner")) __score16++;
            if (__jsonProps.Contains("ref")) __score16++;
            if (__jsonProps.Contains("repoUuid")) __score16++;
            if (__jsonProps.Contains("sha")) __score16++;
            if (__jsonProps.Contains("slug")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            if (__jsonProps.Contains("workspaceUuid")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("commitMetadata")) __score17++;
            if (__jsonProps.Contains("commitMetadata.author")) __score17++;
            if (__jsonProps.Contains("commitMetadata.committer")) __score17++;
            if (__jsonProps.Contains("commitMetadata.message")) __score17++;
            if (__jsonProps.Contains("org")) __score17++;
            if (__jsonProps.Contains("ref")) __score17++;
            if (__jsonProps.Contains("repo")) __score17++;
            if (__jsonProps.Contains("repoPushedAt")) __score17++;
            if (__jsonProps.Contains("sha")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("owner")) __score18++;
            if (__jsonProps.Contains("ref")) __score18++;
            if (__jsonProps.Contains("repo")) __score18++;
            if (__jsonProps.Contains("repoId")) __score18++;
            if (__jsonProps.Contains("sha")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }

            global::Vercel.AutoSDKShared0dd077d6df470379Variant1? autoSDKShared0dd077d6df470379Variant1 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant2? autoSDKShared0dd077d6df470379Variant2 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant3? autoSDKShared0dd077d6df470379Variant3 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant4? autoSDKShared0dd077d6df470379Variant4 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant5? autoSDKShared0dd077d6df470379Variant5 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant6? autoSDKShared0dd077d6df470379Variant6 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant7? autoSDKShared0dd077d6df470379Variant7 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant8? autoSDKShared0dd077d6df470379Variant8 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant9? autoSDKShared0dd077d6df470379Variant9 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant10? autoSDKShared0dd077d6df470379Variant10 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant11? autoSDKShared0dd077d6df470379Variant11 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant12? autoSDKShared0dd077d6df470379Variant12 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant13? autoSDKShared0dd077d6df470379Variant13 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant14? autoSDKShared0dd077d6df470379Variant14 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant15? autoSDKShared0dd077d6df470379Variant15 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant16? autoSDKShared0dd077d6df470379Variant16 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant17? autoSDKShared0dd077d6df470379Variant17 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant18? autoSDKShared0dd077d6df470379Variant18 = default;
            global::Vercel.AutoSDKShared0dd077d6df470379Variant19? autoSDKShared0dd077d6df470379Variant19 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant1).Name}");
                        autoSDKShared0dd077d6df470379Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant2).Name}");
                        autoSDKShared0dd077d6df470379Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant3).Name}");
                        autoSDKShared0dd077d6df470379Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant4).Name}");
                        autoSDKShared0dd077d6df470379Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant5).Name}");
                        autoSDKShared0dd077d6df470379Variant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant6).Name}");
                        autoSDKShared0dd077d6df470379Variant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant7).Name}");
                        autoSDKShared0dd077d6df470379Variant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant8).Name}");
                        autoSDKShared0dd077d6df470379Variant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant9).Name}");
                        autoSDKShared0dd077d6df470379Variant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant10).Name}");
                        autoSDKShared0dd077d6df470379Variant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant11).Name}");
                        autoSDKShared0dd077d6df470379Variant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant12).Name}");
                        autoSDKShared0dd077d6df470379Variant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant13).Name}");
                        autoSDKShared0dd077d6df470379Variant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant14).Name}");
                        autoSDKShared0dd077d6df470379Variant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant15).Name}");
                        autoSDKShared0dd077d6df470379Variant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant16).Name}");
                        autoSDKShared0dd077d6df470379Variant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant17).Name}");
                        autoSDKShared0dd077d6df470379Variant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant18> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant18).Name}");
                        autoSDKShared0dd077d6df470379Variant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant19> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant19).Name}");
                        autoSDKShared0dd077d6df470379Variant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant1).Name}");
                    autoSDKShared0dd077d6df470379Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant2).Name}");
                    autoSDKShared0dd077d6df470379Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant3).Name}");
                    autoSDKShared0dd077d6df470379Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant4).Name}");
                    autoSDKShared0dd077d6df470379Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant5).Name}");
                    autoSDKShared0dd077d6df470379Variant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant6).Name}");
                    autoSDKShared0dd077d6df470379Variant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant7).Name}");
                    autoSDKShared0dd077d6df470379Variant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant8).Name}");
                    autoSDKShared0dd077d6df470379Variant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant9).Name}");
                    autoSDKShared0dd077d6df470379Variant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant10).Name}");
                    autoSDKShared0dd077d6df470379Variant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant11).Name}");
                    autoSDKShared0dd077d6df470379Variant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant12).Name}");
                    autoSDKShared0dd077d6df470379Variant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant13).Name}");
                    autoSDKShared0dd077d6df470379Variant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant14).Name}");
                    autoSDKShared0dd077d6df470379Variant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant15).Name}");
                    autoSDKShared0dd077d6df470379Variant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant16).Name}");
                    autoSDKShared0dd077d6df470379Variant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant17).Name}");
                    autoSDKShared0dd077d6df470379Variant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant18> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant18).Name}");
                    autoSDKShared0dd077d6df470379Variant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0dd077d6df470379Variant1 == null && autoSDKShared0dd077d6df470379Variant2 == null && autoSDKShared0dd077d6df470379Variant3 == null && autoSDKShared0dd077d6df470379Variant4 == null && autoSDKShared0dd077d6df470379Variant5 == null && autoSDKShared0dd077d6df470379Variant6 == null && autoSDKShared0dd077d6df470379Variant7 == null && autoSDKShared0dd077d6df470379Variant8 == null && autoSDKShared0dd077d6df470379Variant9 == null && autoSDKShared0dd077d6df470379Variant10 == null && autoSDKShared0dd077d6df470379Variant11 == null && autoSDKShared0dd077d6df470379Variant12 == null && autoSDKShared0dd077d6df470379Variant13 == null && autoSDKShared0dd077d6df470379Variant14 == null && autoSDKShared0dd077d6df470379Variant15 == null && autoSDKShared0dd077d6df470379Variant16 == null && autoSDKShared0dd077d6df470379Variant17 == null && autoSDKShared0dd077d6df470379Variant18 == null && autoSDKShared0dd077d6df470379Variant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant19> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant19).Name}");
                    autoSDKShared0dd077d6df470379Variant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared0dd077d6df470379(
                autoSDKShared0dd077d6df470379Variant1,

                autoSDKShared0dd077d6df470379Variant2,

                autoSDKShared0dd077d6df470379Variant3,

                autoSDKShared0dd077d6df470379Variant4,

                autoSDKShared0dd077d6df470379Variant5,

                autoSDKShared0dd077d6df470379Variant6,

                autoSDKShared0dd077d6df470379Variant7,

                autoSDKShared0dd077d6df470379Variant8,

                autoSDKShared0dd077d6df470379Variant9,

                autoSDKShared0dd077d6df470379Variant10,

                autoSDKShared0dd077d6df470379Variant11,

                autoSDKShared0dd077d6df470379Variant12,

                autoSDKShared0dd077d6df470379Variant13,

                autoSDKShared0dd077d6df470379Variant14,

                autoSDKShared0dd077d6df470379Variant15,

                autoSDKShared0dd077d6df470379Variant16,

                autoSDKShared0dd077d6df470379Variant17,

                autoSDKShared0dd077d6df470379Variant18,

                autoSDKShared0dd077d6df470379Variant19
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared0dd077d6df470379 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKShared0dd077d6df470379Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant1!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant2!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant3!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant4!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant5!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant6!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant7!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant8!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant9!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant10!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant11!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant12!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant13!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant14!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant15!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant16!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant17!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant18!, typeInfo);
            }
            else if (value.IsAutoSDKShared0dd077d6df470379Variant19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0dd077d6df470379Variant19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0dd077d6df470379Variant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared0dd077d6df470379Variant19!, typeInfo);
            }
        }
    }
}