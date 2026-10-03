#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineSelectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineSelection?>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineSelection? Read(
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
                        return global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineSelectionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineSelection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineSelection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineSelection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineSelectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
