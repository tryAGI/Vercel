#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateConditionalBypassRequestConditionGroupItemConditionVariant4OpJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op Read(
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
                        return global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4OpExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4OpExtensions.ToValueString(value));
        }
    }
}
