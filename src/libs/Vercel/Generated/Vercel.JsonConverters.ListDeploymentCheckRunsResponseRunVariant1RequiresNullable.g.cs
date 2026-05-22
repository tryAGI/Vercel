#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListDeploymentCheckRunsResponseRunVariant1RequiresNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListDeploymentCheckRunsResponseRunVariant1Requires?>
    {
        /// <inheritdoc />
        public override global::Vercel.ListDeploymentCheckRunsResponseRunVariant1Requires? Read(
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
                        return global::Vercel.ListDeploymentCheckRunsResponseRunVariant1RequiresExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListDeploymentCheckRunsResponseRunVariant1Requires)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListDeploymentCheckRunsResponseRunVariant1Requires?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListDeploymentCheckRunsResponseRunVariant1Requires? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ListDeploymentCheckRunsResponseRunVariant1RequiresExtensions.ToValueString(value.Value));
            }
        }
    }
}
