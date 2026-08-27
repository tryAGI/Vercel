#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2ProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider? Read(
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
                        return global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2ProviderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2ProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
