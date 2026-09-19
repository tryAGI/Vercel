#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnvVarEnvironmentsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.EnvVarEnvironments>
    {
        /// <inheritdoc />
        public override global::Vercel.EnvVarEnvironments Read(
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
                        return global::Vercel.EnvVarEnvironmentsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.EnvVarEnvironments)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.EnvVarEnvironments);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.EnvVarEnvironments value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.EnvVarEnvironmentsExtensions.ToValueString(value));
        }
    }
}
