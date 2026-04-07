#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CompleteRollingReleaseResponseRollingReleaseSubstateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate?>
    {
        /// <inheritdoc />
        public override global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate? Read(
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
                        return global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstate? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CompleteRollingReleaseResponseRollingReleaseSubstateExtensions.ToValueString(value.Value));
            }
        }
    }
}
