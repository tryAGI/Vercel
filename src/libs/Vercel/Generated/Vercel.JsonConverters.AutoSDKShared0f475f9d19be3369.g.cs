#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared0f475f9d19be3369JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared0f475f9d19be3369>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared0f475f9d19be3369 Read(
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
            if (__jsonProps.Contains("action")) __score0++;
            if (__jsonProps.Contains("actor")) __score0++;
            if (__jsonProps.Contains("caseId")) __score0++;
            if (__jsonProps.Contains("comment")) __score0++;
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("ineligibleForAppeal")) __score0++;
            if (__jsonProps.Contains("isCascading")) __score0++;
            if (__jsonProps.Contains("reason")) __score0++;
            if (__jsonProps.Contains("registeredShaBlock")) __score0++;
            if (__jsonProps.Contains("registeredShaBlock.createdAt")) __score0++;
            if (__jsonProps.Contains("registeredShaBlock.createdBy")) __score0++;
            if (__jsonProps.Contains("registeredShaBlock.sha")) __score0++;
            if (__jsonProps.Contains("statusCode")) __score0++;
            if (__jsonProps.Contains("threadId")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("action")) __score1++;
            if (__jsonProps.Contains("actor")) __score1++;
            if (__jsonProps.Contains("caseId")) __score1++;
            if (__jsonProps.Contains("comment")) __score1++;
            if (__jsonProps.Contains("createdAt")) __score1++;
            if (__jsonProps.Contains("ineligibleForAppeal")) __score1++;
            if (__jsonProps.Contains("isCascading")) __score1++;
            if (__jsonProps.Contains("threadId")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("action")) __score2++;
            if (__jsonProps.Contains("actor")) __score2++;
            if (__jsonProps.Contains("caseId")) __score2++;
            if (__jsonProps.Contains("comment")) __score2++;
            if (__jsonProps.Contains("createdAt")) __score2++;
            if (__jsonProps.Contains("ineligibleForAppeal")) __score2++;
            if (__jsonProps.Contains("isCascading")) __score2++;
            if (__jsonProps.Contains("reason")) __score2++;
            if (__jsonProps.Contains("route")) __score2++;
            if (__jsonProps.Contains("threadId")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("actor")) __score3++;
            if (__jsonProps.Contains("caseId")) __score3++;
            if (__jsonProps.Contains("comment")) __score3++;
            if (__jsonProps.Contains("createdAt")) __score3++;
            if (__jsonProps.Contains("ineligibleForAppeal")) __score3++;
            if (__jsonProps.Contains("isCascading")) __score3++;
            if (__jsonProps.Contains("route")) __score3++;
            if (__jsonProps.Contains("statusCode")) __score3++;
            if (__jsonProps.Contains("threadId")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vercel.AutoSDKShared0f475f9d19be3369Variant1? autoSDKShared0f475f9d19be3369Variant1 = default;
            global::Vercel.AutoSDKShared0f475f9d19be3369Variant2? autoSDKShared0f475f9d19be3369Variant2 = default;
            global::Vercel.AutoSDKShared0f475f9d19be3369Variant3? autoSDKShared0f475f9d19be3369Variant3 = default;
            global::Vercel.AutoSDKShared0f475f9d19be3369Variant4? autoSDKShared0f475f9d19be3369Variant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant1).Name}");
                        autoSDKShared0f475f9d19be3369Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant2).Name}");
                        autoSDKShared0f475f9d19be3369Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant3).Name}");
                        autoSDKShared0f475f9d19be3369Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant4).Name}");
                        autoSDKShared0f475f9d19be3369Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKShared0f475f9d19be3369Variant1 == null && autoSDKShared0f475f9d19be3369Variant2 == null && autoSDKShared0f475f9d19be3369Variant3 == null && autoSDKShared0f475f9d19be3369Variant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant1).Name}");
                    autoSDKShared0f475f9d19be3369Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0f475f9d19be3369Variant1 == null && autoSDKShared0f475f9d19be3369Variant2 == null && autoSDKShared0f475f9d19be3369Variant3 == null && autoSDKShared0f475f9d19be3369Variant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant2).Name}");
                    autoSDKShared0f475f9d19be3369Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0f475f9d19be3369Variant1 == null && autoSDKShared0f475f9d19be3369Variant2 == null && autoSDKShared0f475f9d19be3369Variant3 == null && autoSDKShared0f475f9d19be3369Variant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant3).Name}");
                    autoSDKShared0f475f9d19be3369Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared0f475f9d19be3369Variant1 == null && autoSDKShared0f475f9d19be3369Variant2 == null && autoSDKShared0f475f9d19be3369Variant3 == null && autoSDKShared0f475f9d19be3369Variant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant4).Name}");
                    autoSDKShared0f475f9d19be3369Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared0f475f9d19be3369(
                autoSDKShared0f475f9d19be3369Variant1,

                autoSDKShared0f475f9d19be3369Variant2,

                autoSDKShared0f475f9d19be3369Variant3,

                autoSDKShared0f475f9d19be3369Variant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared0f475f9d19be3369 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKShared0f475f9d19be3369Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKShared0f475f9d19be3369Variant1(), typeInfo);
            }
            else if (value.IsAutoSDKShared0f475f9d19be3369Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKShared0f475f9d19be3369Variant2(), typeInfo);
            }
            else if (value.IsAutoSDKShared0f475f9d19be3369Variant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKShared0f475f9d19be3369Variant3(), typeInfo);
            }
            else if (value.IsAutoSDKShared0f475f9d19be3369Variant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared0f475f9d19be3369Variant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared0f475f9d19be3369Variant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKShared0f475f9d19be3369Variant4(), typeInfo);
            }
        }
    }
}