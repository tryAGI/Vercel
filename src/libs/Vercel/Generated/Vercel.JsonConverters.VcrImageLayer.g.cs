#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class VcrImageLayerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.VcrImageLayer>
    {
        /// <inheritdoc />
        public override global::Vercel.VcrImageLayer Read(
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
            if (__jsonProps.Contains("baseImage")) __score0++;
            if (__jsonProps.Contains("collapsedDigests")) __score0++;
            if (__jsonProps.Contains("collapsedLayerCount")) __score0++;
            if (__jsonProps.Contains("createdBy")) __score0++;
            if (__jsonProps.Contains("digest")) __score0++;
            if (__jsonProps.Contains("operation")) __score0++;
            if (__jsonProps.Contains("sizeBytes")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("command")) __score1++;
            if (__jsonProps.Contains("createdBy")) __score1++;
            if (__jsonProps.Contains("digest")) __score1++;
            if (__jsonProps.Contains("operation")) __score1++;
            if (__jsonProps.Contains("sizeBytes")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("createdBy")) __score2++;
            if (__jsonProps.Contains("digest")) __score2++;
            if (__jsonProps.Contains("env")) __score2++;
            if (__jsonProps.Contains("operation")) __score2++;
            if (__jsonProps.Contains("sizeBytes")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("createdBy")) __score3++;
            if (__jsonProps.Contains("digest")) __score3++;
            if (__jsonProps.Contains("operation")) __score3++;
            if (__jsonProps.Contains("sizeBytes")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vercel.VcrImageLayerVariant1? vcrImageLayerVariant1 = default;
            global::Vercel.VcrImageLayerVariant2? vcrImageLayerVariant2 = default;
            global::Vercel.VcrImageLayerVariant3? vcrImageLayerVariant3 = default;
            global::Vercel.VcrImageLayerVariant4? vcrImageLayerVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant1).Name}");
                        vcrImageLayerVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant2).Name}");
                        vcrImageLayerVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant3).Name}");
                        vcrImageLayerVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant4).Name}");
                        vcrImageLayerVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (vcrImageLayerVariant1 == null && vcrImageLayerVariant2 == null && vcrImageLayerVariant3 == null && vcrImageLayerVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant1).Name}");
                    vcrImageLayerVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (vcrImageLayerVariant1 == null && vcrImageLayerVariant2 == null && vcrImageLayerVariant3 == null && vcrImageLayerVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant2).Name}");
                    vcrImageLayerVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (vcrImageLayerVariant1 == null && vcrImageLayerVariant2 == null && vcrImageLayerVariant3 == null && vcrImageLayerVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant3).Name}");
                    vcrImageLayerVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (vcrImageLayerVariant1 == null && vcrImageLayerVariant2 == null && vcrImageLayerVariant3 == null && vcrImageLayerVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant4).Name}");
                    vcrImageLayerVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.VcrImageLayer(
                vcrImageLayerVariant1,

                vcrImageLayerVariant2,

                vcrImageLayerVariant3,

                vcrImageLayerVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.VcrImageLayer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVcrImageLayerVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VcrImageLayerVariant1!, typeInfo);
            }
            else if (value.IsVcrImageLayerVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VcrImageLayerVariant2!, typeInfo);
            }
            else if (value.IsVcrImageLayerVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VcrImageLayerVariant3!, typeInfo);
            }
            else if (value.IsVcrImageLayerVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.VcrImageLayerVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.VcrImageLayerVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.VcrImageLayerVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VcrImageLayerVariant4!, typeInfo);
            }
        }
    }
}