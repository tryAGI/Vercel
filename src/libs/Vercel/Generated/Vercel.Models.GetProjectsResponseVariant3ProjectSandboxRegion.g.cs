
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSandboxRegion
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
    public static class GetProjectsResponseVariant3ProjectSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSandboxRegion value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSandboxRegion.Cdg1 => "cdg1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Cle1 => "cle1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Iad1 => "iad1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => GetProjectsResponseVariant3ProjectSandboxRegion.Cdg1,
                "cle1" => GetProjectsResponseVariant3ProjectSandboxRegion.Cle1,
                "iad1" => GetProjectsResponseVariant3ProjectSandboxRegion.Iad1,
                "sfo1" => GetProjectsResponseVariant3ProjectSandboxRegion.Sfo1,
                _ => null,
            };
        }
    }
}