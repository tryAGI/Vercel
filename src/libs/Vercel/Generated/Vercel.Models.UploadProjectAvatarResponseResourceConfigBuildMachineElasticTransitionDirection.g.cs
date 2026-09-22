
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseResourceConfigBuildMachineElasticTransitionDirection
    {
        /// <summary>
        ///
        /// </summary>
        Downgrade,
        /// <summary>
        ///
        /// </summary>
        Upgrade,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseResourceConfigBuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseResourceConfigBuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseResourceConfigBuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}