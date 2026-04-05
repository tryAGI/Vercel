#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateFlagResponseEnvironmentsRuleConditionCmpJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmp>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmp Read(
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
                        return global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmpExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmp)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmp);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmp value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmpExtensions.ToValueString(value));
        }
    }
}
