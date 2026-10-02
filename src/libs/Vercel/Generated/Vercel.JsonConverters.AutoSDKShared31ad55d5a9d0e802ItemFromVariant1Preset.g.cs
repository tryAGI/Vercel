#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared31ad55d5a9d0e802ItemFromVariant1PresetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset Read(
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
                        return global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1PresetExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1Preset value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1PresetExtensions.ToValueString(value));
        }
    }
}
