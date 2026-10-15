#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateConditionalBypassRequestConditionGroupItemConditionVariant2OpJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op Read(
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
                        return global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant2OpExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant2OpExtensions.ToValueString(value));
        }
    }
}
