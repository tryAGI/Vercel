
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8422af433e1bf486Plan
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
    public static class AutoSDKShared8422af433e1bf486PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8422af433e1bf486Plan value)
        {
            return value switch
            {
                AutoSDKShared8422af433e1bf486Plan.Enterprise => "enterprise",
                AutoSDKShared8422af433e1bf486Plan.Hobby => "hobby",
                AutoSDKShared8422af433e1bf486Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8422af433e1bf486Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => AutoSDKShared8422af433e1bf486Plan.Enterprise,
                "hobby" => AutoSDKShared8422af433e1bf486Plan.Hobby,
                "pro" => AutoSDKShared8422af433e1bf486Plan.Pro,
                _ => null,
            };
        }
    }
}