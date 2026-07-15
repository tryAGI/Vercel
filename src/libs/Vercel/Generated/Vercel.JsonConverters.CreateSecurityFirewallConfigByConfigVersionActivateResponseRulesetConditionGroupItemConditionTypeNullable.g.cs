#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType? Read(
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
                        return global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
