#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListProjectChecksResponseCheckBlocksNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListProjectChecksResponseCheckBlocks?>
    {
        /// <inheritdoc />
        public override global::Vercel.ListProjectChecksResponseCheckBlocks? Read(
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
                        return global::Vercel.ListProjectChecksResponseCheckBlocksExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListProjectChecksResponseCheckBlocks)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListProjectChecksResponseCheckBlocks?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListProjectChecksResponseCheckBlocks? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ListProjectChecksResponseCheckBlocksExtensions.ToValueString(value.Value));
            }
        }
    }
}
