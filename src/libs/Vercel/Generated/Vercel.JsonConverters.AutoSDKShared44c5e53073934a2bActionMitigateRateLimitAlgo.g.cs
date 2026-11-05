#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo Read(
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
                        return global::Vercel.AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgoExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgoExtensions.ToValueString(value));
        }
    }
}
