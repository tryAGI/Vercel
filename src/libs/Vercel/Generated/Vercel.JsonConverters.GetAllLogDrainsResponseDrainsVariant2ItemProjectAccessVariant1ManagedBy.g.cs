#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy>
    {
        /// <inheritdoc />
        public override global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy Read(
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
                        return global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedByExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedByExtensions.ToValueString(value));
        }
    }
}
