
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum AutoSDKSharede064e44b973b9ad0BranchMatcherType
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
    public static class AutoSDKSharede064e44b973b9ad0BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede064e44b973b9ad0BranchMatcherType value)
        {
            return value switch
            {
                AutoSDKSharede064e44b973b9ad0BranchMatcherType.EndsWith => "endsWith",
                AutoSDKSharede064e44b973b9ad0BranchMatcherType.Equals => "equals",
                AutoSDKSharede064e44b973b9ad0BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede064e44b973b9ad0BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => AutoSDKSharede064e44b973b9ad0BranchMatcherType.EndsWith,
                "equals" => AutoSDKSharede064e44b973b9ad0BranchMatcherType.Equals,
                "startsWith" => AutoSDKSharede064e44b973b9ad0BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}