#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListDrivesSortOrderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListDrivesSortOrder>
    {
        /// <inheritdoc />
        public override global::Vercel.ListDrivesSortOrder Read(
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
                        return global::Vercel.ListDrivesSortOrderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListDrivesSortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListDrivesSortOrder);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListDrivesSortOrder value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.ListDrivesSortOrderExtensions.ToValueString(value));
        }
    }
}
