
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum AutoSDKShared7524a6c3199bd963BranchMatcherType
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
    public static class AutoSDKShared7524a6c3199bd963BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7524a6c3199bd963BranchMatcherType value)
        {
            return value switch
            {
                AutoSDKShared7524a6c3199bd963BranchMatcherType.EndsWith => "endsWith",
                AutoSDKShared7524a6c3199bd963BranchMatcherType.Equals => "equals",
                AutoSDKShared7524a6c3199bd963BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7524a6c3199bd963BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => AutoSDKShared7524a6c3199bd963BranchMatcherType.EndsWith,
                "equals" => AutoSDKShared7524a6c3199bd963BranchMatcherType.Equals,
                "startsWith" => AutoSDKShared7524a6c3199bd963BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}