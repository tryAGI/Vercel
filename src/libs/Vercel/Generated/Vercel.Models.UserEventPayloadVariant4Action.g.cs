
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant4Action
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant4ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant4Action value)
        {
            return value switch
            {
                UserEventPayloadVariant4Action.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant4Action? ToEnum(string value)
        {
            return value switch
            {
                "read" => UserEventPayloadVariant4Action.Read,
                _ => null,
            };
        }
    }
}