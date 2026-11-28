#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared501a59b9a4a852f0JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared501a59b9a4a852f0>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared501a59b9a4a852f0 Read(
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
            if (__jsonProps.Contains("deliveryStats.totalFailedDeliveries")) __score0++;
            if (__jsonProps.Contains("deliveryStats.totalRetriedDeliveries")) __score0++;
            if (__jsonProps.Contains("deliveryStats.totalSuccessfulDeliveries")) __score0++;
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
            if (__jsonProps.Contains("deliveryStats.totalFailedDeliveries")) __score1++;
            if (__jsonProps.Contains("deliveryStats.totalRetriedDeliveries")) __score1++;
            if (__jsonProps.Contains("deliveryStats.totalSuccessfulDeliveries")) __score1++;
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

            global::Vercel.AutoSDKShareda3e211e8bee7aaa5? shareda3e211e8bee7aaa5 = default;
            global::Vercel.AutoSDKShared2b02cf1378da97a7? shared2b02cf1378da97a7 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda3e211e8bee7aaa5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda3e211e8bee7aaa5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda3e211e8bee7aaa5).Name}");
                        shareda3e211e8bee7aaa5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared2b02cf1378da97a7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared2b02cf1378da97a7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared2b02cf1378da97a7).Name}");
                        shared2b02cf1378da97a7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (shareda3e211e8bee7aaa5 == null && shared2b02cf1378da97a7 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda3e211e8bee7aaa5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda3e211e8bee7aaa5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda3e211e8bee7aaa5).Name}");
                    shareda3e211e8bee7aaa5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (shareda3e211e8bee7aaa5 == null && shared2b02cf1378da97a7 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared2b02cf1378da97a7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared2b02cf1378da97a7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared2b02cf1378da97a7).Name}");
                    shared2b02cf1378da97a7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Vercel.AutoSDKShared501a59b9a4a852f0(
                shareda3e211e8bee7aaa5,

                shared2b02cf1378da97a7
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared501a59b9a4a852f0 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShareda3e211e8bee7aaa5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda3e211e8bee7aaa5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda3e211e8bee7aaa5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda3e211e8bee7aaa5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShareda3e211e8bee7aaa5(), typeInfo);
            }
            else if (value.IsShared2b02cf1378da97a7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared2b02cf1378da97a7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared2b02cf1378da97a7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared2b02cf1378da97a7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShared2b02cf1378da97a7(), typeInfo);
            }
        }
    }
}