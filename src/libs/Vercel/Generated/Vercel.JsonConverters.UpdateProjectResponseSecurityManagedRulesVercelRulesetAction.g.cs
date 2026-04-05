#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateProjectResponseSecurityManagedRulesVercelRulesetActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateProjectResponseSecurityManagedRulesVercelRulesetAction>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateProjectResponseSecurityManagedRulesVercelRulesetAction Read(
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
                        return global::Vercel.UpdateProjectResponseSecurityManagedRulesVercelRulesetActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateProjectResponseSecurityManagedRulesVercelRulesetAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateProjectResponseSecurityManagedRulesVercelRulesetAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateProjectResponseSecurityManagedRulesVercelRulesetAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.UpdateProjectResponseSecurityManagedRulesVercelRulesetActionExtensions.ToValueString(value));
        }
    }
}
