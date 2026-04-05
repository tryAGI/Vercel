#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamSamlDirectorySyncStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.TeamSamlDirectorySyncState?>
    {
        /// <inheritdoc />
        public override global::Vercel.TeamSamlDirectorySyncState? Read(
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
                        return global::Vercel.TeamSamlDirectorySyncStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.TeamSamlDirectorySyncState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.TeamSamlDirectorySyncState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.TeamSamlDirectorySyncState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.TeamSamlDirectorySyncStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
