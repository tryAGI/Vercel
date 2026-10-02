#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigFunctionDefaultMemoryTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigFunctionDefaultMemoryType>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigFunctionDefaultMemoryType Read(
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
                        return global::Vercel.AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigFunctionDefaultMemoryTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigFunctionDefaultMemoryType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigFunctionDefaultMemoryType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigFunctionDefaultMemoryType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKSharedfe1f84289679c6c4DefaultResourceConfigFunctionDefaultMemoryTypeExtensions.ToValueString(value));
        }
    }
}
