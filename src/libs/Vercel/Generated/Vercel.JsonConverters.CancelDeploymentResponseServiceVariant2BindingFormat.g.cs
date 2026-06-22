#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CancelDeploymentResponseServiceVariant2BindingFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CancelDeploymentResponseServiceVariant2BindingFormat>
    {
        /// <inheritdoc />
        public override global::Vercel.CancelDeploymentResponseServiceVariant2BindingFormat Read(
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
                        return global::Vercel.CancelDeploymentResponseServiceVariant2BindingFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CancelDeploymentResponseServiceVariant2BindingFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CancelDeploymentResponseServiceVariant2BindingFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CancelDeploymentResponseServiceVariant2BindingFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CancelDeploymentResponseServiceVariant2BindingFormatExtensions.ToValueString(value));
        }
    }
}
