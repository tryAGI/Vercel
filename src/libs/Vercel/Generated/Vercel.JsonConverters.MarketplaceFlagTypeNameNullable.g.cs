#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class MarketplaceFlagTypeNameNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.MarketplaceFlagTypeName?>
    {
        /// <inheritdoc />
        public override global::Vercel.MarketplaceFlagTypeName? Read(
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
                        return global::Vercel.MarketplaceFlagTypeNameExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.MarketplaceFlagTypeName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.MarketplaceFlagTypeName?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.MarketplaceFlagTypeName? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.MarketplaceFlagTypeNameExtensions.ToValueString(value.Value));
            }
        }
    }
}
