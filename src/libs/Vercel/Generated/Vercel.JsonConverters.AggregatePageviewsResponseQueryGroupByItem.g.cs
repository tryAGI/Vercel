#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AggregatePageviewsResponseQueryGroupByItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AggregatePageviewsResponseQueryGroupByItem>
    {
        /// <inheritdoc />
        public override global::Vercel.AggregatePageviewsResponseQueryGroupByItem Read(
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
                        return global::Vercel.AggregatePageviewsResponseQueryGroupByItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AggregatePageviewsResponseQueryGroupByItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AggregatePageviewsResponseQueryGroupByItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AggregatePageviewsResponseQueryGroupByItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AggregatePageviewsResponseQueryGroupByItemExtensions.ToValueString(value));
        }
    }
}
