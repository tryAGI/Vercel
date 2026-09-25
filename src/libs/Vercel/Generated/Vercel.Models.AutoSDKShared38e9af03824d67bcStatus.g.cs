
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared38e9af03824d67bcStatus
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
    public static class AutoSDKShared38e9af03824d67bcStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared38e9af03824d67bcStatus value)
        {
            return value switch
            {
                AutoSDKShared38e9af03824d67bcStatus.Active => "active",
                AutoSDKShared38e9af03824d67bcStatus.Pending => "pending",
                AutoSDKShared38e9af03824d67bcStatus.Revoking => "revoking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared38e9af03824d67bcStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AutoSDKShared38e9af03824d67bcStatus.Active,
                "pending" => AutoSDKShared38e9af03824d67bcStatus.Pending,
                "revoking" => AutoSDKShared38e9af03824d67bcStatus.Revoking,
                _ => null,
            };
        }
    }
}