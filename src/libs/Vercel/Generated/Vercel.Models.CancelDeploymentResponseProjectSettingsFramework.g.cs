
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseProjectSettingsFramework
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
    public static class CancelDeploymentResponseProjectSettingsFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseProjectSettingsFramework value)
        {
            return value switch
            {
                CancelDeploymentResponseProjectSettingsFramework.Angular => "angular",
                CancelDeploymentResponseProjectSettingsFramework.Astro => "astro",
                CancelDeploymentResponseProjectSettingsFramework.Blitzjs => "blitzjs",
                CancelDeploymentResponseProjectSettingsFramework.Brunch => "brunch",
                CancelDeploymentResponseProjectSettingsFramework.CreateReactApp => "create-react-app",
                CancelDeploymentResponseProjectSettingsFramework.Django => "django",
                CancelDeploymentResponseProjectSettingsFramework.Docusaurus => "docusaurus",
                CancelDeploymentResponseProjectSettingsFramework.Docusaurus2 => "docusaurus-2",
                CancelDeploymentResponseProjectSettingsFramework.Dojo => "dojo",
                CancelDeploymentResponseProjectSettingsFramework.Eleventy => "eleventy",
                CancelDeploymentResponseProjectSettingsFramework.Elysia => "elysia",
                CancelDeploymentResponseProjectSettingsFramework.Ember => "ember",
                CancelDeploymentResponseProjectSettingsFramework.Express => "express",
                CancelDeploymentResponseProjectSettingsFramework.Fastapi => "fastapi",
                CancelDeploymentResponseProjectSettingsFramework.Fasthtml => "fasthtml",
                CancelDeploymentResponseProjectSettingsFramework.Fastify => "fastify",
                CancelDeploymentResponseProjectSettingsFramework.Flask => "flask",
                CancelDeploymentResponseProjectSettingsFramework.Gatsby => "gatsby",
                CancelDeploymentResponseProjectSettingsFramework.Go => "go",
                CancelDeploymentResponseProjectSettingsFramework.Gridsome => "gridsome",
                CancelDeploymentResponseProjectSettingsFramework.H3 => "h3",
                CancelDeploymentResponseProjectSettingsFramework.Hexo => "hexo",
                CancelDeploymentResponseProjectSettingsFramework.Hono => "hono",
                CancelDeploymentResponseProjectSettingsFramework.Hugo => "hugo",
                CancelDeploymentResponseProjectSettingsFramework.Hydrogen => "hydrogen",
                CancelDeploymentResponseProjectSettingsFramework.IonicAngular => "ionic-angular",
                CancelDeploymentResponseProjectSettingsFramework.IonicReact => "ionic-react",
                CancelDeploymentResponseProjectSettingsFramework.Jekyll => "jekyll",
                CancelDeploymentResponseProjectSettingsFramework.Koa => "koa",
                CancelDeploymentResponseProjectSettingsFramework.Middleman => "middleman",
                CancelDeploymentResponseProjectSettingsFramework.Nestjs => "nestjs",
                CancelDeploymentResponseProjectSettingsFramework.Nextjs => "nextjs",
                CancelDeploymentResponseProjectSettingsFramework.Nitro => "nitro",
                CancelDeploymentResponseProjectSettingsFramework.Node => "node",
                CancelDeploymentResponseProjectSettingsFramework.Nuxtjs => "nuxtjs",
                CancelDeploymentResponseProjectSettingsFramework.Parcel => "parcel",
                CancelDeploymentResponseProjectSettingsFramework.Polymer => "polymer",
                CancelDeploymentResponseProjectSettingsFramework.Preact => "preact",
                CancelDeploymentResponseProjectSettingsFramework.Python => "python",
                CancelDeploymentResponseProjectSettingsFramework.ReactRouter => "react-router",
                CancelDeploymentResponseProjectSettingsFramework.Redwoodjs => "redwoodjs",
                CancelDeploymentResponseProjectSettingsFramework.Remix => "remix",
                CancelDeploymentResponseProjectSettingsFramework.Ruby => "ruby",
                CancelDeploymentResponseProjectSettingsFramework.Rust => "rust",
                CancelDeploymentResponseProjectSettingsFramework.Saber => "saber",
                CancelDeploymentResponseProjectSettingsFramework.Sanity => "sanity",
                CancelDeploymentResponseProjectSettingsFramework.SanityV3 => "sanity-v3",
                CancelDeploymentResponseProjectSettingsFramework.Sapper => "sapper",
                CancelDeploymentResponseProjectSettingsFramework.Scully => "scully",
                CancelDeploymentResponseProjectSettingsFramework.Services => "services",
                CancelDeploymentResponseProjectSettingsFramework.Solidstart => "solidstart",
                CancelDeploymentResponseProjectSettingsFramework.Solidstart1 => "solidstart-1",
                CancelDeploymentResponseProjectSettingsFramework.Stencil => "stencil",
                CancelDeploymentResponseProjectSettingsFramework.Storybook => "storybook",
                CancelDeploymentResponseProjectSettingsFramework.Svelte => "svelte",
                CancelDeploymentResponseProjectSettingsFramework.Sveltekit => "sveltekit",
                CancelDeploymentResponseProjectSettingsFramework.Sveltekit1 => "sveltekit-1",
                CancelDeploymentResponseProjectSettingsFramework.TanstackStart => "tanstack-start",
                CancelDeploymentResponseProjectSettingsFramework.Umijs => "umijs",
                CancelDeploymentResponseProjectSettingsFramework.Vite => "vite",
                CancelDeploymentResponseProjectSettingsFramework.Vitepress => "vitepress",
                CancelDeploymentResponseProjectSettingsFramework.Vue => "vue",
                CancelDeploymentResponseProjectSettingsFramework.Vuepress => "vuepress",
                CancelDeploymentResponseProjectSettingsFramework.Xmcp => "xmcp",
                CancelDeploymentResponseProjectSettingsFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseProjectSettingsFramework? ToEnum(string value)
        {
            return value switch
            {
                "angular" => CancelDeploymentResponseProjectSettingsFramework.Angular,
                "astro" => CancelDeploymentResponseProjectSettingsFramework.Astro,
                "blitzjs" => CancelDeploymentResponseProjectSettingsFramework.Blitzjs,
                "brunch" => CancelDeploymentResponseProjectSettingsFramework.Brunch,
                "create-react-app" => CancelDeploymentResponseProjectSettingsFramework.CreateReactApp,
                "django" => CancelDeploymentResponseProjectSettingsFramework.Django,
                "docusaurus" => CancelDeploymentResponseProjectSettingsFramework.Docusaurus,
                "docusaurus-2" => CancelDeploymentResponseProjectSettingsFramework.Docusaurus2,
                "dojo" => CancelDeploymentResponseProjectSettingsFramework.Dojo,
                "eleventy" => CancelDeploymentResponseProjectSettingsFramework.Eleventy,
                "elysia" => CancelDeploymentResponseProjectSettingsFramework.Elysia,
                "ember" => CancelDeploymentResponseProjectSettingsFramework.Ember,
                "express" => CancelDeploymentResponseProjectSettingsFramework.Express,
                "fastapi" => CancelDeploymentResponseProjectSettingsFramework.Fastapi,
                "fasthtml" => CancelDeploymentResponseProjectSettingsFramework.Fasthtml,
                "fastify" => CancelDeploymentResponseProjectSettingsFramework.Fastify,
                "flask" => CancelDeploymentResponseProjectSettingsFramework.Flask,
                "gatsby" => CancelDeploymentResponseProjectSettingsFramework.Gatsby,
                "go" => CancelDeploymentResponseProjectSettingsFramework.Go,
                "gridsome" => CancelDeploymentResponseProjectSettingsFramework.Gridsome,
                "h3" => CancelDeploymentResponseProjectSettingsFramework.H3,
                "hexo" => CancelDeploymentResponseProjectSettingsFramework.Hexo,
                "hono" => CancelDeploymentResponseProjectSettingsFramework.Hono,
                "hugo" => CancelDeploymentResponseProjectSettingsFramework.Hugo,
                "hydrogen" => CancelDeploymentResponseProjectSettingsFramework.Hydrogen,
                "ionic-angular" => CancelDeploymentResponseProjectSettingsFramework.IonicAngular,
                "ionic-react" => CancelDeploymentResponseProjectSettingsFramework.IonicReact,
                "jekyll" => CancelDeploymentResponseProjectSettingsFramework.Jekyll,
                "koa" => CancelDeploymentResponseProjectSettingsFramework.Koa,
                "middleman" => CancelDeploymentResponseProjectSettingsFramework.Middleman,
                "nestjs" => CancelDeploymentResponseProjectSettingsFramework.Nestjs,
                "nextjs" => CancelDeploymentResponseProjectSettingsFramework.Nextjs,
                "nitro" => CancelDeploymentResponseProjectSettingsFramework.Nitro,
                "node" => CancelDeploymentResponseProjectSettingsFramework.Node,
                "nuxtjs" => CancelDeploymentResponseProjectSettingsFramework.Nuxtjs,
                "parcel" => CancelDeploymentResponseProjectSettingsFramework.Parcel,
                "polymer" => CancelDeploymentResponseProjectSettingsFramework.Polymer,
                "preact" => CancelDeploymentResponseProjectSettingsFramework.Preact,
                "python" => CancelDeploymentResponseProjectSettingsFramework.Python,
                "react-router" => CancelDeploymentResponseProjectSettingsFramework.ReactRouter,
                "redwoodjs" => CancelDeploymentResponseProjectSettingsFramework.Redwoodjs,
                "remix" => CancelDeploymentResponseProjectSettingsFramework.Remix,
                "ruby" => CancelDeploymentResponseProjectSettingsFramework.Ruby,
                "rust" => CancelDeploymentResponseProjectSettingsFramework.Rust,
                "saber" => CancelDeploymentResponseProjectSettingsFramework.Saber,
                "sanity" => CancelDeploymentResponseProjectSettingsFramework.Sanity,
                "sanity-v3" => CancelDeploymentResponseProjectSettingsFramework.SanityV3,
                "sapper" => CancelDeploymentResponseProjectSettingsFramework.Sapper,
                "scully" => CancelDeploymentResponseProjectSettingsFramework.Scully,
                "services" => CancelDeploymentResponseProjectSettingsFramework.Services,
                "solidstart" => CancelDeploymentResponseProjectSettingsFramework.Solidstart,
                "solidstart-1" => CancelDeploymentResponseProjectSettingsFramework.Solidstart1,
                "stencil" => CancelDeploymentResponseProjectSettingsFramework.Stencil,
                "storybook" => CancelDeploymentResponseProjectSettingsFramework.Storybook,
                "svelte" => CancelDeploymentResponseProjectSettingsFramework.Svelte,
                "sveltekit" => CancelDeploymentResponseProjectSettingsFramework.Sveltekit,
                "sveltekit-1" => CancelDeploymentResponseProjectSettingsFramework.Sveltekit1,
                "tanstack-start" => CancelDeploymentResponseProjectSettingsFramework.TanstackStart,
                "umijs" => CancelDeploymentResponseProjectSettingsFramework.Umijs,
                "vite" => CancelDeploymentResponseProjectSettingsFramework.Vite,
                "vitepress" => CancelDeploymentResponseProjectSettingsFramework.Vitepress,
                "vue" => CancelDeploymentResponseProjectSettingsFramework.Vue,
                "vuepress" => CancelDeploymentResponseProjectSettingsFramework.Vuepress,
                "xmcp" => CancelDeploymentResponseProjectSettingsFramework.Xmcp,
                "zola" => CancelDeploymentResponseProjectSettingsFramework.Zola,
                _ => null,
            };
        }
    }
}