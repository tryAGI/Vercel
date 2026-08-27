
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum UploadProjectAvatarResponseServiceServiceType
    {
        /// <summary>
        ///
        /// </summary>
        Cron,
        /// <summary>
        ///
        /// </summary>
        Job,
        /// <summary>
        ///
        /// </summary>
        Web,
        /// <summary>
        ///
        /// </summary>
        Worker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseServiceServiceType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseServiceServiceType.Cron => "cron",
                UploadProjectAvatarResponseServiceServiceType.Job => "job",
                UploadProjectAvatarResponseServiceServiceType.Web => "web",
                UploadProjectAvatarResponseServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => UploadProjectAvatarResponseServiceServiceType.Cron,
                "job" => UploadProjectAvatarResponseServiceServiceType.Job,
                "web" => UploadProjectAvatarResponseServiceServiceType.Web,
                "worker" => UploadProjectAvatarResponseServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}