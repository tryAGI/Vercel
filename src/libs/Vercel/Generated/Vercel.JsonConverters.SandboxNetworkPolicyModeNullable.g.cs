#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class SandboxNetworkPolicyModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.SandboxNetworkPolicyMode?>
    {
        /// <inheritdoc />
        public override global::Vercel.SandboxNetworkPolicyMode? Read(
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
                        return global::Vercel.SandboxNetworkPolicyModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.SandboxNetworkPolicyMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.SandboxNetworkPolicyMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.SandboxNetworkPolicyMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.SandboxNetworkPolicyModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
