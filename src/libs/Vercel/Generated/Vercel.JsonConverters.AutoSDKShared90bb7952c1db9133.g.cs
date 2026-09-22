#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared90bb7952c1db9133JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared90bb7952c1db9133>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared90bb7952c1db9133 Read(
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

            global::Vercel.AutoSDKShared9c06dfe8dd59ad6d? shared9c06dfe8dd59ad6d = default;
            global::Vercel.AutoSDKShared383028c008cc4ae0? shared383028c008cc4ae0 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d).Name}");
                        shared9c06dfe8dd59ad6d = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared383028c008cc4ae0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared383028c008cc4ae0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared383028c008cc4ae0).Name}");
                        shared383028c008cc4ae0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shared9c06dfe8dd59ad6d == null && shared383028c008cc4ae0 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d).Name}");
                    shared9c06dfe8dd59ad6d = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (shared9c06dfe8dd59ad6d == null && shared383028c008cc4ae0 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared383028c008cc4ae0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared383028c008cc4ae0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared383028c008cc4ae0).Name}");
                    shared383028c008cc4ae0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared90bb7952c1db9133(
                shared9c06dfe8dd59ad6d,

                shared383028c008cc4ae0
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared90bb7952c1db9133 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShared9c06dfe8dd59ad6d)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared9c06dfe8dd59ad6d!, typeInfo);
            }
            else if (value.IsShared383028c008cc4ae0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared383028c008cc4ae0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared383028c008cc4ae0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared383028c008cc4ae0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared383028c008cc4ae0!, typeInfo);
            }
        }
    }
}