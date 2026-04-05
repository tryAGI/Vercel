#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CancelDeploymentResponseGitSourceVariant13TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CancelDeploymentResponseGitSourceVariant13Type?>
    {
        /// <inheritdoc />
        public override global::Vercel.CancelDeploymentResponseGitSourceVariant13Type? Read(
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
                        return global::Vercel.CancelDeploymentResponseGitSourceVariant13TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CancelDeploymentResponseGitSourceVariant13Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CancelDeploymentResponseGitSourceVariant13Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CancelDeploymentResponseGitSourceVariant13Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CancelDeploymentResponseGitSourceVariant13TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
