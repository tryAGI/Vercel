#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration Read(
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
                        return global::Vercel.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfigurationExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfigurationExtensions.ToValueString(value));
        }
    }
}
