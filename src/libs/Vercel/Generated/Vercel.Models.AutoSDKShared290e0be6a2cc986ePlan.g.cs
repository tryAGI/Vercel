
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared290e0be6a2cc986ePlan
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
    public static class AutoSDKShared290e0be6a2cc986ePlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared290e0be6a2cc986ePlan value)
        {
            return value switch
            {
                AutoSDKShared290e0be6a2cc986ePlan.Enterprise => "enterprise",
                AutoSDKShared290e0be6a2cc986ePlan.Hobby => "hobby",
                AutoSDKShared290e0be6a2cc986ePlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared290e0be6a2cc986ePlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => AutoSDKShared290e0be6a2cc986ePlan.Enterprise,
                "hobby" => AutoSDKShared290e0be6a2cc986ePlan.Hobby,
                "pro" => AutoSDKShared290e0be6a2cc986ePlan.Pro,
                _ => null,
            };
        }
    }
}