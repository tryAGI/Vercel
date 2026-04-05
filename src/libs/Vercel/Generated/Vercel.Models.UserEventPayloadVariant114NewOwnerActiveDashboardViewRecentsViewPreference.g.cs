
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreference
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreference.Closed => "closed",
                UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreference.Closed,
                "open" => UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreference.Open,
                _ => null,
            };
        }
    }
}