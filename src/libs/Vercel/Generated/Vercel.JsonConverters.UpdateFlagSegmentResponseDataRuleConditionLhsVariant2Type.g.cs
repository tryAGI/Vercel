#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateFlagSegmentResponseDataRuleConditionLhsVariant2TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type Read(
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
                        return global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2TypeExtensions.ToValueString(value));
        }
    }
}
