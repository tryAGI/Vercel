
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8DeliveryVariant5Target
    {
        /// <summary>
        ///
        /// </summary>
        VercelOtelTracesDb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8df5bff0bb4332b8DeliveryVariant5TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8DeliveryVariant5Target value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant5Target.VercelOtelTracesDb => "vercel-otel-traces-db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8DeliveryVariant5Target? ToEnum(string value)
        {
            return value switch
            {
                "vercel-otel-traces-db" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant5Target.VercelOtelTracesDb,
                _ => null,
            };
        }
    }
}