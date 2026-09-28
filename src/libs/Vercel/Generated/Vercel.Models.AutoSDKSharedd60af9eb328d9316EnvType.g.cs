
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd60af9eb328d9316EnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd60af9eb328d9316EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd60af9eb328d9316EnvType value)
        {
            return value switch
            {
                AutoSDKSharedd60af9eb328d9316EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd60af9eb328d9316EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => AutoSDKSharedd60af9eb328d9316EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}