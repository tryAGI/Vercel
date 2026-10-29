#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateConditionalBypassResponseConditionGroupItemConditionOpNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateConditionalBypassResponseConditionGroupItemConditionOp?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateConditionalBypassResponseConditionGroupItemConditionOp? Read(
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
                        return global::Vercel.UpdateConditionalBypassResponseConditionGroupItemConditionOpExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateConditionalBypassResponseConditionGroupItemConditionOp)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateConditionalBypassResponseConditionGroupItemConditionOp?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateConditionalBypassResponseConditionGroupItemConditionOp? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateConditionalBypassResponseConditionGroupItemConditionOpExtensions.ToValueString(value.Value));
            }
        }
    }
}
