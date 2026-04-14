#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType? Read(
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
                        return global::Vercel.CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
