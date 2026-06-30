#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType? Read(
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
                        return global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentBranchMatcherTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
