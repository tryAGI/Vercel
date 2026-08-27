#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteSecurityFirewallConfigByConfigVersionResponseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.DeleteSecurityFirewallConfigByConfigVersionResponse?>
    {
        /// <inheritdoc />
        public override global::Vercel.DeleteSecurityFirewallConfigByConfigVersionResponse? Read(
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
                        return global::Vercel.DeleteSecurityFirewallConfigByConfigVersionResponseExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.DeleteSecurityFirewallConfigByConfigVersionResponse)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.DeleteSecurityFirewallConfigByConfigVersionResponse?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.DeleteSecurityFirewallConfigByConfigVersionResponse? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.DeleteSecurityFirewallConfigByConfigVersionResponseExtensions.ToValueString(value.Value));
            }
        }
    }
}
