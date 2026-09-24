#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared4cd5b795d6ac66fcJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared4cd5b795d6ac66fc>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared4cd5b795d6ac66fc Read(
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
            if (__jsonProps.Contains("repoId")) __score9++;
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
            if (__jsonProps.Contains("repoId")) __score17++;
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

            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1? autoSDKShared4cd5b795d6ac66fcVariant1 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2? autoSDKShared4cd5b795d6ac66fcVariant2 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3? autoSDKShared4cd5b795d6ac66fcVariant3 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4? autoSDKShared4cd5b795d6ac66fcVariant4 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5? autoSDKShared4cd5b795d6ac66fcVariant5 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6? autoSDKShared4cd5b795d6ac66fcVariant6 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7? autoSDKShared4cd5b795d6ac66fcVariant7 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8? autoSDKShared4cd5b795d6ac66fcVariant8 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9? autoSDKShared4cd5b795d6ac66fcVariant9 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10? autoSDKShared4cd5b795d6ac66fcVariant10 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11? autoSDKShared4cd5b795d6ac66fcVariant11 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12? autoSDKShared4cd5b795d6ac66fcVariant12 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13? autoSDKShared4cd5b795d6ac66fcVariant13 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14? autoSDKShared4cd5b795d6ac66fcVariant14 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15? autoSDKShared4cd5b795d6ac66fcVariant15 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16? autoSDKShared4cd5b795d6ac66fcVariant16 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17? autoSDKShared4cd5b795d6ac66fcVariant17 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18? autoSDKShared4cd5b795d6ac66fcVariant18 = default;
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19? autoSDKShared4cd5b795d6ac66fcVariant19 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19).Name}");
                        autoSDKShared4cd5b795d6ac66fcVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared4cd5b795d6ac66fcVariant1 == null && autoSDKShared4cd5b795d6ac66fcVariant2 == null && autoSDKShared4cd5b795d6ac66fcVariant3 == null && autoSDKShared4cd5b795d6ac66fcVariant4 == null && autoSDKShared4cd5b795d6ac66fcVariant5 == null && autoSDKShared4cd5b795d6ac66fcVariant6 == null && autoSDKShared4cd5b795d6ac66fcVariant7 == null && autoSDKShared4cd5b795d6ac66fcVariant8 == null && autoSDKShared4cd5b795d6ac66fcVariant9 == null && autoSDKShared4cd5b795d6ac66fcVariant10 == null && autoSDKShared4cd5b795d6ac66fcVariant11 == null && autoSDKShared4cd5b795d6ac66fcVariant12 == null && autoSDKShared4cd5b795d6ac66fcVariant13 == null && autoSDKShared4cd5b795d6ac66fcVariant14 == null && autoSDKShared4cd5b795d6ac66fcVariant15 == null && autoSDKShared4cd5b795d6ac66fcVariant16 == null && autoSDKShared4cd5b795d6ac66fcVariant17 == null && autoSDKShared4cd5b795d6ac66fcVariant18 == null && autoSDKShared4cd5b795d6ac66fcVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19).Name}");
                    autoSDKShared4cd5b795d6ac66fcVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared4cd5b795d6ac66fc(
                autoSDKShared4cd5b795d6ac66fcVariant1,

                autoSDKShared4cd5b795d6ac66fcVariant2,

                autoSDKShared4cd5b795d6ac66fcVariant3,

                autoSDKShared4cd5b795d6ac66fcVariant4,

                autoSDKShared4cd5b795d6ac66fcVariant5,

                autoSDKShared4cd5b795d6ac66fcVariant6,

                autoSDKShared4cd5b795d6ac66fcVariant7,

                autoSDKShared4cd5b795d6ac66fcVariant8,

                autoSDKShared4cd5b795d6ac66fcVariant9,

                autoSDKShared4cd5b795d6ac66fcVariant10,

                autoSDKShared4cd5b795d6ac66fcVariant11,

                autoSDKShared4cd5b795d6ac66fcVariant12,

                autoSDKShared4cd5b795d6ac66fcVariant13,

                autoSDKShared4cd5b795d6ac66fcVariant14,

                autoSDKShared4cd5b795d6ac66fcVariant15,

                autoSDKShared4cd5b795d6ac66fcVariant16,

                autoSDKShared4cd5b795d6ac66fcVariant17,

                autoSDKShared4cd5b795d6ac66fcVariant18,

                autoSDKShared4cd5b795d6ac66fcVariant19
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared4cd5b795d6ac66fc value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant1!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant2!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant3!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant4!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant5!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant6!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant7!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant8!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant9!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant10!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant11!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant12!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant13!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant14!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant15!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant16!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant17!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant18!, typeInfo);
            }
            else if (value.IsAutoSDKShared4cd5b795d6ac66fcVariant19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared4cd5b795d6ac66fcVariant19!, typeInfo);
            }
        }
    }
}