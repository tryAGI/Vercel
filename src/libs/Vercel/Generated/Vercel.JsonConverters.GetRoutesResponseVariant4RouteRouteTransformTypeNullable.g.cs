#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetRoutesResponseVariant4RouteRouteTransformTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetRoutesResponseVariant4RouteRouteTransformType?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetRoutesResponseVariant4RouteRouteTransformType? Read(
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
                        return global::Vercel.GetRoutesResponseVariant4RouteRouteTransformTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetRoutesResponseVariant4RouteRouteTransformType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetRoutesResponseVariant4RouteRouteTransformType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetRoutesResponseVariant4RouteRouteTransformTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
