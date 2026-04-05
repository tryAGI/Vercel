#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetRoutesResponseVariant2RouteSrcSyntaxJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax>
    {
        /// <inheritdoc />
        public override global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax Read(
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
                        return global::Vercel.GetRoutesResponseVariant2RouteSrcSyntaxExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetRoutesResponseVariant2RouteSrcSyntax value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetRoutesResponseVariant2RouteSrcSyntaxExtensions.ToValueString(value));
        }
    }
}
