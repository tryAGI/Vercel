#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditRouteResponseRouteRouteMitigateActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.EditRouteResponseRouteRouteMitigateAction>
    {
        /// <inheritdoc />
        public override global::Vercel.EditRouteResponseRouteRouteMitigateAction Read(
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
                        return global::Vercel.EditRouteResponseRouteRouteMitigateActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.EditRouteResponseRouteRouteMitigateAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.EditRouteResponseRouteRouteMitigateAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.EditRouteResponseRouteRouteMitigateAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.EditRouteResponseRouteRouteMitigateActionExtensions.ToValueString(value));
        }
    }
}
