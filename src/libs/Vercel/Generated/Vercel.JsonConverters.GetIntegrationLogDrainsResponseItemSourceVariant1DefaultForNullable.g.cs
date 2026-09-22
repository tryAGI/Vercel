#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetIntegrationLogDrainsResponseItemSourceVariant1DefaultForNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetIntegrationLogDrainsResponseItemSourceVariant1DefaultFor?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetIntegrationLogDrainsResponseItemSourceVariant1DefaultFor? Read(
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
                        return global::Vercel.GetIntegrationLogDrainsResponseItemSourceVariant1DefaultForExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetIntegrationLogDrainsResponseItemSourceVariant1DefaultFor)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetIntegrationLogDrainsResponseItemSourceVariant1DefaultFor?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetIntegrationLogDrainsResponseItemSourceVariant1DefaultFor? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetIntegrationLogDrainsResponseItemSourceVariant1DefaultForExtensions.ToValueString(value.Value));
            }
        }
    }
}
