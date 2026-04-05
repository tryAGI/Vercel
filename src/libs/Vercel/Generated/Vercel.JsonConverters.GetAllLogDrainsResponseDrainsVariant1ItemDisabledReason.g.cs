#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAllLogDrainsResponseDrainsVariant1ItemDisabledReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason>
    {
        /// <inheritdoc />
        public override global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason Read(
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
                        return global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemDisabledReasonExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemDisabledReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemDisabledReasonExtensions.ToValueString(value));
        }
    }
}
