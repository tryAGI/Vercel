#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedfb6f42506e3e02aeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedfb6f42506e3e02ae>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedfb6f42506e3e02ae Read(
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
            if (__jsonProps.Contains("code")) __score0++;
            if (__jsonProps.Contains("details")) __score0++;
            if (__jsonProps.Contains("details.detectedLanguageCode")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("code")) __score1++;
            if (__jsonProps.Contains("details")) __score1++;
            if (__jsonProps.Contains("details.detectedLanguageCode")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("code")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("code")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("code")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("code")) __score5++;
            if (__jsonProps.Contains("details")) __score5++;
            if (__jsonProps.Contains("details.numDaysUntilTransferrable")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("code")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("code")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("code")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("code")) __score9++;
            if (__jsonProps.Contains("details")) __score9++;
            if (__jsonProps.Contains("details.invalidField")) __score9++;
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

            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1? autoSDKSharedfb6f42506e3e02aeVariant1 = default;
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2? autoSDKSharedfb6f42506e3e02aeVariant2 = default;
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3? autoSDKSharedfb6f42506e3e02aeVariant3 = default;
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4? autoSDKSharedfb6f42506e3e02aeVariant4 = default;
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5? autoSDKSharedfb6f42506e3e02aeVariant5 = default;
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6? autoSDKSharedfb6f42506e3e02aeVariant6 = default;
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7? autoSDKSharedfb6f42506e3e02aeVariant7 = default;
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8? autoSDKSharedfb6f42506e3e02aeVariant8 = default;
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9? autoSDKSharedfb6f42506e3e02aeVariant9 = default;
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10? autoSDKSharedfb6f42506e3e02aeVariant10 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10).Name}");
                        autoSDKSharedfb6f42506e3e02aeVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedfb6f42506e3e02aeVariant1 == null && autoSDKSharedfb6f42506e3e02aeVariant2 == null && autoSDKSharedfb6f42506e3e02aeVariant3 == null && autoSDKSharedfb6f42506e3e02aeVariant4 == null && autoSDKSharedfb6f42506e3e02aeVariant5 == null && autoSDKSharedfb6f42506e3e02aeVariant6 == null && autoSDKSharedfb6f42506e3e02aeVariant7 == null && autoSDKSharedfb6f42506e3e02aeVariant8 == null && autoSDKSharedfb6f42506e3e02aeVariant9 == null && autoSDKSharedfb6f42506e3e02aeVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10).Name}");
                    autoSDKSharedfb6f42506e3e02aeVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKSharedfb6f42506e3e02ae(
                autoSDKSharedfb6f42506e3e02aeVariant1,

                autoSDKSharedfb6f42506e3e02aeVariant2,

                autoSDKSharedfb6f42506e3e02aeVariant3,

                autoSDKSharedfb6f42506e3e02aeVariant4,

                autoSDKSharedfb6f42506e3e02aeVariant5,

                autoSDKSharedfb6f42506e3e02aeVariant6,

                autoSDKSharedfb6f42506e3e02aeVariant7,

                autoSDKSharedfb6f42506e3e02aeVariant8,

                autoSDKSharedfb6f42506e3e02aeVariant9,

                autoSDKSharedfb6f42506e3e02aeVariant10
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedfb6f42506e3e02ae value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant1!, typeInfo);
            }
            else if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant2!, typeInfo);
            }
            else if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant3!, typeInfo);
            }
            else if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant4!, typeInfo);
            }
            else if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant5!, typeInfo);
            }
            else if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant6!, typeInfo);
            }
            else if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant7!, typeInfo);
            }
            else if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant8!, typeInfo);
            }
            else if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant9!, typeInfo);
            }
            else if (value.IsAutoSDKSharedfb6f42506e3e02aeVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedfb6f42506e3e02aeVariant10!, typeInfo);
            }
        }
    }
}