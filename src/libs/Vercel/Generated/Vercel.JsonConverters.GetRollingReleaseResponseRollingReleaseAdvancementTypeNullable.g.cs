#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetRollingReleaseResponseRollingReleaseAdvancementTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType? Read(
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
                        return global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetRollingReleaseResponseRollingReleaseAdvancementTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
