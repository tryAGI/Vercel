
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant37DataPlanSlug
    {
        /// <summary>
        /// 
        /// </summary>
        V0Business,
        /// <summary>
        /// 
        /// </summary>
        V0Teams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant37DataPlanSlugExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant37DataPlanSlug value)
        {
            return value switch
            {
                UserEventPayloadVariant37DataPlanSlug.V0Business => "v0_business",
                UserEventPayloadVariant37DataPlanSlug.V0Teams => "v0_teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant37DataPlanSlug? ToEnum(string value)
        {
            return value switch
            {
                "v0_business" => UserEventPayloadVariant37DataPlanSlug.V0Business,
                "v0_teams" => UserEventPayloadVariant37DataPlanSlug.V0Teams,
                _ => null,
            };
        }
    }
}