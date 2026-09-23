
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum AutoSDKShared8422af433e1bf486BranchMatcherType
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
    public static class AutoSDKShared8422af433e1bf486BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8422af433e1bf486BranchMatcherType value)
        {
            return value switch
            {
                AutoSDKShared8422af433e1bf486BranchMatcherType.EndsWith => "endsWith",
                AutoSDKShared8422af433e1bf486BranchMatcherType.Equals => "equals",
                AutoSDKShared8422af433e1bf486BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8422af433e1bf486BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => AutoSDKShared8422af433e1bf486BranchMatcherType.EndsWith,
                "equals" => AutoSDKShared8422af433e1bf486BranchMatcherType.Equals,
                "startsWith" => AutoSDKShared8422af433e1bf486BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}