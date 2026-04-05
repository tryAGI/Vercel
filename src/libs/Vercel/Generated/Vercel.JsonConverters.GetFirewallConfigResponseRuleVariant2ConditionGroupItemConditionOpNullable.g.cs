#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOpNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp? Read(
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
                        return global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOpExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOpExtensions.ToValueString(value.Value));
            }
        }
    }
}
