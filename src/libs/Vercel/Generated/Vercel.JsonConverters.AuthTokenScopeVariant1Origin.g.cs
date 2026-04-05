#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AuthTokenScopeVariant1OriginJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AuthTokenScopeVariant1Origin>
    {
        /// <inheritdoc />
        public override global::Vercel.AuthTokenScopeVariant1Origin Read(
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
                        return global::Vercel.AuthTokenScopeVariant1OriginExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AuthTokenScopeVariant1Origin)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AuthTokenScopeVariant1Origin);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AuthTokenScopeVariant1Origin value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AuthTokenScopeVariant1OriginExtensions.ToValueString(value));
        }
    }
}
