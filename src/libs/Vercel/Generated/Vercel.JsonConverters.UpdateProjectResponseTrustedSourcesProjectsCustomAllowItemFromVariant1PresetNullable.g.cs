#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1PresetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset? Read(
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
                        return global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1PresetExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1PresetExtensions.ToValueString(value.Value));
            }
        }
    }
}
