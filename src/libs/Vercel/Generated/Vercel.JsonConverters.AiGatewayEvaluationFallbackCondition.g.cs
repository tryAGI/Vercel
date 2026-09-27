#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AiGatewayEvaluationFallbackConditionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AiGatewayEvaluationFallbackCondition>
    {
        /// <inheritdoc />
        public override global::Vercel.AiGatewayEvaluationFallbackCondition Read(
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
            if (__jsonProps.Contains("confidenceBelow")) __score0++;
            if (__jsonProps.Contains("question")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("probabilityBetween")) __score1++;
            if (__jsonProps.Contains("question")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("any")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("all")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("atLeast")) __score4++;
            if (__jsonProps.Contains("atLeast.conditions")) __score4++;
            if (__jsonProps.Contains("atLeast.count")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Vercel.AiGatewayEvaluationFallbackConditionVariant1? aiGatewayEvaluationFallbackConditionVariant1 = default;
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant2? aiGatewayEvaluationFallbackConditionVariant2 = default;
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant3? aiGatewayEvaluationFallbackConditionVariant3 = default;
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant4? aiGatewayEvaluationFallbackConditionVariant4 = default;
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant5? aiGatewayEvaluationFallbackConditionVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1).Name}");
                        aiGatewayEvaluationFallbackConditionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2).Name}");
                        aiGatewayEvaluationFallbackConditionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3).Name}");
                        aiGatewayEvaluationFallbackConditionVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4).Name}");
                        aiGatewayEvaluationFallbackConditionVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5).Name}");
                        aiGatewayEvaluationFallbackConditionVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (aiGatewayEvaluationFallbackConditionVariant1 == null && aiGatewayEvaluationFallbackConditionVariant2 == null && aiGatewayEvaluationFallbackConditionVariant3 == null && aiGatewayEvaluationFallbackConditionVariant4 == null && aiGatewayEvaluationFallbackConditionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1).Name}");
                    aiGatewayEvaluationFallbackConditionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (aiGatewayEvaluationFallbackConditionVariant1 == null && aiGatewayEvaluationFallbackConditionVariant2 == null && aiGatewayEvaluationFallbackConditionVariant3 == null && aiGatewayEvaluationFallbackConditionVariant4 == null && aiGatewayEvaluationFallbackConditionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2).Name}");
                    aiGatewayEvaluationFallbackConditionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (aiGatewayEvaluationFallbackConditionVariant1 == null && aiGatewayEvaluationFallbackConditionVariant2 == null && aiGatewayEvaluationFallbackConditionVariant3 == null && aiGatewayEvaluationFallbackConditionVariant4 == null && aiGatewayEvaluationFallbackConditionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3).Name}");
                    aiGatewayEvaluationFallbackConditionVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (aiGatewayEvaluationFallbackConditionVariant1 == null && aiGatewayEvaluationFallbackConditionVariant2 == null && aiGatewayEvaluationFallbackConditionVariant3 == null && aiGatewayEvaluationFallbackConditionVariant4 == null && aiGatewayEvaluationFallbackConditionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4).Name}");
                    aiGatewayEvaluationFallbackConditionVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (aiGatewayEvaluationFallbackConditionVariant1 == null && aiGatewayEvaluationFallbackConditionVariant2 == null && aiGatewayEvaluationFallbackConditionVariant3 == null && aiGatewayEvaluationFallbackConditionVariant4 == null && aiGatewayEvaluationFallbackConditionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5).Name}");
                    aiGatewayEvaluationFallbackConditionVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AiGatewayEvaluationFallbackCondition(
                aiGatewayEvaluationFallbackConditionVariant1,

                aiGatewayEvaluationFallbackConditionVariant2,

                aiGatewayEvaluationFallbackConditionVariant3,

                aiGatewayEvaluationFallbackConditionVariant4,

                aiGatewayEvaluationFallbackConditionVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AiGatewayEvaluationFallbackCondition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAiGatewayEvaluationFallbackConditionVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AiGatewayEvaluationFallbackConditionVariant1!, typeInfo);
            }
            else if (value.IsAiGatewayEvaluationFallbackConditionVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AiGatewayEvaluationFallbackConditionVariant2!, typeInfo);
            }
            else if (value.IsAiGatewayEvaluationFallbackConditionVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AiGatewayEvaluationFallbackConditionVariant3!, typeInfo);
            }
            else if (value.IsAiGatewayEvaluationFallbackConditionVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AiGatewayEvaluationFallbackConditionVariant4!, typeInfo);
            }
            else if (value.IsAiGatewayEvaluationFallbackConditionVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AiGatewayEvaluationFallbackConditionVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AiGatewayEvaluationFallbackConditionVariant5!, typeInfo);
            }
        }
    }
}