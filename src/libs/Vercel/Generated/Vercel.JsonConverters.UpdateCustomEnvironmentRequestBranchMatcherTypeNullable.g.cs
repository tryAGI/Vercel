#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateCustomEnvironmentRequestBranchMatcherTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateCustomEnvironmentRequestBranchMatcherType?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateCustomEnvironmentRequestBranchMatcherType? Read(
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
                        return global::Vercel.UpdateCustomEnvironmentRequestBranchMatcherTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateCustomEnvironmentRequestBranchMatcherType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateCustomEnvironmentRequestBranchMatcherType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateCustomEnvironmentRequestBranchMatcherType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateCustomEnvironmentRequestBranchMatcherTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
