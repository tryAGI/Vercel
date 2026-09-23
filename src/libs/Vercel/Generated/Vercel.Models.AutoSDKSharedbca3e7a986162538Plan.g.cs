
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbca3e7a986162538Plan
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Hobby,
        /// <summary>
        ///
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbca3e7a986162538PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbca3e7a986162538Plan value)
        {
            return value switch
            {
                AutoSDKSharedbca3e7a986162538Plan.Enterprise => "enterprise",
                AutoSDKSharedbca3e7a986162538Plan.Hobby => "hobby",
                AutoSDKSharedbca3e7a986162538Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbca3e7a986162538Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => AutoSDKSharedbca3e7a986162538Plan.Enterprise,
                "hobby" => AutoSDKSharedbca3e7a986162538Plan.Hobby,
                "pro" => AutoSDKSharedbca3e7a986162538Plan.Pro,
                _ => null,
            };
        }
    }
}