#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared3e4933d1b69c5ad0JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared3e4933d1b69c5ad0>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared3e4933d1b69c5ad0 Read(
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

            global::Vercel.AutoSDKShared0feeac66613930d1? shared0feeac66613930d1 = default;
            global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2? autoSDKShared3e4933d1b69c5ad0Variant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0feeac66613930d1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0feeac66613930d1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0feeac66613930d1).Name}");
                        shared0feeac66613930d1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2).Name}");
                        autoSDKShared3e4933d1b69c5ad0Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shared0feeac66613930d1 == null && autoSDKShared3e4933d1b69c5ad0Variant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0feeac66613930d1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0feeac66613930d1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0feeac66613930d1).Name}");
                    shared0feeac66613930d1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (shared0feeac66613930d1 == null && autoSDKShared3e4933d1b69c5ad0Variant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2).Name}");
                    autoSDKShared3e4933d1b69c5ad0Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared3e4933d1b69c5ad0(
                shared0feeac66613930d1,

                autoSDKShared3e4933d1b69c5ad0Variant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared3e4933d1b69c5ad0 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShared0feeac66613930d1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0feeac66613930d1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0feeac66613930d1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0feeac66613930d1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared0feeac66613930d1!, typeInfo);
            }
            else if (value.IsAutoSDKShared3e4933d1b69c5ad0Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared3e4933d1b69c5ad0Variant2!, typeInfo);
            }
        }
    }
}