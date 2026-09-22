#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedf1f589ae3ca84945JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedf1f589ae3ca84945>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedf1f589ae3ca84945 Read(
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
            if (__jsonProps.Contains("user")) __score0++;
            if (__jsonProps.Contains("user.id")) __score0++;
            if (__jsonProps.Contains("via")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("app")) __score1++;
            if (__jsonProps.Contains("app.clientId")) __score1++;
            if (__jsonProps.Contains("app.id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("integration")) __score2++;
            if (__jsonProps.Contains("integration.configurationId")) __score2++;
            if (__jsonProps.Contains("integration.integrationId")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1? autoSDKSharedf1f589ae3ca84945Variant1 = default;
            global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2? autoSDKSharedf1f589ae3ca84945Variant2 = default;
            global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3? autoSDKSharedf1f589ae3ca84945Variant3 = default;
            global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4? autoSDKSharedf1f589ae3ca84945Variant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1).Name}");
                        autoSDKSharedf1f589ae3ca84945Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2).Name}");
                        autoSDKSharedf1f589ae3ca84945Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3).Name}");
                        autoSDKSharedf1f589ae3ca84945Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4).Name}");
                        autoSDKSharedf1f589ae3ca84945Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKSharedf1f589ae3ca84945Variant1 == null && autoSDKSharedf1f589ae3ca84945Variant2 == null && autoSDKSharedf1f589ae3ca84945Variant3 == null && autoSDKSharedf1f589ae3ca84945Variant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1).Name}");
                    autoSDKSharedf1f589ae3ca84945Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedf1f589ae3ca84945Variant1 == null && autoSDKSharedf1f589ae3ca84945Variant2 == null && autoSDKSharedf1f589ae3ca84945Variant3 == null && autoSDKSharedf1f589ae3ca84945Variant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2).Name}");
                    autoSDKSharedf1f589ae3ca84945Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedf1f589ae3ca84945Variant1 == null && autoSDKSharedf1f589ae3ca84945Variant2 == null && autoSDKSharedf1f589ae3ca84945Variant3 == null && autoSDKSharedf1f589ae3ca84945Variant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3).Name}");
                    autoSDKSharedf1f589ae3ca84945Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedf1f589ae3ca84945Variant1 == null && autoSDKSharedf1f589ae3ca84945Variant2 == null && autoSDKSharedf1f589ae3ca84945Variant3 == null && autoSDKSharedf1f589ae3ca84945Variant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4).Name}");
                    autoSDKSharedf1f589ae3ca84945Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKSharedf1f589ae3ca84945(
                autoSDKSharedf1f589ae3ca84945Variant1,

                autoSDKSharedf1f589ae3ca84945Variant2,

                autoSDKSharedf1f589ae3ca84945Variant3,

                autoSDKSharedf1f589ae3ca84945Variant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedf1f589ae3ca84945 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKSharedf1f589ae3ca84945Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedf1f589ae3ca84945Variant1!, typeInfo);
            }
            else if (value.IsAutoSDKSharedf1f589ae3ca84945Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedf1f589ae3ca84945Variant2!, typeInfo);
            }
            else if (value.IsAutoSDKSharedf1f589ae3ca84945Variant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedf1f589ae3ca84945Variant3!, typeInfo);
            }
            else if (value.IsAutoSDKSharedf1f589ae3ca84945Variant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedf1f589ae3ca84945Variant4!, typeInfo);
            }
        }
    }
}