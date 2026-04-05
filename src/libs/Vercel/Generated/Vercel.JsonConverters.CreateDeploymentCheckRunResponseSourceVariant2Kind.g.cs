#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDeploymentCheckRunResponseSourceVariant2KindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateDeploymentCheckRunResponseSourceVariant2Kind>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateDeploymentCheckRunResponseSourceVariant2Kind Read(
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
                        return global::Vercel.CreateDeploymentCheckRunResponseSourceVariant2KindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateDeploymentCheckRunResponseSourceVariant2Kind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateDeploymentCheckRunResponseSourceVariant2Kind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateDeploymentCheckRunResponseSourceVariant2Kind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateDeploymentCheckRunResponseSourceVariant2KindExtensions.ToValueString(value));
        }
    }
}
