#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction Read(
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
                        return global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetActionMitigateRateLimitActionExtensions.ToValueString(value));
        }
    }
}
