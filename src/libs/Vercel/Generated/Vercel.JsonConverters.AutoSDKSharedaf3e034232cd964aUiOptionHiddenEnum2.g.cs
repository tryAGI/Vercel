#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2 Read(
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
                        return global::Vercel.AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKSharedaf3e034232cd964aUiOptionHiddenEnum2Extensions.ToValueString(value));
        }
    }
}
