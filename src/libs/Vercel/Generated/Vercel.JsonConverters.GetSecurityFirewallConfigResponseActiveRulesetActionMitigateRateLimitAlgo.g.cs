#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo>
    {
        /// <inheritdoc />
        public override global::Vercel.GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo Read(
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
                        return global::Vercel.GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgoExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgo value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetSecurityFirewallConfigResponseActiveRulesetActionMitigateRateLimitAlgoExtensions.ToValueString(value));
        }
    }
}
