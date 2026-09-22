
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3ba4fd4930b951c7Status
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Revoking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared3ba4fd4930b951c7StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3ba4fd4930b951c7Status value)
        {
            return value switch
            {
                AutoSDKShared3ba4fd4930b951c7Status.Active => "active",
                AutoSDKShared3ba4fd4930b951c7Status.Pending => "pending",
                AutoSDKShared3ba4fd4930b951c7Status.Revoking => "revoking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3ba4fd4930b951c7Status? ToEnum(string value)
        {
            return value switch
            {
                "active" => AutoSDKShared3ba4fd4930b951c7Status.Active,
                "pending" => AutoSDKShared3ba4fd4930b951c7Status.Pending,
                "revoking" => AutoSDKShared3ba4fd4930b951c7Status.Revoking,
                _ => null,
            };
        }
    }
}