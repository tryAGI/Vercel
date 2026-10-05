#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared87d88207314b07b3SourceVariant4OriginJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4Origin>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4Origin Read(
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
                        return global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4OriginExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4Origin)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4Origin);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4Origin value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4OriginExtensions.ToValueString(value));
        }
    }
}
