#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class SegmentDataRuleOutcomeVariant2TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.SegmentDataRuleOutcomeVariant2Type?>
    {
        /// <inheritdoc />
        public override global::Vercel.SegmentDataRuleOutcomeVariant2Type? Read(
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
                        return global::Vercel.SegmentDataRuleOutcomeVariant2TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.SegmentDataRuleOutcomeVariant2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.SegmentDataRuleOutcomeVariant2Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.SegmentDataRuleOutcomeVariant2Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.SegmentDataRuleOutcomeVariant2TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
