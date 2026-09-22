#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared238fc1521601aa81MfeConfigUploadStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared238fc1521601aa81MfeConfigUploadState>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared238fc1521601aa81MfeConfigUploadState Read(
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
                        return global::Vercel.AutoSDKShared238fc1521601aa81MfeConfigUploadStateExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared238fc1521601aa81MfeConfigUploadState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared238fc1521601aa81MfeConfigUploadState);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared238fc1521601aa81MfeConfigUploadState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared238fc1521601aa81MfeConfigUploadStateExtensions.ToValueString(value));
        }
    }
}
