#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedaf1cf971744a2ae1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedaf1cf971744a2ae1>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedaf1cf971744a2ae1 Read(
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
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("delivery")) __score0++;
            if (__jsonProps.Contains("deliveryStats")) __score0++;
            if (__jsonProps.Contains("deliveryStats.attempts")) __score0++;
            if (__jsonProps.Contains("deliveryStats.failures")) __score0++;
            if (__jsonProps.Contains("deliveryStats.state")) __score0++;
            if (__jsonProps.Contains("deliveryStats.window")) __score0++;
            if (__jsonProps.Contains("disabledAt")) __score0++;
            if (__jsonProps.Contains("disabledBy")) __score0++;
            if (__jsonProps.Contains("disabledReason")) __score0++;
            if (__jsonProps.Contains("filterV2")) __score0++;
            if (__jsonProps.Contains("filterV2.filter")) __score0++;
            if (__jsonProps.Contains("filterV2.version")) __score0++;
            if (__jsonProps.Contains("firstErrorTimestamp")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("ownerId")) __score0++;
            if (__jsonProps.Contains("projectIds")) __score0++;
            if (__jsonProps.Contains("sampling")) __score0++;
            if (__jsonProps.Contains("schemas")) __score0++;
            if (__jsonProps.Contains("schemas.ai_gateway")) __score0++;
            if (__jsonProps.Contains("schemas.analytics")) __score0++;
            if (__jsonProps.Contains("schemas.audit_log")) __score0++;
            if (__jsonProps.Contains("schemas.connect")) __score0++;
            if (__jsonProps.Contains("schemas.log")) __score0++;
            if (__jsonProps.Contains("schemas.speed_insights")) __score0++;
            if (__jsonProps.Contains("schemas.trace")) __score0++;
            if (__jsonProps.Contains("source")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("teamId")) __score0++;
            if (__jsonProps.Contains("updatedAt")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("createdAt")) __score1++;
            if (__jsonProps.Contains("delivery")) __score1++;
            if (__jsonProps.Contains("deliveryStats")) __score1++;
            if (__jsonProps.Contains("deliveryStats.attempts")) __score1++;
            if (__jsonProps.Contains("deliveryStats.failures")) __score1++;
            if (__jsonProps.Contains("deliveryStats.state")) __score1++;
            if (__jsonProps.Contains("deliveryStats.window")) __score1++;
            if (__jsonProps.Contains("disabledAt")) __score1++;
            if (__jsonProps.Contains("disabledBy")) __score1++;
            if (__jsonProps.Contains("disabledReason")) __score1++;
            if (__jsonProps.Contains("filterV2")) __score1++;
            if (__jsonProps.Contains("filterV2.filter")) __score1++;
            if (__jsonProps.Contains("filterV2.version")) __score1++;
            if (__jsonProps.Contains("firstErrorTimestamp")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("integrationConfigurationUri")) __score1++;
            if (__jsonProps.Contains("integrationIcon")) __score1++;
            if (__jsonProps.Contains("integrationWebsite")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("ownerId")) __score1++;
            if (__jsonProps.Contains("projectAccess")) __score1++;
            if (__jsonProps.Contains("projectIds")) __score1++;
            if (__jsonProps.Contains("sampling")) __score1++;
            if (__jsonProps.Contains("schemas")) __score1++;
            if (__jsonProps.Contains("schemas.ai_gateway")) __score1++;
            if (__jsonProps.Contains("schemas.analytics")) __score1++;
            if (__jsonProps.Contains("schemas.audit_log")) __score1++;
            if (__jsonProps.Contains("schemas.connect")) __score1++;
            if (__jsonProps.Contains("schemas.log")) __score1++;
            if (__jsonProps.Contains("schemas.speed_insights")) __score1++;
            if (__jsonProps.Contains("schemas.trace")) __score1++;
            if (__jsonProps.Contains("source")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("teamId")) __score1++;
            if (__jsonProps.Contains("updatedAt")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vercel.AutoSDKShared90103a1814ebf3a8? shared90103a1814ebf3a8 = default;
            global::Vercel.AutoSDKShared9f8c0585e20078fc? shared9f8c0585e20078fc = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared90103a1814ebf3a8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared90103a1814ebf3a8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared90103a1814ebf3a8).Name}");
                        shared90103a1814ebf3a8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared9f8c0585e20078fc), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared9f8c0585e20078fc> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared9f8c0585e20078fc).Name}");
                        shared9f8c0585e20078fc = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (shared90103a1814ebf3a8 == null && shared9f8c0585e20078fc == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared90103a1814ebf3a8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared90103a1814ebf3a8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared90103a1814ebf3a8).Name}");
                    shared90103a1814ebf3a8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (shared90103a1814ebf3a8 == null && shared9f8c0585e20078fc == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared9f8c0585e20078fc), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared9f8c0585e20078fc> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared9f8c0585e20078fc).Name}");
                    shared9f8c0585e20078fc = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Vercel.AutoSDKSharedaf1cf971744a2ae1(
                shared90103a1814ebf3a8,

                shared9f8c0585e20078fc
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedaf1cf971744a2ae1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShared90103a1814ebf3a8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared90103a1814ebf3a8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared90103a1814ebf3a8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared90103a1814ebf3a8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShared90103a1814ebf3a8(), typeInfo);
            }
            else if (value.IsShared9f8c0585e20078fc)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared9f8c0585e20078fc), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared9f8c0585e20078fc?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared9f8c0585e20078fc).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShared9f8c0585e20078fc(), typeInfo);
            }
        }
    }
}