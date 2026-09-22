#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared02b3ab4a1bf599afAlgorithmJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared02b3ab4a1bf599afAlgorithm>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared02b3ab4a1bf599afAlgorithm Read(
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
                        return global::Vercel.AutoSDKShared02b3ab4a1bf599afAlgorithmExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared02b3ab4a1bf599afAlgorithm)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared02b3ab4a1bf599afAlgorithm);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared02b3ab4a1bf599afAlgorithm value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared02b3ab4a1bf599afAlgorithmExtensions.ToValueString(value));
        }
    }
}
