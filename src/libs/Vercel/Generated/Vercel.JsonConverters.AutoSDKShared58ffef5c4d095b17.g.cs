#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared58ffef5c4d095b17JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared58ffef5c4d095b17>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared58ffef5c4d095b17 Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("user")) __score0++;
            if (__jsonProps.Contains("user.id")) __score0++;
            if (__jsonProps.Contains("via")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("project")) __score1++;
            if (__jsonProps.Contains("project.id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("app")) __score2++;
            if (__jsonProps.Contains("app.clientId")) __score2++;
            if (__jsonProps.Contains("app.id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("integration")) __score3++;
            if (__jsonProps.Contains("integration.configurationId")) __score3++;
            if (__jsonProps.Contains("integration.integrationId")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1? autoSDKShared58ffef5c4d095b17Variant1 = default;
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2? autoSDKShared58ffef5c4d095b17Variant2 = default;
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3? autoSDKShared58ffef5c4d095b17Variant3 = default;
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4? autoSDKShared58ffef5c4d095b17Variant4 = default;
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5? autoSDKShared58ffef5c4d095b17Variant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1).Name}");
                        autoSDKShared58ffef5c4d095b17Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2).Name}");
                        autoSDKShared58ffef5c4d095b17Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3).Name}");
                        autoSDKShared58ffef5c4d095b17Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4).Name}");
                        autoSDKShared58ffef5c4d095b17Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5).Name}");
                        autoSDKShared58ffef5c4d095b17Variant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (autoSDKShared58ffef5c4d095b17Variant1 == null && autoSDKShared58ffef5c4d095b17Variant2 == null && autoSDKShared58ffef5c4d095b17Variant3 == null && autoSDKShared58ffef5c4d095b17Variant4 == null && autoSDKShared58ffef5c4d095b17Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1).Name}");
                    autoSDKShared58ffef5c4d095b17Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (autoSDKShared58ffef5c4d095b17Variant1 == null && autoSDKShared58ffef5c4d095b17Variant2 == null && autoSDKShared58ffef5c4d095b17Variant3 == null && autoSDKShared58ffef5c4d095b17Variant4 == null && autoSDKShared58ffef5c4d095b17Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2).Name}");
                    autoSDKShared58ffef5c4d095b17Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (autoSDKShared58ffef5c4d095b17Variant1 == null && autoSDKShared58ffef5c4d095b17Variant2 == null && autoSDKShared58ffef5c4d095b17Variant3 == null && autoSDKShared58ffef5c4d095b17Variant4 == null && autoSDKShared58ffef5c4d095b17Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3).Name}");
                    autoSDKShared58ffef5c4d095b17Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (autoSDKShared58ffef5c4d095b17Variant1 == null && autoSDKShared58ffef5c4d095b17Variant2 == null && autoSDKShared58ffef5c4d095b17Variant3 == null && autoSDKShared58ffef5c4d095b17Variant4 == null && autoSDKShared58ffef5c4d095b17Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4).Name}");
                    autoSDKShared58ffef5c4d095b17Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (autoSDKShared58ffef5c4d095b17Variant1 == null && autoSDKShared58ffef5c4d095b17Variant2 == null && autoSDKShared58ffef5c4d095b17Variant3 == null && autoSDKShared58ffef5c4d095b17Variant4 == null && autoSDKShared58ffef5c4d095b17Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5).Name}");
                    autoSDKShared58ffef5c4d095b17Variant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Vercel.AutoSDKShared58ffef5c4d095b17(
                autoSDKShared58ffef5c4d095b17Variant1,

                autoSDKShared58ffef5c4d095b17Variant2,

                autoSDKShared58ffef5c4d095b17Variant3,

                autoSDKShared58ffef5c4d095b17Variant4,

                autoSDKShared58ffef5c4d095b17Variant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared58ffef5c4d095b17 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKShared58ffef5c4d095b17Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKShared58ffef5c4d095b17Variant1(), typeInfo);
            }
            else if (value.IsAutoSDKShared58ffef5c4d095b17Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKShared58ffef5c4d095b17Variant2(), typeInfo);
            }
            else if (value.IsAutoSDKShared58ffef5c4d095b17Variant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKShared58ffef5c4d095b17Variant3(), typeInfo);
            }
            else if (value.IsAutoSDKShared58ffef5c4d095b17Variant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKShared58ffef5c4d095b17Variant4(), typeInfo);
            }
            else if (value.IsAutoSDKShared58ffef5c4d095b17Variant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared58ffef5c4d095b17Variant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKShared58ffef5c4d095b17Variant5(), typeInfo);
            }
        }
    }
}