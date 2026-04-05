#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2SecretKindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2SecretKind?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2SecretKind? Read(
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
                        return global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2SecretKindExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2SecretKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2SecretKind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2SecretKind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant2SecretKindExtensions.ToValueString(value.Value));
            }
        }
    }
}
