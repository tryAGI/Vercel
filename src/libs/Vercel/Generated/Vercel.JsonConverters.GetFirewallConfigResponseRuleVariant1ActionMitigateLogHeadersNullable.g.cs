#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeadersNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders? Read(
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
                        return global::Vercel.GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeadersExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeadersExtensions.ToValueString(value.Value));
            }
        }
    }
}
