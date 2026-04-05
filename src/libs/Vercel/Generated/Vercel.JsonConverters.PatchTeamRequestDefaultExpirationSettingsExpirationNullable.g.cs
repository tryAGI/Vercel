#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchTeamRequestDefaultExpirationSettingsExpirationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpiration?>
    {
        /// <inheritdoc />
        public override global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpiration? Read(
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
                        return global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpirationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpiration)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpiration?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpiration? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.PatchTeamRequestDefaultExpirationSettingsExpirationExtensions.ToValueString(value.Value));
            }
        }
    }
}
