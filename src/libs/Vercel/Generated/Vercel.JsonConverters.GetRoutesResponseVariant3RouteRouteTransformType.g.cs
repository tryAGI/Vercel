#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetRoutesResponseVariant3RouteRouteTransformTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetRoutesResponseVariant3RouteRouteTransformType>
    {
        /// <inheritdoc />
        public override global::Vercel.GetRoutesResponseVariant3RouteRouteTransformType Read(
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
                        return global::Vercel.GetRoutesResponseVariant3RouteRouteTransformTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetRoutesResponseVariant3RouteRouteTransformType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetRoutesResponseVariant3RouteRouteTransformType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetRoutesResponseVariant3RouteRouteTransformTypeExtensions.ToValueString(value));
        }
    }
}
