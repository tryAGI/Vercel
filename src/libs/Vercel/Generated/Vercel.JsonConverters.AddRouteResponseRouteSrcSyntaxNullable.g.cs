#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AddRouteResponseRouteSrcSyntaxNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AddRouteResponseRouteSrcSyntax?>
    {
        /// <inheritdoc />
        public override global::Vercel.AddRouteResponseRouteSrcSyntax? Read(
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
                        return global::Vercel.AddRouteResponseRouteSrcSyntaxExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AddRouteResponseRouteSrcSyntax)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AddRouteResponseRouteSrcSyntax?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AddRouteResponseRouteSrcSyntax? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AddRouteResponseRouteSrcSyntaxExtensions.ToValueString(value.Value));
            }
        }
    }
}
