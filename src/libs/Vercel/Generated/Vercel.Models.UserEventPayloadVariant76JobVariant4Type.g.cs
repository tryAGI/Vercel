
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant76JobVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Push,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant76JobVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant76JobVariant4Type value)
        {
            return value switch
            {
                UserEventPayloadVariant76JobVariant4Type.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant76JobVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "push" => UserEventPayloadVariant76JobVariant4Type.Push,
                _ => null,
            };
        }
    }
}