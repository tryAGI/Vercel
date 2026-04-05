#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CompleteRollingReleaseResponseRollingReleaseAdvancementTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType>
    {
        /// <inheritdoc />
        public override global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType Read(
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
                        return global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CompleteRollingReleaseResponseRollingReleaseAdvancementTypeExtensions.ToValueString(value));
        }
    }
}
