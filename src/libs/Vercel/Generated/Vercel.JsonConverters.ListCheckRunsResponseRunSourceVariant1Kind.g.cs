#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListCheckRunsResponseRunSourceVariant1KindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListCheckRunsResponseRunSourceVariant1Kind>
    {
        /// <inheritdoc />
        public override global::Vercel.ListCheckRunsResponseRunSourceVariant1Kind Read(
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
                        return global::Vercel.ListCheckRunsResponseRunSourceVariant1KindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListCheckRunsResponseRunSourceVariant1Kind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListCheckRunsResponseRunSourceVariant1Kind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListCheckRunsResponseRunSourceVariant1Kind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.ListCheckRunsResponseRunSourceVariant1KindExtensions.ToValueString(value));
        }
    }
}
