
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportResourceRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Onboarding,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Resumed,
        /// <summary>
        /// 
        /// </summary>
        Suspended,
        /// <summary>
        /// 
        /// </summary>
        Uninstalled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportResourceRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportResourceRequestStatus value)
        {
            return value switch
            {
                ImportResourceRequestStatus.Error => "error",
                ImportResourceRequestStatus.Onboarding => "onboarding",
                ImportResourceRequestStatus.Pending => "pending",
                ImportResourceRequestStatus.Ready => "ready",
                ImportResourceRequestStatus.Resumed => "resumed",
                ImportResourceRequestStatus.Suspended => "suspended",
                ImportResourceRequestStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportResourceRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ImportResourceRequestStatus.Error,
                "onboarding" => ImportResourceRequestStatus.Onboarding,
                "pending" => ImportResourceRequestStatus.Pending,
                "ready" => ImportResourceRequestStatus.Ready,
                "resumed" => ImportResourceRequestStatus.Resumed,
                "suspended" => ImportResourceRequestStatus.Suspended,
                "uninstalled" => ImportResourceRequestStatus.Uninstalled,
                _ => null,
            };
        }
    }
}