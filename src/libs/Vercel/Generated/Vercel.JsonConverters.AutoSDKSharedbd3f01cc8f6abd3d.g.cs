#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedbd3f01cc8f6abd3dJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d Read(
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
            if (__jsonProps.Contains("alias")) __score2++;
            if (__jsonProps.Contains("aliasError")) __score2++;
            if (__jsonProps.Contains("aliasError.code")) __score2++;
            if (__jsonProps.Contains("aliasError.message")) __score2++;
            if (__jsonProps.Contains("aliasWarning")) __score2++;
            if (__jsonProps.Contains("aliasWarning.action")) __score2++;
            if (__jsonProps.Contains("aliasWarning.code")) __score2++;
            if (__jsonProps.Contains("aliasWarning.link")) __score2++;
            if (__jsonProps.Contains("aliasWarning.message")) __score2++;
            if (__jsonProps.Contains("date")) __score2++;
            if (__jsonProps.Contains("deploymentId")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1? autoSDKSharedbd3f01cc8f6abd3dVariant1 = default;
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2? autoSDKSharedbd3f01cc8f6abd3dVariant2 = default;
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3? autoSDKSharedbd3f01cc8f6abd3dVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1).Name}");
                        autoSDKSharedbd3f01cc8f6abd3dVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2).Name}");
                        autoSDKSharedbd3f01cc8f6abd3dVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3).Name}");
                        autoSDKSharedbd3f01cc8f6abd3dVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKSharedbd3f01cc8f6abd3dVariant1 == null && autoSDKSharedbd3f01cc8f6abd3dVariant2 == null && autoSDKSharedbd3f01cc8f6abd3dVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1).Name}");
                    autoSDKSharedbd3f01cc8f6abd3dVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedbd3f01cc8f6abd3dVariant1 == null && autoSDKSharedbd3f01cc8f6abd3dVariant2 == null && autoSDKSharedbd3f01cc8f6abd3dVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2).Name}");
                    autoSDKSharedbd3f01cc8f6abd3dVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedbd3f01cc8f6abd3dVariant1 == null && autoSDKSharedbd3f01cc8f6abd3dVariant2 == null && autoSDKSharedbd3f01cc8f6abd3dVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3).Name}");
                    autoSDKSharedbd3f01cc8f6abd3dVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d(
                autoSDKSharedbd3f01cc8f6abd3dVariant1,

                autoSDKSharedbd3f01cc8f6abd3dVariant2,

                autoSDKSharedbd3f01cc8f6abd3dVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3d value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKSharedbd3f01cc8f6abd3dVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedbd3f01cc8f6abd3dVariant1!, typeInfo);
            }
            else if (value.IsAutoSDKSharedbd3f01cc8f6abd3dVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedbd3f01cc8f6abd3dVariant2!, typeInfo);
            }
            else if (value.IsAutoSDKSharedbd3f01cc8f6abd3dVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedbd3f01cc8f6abd3dVariant3!, typeInfo);
            }
        }
    }
}