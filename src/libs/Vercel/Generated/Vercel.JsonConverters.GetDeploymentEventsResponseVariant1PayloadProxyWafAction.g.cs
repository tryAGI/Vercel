#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDeploymentEventsResponseVariant1PayloadProxyWafActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyWafAction>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyWafAction Read(
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
                        return global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyWafActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyWafAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyWafAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyWafAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetDeploymentEventsResponseVariant1PayloadProxyWafActionExtensions.ToValueString(value));
        }
    }
}
