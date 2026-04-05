#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateFlagResponseExperimentGuardrailMetricMetricUnitNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateFlagResponseExperimentGuardrailMetricMetricUnit?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateFlagResponseExperimentGuardrailMetricMetricUnit? Read(
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
                        return global::Vercel.CreateFlagResponseExperimentGuardrailMetricMetricUnitExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateFlagResponseExperimentGuardrailMetricMetricUnit)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateFlagResponseExperimentGuardrailMetricMetricUnit?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateFlagResponseExperimentGuardrailMetricMetricUnit? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateFlagResponseExperimentGuardrailMetricMetricUnitExtensions.ToValueString(value.Value));
            }
        }
    }
}
