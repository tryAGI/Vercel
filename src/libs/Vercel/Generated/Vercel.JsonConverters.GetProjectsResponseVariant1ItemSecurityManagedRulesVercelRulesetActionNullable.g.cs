#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction? Read(
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
                        return global::Vercel.GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
