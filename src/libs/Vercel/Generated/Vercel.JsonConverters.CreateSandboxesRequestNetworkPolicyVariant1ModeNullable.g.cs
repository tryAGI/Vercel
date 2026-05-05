#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSandboxesRequestNetworkPolicyVariant1ModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1Mode?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1Mode? Read(
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
                        return global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1ModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1Mode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1Mode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1Mode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1ModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
