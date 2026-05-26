#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSandboxesSessionsBySessionIdCmdByCmdIdWaitNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdWait?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdWait? Read(
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
                        return global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdWaitExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdWait)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdWait?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdWait? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetSandboxesSessionsBySessionIdCmdByCmdIdWaitExtensions.ToValueString(value.Value));
            }
        }
    }
}
