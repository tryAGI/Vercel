#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedcf426121243a64beJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedcf426121243a64be>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedcf426121243a64be Read(
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
            if (__jsonProps.Contains("created")) __score0++;
            if (__jsonProps.Contains("payload")) __score0++;
            if (__jsonProps.Contains("payload.created")) __score0++;
            if (__jsonProps.Contains("payload.date")) __score0++;
            if (__jsonProps.Contains("payload.deploymentId")) __score0++;
            if (__jsonProps.Contains("payload.id")) __score0++;
            if (__jsonProps.Contains("payload.info")) __score0++;
            if (__jsonProps.Contains("payload.proxy")) __score0++;
            if (__jsonProps.Contains("payload.requestId")) __score0++;
            if (__jsonProps.Contains("payload.serial")) __score0++;
            if (__jsonProps.Contains("payload.statusCode")) __score0++;
            if (__jsonProps.Contains("payload.text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("created")) __score1++;
            if (__jsonProps.Contains("date")) __score1++;
            if (__jsonProps.Contains("deploymentId")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("info")) __score1++;
            if (__jsonProps.Contains("info.entrypoint")) __score1++;
            if (__jsonProps.Contains("info.name")) __score1++;
            if (__jsonProps.Contains("info.path")) __score1++;
            if (__jsonProps.Contains("info.readyState")) __score1++;
            if (__jsonProps.Contains("info.serviceName")) __score1++;
            if (__jsonProps.Contains("info.step")) __score1++;
            if (__jsonProps.Contains("info.type")) __score1++;
            if (__jsonProps.Contains("level")) __score1++;
            if (__jsonProps.Contains("serial")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Vercel.AutoSDKSharedcf426121243a64beVariant1? autoSDKSharedcf426121243a64beVariant1 = default;
            global::Vercel.AutoSDKSharedcf426121243a64beVariant2? autoSDKSharedcf426121243a64beVariant2 = default;
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d? sharedbd3f01cc8f6abd3d = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedcf426121243a64beVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant1).Name}");
                        autoSDKSharedcf426121243a64beVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedcf426121243a64beVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant2).Name}");
                        autoSDKSharedcf426121243a64beVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d).Name}");
                        sharedbd3f01cc8f6abd3d = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (autoSDKSharedcf426121243a64beVariant1 == null && autoSDKSharedcf426121243a64beVariant2 == null && sharedbd3f01cc8f6abd3d == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedcf426121243a64beVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant1).Name}");
                    autoSDKSharedcf426121243a64beVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (autoSDKSharedcf426121243a64beVariant1 == null && autoSDKSharedcf426121243a64beVariant2 == null && sharedbd3f01cc8f6abd3d == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedcf426121243a64beVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant2).Name}");
                    autoSDKSharedcf426121243a64beVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (autoSDKSharedcf426121243a64beVariant1 == null && autoSDKSharedcf426121243a64beVariant2 == null && sharedbd3f01cc8f6abd3d == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d).Name}");
                    sharedbd3f01cc8f6abd3d = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Vercel.AutoSDKSharedcf426121243a64be(
                autoSDKSharedcf426121243a64beVariant1,

                autoSDKSharedcf426121243a64beVariant2,

                sharedbd3f01cc8f6abd3d
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedcf426121243a64be value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKSharedcf426121243a64beVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedcf426121243a64beVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKSharedcf426121243a64beVariant1(), typeInfo);
            }
            else if (value.IsAutoSDKSharedcf426121243a64beVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedcf426121243a64beVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedcf426121243a64beVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKSharedcf426121243a64beVariant2(), typeInfo);
            }
            else if (value.IsSharedbd3f01cc8f6abd3d)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSharedbd3f01cc8f6abd3d(), typeInfo);
            }
        }
    }
}