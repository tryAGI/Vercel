
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Push,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant70JobVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant4Type value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant4Type.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "push" => UserEventPayloadVariant70JobVariant4Type.Push,
                _ => null,
            };
        }
    }
}