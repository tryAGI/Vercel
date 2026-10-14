#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared97ad06bd8a349d59RoutePrefixSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared97ad06bd8a349d59RoutePrefixSource>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared97ad06bd8a349d59RoutePrefixSource Read(
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
                        return global::Vercel.AutoSDKShared97ad06bd8a349d59RoutePrefixSourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared97ad06bd8a349d59RoutePrefixSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared97ad06bd8a349d59RoutePrefixSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared97ad06bd8a349d59RoutePrefixSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared97ad06bd8a349d59RoutePrefixSourceExtensions.ToValueString(value));
        }
    }
}
