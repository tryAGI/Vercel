
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared477368a6d087a9cdState
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared477368a6d087a9cdStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared477368a6d087a9cdState value)
        {
            return value switch
            {
                AutoSDKShared477368a6d087a9cdState.Active => "active",
                AutoSDKShared477368a6d087a9cdState.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared477368a6d087a9cdState? ToEnum(string value)
        {
            return value switch
            {
                "active" => AutoSDKShared477368a6d087a9cdState.Active,
                "archived" => AutoSDKShared477368a6d087a9cdState.Archived,
                _ => null,
            };
        }
    }
}