#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateRouteResponseRouteConditionOperatorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GenerateRouteResponseRouteConditionOperator?>
    {
        /// <inheritdoc />
        public override global::Vercel.GenerateRouteResponseRouteConditionOperator? Read(
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
                        return global::Vercel.GenerateRouteResponseRouteConditionOperatorExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GenerateRouteResponseRouteConditionOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GenerateRouteResponseRouteConditionOperator?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GenerateRouteResponseRouteConditionOperator? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GenerateRouteResponseRouteConditionOperatorExtensions.ToValueString(value.Value));
            }
        }
    }
}
