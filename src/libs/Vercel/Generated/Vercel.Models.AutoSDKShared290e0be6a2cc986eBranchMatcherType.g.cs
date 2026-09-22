
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum AutoSDKShared290e0be6a2cc986eBranchMatcherType
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
    public static class AutoSDKShared290e0be6a2cc986eBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared290e0be6a2cc986eBranchMatcherType value)
        {
            return value switch
            {
                AutoSDKShared290e0be6a2cc986eBranchMatcherType.EndsWith => "endsWith",
                AutoSDKShared290e0be6a2cc986eBranchMatcherType.Equals => "equals",
                AutoSDKShared290e0be6a2cc986eBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared290e0be6a2cc986eBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => AutoSDKShared290e0be6a2cc986eBranchMatcherType.EndsWith,
                "equals" => AutoSDKShared290e0be6a2cc986eBranchMatcherType.Equals,
                "startsWith" => AutoSDKShared290e0be6a2cc986eBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}