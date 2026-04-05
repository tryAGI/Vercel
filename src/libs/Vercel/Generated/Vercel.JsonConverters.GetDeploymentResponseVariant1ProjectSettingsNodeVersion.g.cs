#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDeploymentResponseVariant1ProjectSettingsNodeVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDeploymentResponseVariant1ProjectSettingsNodeVersion>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDeploymentResponseVariant1ProjectSettingsNodeVersion Read(
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
                        return global::Vercel.GetDeploymentResponseVariant1ProjectSettingsNodeVersionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDeploymentResponseVariant1ProjectSettingsNodeVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDeploymentResponseVariant1ProjectSettingsNodeVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDeploymentResponseVariant1ProjectSettingsNodeVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetDeploymentResponseVariant1ProjectSettingsNodeVersionExtensions.ToValueString(value));
        }
    }
}
