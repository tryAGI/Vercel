#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDeploymentEventsResponseItemVariant1PayloadProxyWafActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction Read(
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
                        return global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadProxyWafActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetDeploymentEventsResponseItemVariant1PayloadProxyWafActionExtensions.ToValueString(value));
        }
    }
}
