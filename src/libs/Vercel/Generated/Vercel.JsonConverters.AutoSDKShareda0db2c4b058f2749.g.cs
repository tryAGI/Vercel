#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShareda0db2c4b058f2749JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShareda0db2c4b058f2749>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShareda0db2c4b058f2749 Read(
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
            if (__jsonProps.Contains("consumer")) __score0++;
            if (__jsonProps.Contains("initialDelaySeconds")) __score0++;
            if (__jsonProps.Contains("maxConcurrency")) __score0++;
            if (__jsonProps.Contains("maxDeliveries")) __score0++;
            if (__jsonProps.Contains("retryAfterSeconds")) __score0++;
            if (__jsonProps.Contains("topic")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("initialDelaySeconds")) __score1++;
            if (__jsonProps.Contains("maxConcurrency")) __score1++;
            if (__jsonProps.Contains("maxDeliveries")) __score1++;
            if (__jsonProps.Contains("retryAfterSeconds")) __score1++;
            if (__jsonProps.Contains("topic")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1? autoSDKShareda0db2c4b058f2749Variant1 = default;
            global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2? autoSDKShareda0db2c4b058f2749Variant2 = default;
            global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3? autoSDKShareda0db2c4b058f2749Variant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1).Name}");
                        autoSDKShareda0db2c4b058f2749Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2).Name}");
                        autoSDKShareda0db2c4b058f2749Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3).Name}");
                        autoSDKShareda0db2c4b058f2749Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKShareda0db2c4b058f2749Variant1 == null && autoSDKShareda0db2c4b058f2749Variant2 == null && autoSDKShareda0db2c4b058f2749Variant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1).Name}");
                    autoSDKShareda0db2c4b058f2749Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShareda0db2c4b058f2749Variant1 == null && autoSDKShareda0db2c4b058f2749Variant2 == null && autoSDKShareda0db2c4b058f2749Variant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2).Name}");
                    autoSDKShareda0db2c4b058f2749Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShareda0db2c4b058f2749Variant1 == null && autoSDKShareda0db2c4b058f2749Variant2 == null && autoSDKShareda0db2c4b058f2749Variant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3).Name}");
                    autoSDKShareda0db2c4b058f2749Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShareda0db2c4b058f2749(
                autoSDKShareda0db2c4b058f2749Variant1,

                autoSDKShareda0db2c4b058f2749Variant2,

                autoSDKShareda0db2c4b058f2749Variant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShareda0db2c4b058f2749 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKShareda0db2c4b058f2749Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShareda0db2c4b058f2749Variant1!, typeInfo);
            }
            else if (value.IsAutoSDKShareda0db2c4b058f2749Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShareda0db2c4b058f2749Variant2!, typeInfo);
            }
            else if (value.IsAutoSDKShareda0db2c4b058f2749Variant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShareda0db2c4b058f2749Variant3!, typeInfo);
            }
        }
    }
}