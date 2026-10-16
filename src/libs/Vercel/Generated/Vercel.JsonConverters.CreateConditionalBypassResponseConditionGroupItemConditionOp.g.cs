#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateConditionalBypassResponseConditionGroupItemConditionOpJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateConditionalBypassResponseConditionGroupItemConditionOp>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateConditionalBypassResponseConditionGroupItemConditionOp Read(
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
                        return global::Vercel.CreateConditionalBypassResponseConditionGroupItemConditionOpExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateConditionalBypassResponseConditionGroupItemConditionOp)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateConditionalBypassResponseConditionGroupItemConditionOp);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateConditionalBypassResponseConditionGroupItemConditionOp value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateConditionalBypassResponseConditionGroupItemConditionOpExtensions.ToValueString(value));
        }
    }
}
