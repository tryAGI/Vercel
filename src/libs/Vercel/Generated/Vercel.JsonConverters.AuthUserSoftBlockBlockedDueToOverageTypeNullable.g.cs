#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AuthUserSoftBlockBlockedDueToOverageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AuthUserSoftBlockBlockedDueToOverageType?>
    {
        /// <inheritdoc />
        public override global::Vercel.AuthUserSoftBlockBlockedDueToOverageType? Read(
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
                        return global::Vercel.AuthUserSoftBlockBlockedDueToOverageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AuthUserSoftBlockBlockedDueToOverageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AuthUserSoftBlockBlockedDueToOverageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AuthUserSoftBlockBlockedDueToOverageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AuthUserSoftBlockBlockedDueToOverageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
