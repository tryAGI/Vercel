
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7524a6c3199bd963Plan
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
    public static class AutoSDKShared7524a6c3199bd963PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7524a6c3199bd963Plan value)
        {
            return value switch
            {
                AutoSDKShared7524a6c3199bd963Plan.Enterprise => "enterprise",
                AutoSDKShared7524a6c3199bd963Plan.Hobby => "hobby",
                AutoSDKShared7524a6c3199bd963Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7524a6c3199bd963Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => AutoSDKShared7524a6c3199bd963Plan.Enterprise,
                "hobby" => AutoSDKShared7524a6c3199bd963Plan.Hobby,
                "pro" => AutoSDKShared7524a6c3199bd963Plan.Pro,
                _ => null,
            };
        }
    }
}