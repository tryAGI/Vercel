#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrderResponseDomainVariant1ErrorVariant1CodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code>
    {
        /// <inheritdoc />
        public override global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code Read(
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
                        return global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1CodeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1CodeExtensions.ToValueString(value));
        }
    }
}
