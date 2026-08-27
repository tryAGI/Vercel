#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClaimDomainOwnershipResponseDomainEchModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ClaimDomainOwnershipResponseDomainEchMode>
    {
        /// <inheritdoc />
        public override global::Vercel.ClaimDomainOwnershipResponseDomainEchMode Read(
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
                        return global::Vercel.ClaimDomainOwnershipResponseDomainEchModeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ClaimDomainOwnershipResponseDomainEchMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ClaimDomainOwnershipResponseDomainEchMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ClaimDomainOwnershipResponseDomainEchMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.ClaimDomainOwnershipResponseDomainEchModeExtensions.ToValueString(value));
        }
    }
}
