#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedcac2d258b36c4083JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedcac2d258b36c4083>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedcac2d258b36c4083 Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<string>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>), options);
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

            global::System.Collections.Generic.IList<string>? autoSDKSharedcac2d258b36c4083Variant1 = default;
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>? sharedad42af066f165baa = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<string>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<string>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<string>).Name}");
                        autoSDKSharedcac2d258b36c4083Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>).Name}");
                        sharedad42af066f165baa = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKSharedcac2d258b36c4083Variant1 == null && sharedad42af066f165baa == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<string>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<string>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<string>).Name}");
                    autoSDKSharedcac2d258b36c4083Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharedcac2d258b36c4083Variant1 == null && sharedad42af066f165baa == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>).Name}");
                    sharedad42af066f165baa = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKSharedcac2d258b36c4083(
                autoSDKSharedcac2d258b36c4083Variant1,

                sharedad42af066f165baa
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedcac2d258b36c4083 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKSharedcac2d258b36c4083Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<string>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<string>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<string>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharedcac2d258b36c4083Variant1!, typeInfo);
            }
            else if (value.IsSharedad42af066f165baa)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sharedad42af066f165baa!, typeInfo);
            }
        }
    }
}