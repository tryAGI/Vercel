#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared30685e6067cce163JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared30685e6067cce163>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared30685e6067cce163 Read(
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
            if (__jsonProps.Contains("development")) __score0++;
            if (__jsonProps.Contains("development.fallback")) __score0++;
            if (__jsonProps.Contains("development.local")) __score0++;
            if (__jsonProps.Contains("development.task")) __score0++;
            if (__jsonProps.Contains("packageName")) __score0++;
            if (__jsonProps.Contains("projectId")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("assetPrefix")) __score1++;
            if (__jsonProps.Contains("development")) __score1++;
            if (__jsonProps.Contains("development.fallback")) __score1++;
            if (__jsonProps.Contains("development.local")) __score1++;
            if (__jsonProps.Contains("development.task")) __score1++;
            if (__jsonProps.Contains("packageName")) __score1++;
            if (__jsonProps.Contains("projectId")) __score1++;
            if (__jsonProps.Contains("routing")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vercel.AutoSDKShared30685e6067cce163Variant1? autoSDKShared30685e6067cce163Variant1 = default;
            global::Vercel.AutoSDKSharedaffe019c1a64bb83? sharedaffe019c1a64bb83 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared30685e6067cce163Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared30685e6067cce163Variant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared30685e6067cce163Variant1).Name}");
                        autoSDKShared30685e6067cce163Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedaffe019c1a64bb83> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83).Name}");
                        sharedaffe019c1a64bb83 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKShared30685e6067cce163Variant1 == null && sharedaffe019c1a64bb83 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared30685e6067cce163Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared30685e6067cce163Variant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared30685e6067cce163Variant1).Name}");
                    autoSDKShared30685e6067cce163Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared30685e6067cce163Variant1 == null && sharedaffe019c1a64bb83 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedaffe019c1a64bb83> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83).Name}");
                    sharedaffe019c1a64bb83 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared30685e6067cce163(
                autoSDKShared30685e6067cce163Variant1,

                sharedaffe019c1a64bb83
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared30685e6067cce163 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKShared30685e6067cce163Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared30685e6067cce163Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared30685e6067cce163Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared30685e6067cce163Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared30685e6067cce163Variant1!, typeInfo);
            }
            else if (value.IsSharedaffe019c1a64bb83)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedaffe019c1a64bb83?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sharedaffe019c1a64bb83!, typeInfo);
            }
        }
    }
}