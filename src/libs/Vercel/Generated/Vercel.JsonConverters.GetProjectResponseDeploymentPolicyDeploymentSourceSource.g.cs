#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetProjectResponseDeploymentPolicyDeploymentSourceSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetProjectResponseDeploymentPolicyDeploymentSourceSource>
    {
        /// <inheritdoc />
        public override global::Vercel.GetProjectResponseDeploymentPolicyDeploymentSourceSource Read(
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
                        return global::Vercel.GetProjectResponseDeploymentPolicyDeploymentSourceSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetProjectResponseDeploymentPolicyDeploymentSourceSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetProjectResponseDeploymentPolicyDeploymentSourceSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetProjectResponseDeploymentPolicyDeploymentSourceSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetProjectResponseDeploymentPolicyDeploymentSourceSourceExtensions.ToValueString(value));
        }
    }
}
