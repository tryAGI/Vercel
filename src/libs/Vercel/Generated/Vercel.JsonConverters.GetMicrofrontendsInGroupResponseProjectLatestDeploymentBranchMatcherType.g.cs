#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType>
    {
        /// <inheritdoc />
        public override global::Vercel.GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType Read(
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
                        return global::Vercel.GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetMicrofrontendsInGroupResponseProjectLatestDeploymentBranchMatcherTypeExtensions.ToValueString(value));
        }
    }
}
