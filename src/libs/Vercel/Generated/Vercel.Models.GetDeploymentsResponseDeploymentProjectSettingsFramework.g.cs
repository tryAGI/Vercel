
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentsResponseDeploymentProjectSettingsFramework
    {
        /// <summary>
        /// 
        /// </summary>
        Angular,
        /// <summary>
        /// 
        /// </summary>
        Astro,
        /// <summary>
        /// 
        /// </summary>
        Blitzjs,
        /// <summary>
        /// 
        /// </summary>
        Brunch,
        /// <summary>
        /// 
        /// </summary>
        CreateReactApp,
        /// <summary>
        /// 
        /// </summary>
        Django,
        /// <summary>
        /// 
        /// </summary>
        Docusaurus,
        /// <summary>
        /// 
        /// </summary>
        Docusaurus2,
        /// <summary>
        /// 
        /// </summary>
        Dojo,
        /// <summary>
        /// 
        /// </summary>
        Eleventy,
        /// <summary>
        /// 
        /// </summary>
        Elysia,
        /// <summary>
        /// 
        /// </summary>
        Ember,
        /// <summary>
        /// 
        /// </summary>
        Express,
        /// <summary>
        /// 
        /// </summary>
        Fastapi,
        /// <summary>
        /// 
        /// </summary>
        Fasthtml,
        /// <summary>
        /// 
        /// </summary>
        Fastify,
        /// <summary>
        /// 
        /// </summary>
        Flask,
        /// <summary>
        /// 
        /// </summary>
        Gatsby,
        /// <summary>
        /// 
        /// </summary>
        Go,
        /// <summary>
        /// 
        /// </summary>
        Gridsome,
        /// <summary>
        /// 
        /// </summary>
        H3,
        /// <summary>
        /// 
        /// </summary>
        Hexo,
        /// <summary>
        /// 
        /// </summary>
        Hono,
        /// <summary>
        /// 
        /// </summary>
        Hugo,
        /// <summary>
        /// 
        /// </summary>
        Hydrogen,
        /// <summary>
        /// 
        /// </summary>
        IonicAngular,
        /// <summary>
        /// 
        /// </summary>
        IonicReact,
        /// <summary>
        /// 
        /// </summary>
        Jekyll,
        /// <summary>
        /// 
        /// </summary>
        Koa,
        /// <summary>
        /// 
        /// </summary>
        Mastra,
        /// <summary>
        /// 
        /// </summary>
        Middleman,
        /// <summary>
        /// 
        /// </summary>
        Nestjs,
        /// <summary>
        /// 
        /// </summary>
        Nextjs,
        /// <summary>
        /// 
        /// </summary>
        Nitro,
        /// <summary>
        /// 
        /// </summary>
        Node,
        /// <summary>
        /// 
        /// </summary>
        Nuxtjs,
        /// <summary>
        /// 
        /// </summary>
        Parcel,
        /// <summary>
        /// 
        /// </summary>
        Polymer,
        /// <summary>
        /// 
        /// </summary>
        Preact,
        /// <summary>
        /// 
        /// </summary>
        Python,
        /// <summary>
        /// 
        /// </summary>
        ReactRouter,
        /// <summary>
        /// 
        /// </summary>
        Redwoodjs,
        /// <summary>
        /// 
        /// </summary>
        Remix,
        /// <summary>
        /// 
        /// </summary>
        Ruby,
        /// <summary>
        /// 
        /// </summary>
        Rust,
        /// <summary>
        /// 
        /// </summary>
        Saber,
        /// <summary>
        /// 
        /// </summary>
        Sanity,
        /// <summary>
        /// 
        /// </summary>
        SanityV3,
        /// <summary>
        /// 
        /// </summary>
        Sapper,
        /// <summary>
        /// 
        /// </summary>
        Scully,
        /// <summary>
        /// 
        /// </summary>
        Services,
        /// <summary>
        /// 
        /// </summary>
        Solidstart,
        /// <summary>
        /// 
        /// </summary>
        Solidstart1,
        /// <summary>
        /// 
        /// </summary>
        Stencil,
        /// <summary>
        /// 
        /// </summary>
        Storybook,
        /// <summary>
        /// 
        /// </summary>
        Svelte,
        /// <summary>
        /// 
        /// </summary>
        Sveltekit,
        /// <summary>
        /// 
        /// </summary>
        Sveltekit1,
        /// <summary>
        /// 
        /// </summary>
        TanstackStart,
        /// <summary>
        /// 
        /// </summary>
        Umijs,
        /// <summary>
        /// 
        /// </summary>
        Vite,
        /// <summary>
        /// 
        /// </summary>
        Vitepress,
        /// <summary>
        /// 
        /// </summary>
        Vue,
        /// <summary>
        /// 
        /// </summary>
        Vuepress,
        /// <summary>
        /// 
        /// </summary>
        Xmcp,
        /// <summary>
        /// 
        /// </summary>
        Zola,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentsResponseDeploymentProjectSettingsFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentProjectSettingsFramework value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Angular => "angular",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Astro => "astro",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Blitzjs => "blitzjs",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Brunch => "brunch",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.CreateReactApp => "create-react-app",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Django => "django",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Docusaurus => "docusaurus",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Docusaurus2 => "docusaurus-2",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Dojo => "dojo",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Eleventy => "eleventy",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Elysia => "elysia",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Ember => "ember",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Express => "express",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Fastapi => "fastapi",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Fasthtml => "fasthtml",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Fastify => "fastify",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Flask => "flask",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Gatsby => "gatsby",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Go => "go",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Gridsome => "gridsome",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.H3 => "h3",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Hexo => "hexo",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Hono => "hono",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Hugo => "hugo",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Hydrogen => "hydrogen",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.IonicAngular => "ionic-angular",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.IonicReact => "ionic-react",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Jekyll => "jekyll",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Koa => "koa",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Mastra => "mastra",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Middleman => "middleman",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Nestjs => "nestjs",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Nextjs => "nextjs",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Nitro => "nitro",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Node => "node",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Nuxtjs => "nuxtjs",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Parcel => "parcel",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Polymer => "polymer",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Preact => "preact",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Python => "python",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.ReactRouter => "react-router",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Redwoodjs => "redwoodjs",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Remix => "remix",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Ruby => "ruby",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Rust => "rust",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Saber => "saber",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Sanity => "sanity",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.SanityV3 => "sanity-v3",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Sapper => "sapper",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Scully => "scully",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Services => "services",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Solidstart => "solidstart",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Solidstart1 => "solidstart-1",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Stencil => "stencil",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Storybook => "storybook",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Svelte => "svelte",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Sveltekit => "sveltekit",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Sveltekit1 => "sveltekit-1",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.TanstackStart => "tanstack-start",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Umijs => "umijs",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Vite => "vite",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Vitepress => "vitepress",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Vue => "vue",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Vuepress => "vuepress",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Xmcp => "xmcp",
                GetDeploymentsResponseDeploymentProjectSettingsFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentProjectSettingsFramework? ToEnum(string value)
        {
            return value switch
            {
                "angular" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Angular,
                "astro" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Astro,
                "blitzjs" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Blitzjs,
                "brunch" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Brunch,
                "create-react-app" => GetDeploymentsResponseDeploymentProjectSettingsFramework.CreateReactApp,
                "django" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Django,
                "docusaurus" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Docusaurus,
                "docusaurus-2" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Docusaurus2,
                "dojo" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Dojo,
                "eleventy" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Eleventy,
                "elysia" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Elysia,
                "ember" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Ember,
                "express" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Express,
                "fastapi" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Fastapi,
                "fasthtml" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Fasthtml,
                "fastify" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Fastify,
                "flask" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Flask,
                "gatsby" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Gatsby,
                "go" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Go,
                "gridsome" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Gridsome,
                "h3" => GetDeploymentsResponseDeploymentProjectSettingsFramework.H3,
                "hexo" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Hexo,
                "hono" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Hono,
                "hugo" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Hugo,
                "hydrogen" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Hydrogen,
                "ionic-angular" => GetDeploymentsResponseDeploymentProjectSettingsFramework.IonicAngular,
                "ionic-react" => GetDeploymentsResponseDeploymentProjectSettingsFramework.IonicReact,
                "jekyll" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Jekyll,
                "koa" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Koa,
                "mastra" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Mastra,
                "middleman" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Middleman,
                "nestjs" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Nestjs,
                "nextjs" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Nextjs,
                "nitro" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Nitro,
                "node" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Node,
                "nuxtjs" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Nuxtjs,
                "parcel" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Parcel,
                "polymer" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Polymer,
                "preact" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Preact,
                "python" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Python,
                "react-router" => GetDeploymentsResponseDeploymentProjectSettingsFramework.ReactRouter,
                "redwoodjs" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Redwoodjs,
                "remix" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Remix,
                "ruby" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Ruby,
                "rust" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Rust,
                "saber" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Saber,
                "sanity" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Sanity,
                "sanity-v3" => GetDeploymentsResponseDeploymentProjectSettingsFramework.SanityV3,
                "sapper" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Sapper,
                "scully" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Scully,
                "services" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Services,
                "solidstart" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Solidstart,
                "solidstart-1" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Solidstart1,
                "stencil" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Stencil,
                "storybook" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Storybook,
                "svelte" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Svelte,
                "sveltekit" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Sveltekit,
                "sveltekit-1" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Sveltekit1,
                "tanstack-start" => GetDeploymentsResponseDeploymentProjectSettingsFramework.TanstackStart,
                "umijs" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Umijs,
                "vite" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Vite,
                "vitepress" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Vitepress,
                "vue" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Vue,
                "vuepress" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Vuepress,
                "xmcp" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Xmcp,
                "zola" => GetDeploymentsResponseDeploymentProjectSettingsFramework.Zola,
                _ => null,
            };
        }
    }
}