#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateConditionalBypassRequestConditionGroupItemConditionVariant1KeyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key? Read(
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
                        return global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant1KeyExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant1KeyExtensions.ToValueString(value.Value));
            }
        }
    }
}
