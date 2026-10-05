#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared373105c7a8467265JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared373105c7a8467265>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared373105c7a8467265 Read(
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
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("targets")) __score0++;
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
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("targets")) __score1++;
            if (__jsonProps.Contains("timeout")) __score1++;
            if (__jsonProps.Contains("updatedAt")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vercel.AutoSDKShared87d88207314b07b3? shared87d88207314b07b3 = default;
            global::Vercel.AutoSDKSharedca611ecff4bbfd16? sharedca611ecff4bbfd16 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared87d88207314b07b3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared87d88207314b07b3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared87d88207314b07b3).Name}");
                        shared87d88207314b07b3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedca611ecff4bbfd16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedca611ecff4bbfd16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedca611ecff4bbfd16).Name}");
                        sharedca611ecff4bbfd16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shared87d88207314b07b3 == null && sharedca611ecff4bbfd16 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared87d88207314b07b3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared87d88207314b07b3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared87d88207314b07b3).Name}");
                    shared87d88207314b07b3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (shared87d88207314b07b3 == null && sharedca611ecff4bbfd16 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedca611ecff4bbfd16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedca611ecff4bbfd16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedca611ecff4bbfd16).Name}");
                    sharedca611ecff4bbfd16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared373105c7a8467265(
                shared87d88207314b07b3,

                sharedca611ecff4bbfd16
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared373105c7a8467265 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShared87d88207314b07b3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared87d88207314b07b3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared87d88207314b07b3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared87d88207314b07b3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShared87d88207314b07b3(), typeInfo);
            }
            else if (value.IsSharedca611ecff4bbfd16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedca611ecff4bbfd16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedca611ecff4bbfd16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedca611ecff4bbfd16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSharedca611ecff4bbfd16(), typeInfo);
            }
        }
    }
}