#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDeploymentEventsResponseItemVariant2LevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDeploymentEventsResponseItemVariant2Level?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDeploymentEventsResponseItemVariant2Level? Read(
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
                        return global::Vercel.GetDeploymentEventsResponseItemVariant2LevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDeploymentEventsResponseItemVariant2Level)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDeploymentEventsResponseItemVariant2Level?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDeploymentEventsResponseItemVariant2Level? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetDeploymentEventsResponseItemVariant2LevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
