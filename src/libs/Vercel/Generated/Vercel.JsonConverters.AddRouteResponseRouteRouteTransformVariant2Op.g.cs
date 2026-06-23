#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AddRouteResponseRouteRouteTransformVariant2OpJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op>
    {
        /// <inheritdoc />
        public override global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op Read(
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
                        return global::Vercel.AddRouteResponseRouteRouteTransformVariant2OpExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AddRouteResponseRouteRouteTransformVariant2Op value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AddRouteResponseRouteRouteTransformVariant2OpExtensions.ToValueString(value));
        }
    }
}
