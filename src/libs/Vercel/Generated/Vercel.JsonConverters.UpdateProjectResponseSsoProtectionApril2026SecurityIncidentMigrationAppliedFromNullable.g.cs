#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateProjectResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFromNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateProjectResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateProjectResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? Read(
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
                        return global::Vercel.UpdateProjectResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFromExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateProjectResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateProjectResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateProjectResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateProjectResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFromExtensions.ToValueString(value.Value));
            }
        }
    }
}
