#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type?>
    {
        /// <inheritdoc />
        public override global::Vercel.UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type? Read(
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
                        return global::Vercel.UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
