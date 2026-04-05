
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Purchasing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseStatus value)
        {
            return value switch
            {
                GetOrderResponseStatus.Completed => "completed",
                GetOrderResponseStatus.Draft => "draft",
                GetOrderResponseStatus.Failed => "failed",
                GetOrderResponseStatus.Purchasing => "purchasing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetOrderResponseStatus.Completed,
                "draft" => GetOrderResponseStatus.Draft,
                "failed" => GetOrderResponseStatus.Failed,
                "purchasing" => GetOrderResponseStatus.Purchasing,
                _ => null,
            };
        }
    }
}