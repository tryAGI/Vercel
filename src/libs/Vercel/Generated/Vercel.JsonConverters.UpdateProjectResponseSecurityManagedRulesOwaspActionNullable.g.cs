#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateProjectResponseSecurityManagedRulesOwaspActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateProjectResponseSecurityManagedRulesOwaspAction?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateProjectResponseSecurityManagedRulesOwaspAction? Read(
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
                        return global::Vercel.UpdateProjectResponseSecurityManagedRulesOwaspActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateProjectResponseSecurityManagedRulesOwaspAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateProjectResponseSecurityManagedRulesOwaspAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateProjectResponseSecurityManagedRulesOwaspAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateProjectResponseSecurityManagedRulesOwaspActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
