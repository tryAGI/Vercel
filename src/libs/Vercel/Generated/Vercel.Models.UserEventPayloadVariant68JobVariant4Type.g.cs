
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant68JobVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Push,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant68JobVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant68JobVariant4Type value)
        {
            return value switch
            {
                UserEventPayloadVariant68JobVariant4Type.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant68JobVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "push" => UserEventPayloadVariant68JobVariant4Type.Push,
                _ => null,
            };
        }
    }
}