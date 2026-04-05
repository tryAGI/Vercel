#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class TestDrainRequestDeliveryVariant2EncodingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.TestDrainRequestDeliveryVariant2Encoding>
    {
        /// <inheritdoc />
        public override global::Vercel.TestDrainRequestDeliveryVariant2Encoding Read(
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
                        return global::Vercel.TestDrainRequestDeliveryVariant2EncodingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.TestDrainRequestDeliveryVariant2Encoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.TestDrainRequestDeliveryVariant2Encoding);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.TestDrainRequestDeliveryVariant2Encoding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.TestDrainRequestDeliveryVariant2EncodingExtensions.ToValueString(value));
        }
    }
}
