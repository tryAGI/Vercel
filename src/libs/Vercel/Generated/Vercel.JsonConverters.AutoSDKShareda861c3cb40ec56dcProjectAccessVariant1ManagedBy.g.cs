#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedBy>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedBy Read(
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
                        return global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedByExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShareda861c3cb40ec56dcProjectAccessVariant1ManagedByExtensions.ToValueString(value));
        }
    }
}
