
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22SourceVariant4SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelNativeCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedebbc2ea34af24e22SourceVariant4SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22SourceVariant4SubKind value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22SourceVariant4SubKind.VercelNativeCheck => "vercel-native-check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22SourceVariant4SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-native-check" => AutoSDKSharedebbc2ea34af24e22SourceVariant4SubKind.VercelNativeCheck,
                _ => null,
            };
        }
    }
}