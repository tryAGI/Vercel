#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource Read(
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
                        return global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSourceExtensions.ToValueString(value));
        }
    }
}
