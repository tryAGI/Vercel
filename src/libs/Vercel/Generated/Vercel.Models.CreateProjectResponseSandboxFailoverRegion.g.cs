
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseSandboxFailoverRegion
    {
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
    public static class CreateProjectResponseSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSandboxFailoverRegion value)
        {
            return value switch
            {
                CreateProjectResponseSandboxFailoverRegion.Cle1 => "cle1",
                CreateProjectResponseSandboxFailoverRegion.Iad1 => "iad1",
                CreateProjectResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cle1" => CreateProjectResponseSandboxFailoverRegion.Cle1,
                "iad1" => CreateProjectResponseSandboxFailoverRegion.Iad1,
                "sfo1" => CreateProjectResponseSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}