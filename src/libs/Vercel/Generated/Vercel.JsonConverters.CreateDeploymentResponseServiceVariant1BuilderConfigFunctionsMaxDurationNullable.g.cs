#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDurationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration? Read(
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
                        return global::Vercel.CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDurationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDuration? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateDeploymentResponseServiceVariant1BuilderConfigFunctionsMaxDurationExtensions.ToValueString(value.Value));
            }
        }
    }
}
