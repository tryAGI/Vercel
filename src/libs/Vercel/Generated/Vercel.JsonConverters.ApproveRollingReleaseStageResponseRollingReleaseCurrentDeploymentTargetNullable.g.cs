#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTargetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget?>
    {
        /// <inheritdoc />
        public override global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget? Read(
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
                        return global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTargetExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTarget? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentTargetExtensions.ToValueString(value.Value));
            }
        }
    }
}
