#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class FlagEnvironmentsRuleConditionCmpNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.FlagEnvironmentsRuleConditionCmp?>
    {
        /// <inheritdoc />
        public override global::Vercel.FlagEnvironmentsRuleConditionCmp? Read(
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
                        return global::Vercel.FlagEnvironmentsRuleConditionCmpExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.FlagEnvironmentsRuleConditionCmp)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.FlagEnvironmentsRuleConditionCmp?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.FlagEnvironmentsRuleConditionCmp? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.FlagEnvironmentsRuleConditionCmpExtensions.ToValueString(value.Value));
            }
        }
    }
}
