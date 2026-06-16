#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateProjectResponseSecurityManagedRulesTrafficSourcesActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateProjectResponseSecurityManagedRulesTrafficSourcesAction?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateProjectResponseSecurityManagedRulesTrafficSourcesAction? Read(
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
                        return global::Vercel.CreateProjectResponseSecurityManagedRulesTrafficSourcesActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateProjectResponseSecurityManagedRulesTrafficSourcesAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateProjectResponseSecurityManagedRulesTrafficSourcesAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateProjectResponseSecurityManagedRulesTrafficSourcesAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateProjectResponseSecurityManagedRulesTrafficSourcesActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
