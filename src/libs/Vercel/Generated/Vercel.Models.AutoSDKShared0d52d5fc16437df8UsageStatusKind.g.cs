
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8UsageStatusKind
    {
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0d52d5fc16437df8UsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8UsageStatusKind value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8UsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8UsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => AutoSDKShared0d52d5fc16437df8UsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}