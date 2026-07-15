#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction? Read(
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
                        return global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetsActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
