#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared29b35dda7b3e47c4ConfiguredByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared29b35dda7b3e47c4ConfiguredBy>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared29b35dda7b3e47c4ConfiguredBy Read(
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
                        return global::Vercel.AutoSDKShared29b35dda7b3e47c4ConfiguredByExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared29b35dda7b3e47c4ConfiguredBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared29b35dda7b3e47c4ConfiguredBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared29b35dda7b3e47c4ConfiguredBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared29b35dda7b3e47c4ConfiguredByExtensions.ToValueString(value));
        }
    }
}
