#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class VcrImageLayerVariant1OperationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.VcrImageLayerVariant1Operation?>
    {
        /// <inheritdoc />
        public override global::Vercel.VcrImageLayerVariant1Operation? Read(
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
                        return global::Vercel.VcrImageLayerVariant1OperationExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.VcrImageLayerVariant1Operation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.VcrImageLayerVariant1Operation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.VcrImageLayerVariant1Operation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.VcrImageLayerVariant1OperationExtensions.ToValueString(value.Value));
            }
        }
    }
}
