#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class FlagExperimentGuardrailMetricMetricTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.FlagExperimentGuardrailMetricMetricType>
    {
        /// <inheritdoc />
        public override global::Vercel.FlagExperimentGuardrailMetricMetricType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Vercel.FlagExperimentGuardrailMetricMetricTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.FlagExperimentGuardrailMetricMetricType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.FlagExperimentGuardrailMetricMetricType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.FlagExperimentGuardrailMetricMetricType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.FlagExperimentGuardrailMetricMetricTypeExtensions.ToValueString(value));
        }
    }
}
