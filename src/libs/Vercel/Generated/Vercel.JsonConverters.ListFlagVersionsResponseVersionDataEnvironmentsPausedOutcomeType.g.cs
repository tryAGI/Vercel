#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType>
    {
        /// <inheritdoc />
        public override global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType Read(
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
                        return global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeTypeExtensions.ToValueString(value));
        }
    }
}
