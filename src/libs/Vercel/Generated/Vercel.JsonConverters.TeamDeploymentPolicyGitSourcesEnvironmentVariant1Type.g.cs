#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamDeploymentPolicyGitSourcesEnvironmentVariant1TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type>
    {
        /// <inheritdoc />
        public override global::Vercel.TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type Read(
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
                        return global::Vercel.TeamDeploymentPolicyGitSourcesEnvironmentVariant1TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.TeamDeploymentPolicyGitSourcesEnvironmentVariant1TypeExtensions.ToValueString(value));
        }
    }
}
