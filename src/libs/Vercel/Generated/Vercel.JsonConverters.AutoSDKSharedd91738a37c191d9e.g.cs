#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedd91738a37c191d9eJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedd91738a37c191d9e>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedd91738a37c191d9e Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>? sharedbb8e91b17b7d885c = default;
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>? sharedc7ea0f9c95e22568 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>).Name}");
                        sharedbb8e91b17b7d885c = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>).Name}");
                        sharedc7ea0f9c95e22568 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (sharedbb8e91b17b7d885c == null && sharedc7ea0f9c95e22568 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>).Name}");
                    sharedbb8e91b17b7d885c = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (sharedbb8e91b17b7d885c == null && sharedc7ea0f9c95e22568 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>).Name}");
                    sharedc7ea0f9c95e22568 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Vercel.AutoSDKSharedd91738a37c191d9e(
                sharedbb8e91b17b7d885c,

                sharedc7ea0f9c95e22568
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedd91738a37c191d9e value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSharedbb8e91b17b7d885c)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared90103a1814ebf3a8>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSharedbb8e91b17b7d885c(), typeInfo);
            }
            else if (value.IsSharedc7ea0f9c95e22568)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9f8c0585e20078fc>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSharedc7ea0f9c95e22568(), typeInfo);
            }
        }
    }
}