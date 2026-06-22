#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDeploymentResponseServiceVariant2BindingTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateDeploymentResponseServiceVariant2BindingType>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateDeploymentResponseServiceVariant2BindingType Read(
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
                        return global::Vercel.CreateDeploymentResponseServiceVariant2BindingTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateDeploymentResponseServiceVariant2BindingType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateDeploymentResponseServiceVariant2BindingType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateDeploymentResponseServiceVariant2BindingType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateDeploymentResponseServiceVariant2BindingTypeExtensions.ToValueString(value));
        }
    }
}
