#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDrainResponseVariant2DeliveryVariant2EncodingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDrainResponseVariant2DeliveryVariant2Encoding?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDrainResponseVariant2DeliveryVariant2Encoding? Read(
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
                        return global::Vercel.GetDrainResponseVariant2DeliveryVariant2EncodingExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDrainResponseVariant2DeliveryVariant2Encoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDrainResponseVariant2DeliveryVariant2Encoding?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDrainResponseVariant2DeliveryVariant2Encoding? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetDrainResponseVariant2DeliveryVariant2EncodingExtensions.ToValueString(value.Value));
            }
        }
    }
}
