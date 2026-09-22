#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared44edaec6364aec89JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared44edaec6364aec89>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared44edaec6364aec89 Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("variantId")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("base")) __score1++;
            if (__jsonProps.Contains("base.attribute")) __score1++;
            if (__jsonProps.Contains("base.kind")) __score1++;
            if (__jsonProps.Contains("base.type")) __score1++;
            if (__jsonProps.Contains("defaultVariantId")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("weights")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("base")) __score2++;
            if (__jsonProps.Contains("base.attribute")) __score2++;
            if (__jsonProps.Contains("base.kind")) __score2++;
            if (__jsonProps.Contains("base.type")) __score2++;
            if (__jsonProps.Contains("defaultVariantId")) __score2++;
            if (__jsonProps.Contains("rollFromVariantId")) __score2++;
            if (__jsonProps.Contains("rollToVariantId")) __score2++;
            if (__jsonProps.Contains("slots")) __score2++;
            if (__jsonProps.Contains("startTimestamp")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Vercel.AutoSDKShared44edaec6364aec89Variant1? autoSDKShared44edaec6364aec89Variant1 = default;
            global::Vercel.AutoSDKShared44edaec6364aec89Variant2? autoSDKShared44edaec6364aec89Variant2 = default;
            global::Vercel.AutoSDKShared44edaec6364aec89Variant3? autoSDKShared44edaec6364aec89Variant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared44edaec6364aec89Variant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant1).Name}");
                        autoSDKShared44edaec6364aec89Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared44edaec6364aec89Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant2).Name}");
                        autoSDKShared44edaec6364aec89Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared44edaec6364aec89Variant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant3).Name}");
                        autoSDKShared44edaec6364aec89Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKShared44edaec6364aec89Variant1 == null && autoSDKShared44edaec6364aec89Variant2 == null && autoSDKShared44edaec6364aec89Variant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared44edaec6364aec89Variant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant1).Name}");
                    autoSDKShared44edaec6364aec89Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared44edaec6364aec89Variant1 == null && autoSDKShared44edaec6364aec89Variant2 == null && autoSDKShared44edaec6364aec89Variant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared44edaec6364aec89Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant2).Name}");
                    autoSDKShared44edaec6364aec89Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared44edaec6364aec89Variant1 == null && autoSDKShared44edaec6364aec89Variant2 == null && autoSDKShared44edaec6364aec89Variant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared44edaec6364aec89Variant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant3).Name}");
                    autoSDKShared44edaec6364aec89Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared44edaec6364aec89(
                autoSDKShared44edaec6364aec89Variant1,

                autoSDKShared44edaec6364aec89Variant2,

                autoSDKShared44edaec6364aec89Variant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared44edaec6364aec89 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKShared44edaec6364aec89Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared44edaec6364aec89Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared44edaec6364aec89Variant1!, typeInfo);
            }
            else if (value.IsAutoSDKShared44edaec6364aec89Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared44edaec6364aec89Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared44edaec6364aec89Variant2!, typeInfo);
            }
            else if (value.IsAutoSDKShared44edaec6364aec89Variant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared44edaec6364aec89Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared44edaec6364aec89Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared44edaec6364aec89Variant3!, typeInfo);
            }
        }
    }
}