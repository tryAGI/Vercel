#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchEdgeConfigItemsRequestItemOperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PatchEdgeConfigItemsRequestItemOperation>
    {
        /// <inheritdoc />
        public override global::Vercel.PatchEdgeConfigItemsRequestItemOperation Read(
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
                        return global::Vercel.PatchEdgeConfigItemsRequestItemOperationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.PatchEdgeConfigItemsRequestItemOperation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.PatchEdgeConfigItemsRequestItemOperation);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PatchEdgeConfigItemsRequestItemOperation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.PatchEdgeConfigItemsRequestItemOperationExtensions.ToValueString(value));
        }
    }
}
