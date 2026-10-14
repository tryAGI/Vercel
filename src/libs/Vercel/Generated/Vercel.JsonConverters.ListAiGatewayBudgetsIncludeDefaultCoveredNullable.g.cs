#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListAiGatewayBudgetsIncludeDefaultCoveredNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered?>
    {
        /// <inheritdoc />
        public override global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered? Read(
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
                        return global::Vercel.ListAiGatewayBudgetsIncludeDefaultCoveredExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ListAiGatewayBudgetsIncludeDefaultCoveredExtensions.ToValueString(value.Value));
            }
        }
    }
}
