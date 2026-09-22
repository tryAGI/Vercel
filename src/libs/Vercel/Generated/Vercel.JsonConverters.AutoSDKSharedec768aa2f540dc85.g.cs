#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedec768aa2f540dc85JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedec768aa2f540dc85>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedec768aa2f540dc85 Read(
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
            if (__jsonProps.Contains("caseSensitive")) __score0++;
            if (__jsonProps.Contains("check")) __score0++;
            if (__jsonProps.Contains("continue")) __score0++;
            if (__jsonProps.Contains("dest")) __score0++;
            if (__jsonProps.Contains("destination")) __score0++;
            if (__jsonProps.Contains("env")) __score0++;
            if (__jsonProps.Contains("has")) __score0++;
            if (__jsonProps.Contains("headers")) __score0++;
            if (__jsonProps.Contains("important")) __score0++;
            if (__jsonProps.Contains("locale")) __score0++;
            if (__jsonProps.Contains("locale.cookie")) __score0++;
            if (__jsonProps.Contains("locale.redirect")) __score0++;
            if (__jsonProps.Contains("methods")) __score0++;
            if (__jsonProps.Contains("middleware")) __score0++;
            if (__jsonProps.Contains("middlewarePath")) __score0++;
            if (__jsonProps.Contains("middlewareRawSrc")) __score0++;
            if (__jsonProps.Contains("missing")) __score0++;
            if (__jsonProps.Contains("mitigate")) __score0++;
            if (__jsonProps.Contains("mitigate.action")) __score0++;
            if (__jsonProps.Contains("override")) __score0++;
            if (__jsonProps.Contains("respectOriginCacheControl")) __score0++;
            if (__jsonProps.Contains("source")) __score0++;
            if (__jsonProps.Contains("src")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("statusCode")) __score0++;
            if (__jsonProps.Contains("transforms")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("dest")) __score1++;
            if (__jsonProps.Contains("handle")) __score1++;
            if (__jsonProps.Contains("src")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vercel.AutoSDKShared5f73cd821829ef28? shared5f73cd821829ef28 = default;
            global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2? autoSDKSharedec768aa2f540dc85Variant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared5f73cd821829ef28), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared5f73cd821829ef28> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared5f73cd821829ef28).Name}");
                        shared5f73cd821829ef28 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2).Name}");
                        autoSDKSharedec768aa2f540dc85Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shared5f73cd821829ef28 == null && autoSDKSharedec768aa2f540dc85Variant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared5f73cd821829ef28), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared5f73cd821829ef28> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared5f73cd821829ef28).Name}");
                    shared5f73cd821829ef28 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (shared5f73cd821829ef28 == null && autoSDKSharedec768aa2f540dc85Variant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2).Name}");
                    autoSDKSharedec768aa2f540dc85Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKSharedec768aa2f540dc85(
                shared5f73cd821829ef28,

                autoSDKSharedec768aa2f540dc85Variant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedec768aa2f540dc85 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShared5f73cd821829ef28)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared5f73cd821829ef28), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared5f73cd821829ef28?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared5f73cd821829ef28).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared5f73cd821829ef28!, typeInfo);
            }
            else if (value.IsAutoSDKSharedec768aa2f540dc85Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedec768aa2f540dc85Variant2!, typeInfo);
            }
        }
    }
}