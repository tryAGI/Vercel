#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDeploymentCheckRunResponseVariant1SourceVariant3ProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3Provider>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3Provider Read(
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
                        return global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3ProviderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3Provider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3Provider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3Provider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3ProviderExtensions.ToValueString(value));
        }
    }
}
