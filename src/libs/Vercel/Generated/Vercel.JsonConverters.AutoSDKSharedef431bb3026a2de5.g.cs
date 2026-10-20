#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedef431bb3026a2de5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedef431bb3026a2de5>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedef431bb3026a2de5 Read(
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
            if (__jsonProps.Contains("blocks")) __score0++;
            if (__jsonProps.Contains("checkId")) __score0++;
            if (__jsonProps.Contains("completedAt")) __score0++;
            if (__jsonProps.Contains("conclusion")) __score0++;
            if (__jsonProps.Contains("conclusionText")) __score0++;
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("deploymentId")) __score0++;
            if (__jsonProps.Contains("expectationRef")) __score0++;
            if (__jsonProps.Contains("expectationRef.invocationAttempt")) __score0++;
            if (__jsonProps.Contains("expectationRef.invocationId")) __score0++;
            if (__jsonProps.Contains("expectationRef.jobDefinitionId")) __score0++;
            if (__jsonProps.Contains("expectationRef.jobRunAttempt")) __score0++;
            if (__jsonProps.Contains("expectationRevision")) __score0++;
            if (__jsonProps.Contains("externalId")) __score0++;
            if (__jsonProps.Contains("externalUrl")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("output")) __score0++;
            if (__jsonProps.Contains("ownerId")) __score0++;
            if (__jsonProps.Contains("projectId")) __score0++;
            if (__jsonProps.Contains("requires")) __score0++;
            if (__jsonProps.Contains("source")) __score0++;
            if (__jsonProps.Contains("startedAt")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("targets")) __score0++;
            if (__jsonProps.Contains("taskSummary")) __score0++;
            if (__jsonProps.Contains("taskSummary.failed")) __score0++;
            if (__jsonProps.Contains("taskSummary.pending")) __score0++;
            if (__jsonProps.Contains("taskSummary.succeeded")) __score0++;
            if (__jsonProps.Contains("taskSummary.total")) __score0++;
            if (__jsonProps.Contains("timeout")) __score0++;
            if (__jsonProps.Contains("updatedAt")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("blocks")) __score1++;
            if (__jsonProps.Contains("completedAt")) __score1++;
            if (__jsonProps.Contains("conclusion")) __score1++;
            if (__jsonProps.Contains("conclusionText")) __score1++;
            if (__jsonProps.Contains("createdAt")) __score1++;
            if (__jsonProps.Contains("deploymentId")) __score1++;
            if (__jsonProps.Contains("expectationRef")) __score1++;
            if (__jsonProps.Contains("expectationRef.invocationAttempt")) __score1++;
            if (__jsonProps.Contains("expectationRef.invocationId")) __score1++;
            if (__jsonProps.Contains("expectationRef.jobDefinitionId")) __score1++;
            if (__jsonProps.Contains("expectationRef.jobRunAttempt")) __score1++;
            if (__jsonProps.Contains("expectationRevision")) __score1++;
            if (__jsonProps.Contains("externalId")) __score1++;
            if (__jsonProps.Contains("externalUrl")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("output")) __score1++;
            if (__jsonProps.Contains("ownerId")) __score1++;
            if (__jsonProps.Contains("projectId")) __score1++;
            if (__jsonProps.Contains("requires")) __score1++;
            if (__jsonProps.Contains("source")) __score1++;
            if (__jsonProps.Contains("startedAt")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("targets")) __score1++;
            if (__jsonProps.Contains("taskSummary")) __score1++;
            if (__jsonProps.Contains("taskSummary.failed")) __score1++;
            if (__jsonProps.Contains("taskSummary.pending")) __score1++;
            if (__jsonProps.Contains("taskSummary.succeeded")) __score1++;
            if (__jsonProps.Contains("taskSummary.total")) __score1++;
            if (__jsonProps.Contains("timeout")) __score1++;
            if (__jsonProps.Contains("updatedAt")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vercel.AutoSDKSharede3c00aaf9d3a15be? sharede3c00aaf9d3a15be = default;
            global::Vercel.AutoSDKShareddb8a6ccf5b64d660? shareddb8a6ccf5b64d660 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede3c00aaf9d3a15be), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede3c00aaf9d3a15be> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede3c00aaf9d3a15be).Name}");
                        sharede3c00aaf9d3a15be = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareddb8a6ccf5b64d660), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareddb8a6ccf5b64d660> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareddb8a6ccf5b64d660).Name}");
                        shareddb8a6ccf5b64d660 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (sharede3c00aaf9d3a15be == null && shareddb8a6ccf5b64d660 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede3c00aaf9d3a15be), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede3c00aaf9d3a15be> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede3c00aaf9d3a15be).Name}");
                    sharede3c00aaf9d3a15be = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (sharede3c00aaf9d3a15be == null && shareddb8a6ccf5b64d660 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareddb8a6ccf5b64d660), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareddb8a6ccf5b64d660> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareddb8a6ccf5b64d660).Name}");
                    shareddb8a6ccf5b64d660 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Vercel.AutoSDKSharedef431bb3026a2de5(
                sharede3c00aaf9d3a15be,

                shareddb8a6ccf5b64d660
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedef431bb3026a2de5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSharede3c00aaf9d3a15be)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede3c00aaf9d3a15be), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede3c00aaf9d3a15be?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede3c00aaf9d3a15be).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSharede3c00aaf9d3a15be(), typeInfo);
            }
            else if (value.IsShareddb8a6ccf5b64d660)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareddb8a6ccf5b64d660), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareddb8a6ccf5b64d660?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareddb8a6ccf5b64d660).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShareddb8a6ccf5b64d660(), typeInfo);
            }
        }
    }
}