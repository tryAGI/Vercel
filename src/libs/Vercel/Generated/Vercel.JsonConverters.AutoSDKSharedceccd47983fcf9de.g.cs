#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedceccd47983fcf9deJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedceccd47983fcf9de>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedceccd47983fcf9de Read(
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
            if (__jsonProps.Contains("default")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("enum")) __score0++;
            if (__jsonProps.Contains("maxLength")) __score0++;
            if (__jsonProps.Contains("minLength")) __score0++;
            if (__jsonProps.Contains("pattern")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("ui:control")) __score0++;
            if (__jsonProps.Contains("ui:description")) __score0++;
            if (__jsonProps.Contains("ui:disabled")) __score0++;
            if (__jsonProps.Contains("ui:formatted-value")) __score0++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score0++;
            if (__jsonProps.Contains("ui:hidden")) __score0++;
            if (__jsonProps.Contains("ui:label")) __score0++;
            if (__jsonProps.Contains("ui:paid-only")) __score0++;
            if (__jsonProps.Contains("ui:placeholder")) __score0++;
            if (__jsonProps.Contains("ui:read-only")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("default")) __score1++;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("exclusiveMaximum")) __score1++;
            if (__jsonProps.Contains("exclusiveMinimum")) __score1++;
            if (__jsonProps.Contains("maximum")) __score1++;
            if (__jsonProps.Contains("minimum")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("ui:control")) __score1++;
            if (__jsonProps.Contains("ui:description")) __score1++;
            if (__jsonProps.Contains("ui:disabled")) __score1++;
            if (__jsonProps.Contains("ui:formatted-value")) __score1++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score1++;
            if (__jsonProps.Contains("ui:hidden")) __score1++;
            if (__jsonProps.Contains("ui:label")) __score1++;
            if (__jsonProps.Contains("ui:paid-only")) __score1++;
            if (__jsonProps.Contains("ui:placeholder")) __score1++;
            if (__jsonProps.Contains("ui:read-only")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("default")) __score2++;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("ui:control")) __score2++;
            if (__jsonProps.Contains("ui:description")) __score2++;
            if (__jsonProps.Contains("ui:disabled")) __score2++;
            if (__jsonProps.Contains("ui:formatted-value")) __score2++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score2++;
            if (__jsonProps.Contains("ui:hidden")) __score2++;
            if (__jsonProps.Contains("ui:label")) __score2++;
            if (__jsonProps.Contains("ui:paid-only")) __score2++;
            if (__jsonProps.Contains("ui:read-only")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("default")) __score3++;
            if (__jsonProps.Contains("description")) __score3++;
            if (__jsonProps.Contains("items")) __score3++;
            if (__jsonProps.Contains("items.default")) __score3++;
            if (__jsonProps.Contains("items.description")) __score3++;
            if (__jsonProps.Contains("items.exclusiveMaximum")) __score3++;
            if (__jsonProps.Contains("items.exclusiveMinimum")) __score3++;
            if (__jsonProps.Contains("items.maximum")) __score3++;
            if (__jsonProps.Contains("items.minimum")) __score3++;
            if (__jsonProps.Contains("items.type")) __score3++;
            if (__jsonProps.Contains("maxItems")) __score3++;
            if (__jsonProps.Contains("minItems")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("ui:control")) __score3++;
            if (__jsonProps.Contains("ui:description")) __score3++;
            if (__jsonProps.Contains("ui:disabled")) __score3++;
            if (__jsonProps.Contains("ui:formatted-value")) __score3++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score3++;
            if (__jsonProps.Contains("ui:hidden")) __score3++;
            if (__jsonProps.Contains("ui:label")) __score3++;
            if (__jsonProps.Contains("ui:paid-only")) __score3++;
            if (__jsonProps.Contains("ui:read-only")) __score3++;
            if (__jsonProps.Contains("ui:steps")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("default")) __score4++;
            if (__jsonProps.Contains("description")) __score4++;
            if (__jsonProps.Contains("enum")) __score4++;
            if (__jsonProps.Contains("maxLength")) __score4++;
            if (__jsonProps.Contains("minLength")) __score4++;
            if (__jsonProps.Contains("pattern")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("ui:control")) __score4++;
            if (__jsonProps.Contains("ui:description")) __score4++;
            if (__jsonProps.Contains("ui:disabled")) __score4++;
            if (__jsonProps.Contains("ui:formatted-value")) __score4++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score4++;
            if (__jsonProps.Contains("ui:hidden")) __score4++;
            if (__jsonProps.Contains("ui:label")) __score4++;
            if (__jsonProps.Contains("ui:options")) __score4++;
            if (__jsonProps.Contains("ui:paid-only")) __score4++;
            if (__jsonProps.Contains("ui:placeholder")) __score4++;
            if (__jsonProps.Contains("ui:read-only")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("default")) __score5++;
            if (__jsonProps.Contains("description")) __score5++;
            if (__jsonProps.Contains("enum")) __score5++;
            if (__jsonProps.Contains("maxLength")) __score5++;
            if (__jsonProps.Contains("minLength")) __score5++;
            if (__jsonProps.Contains("pattern")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("ui:control")) __score5++;
            if (__jsonProps.Contains("ui:description")) __score5++;
            if (__jsonProps.Contains("ui:disabled")) __score5++;
            if (__jsonProps.Contains("ui:formatted-value")) __score5++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score5++;
            if (__jsonProps.Contains("ui:hidden")) __score5++;
            if (__jsonProps.Contains("ui:label")) __score5++;
            if (__jsonProps.Contains("ui:options")) __score5++;
            if (__jsonProps.Contains("ui:paid-only")) __score5++;
            if (__jsonProps.Contains("ui:placeholder")) __score5++;
            if (__jsonProps.Contains("ui:read-only")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("default")) __score6++;
            if (__jsonProps.Contains("description")) __score6++;
            if (__jsonProps.Contains("example")) __score6++;
            if (__jsonProps.Contains("items")) __score6++;
            if (__jsonProps.Contains("items.default")) __score6++;
            if (__jsonProps.Contains("items.description")) __score6++;
            if (__jsonProps.Contains("items.enum")) __score6++;
            if (__jsonProps.Contains("items.maxLength")) __score6++;
            if (__jsonProps.Contains("items.minLength")) __score6++;
            if (__jsonProps.Contains("items.pattern")) __score6++;
            if (__jsonProps.Contains("items.type")) __score6++;
            if (__jsonProps.Contains("maxItems")) __score6++;
            if (__jsonProps.Contains("minItems")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("ui:control")) __score6++;
            if (__jsonProps.Contains("ui:description")) __score6++;
            if (__jsonProps.Contains("ui:disabled")) __score6++;
            if (__jsonProps.Contains("ui:formatted-value")) __score6++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score6++;
            if (__jsonProps.Contains("ui:hidden")) __score6++;
            if (__jsonProps.Contains("ui:label")) __score6++;
            if (__jsonProps.Contains("ui:options")) __score6++;
            if (__jsonProps.Contains("ui:paid-only")) __score6++;
            if (__jsonProps.Contains("ui:placeholder")) __score6++;
            if (__jsonProps.Contains("ui:read-only")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("default")) __score7++;
            if (__jsonProps.Contains("description")) __score7++;
            if (__jsonProps.Contains("enum")) __score7++;
            if (__jsonProps.Contains("maxLength")) __score7++;
            if (__jsonProps.Contains("minLength")) __score7++;
            if (__jsonProps.Contains("pattern")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("ui:control")) __score7++;
            if (__jsonProps.Contains("ui:description")) __score7++;
            if (__jsonProps.Contains("ui:disabled")) __score7++;
            if (__jsonProps.Contains("ui:formatted-value")) __score7++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score7++;
            if (__jsonProps.Contains("ui:hidden")) __score7++;
            if (__jsonProps.Contains("ui:label")) __score7++;
            if (__jsonProps.Contains("ui:options")) __score7++;
            if (__jsonProps.Contains("ui:paid-only")) __score7++;
            if (__jsonProps.Contains("ui:placeholder")) __score7++;
            if (__jsonProps.Contains("ui:read-only")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("default")) __score8++;
            if (__jsonProps.Contains("description")) __score8++;
            if (__jsonProps.Contains("example")) __score8++;
            if (__jsonProps.Contains("items")) __score8++;
            if (__jsonProps.Contains("items.default")) __score8++;
            if (__jsonProps.Contains("items.description")) __score8++;
            if (__jsonProps.Contains("items.enum")) __score8++;
            if (__jsonProps.Contains("items.maxLength")) __score8++;
            if (__jsonProps.Contains("items.minLength")) __score8++;
            if (__jsonProps.Contains("items.pattern")) __score8++;
            if (__jsonProps.Contains("items.type")) __score8++;
            if (__jsonProps.Contains("maxItems")) __score8++;
            if (__jsonProps.Contains("minItems")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("ui:control")) __score8++;
            if (__jsonProps.Contains("ui:description")) __score8++;
            if (__jsonProps.Contains("ui:disabled")) __score8++;
            if (__jsonProps.Contains("ui:formatted-value")) __score8++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score8++;
            if (__jsonProps.Contains("ui:hidden")) __score8++;
            if (__jsonProps.Contains("ui:label")) __score8++;
            if (__jsonProps.Contains("ui:options")) __score8++;
            if (__jsonProps.Contains("ui:paid-only")) __score8++;
            if (__jsonProps.Contains("ui:placeholder")) __score8++;
            if (__jsonProps.Contains("ui:read-only")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("default")) __score9++;
            if (__jsonProps.Contains("description")) __score9++;
            if (__jsonProps.Contains("enum")) __score9++;
            if (__jsonProps.Contains("maxLength")) __score9++;
            if (__jsonProps.Contains("minLength")) __score9++;
            if (__jsonProps.Contains("pattern")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("ui:control")) __score9++;
            if (__jsonProps.Contains("ui:description")) __score9++;
            if (__jsonProps.Contains("ui:disabled")) __score9++;
            if (__jsonProps.Contains("ui:formatted-value")) __score9++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score9++;
            if (__jsonProps.Contains("ui:hidden")) __score9++;
            if (__jsonProps.Contains("ui:label")) __score9++;
            if (__jsonProps.Contains("ui:options")) __score9++;
            if (__jsonProps.Contains("ui:paid-only")) __score9++;
            if (__jsonProps.Contains("ui:placeholder")) __score9++;
            if (__jsonProps.Contains("ui:read-only")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("default")) __score10++;
            if (__jsonProps.Contains("description")) __score10++;
            if (__jsonProps.Contains("enum")) __score10++;
            if (__jsonProps.Contains("maxLength")) __score10++;
            if (__jsonProps.Contains("minLength")) __score10++;
            if (__jsonProps.Contains("pattern")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            if (__jsonProps.Contains("ui:control")) __score10++;
            if (__jsonProps.Contains("ui:description")) __score10++;
            if (__jsonProps.Contains("ui:disabled")) __score10++;
            if (__jsonProps.Contains("ui:formatted-value")) __score10++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score10++;
            if (__jsonProps.Contains("ui:hidden")) __score10++;
            if (__jsonProps.Contains("ui:label")) __score10++;
            if (__jsonProps.Contains("ui:paid-only")) __score10++;
            if (__jsonProps.Contains("ui:placeholder")) __score10++;
            if (__jsonProps.Contains("ui:read-only")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("description")) __score11++;
            if (__jsonProps.Contains("git:providers")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            if (__jsonProps.Contains("ui:control")) __score11++;
            if (__jsonProps.Contains("ui:description")) __score11++;
            if (__jsonProps.Contains("ui:disabled")) __score11++;
            if (__jsonProps.Contains("ui:formatted-value")) __score11++;
            if (__jsonProps.Contains("ui:formatted-value.expr")) __score11++;
            if (__jsonProps.Contains("ui:hidden")) __score11++;
            if (__jsonProps.Contains("ui:label")) __score11++;
            if (__jsonProps.Contains("ui:paid-only")) __score11++;
            if (__jsonProps.Contains("ui:placeholder")) __score11++;
            if (__jsonProps.Contains("ui:read-only")) __score11++;
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

            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1? autoSDKSharedceccd47983fcf9deVariant1 = default;
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2? autoSDKSharedceccd47983fcf9deVariant2 = default;
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3? autoSDKSharedceccd47983fcf9deVariant3 = default;
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4? autoSDKSharedceccd47983fcf9deVariant4 = default;
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5? autoSDKSharedceccd47983fcf9deVariant5 = default;
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6? autoSDKSharedceccd47983fcf9deVariant6 = default;
            global::Vercel.AutoSDKSharedaf3e034232cd964a? sharedaf3e034232cd964a = default;
            global::Vercel.AutoSDKShared0603220ab3785539? shared0603220ab3785539 = default;
            global::Vercel.AutoSDKShared2c06e7f88512c8b8? shared2c06e7f88512c8b8 = default;
            global::Vercel.AutoSDKSharedfc279ab2bedb9f61? sharedfc279ab2bedb9f61 = default;
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11? autoSDKSharedceccd47983fcf9deVariant11 = default;
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12? autoSDKSharedceccd47983fcf9deVariant12 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1).Name}");
                        autoSDKSharedceccd47983fcf9deVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2).Name}");
                        autoSDKSharedceccd47983fcf9deVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3).Name}");
                        autoSDKSharedceccd47983fcf9deVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4).Name}");
                        autoSDKSharedceccd47983fcf9deVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5).Name}");
                        autoSDKSharedceccd47983fcf9deVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6).Name}");
                        autoSDKSharedceccd47983fcf9deVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedaf3e034232cd964a), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedaf3e034232cd964a> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedaf3e034232cd964a).Name}");
                        sharedaf3e034232cd964a = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0603220ab3785539), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0603220ab3785539> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0603220ab3785539).Name}");
                        shared0603220ab3785539 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared2c06e7f88512c8b8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared2c06e7f88512c8b8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared2c06e7f88512c8b8).Name}");
                        shared2c06e7f88512c8b8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfc279ab2bedb9f61), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfc279ab2bedb9f61> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfc279ab2bedb9f61).Name}");
                        sharedfc279ab2bedb9f61 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11).Name}");
                        autoSDKSharedceccd47983fcf9deVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12).Name}");
                        autoSDKSharedceccd47983fcf9deVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1).Name}");
                    autoSDKSharedceccd47983fcf9deVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2).Name}");
                    autoSDKSharedceccd47983fcf9deVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3).Name}");
                    autoSDKSharedceccd47983fcf9deVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4).Name}");
                    autoSDKSharedceccd47983fcf9deVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5).Name}");
                    autoSDKSharedceccd47983fcf9deVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6).Name}");
                    autoSDKSharedceccd47983fcf9deVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedaf3e034232cd964a), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedaf3e034232cd964a> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedaf3e034232cd964a).Name}");
                    sharedaf3e034232cd964a = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0603220ab3785539), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0603220ab3785539> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0603220ab3785539).Name}");
                    shared0603220ab3785539 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared2c06e7f88512c8b8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared2c06e7f88512c8b8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared2c06e7f88512c8b8).Name}");
                    shared2c06e7f88512c8b8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfc279ab2bedb9f61), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfc279ab2bedb9f61> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfc279ab2bedb9f61).Name}");
                    sharedfc279ab2bedb9f61 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11).Name}");
                    autoSDKSharedceccd47983fcf9deVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedceccd47983fcf9deVariant1 == null && autoSDKSharedceccd47983fcf9deVariant2 == null && autoSDKSharedceccd47983fcf9deVariant3 == null && autoSDKSharedceccd47983fcf9deVariant4 == null && autoSDKSharedceccd47983fcf9deVariant5 == null && autoSDKSharedceccd47983fcf9deVariant6 == null && sharedaf3e034232cd964a == null && shared0603220ab3785539 == null && shared2c06e7f88512c8b8 == null && sharedfc279ab2bedb9f61 == null && autoSDKSharedceccd47983fcf9deVariant11 == null && autoSDKSharedceccd47983fcf9deVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12).Name}");
                    autoSDKSharedceccd47983fcf9deVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKSharedceccd47983fcf9de(
                autoSDKSharedceccd47983fcf9deVariant1,

                autoSDKSharedceccd47983fcf9deVariant2,

                autoSDKSharedceccd47983fcf9deVariant3,

                autoSDKSharedceccd47983fcf9deVariant4,

                autoSDKSharedceccd47983fcf9deVariant5,

                autoSDKSharedceccd47983fcf9deVariant6,

                sharedaf3e034232cd964a,

                shared0603220ab3785539,

                shared2c06e7f88512c8b8,

                sharedfc279ab2bedb9f61,

                autoSDKSharedceccd47983fcf9deVariant11,

                autoSDKSharedceccd47983fcf9deVariant12
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedceccd47983fcf9de value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKSharedceccd47983fcf9deVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedceccd47983fcf9deVariant1!, typeInfo);
            }
            else if (value.IsAutoSDKSharedceccd47983fcf9deVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedceccd47983fcf9deVariant2!, typeInfo);
            }
            else if (value.IsAutoSDKSharedceccd47983fcf9deVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedceccd47983fcf9deVariant3!, typeInfo);
            }
            else if (value.IsAutoSDKSharedceccd47983fcf9deVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedceccd47983fcf9deVariant4!, typeInfo);
            }
            else if (value.IsAutoSDKSharedceccd47983fcf9deVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedceccd47983fcf9deVariant5!, typeInfo);
            }
            else if (value.IsAutoSDKSharedceccd47983fcf9deVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedceccd47983fcf9deVariant6!, typeInfo);
            }
            else if (value.IsSharedaf3e034232cd964a)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedaf3e034232cd964a), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedaf3e034232cd964a?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedaf3e034232cd964a).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sharedaf3e034232cd964a!, typeInfo);
            }
            else if (value.IsShared0603220ab3785539)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0603220ab3785539), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0603220ab3785539?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0603220ab3785539).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared0603220ab3785539!, typeInfo);
            }
            else if (value.IsShared2c06e7f88512c8b8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared2c06e7f88512c8b8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared2c06e7f88512c8b8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared2c06e7f88512c8b8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared2c06e7f88512c8b8!, typeInfo);
            }
            else if (value.IsSharedfc279ab2bedb9f61)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfc279ab2bedb9f61), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfc279ab2bedb9f61?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfc279ab2bedb9f61).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sharedfc279ab2bedb9f61!, typeInfo);
            }
            else if (value.IsAutoSDKSharedceccd47983fcf9deVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedceccd47983fcf9deVariant11!, typeInfo);
            }
            else if (value.IsAutoSDKSharedceccd47983fcf9deVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedceccd47983fcf9deVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedceccd47983fcf9deVariant12!, typeInfo);
            }
        }
    }
}