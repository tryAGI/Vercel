
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum AutoSDKSharedbca3e7a986162538BranchMatcherType
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
    public static class AutoSDKSharedbca3e7a986162538BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbca3e7a986162538BranchMatcherType value)
        {
            return value switch
            {
                AutoSDKSharedbca3e7a986162538BranchMatcherType.EndsWith => "endsWith",
                AutoSDKSharedbca3e7a986162538BranchMatcherType.Equals => "equals",
                AutoSDKSharedbca3e7a986162538BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbca3e7a986162538BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => AutoSDKSharedbca3e7a986162538BranchMatcherType.EndsWith,
                "equals" => AutoSDKSharedbca3e7a986162538BranchMatcherType.Equals,
                "startsWith" => AutoSDKSharedbca3e7a986162538BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}