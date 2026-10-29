#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateConditionalBypassRequestConditionGroupItemConditionVariant2OpNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op? Read(
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
                        return global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2OpExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2OpExtensions.ToValueString(value.Value));
            }
        }
    }
}
