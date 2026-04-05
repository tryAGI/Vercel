
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateResourceRequestStatus
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
    public static class UpdateResourceRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResourceRequestStatus value)
        {
            return value switch
            {
                UpdateResourceRequestStatus.Error => "error",
                UpdateResourceRequestStatus.Onboarding => "onboarding",
                UpdateResourceRequestStatus.Pending => "pending",
                UpdateResourceRequestStatus.Ready => "ready",
                UpdateResourceRequestStatus.Resumed => "resumed",
                UpdateResourceRequestStatus.Suspended => "suspended",
                UpdateResourceRequestStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResourceRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateResourceRequestStatus.Error,
                "onboarding" => UpdateResourceRequestStatus.Onboarding,
                "pending" => UpdateResourceRequestStatus.Pending,
                "ready" => UpdateResourceRequestStatus.Ready,
                "resumed" => UpdateResourceRequestStatus.Resumed,
                "suspended" => UpdateResourceRequestStatus.Suspended,
                "uninstalled" => UpdateResourceRequestStatus.Uninstalled,
                _ => null,
            };
        }
    }
}