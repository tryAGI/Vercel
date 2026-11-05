
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UserEventViaItemVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventViaItemVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventViaItemVariant4Type value)
        {
            return value switch
            {
                UserEventViaItemVariant4Type.External => "external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventViaItemVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "external" => UserEventViaItemVariant4Type.External,
                _ => null,
            };
        }
    }
}