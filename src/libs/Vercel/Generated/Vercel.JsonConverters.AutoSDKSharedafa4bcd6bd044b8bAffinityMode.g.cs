#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharedafa4bcd6bd044b8bAffinityModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedafa4bcd6bd044b8bAffinityMode>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedafa4bcd6bd044b8bAffinityMode Read(
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
                        return global::Vercel.AutoSDKSharedafa4bcd6bd044b8bAffinityModeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharedafa4bcd6bd044b8bAffinityMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharedafa4bcd6bd044b8bAffinityMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedafa4bcd6bd044b8bAffinityMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKSharedafa4bcd6bd044b8bAffinityModeExtensions.ToValueString(value));
        }
    }
}
