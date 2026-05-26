#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSandboxesSessionsSortOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetSandboxesSessionsSortOrder?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetSandboxesSessionsSortOrder? Read(
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
                        return global::Vercel.GetSandboxesSessionsSortOrderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetSandboxesSessionsSortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetSandboxesSessionsSortOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetSandboxesSessionsSortOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetSandboxesSessionsSortOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
