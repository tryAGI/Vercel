
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticTransitionDirection
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
    public static class UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}