#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType? Read(
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
                        return global::Vercel.GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
