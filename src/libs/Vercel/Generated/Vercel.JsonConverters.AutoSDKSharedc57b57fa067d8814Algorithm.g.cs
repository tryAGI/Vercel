#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharedc57b57fa067d8814AlgorithmJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedc57b57fa067d8814Algorithm>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedc57b57fa067d8814Algorithm Read(
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
                        return global::Vercel.AutoSDKSharedc57b57fa067d8814AlgorithmExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharedc57b57fa067d8814Algorithm)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharedc57b57fa067d8814Algorithm);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedc57b57fa067d8814Algorithm value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKSharedc57b57fa067d8814AlgorithmExtensions.ToValueString(value));
        }
    }
}
