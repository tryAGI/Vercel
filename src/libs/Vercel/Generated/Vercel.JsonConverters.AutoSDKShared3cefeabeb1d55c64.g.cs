#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared3cefeabeb1d55c64JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared3cefeabeb1d55c64>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared3cefeabeb1d55c64 Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>), options);
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

            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>? shared6a1866dc1efffce0 = default;
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>? autoSDKShared3cefeabeb1d55c64Variant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>).Name}");
                        shared6a1866dc1efffce0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>).Name}");
                        autoSDKShared3cefeabeb1d55c64Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shared6a1866dc1efffce0 == null && autoSDKShared3cefeabeb1d55c64Variant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>).Name}");
                    shared6a1866dc1efffce0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (shared6a1866dc1efffce0 == null && autoSDKShared3cefeabeb1d55c64Variant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>).Name}");
                    autoSDKShared3cefeabeb1d55c64Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared3cefeabeb1d55c64(
                shared6a1866dc1efffce0,

                autoSDKShared3cefeabeb1d55c64Variant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared3cefeabeb1d55c64 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShared6a1866dc1efffce0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared6a1866dc1efffce0!, typeInfo);
            }
            else if (value.IsAutoSDKShared3cefeabeb1d55c64Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared3cefeabeb1d55c64Variant2!, typeInfo);
            }
        }
    }
}