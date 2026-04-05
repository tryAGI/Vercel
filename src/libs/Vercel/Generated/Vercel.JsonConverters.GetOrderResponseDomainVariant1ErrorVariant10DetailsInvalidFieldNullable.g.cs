#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidFieldNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField? Read(
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
                        return global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidFieldExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidFieldExtensions.ToValueString(value.Value));
            }
        }
    }
}
