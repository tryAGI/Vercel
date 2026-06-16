#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetProjectsResponseVariant3ProjectPassportDeploymentTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetProjectsResponseVariant3ProjectPassportDeploymentType?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetProjectsResponseVariant3ProjectPassportDeploymentType? Read(
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
                        return global::Vercel.GetProjectsResponseVariant3ProjectPassportDeploymentTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetProjectsResponseVariant3ProjectPassportDeploymentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetProjectsResponseVariant3ProjectPassportDeploymentType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetProjectsResponseVariant3ProjectPassportDeploymentType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetProjectsResponseVariant3ProjectPassportDeploymentTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
