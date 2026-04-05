
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Northstar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant114NewOwnerVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerVersion value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerVersion.Northstar => "northstar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerVersion? ToEnum(string value)
        {
            return value switch
            {
                "northstar" => UserEventPayloadVariant114NewOwnerVersion.Northstar,
                _ => null,
            };
        }
    }
}