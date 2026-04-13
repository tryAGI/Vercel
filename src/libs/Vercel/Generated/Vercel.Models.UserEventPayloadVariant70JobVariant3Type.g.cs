
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Pr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant70JobVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant3Type value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant3Type.Pr => "pr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "pr" => UserEventPayloadVariant70JobVariant3Type.Pr,
                _ => null,
            };
        }
    }
}