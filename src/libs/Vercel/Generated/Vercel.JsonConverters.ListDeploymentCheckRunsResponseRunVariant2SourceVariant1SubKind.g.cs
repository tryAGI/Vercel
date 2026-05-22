#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListDeploymentCheckRunsResponseRunVariant2SourceVariant1SubKindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant1SubKind>
    {
        /// <inheritdoc />
        public override global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant1SubKind Read(
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
                        return global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant1SubKindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant1SubKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant1SubKind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant1SubKind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant1SubKindExtensions.ToValueString(value));
        }
    }
}
