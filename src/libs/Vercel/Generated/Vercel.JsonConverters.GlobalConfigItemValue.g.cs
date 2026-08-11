#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class GlobalConfigItemValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GlobalConfigItemValue>
    {
        /// <inheritdoc />
        public override global::Vercel.GlobalConfigItemValue Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(string), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(double), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(bool), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            string? globalConfigItemValueVariant1 = default;
            double? globalConfigItemValueVariant2 = default;
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>? globalConfigItemValueVariant3 = default;
            global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>? globalConfigItemValueVariant4 = default;
            bool? globalConfigItemValueVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        globalConfigItemValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                        globalConfigItemValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>).Name}");
                        globalConfigItemValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>).Name}");
                        globalConfigItemValueVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(bool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(bool).Name}");
                        globalConfigItemValueVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (globalConfigItemValueVariant1 == null && globalConfigItemValueVariant2 == null && globalConfigItemValueVariant3 == null && globalConfigItemValueVariant4 == null && globalConfigItemValueVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    globalConfigItemValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (globalConfigItemValueVariant1 == null && globalConfigItemValueVariant2 == null && globalConfigItemValueVariant3 == null && globalConfigItemValueVariant4 == null && globalConfigItemValueVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                    globalConfigItemValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (globalConfigItemValueVariant1 == null && globalConfigItemValueVariant2 == null && globalConfigItemValueVariant3 == null && globalConfigItemValueVariant4 == null && globalConfigItemValueVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>).Name}");
                    globalConfigItemValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (globalConfigItemValueVariant1 == null && globalConfigItemValueVariant2 == null && globalConfigItemValueVariant3 == null && globalConfigItemValueVariant4 == null && globalConfigItemValueVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>).Name}");
                    globalConfigItemValueVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (globalConfigItemValueVariant1 == null && globalConfigItemValueVariant2 == null && globalConfigItemValueVariant3 == null && globalConfigItemValueVariant4 == null && globalConfigItemValueVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(bool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(bool).Name}");
                    globalConfigItemValueVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.GlobalConfigItemValue(
                globalConfigItemValueVariant1,

                globalConfigItemValueVariant2,

                globalConfigItemValueVariant3,

                globalConfigItemValueVariant4,

                globalConfigItemValueVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GlobalConfigItemValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGlobalConfigItemValueVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GlobalConfigItemValueVariant1!, typeInfo);
            }
            else if (value.IsGlobalConfigItemValueVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GlobalConfigItemValueVariant2!.Value, typeInfo);
            }
            else if (value.IsGlobalConfigItemValueVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GlobalConfigItemValueVariant3!, typeInfo);
            }
            else if (value.IsGlobalConfigItemValueVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GlobalConfigItemValueVariant4!, typeInfo);
            }
            else if (value.IsGlobalConfigItemValueVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(bool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(bool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GlobalConfigItemValueVariant5!.Value, typeInfo);
            }
        }
    }
}