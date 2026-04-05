#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class StageRoutesRequestRouteRouteMissingItemTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.StageRoutesRequestRouteRouteMissingItemType?>
    {
        /// <inheritdoc />
        public override global::Vercel.StageRoutesRequestRouteRouteMissingItemType? Read(
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
                        return global::Vercel.StageRoutesRequestRouteRouteMissingItemTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.StageRoutesRequestRouteRouteMissingItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.StageRoutesRequestRouteRouteMissingItemType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.StageRoutesRequestRouteRouteMissingItemType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.StageRoutesRequestRouteRouteMissingItemTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
