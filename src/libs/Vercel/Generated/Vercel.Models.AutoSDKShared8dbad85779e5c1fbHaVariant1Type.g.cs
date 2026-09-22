
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8dbad85779e5c1fbHaVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8dbad85779e5c1fbHaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8dbad85779e5c1fbHaVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared8dbad85779e5c1fbHaVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8dbad85779e5c1fbHaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AutoSDKShared8dbad85779e5c1fbHaVariant1Type.Host,
                _ => null,
            };
        }
    }
}