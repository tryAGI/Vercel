#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class BoughtTooRecentlyCodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.BoughtTooRecentlyCode>
    {
        /// <inheritdoc />
        public override global::Vercel.BoughtTooRecentlyCode Read(
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
                        return global::Vercel.BoughtTooRecentlyCodeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.BoughtTooRecentlyCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.BoughtTooRecentlyCode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.BoughtTooRecentlyCode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.BoughtTooRecentlyCodeExtensions.ToValueString(value));
        }
    }
}
