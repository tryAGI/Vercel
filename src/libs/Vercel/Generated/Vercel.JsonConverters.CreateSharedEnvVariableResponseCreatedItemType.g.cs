#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSharedEnvVariableResponseCreatedItemTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateSharedEnvVariableResponseCreatedItemType>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateSharedEnvVariableResponseCreatedItemType Read(
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
                        return global::Vercel.CreateSharedEnvVariableResponseCreatedItemTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateSharedEnvVariableResponseCreatedItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateSharedEnvVariableResponseCreatedItemType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateSharedEnvVariableResponseCreatedItemType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateSharedEnvVariableResponseCreatedItemTypeExtensions.ToValueString(value));
        }
    }
}
