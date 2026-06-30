#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateMicrofrontendsResponseAliaDeploymentTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateMicrofrontendsResponseAliaDeploymentType>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateMicrofrontendsResponseAliaDeploymentType Read(
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
                        return global::Vercel.UpdateMicrofrontendsResponseAliaDeploymentTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateMicrofrontendsResponseAliaDeploymentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateMicrofrontendsResponseAliaDeploymentType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateMicrofrontendsResponseAliaDeploymentType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.UpdateMicrofrontendsResponseAliaDeploymentTypeExtensions.ToValueString(value));
        }
    }
}
