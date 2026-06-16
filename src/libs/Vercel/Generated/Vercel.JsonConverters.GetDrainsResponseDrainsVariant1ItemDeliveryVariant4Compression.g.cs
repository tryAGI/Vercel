#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDrainsResponseDrainsVariant1ItemDeliveryVariant4CompressionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression Read(
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
                        return global::Vercel.GetDrainsResponseDrainsVariant1ItemDeliveryVariant4CompressionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetDrainsResponseDrainsVariant1ItemDeliveryVariant4CompressionExtensions.ToValueString(value));
        }
    }
}
