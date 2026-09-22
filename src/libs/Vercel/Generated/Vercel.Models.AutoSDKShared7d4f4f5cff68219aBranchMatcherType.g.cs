
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum AutoSDKShared7d4f4f5cff68219aBranchMatcherType
    {
        /// <summary>
        ///
        /// </summary>
        EndsWith,
        /// <summary>
        ///
        /// </summary>
        Equals,
        /// <summary>
        ///
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7d4f4f5cff68219aBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7d4f4f5cff68219aBranchMatcherType value)
        {
            return value switch
            {
                AutoSDKShared7d4f4f5cff68219aBranchMatcherType.EndsWith => "endsWith",
                AutoSDKShared7d4f4f5cff68219aBranchMatcherType.Equals => "equals",
                AutoSDKShared7d4f4f5cff68219aBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7d4f4f5cff68219aBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => AutoSDKShared7d4f4f5cff68219aBranchMatcherType.EndsWith,
                "equals" => AutoSDKShared7d4f4f5cff68219aBranchMatcherType.Equals,
                "startsWith" => AutoSDKShared7d4f4f5cff68219aBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}