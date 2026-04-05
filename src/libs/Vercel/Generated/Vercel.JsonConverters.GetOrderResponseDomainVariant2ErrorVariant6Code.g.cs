#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrderResponseDomainVariant2ErrorVariant6CodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code>
    {
        /// <inheritdoc />
        public override global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code Read(
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
                        return global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6CodeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6CodeExtensions.ToValueString(value));
        }
    }
}
