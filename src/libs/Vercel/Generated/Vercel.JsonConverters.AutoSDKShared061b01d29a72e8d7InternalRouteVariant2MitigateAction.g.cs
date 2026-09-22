#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared061b01d29a72e8d7InternalRouteVariant2MitigateActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared061b01d29a72e8d7InternalRouteVariant2MitigateAction>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared061b01d29a72e8d7InternalRouteVariant2MitigateAction Read(
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
                        return global::Vercel.AutoSDKShared061b01d29a72e8d7InternalRouteVariant2MitigateActionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared061b01d29a72e8d7InternalRouteVariant2MitigateAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared061b01d29a72e8d7InternalRouteVariant2MitigateAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared061b01d29a72e8d7InternalRouteVariant2MitigateAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared061b01d29a72e8d7InternalRouteVariant2MitigateActionExtensions.ToValueString(value));
        }
    }
}
