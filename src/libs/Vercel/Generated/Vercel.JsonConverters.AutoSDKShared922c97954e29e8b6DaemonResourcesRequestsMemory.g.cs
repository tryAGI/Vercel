#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemoryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory Read(
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
                        return global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemoryExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemoryExtensions.ToValueString(value));
        }
    }
}
