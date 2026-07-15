#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSecurityFirewallConfigResponseActiveCrsXssActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetSecurityFirewallConfigResponseActiveCrsXssAction>
    {
        /// <inheritdoc />
        public override global::Vercel.GetSecurityFirewallConfigResponseActiveCrsXssAction Read(
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
                        return global::Vercel.GetSecurityFirewallConfigResponseActiveCrsXssActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetSecurityFirewallConfigResponseActiveCrsXssAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetSecurityFirewallConfigResponseActiveCrsXssAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetSecurityFirewallConfigResponseActiveCrsXssAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetSecurityFirewallConfigResponseActiveCrsXssActionExtensions.ToValueString(value));
        }
    }
}
