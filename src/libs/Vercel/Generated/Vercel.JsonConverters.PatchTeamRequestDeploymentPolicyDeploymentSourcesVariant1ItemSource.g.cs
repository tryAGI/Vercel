#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource>
    {
        /// <inheritdoc />
        public override global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource Read(
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
                        return global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSourceExtensions.ToValueString(value));
        }
    }
}
