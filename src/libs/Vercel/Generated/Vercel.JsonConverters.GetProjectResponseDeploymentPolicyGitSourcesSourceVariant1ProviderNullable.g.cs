#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider? Read(
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
                        return global::Vercel.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
