#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateDrainResponseVariant1DeliveryVariant2EncodingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2Encoding>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2Encoding Read(
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
                        return global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2EncodingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2Encoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2Encoding);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2Encoding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.UpdateDrainResponseVariant1DeliveryVariant2EncodingExtensions.ToValueString(value));
        }
    }
}
