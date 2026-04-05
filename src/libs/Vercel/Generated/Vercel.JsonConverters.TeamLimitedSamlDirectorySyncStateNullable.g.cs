#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamLimitedSamlDirectorySyncStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.TeamLimitedSamlDirectorySyncState?>
    {
        /// <inheritdoc />
        public override global::Vercel.TeamLimitedSamlDirectorySyncState? Read(
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
                        return global::Vercel.TeamLimitedSamlDirectorySyncStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.TeamLimitedSamlDirectorySyncState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.TeamLimitedSamlDirectorySyncState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.TeamLimitedSamlDirectorySyncState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.TeamLimitedSamlDirectorySyncStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
