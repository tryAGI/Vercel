#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateDrainResponseVariant2DeliveryVariant1CompressionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateDrainResponseVariant2DeliveryVariant1Compression?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateDrainResponseVariant2DeliveryVariant1Compression? Read(
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
                        return global::Vercel.UpdateDrainResponseVariant2DeliveryVariant1CompressionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateDrainResponseVariant2DeliveryVariant1Compression)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateDrainResponseVariant2DeliveryVariant1Compression?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateDrainResponseVariant2DeliveryVariant1Compression? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateDrainResponseVariant2DeliveryVariant1CompressionExtensions.ToValueString(value.Value));
            }
        }
    }
}
