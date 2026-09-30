#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharedea12f8422dc06e51ConnectConfigurationEnvIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedea12f8422dc06e51ConnectConfigurationEnvId>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedea12f8422dc06e51ConnectConfigurationEnvId Read(
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
                        return global::Vercel.AutoSDKSharedea12f8422dc06e51ConnectConfigurationEnvIdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharedea12f8422dc06e51ConnectConfigurationEnvId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharedea12f8422dc06e51ConnectConfigurationEnvId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedea12f8422dc06e51ConnectConfigurationEnvId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKSharedea12f8422dc06e51ConnectConfigurationEnvIdExtensions.ToValueString(value));
        }
    }
}
