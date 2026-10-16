#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AddOrganizationTeamRequestBillingPlanNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AddOrganizationTeamRequestBillingPlan?>
    {
        /// <inheritdoc />
        public override global::Vercel.AddOrganizationTeamRequestBillingPlan? Read(
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
                        return global::Vercel.AddOrganizationTeamRequestBillingPlanExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AddOrganizationTeamRequestBillingPlan)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AddOrganizationTeamRequestBillingPlan?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AddOrganizationTeamRequestBillingPlan? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AddOrganizationTeamRequestBillingPlanExtensions.ToValueString(value.Value));
            }
        }
    }
}
