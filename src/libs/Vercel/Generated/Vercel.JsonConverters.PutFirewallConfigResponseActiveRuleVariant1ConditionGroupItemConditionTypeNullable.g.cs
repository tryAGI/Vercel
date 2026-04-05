#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType?>
    {
        /// <inheritdoc />
        public override global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType? Read(
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
                        return global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
