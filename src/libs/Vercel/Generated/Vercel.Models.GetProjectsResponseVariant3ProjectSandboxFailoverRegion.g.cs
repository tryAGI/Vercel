
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSandboxFailoverRegion
    {
        /// <summary>
        ///
        /// </summary>
        Cdg1,
        /// <summary>
        ///
        /// </summary>
        Cle1,
        /// <summary>
        ///
        /// </summary>
        Iad1,
        /// <summary>
        ///
        /// </summary>
        Sfo1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSandboxFailoverRegion value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cdg1 => "cdg1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cle1 => "cle1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Iad1 => "iad1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cdg1,
                "cle1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cle1,
                "iad1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Iad1,
                "sfo1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}