#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider? Read(
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
                        return global::Vercel.UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
