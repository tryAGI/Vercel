
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateInstallationRequestStatus
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
    public static class UpdateInstallationRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInstallationRequestStatus value)
        {
            return value switch
            {
                UpdateInstallationRequestStatus.Error => "error",
                UpdateInstallationRequestStatus.Onboarding => "onboarding",
                UpdateInstallationRequestStatus.Pending => "pending",
                UpdateInstallationRequestStatus.Ready => "ready",
                UpdateInstallationRequestStatus.Resumed => "resumed",
                UpdateInstallationRequestStatus.Suspended => "suspended",
                UpdateInstallationRequestStatus.Uninstalled => "uninstalled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInstallationRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateInstallationRequestStatus.Error,
                "onboarding" => UpdateInstallationRequestStatus.Onboarding,
                "pending" => UpdateInstallationRequestStatus.Pending,
                "ready" => UpdateInstallationRequestStatus.Ready,
                "resumed" => UpdateInstallationRequestStatus.Resumed,
                "suspended" => UpdateInstallationRequestStatus.Suspended,
                "uninstalled" => UpdateInstallationRequestStatus.Uninstalled,
                _ => null,
            };
        }
    }
}