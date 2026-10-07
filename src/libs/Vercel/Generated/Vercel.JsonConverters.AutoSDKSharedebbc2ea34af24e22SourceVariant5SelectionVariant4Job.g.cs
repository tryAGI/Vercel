#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4JobJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job Read(
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
                        return global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4JobExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Job value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4JobExtensions.ToValueString(value));
        }
    }
}
