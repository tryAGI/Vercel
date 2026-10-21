#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared19aed0f0e253807cNodeVersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared19aed0f0e253807cNodeVersion?>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared19aed0f0e253807cNodeVersion? Read(
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
                        return global::Vercel.AutoSDKShared19aed0f0e253807cNodeVersionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared19aed0f0e253807cNodeVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared19aed0f0e253807cNodeVersion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared19aed0f0e253807cNodeVersion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AutoSDKShared19aed0f0e253807cNodeVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
