#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1TargetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target?>
    {
        /// <inheritdoc />
        public override global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target? Read(
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
                        return global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1TargetExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1TargetExtensions.ToValueString(value.Value));
            }
        }
    }
}
