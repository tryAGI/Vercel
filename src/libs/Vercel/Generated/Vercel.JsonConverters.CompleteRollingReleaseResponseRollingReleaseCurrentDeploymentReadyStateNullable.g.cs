#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?>
    {
        /// <inheritdoc />
        public override global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState? Read(
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
                        return global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
