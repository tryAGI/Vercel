#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class RemoveProjectEnvResponseVariant2TargetItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.RemoveProjectEnvResponseVariant2TargetItem>
    {
        /// <inheritdoc />
        public override global::Vercel.RemoveProjectEnvResponseVariant2TargetItem Read(
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
                        return global::Vercel.RemoveProjectEnvResponseVariant2TargetItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.RemoveProjectEnvResponseVariant2TargetItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.RemoveProjectEnvResponseVariant2TargetItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.RemoveProjectEnvResponseVariant2TargetItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.RemoveProjectEnvResponseVariant2TargetItemExtensions.ToValueString(value));
        }
    }
}
