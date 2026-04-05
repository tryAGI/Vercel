#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AuthUserResourceConfigBuildMachinePurchaseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AuthUserResourceConfigBuildMachinePurchaseType?>
    {
        /// <inheritdoc />
        public override global::Vercel.AuthUserResourceConfigBuildMachinePurchaseType? Read(
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
                        return global::Vercel.AuthUserResourceConfigBuildMachinePurchaseTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AuthUserResourceConfigBuildMachinePurchaseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AuthUserResourceConfigBuildMachinePurchaseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AuthUserResourceConfigBuildMachinePurchaseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AuthUserResourceConfigBuildMachinePurchaseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
