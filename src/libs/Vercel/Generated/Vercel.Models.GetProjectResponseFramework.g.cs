
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseFramework
    {
        /// <summary>
        /// 
        /// </summary>
        ActixWeb,
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
        Axum,
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
    public static class GetProjectResponseFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseFramework value)
        {
            return value switch
            {
                GetProjectResponseFramework.ActixWeb => "actix-web",
                GetProjectResponseFramework.Angular => "angular",
                GetProjectResponseFramework.Astro => "astro",
                GetProjectResponseFramework.Axum => "axum",
                GetProjectResponseFramework.Blitzjs => "blitzjs",
                GetProjectResponseFramework.Brunch => "brunch",
                GetProjectResponseFramework.CreateReactApp => "create-react-app",
                GetProjectResponseFramework.Django => "django",
                GetProjectResponseFramework.Docusaurus => "docusaurus",
                GetProjectResponseFramework.Docusaurus2 => "docusaurus-2",
                GetProjectResponseFramework.Dojo => "dojo",
                GetProjectResponseFramework.Eleventy => "eleventy",
                GetProjectResponseFramework.Elysia => "elysia",
                GetProjectResponseFramework.Ember => "ember",
                GetProjectResponseFramework.Express => "express",
                GetProjectResponseFramework.Fastapi => "fastapi",
                GetProjectResponseFramework.Fasthtml => "fasthtml",
                GetProjectResponseFramework.Fastify => "fastify",
                GetProjectResponseFramework.Flask => "flask",
                GetProjectResponseFramework.Gatsby => "gatsby",
                GetProjectResponseFramework.Go => "go",
                GetProjectResponseFramework.Gridsome => "gridsome",
                GetProjectResponseFramework.H3 => "h3",
                GetProjectResponseFramework.Hexo => "hexo",
                GetProjectResponseFramework.Hono => "hono",
                GetProjectResponseFramework.Hugo => "hugo",
                GetProjectResponseFramework.Hydrogen => "hydrogen",
                GetProjectResponseFramework.IonicAngular => "ionic-angular",
                GetProjectResponseFramework.IonicReact => "ionic-react",
                GetProjectResponseFramework.Jekyll => "jekyll",
                GetProjectResponseFramework.Koa => "koa",
                GetProjectResponseFramework.Mastra => "mastra",
                GetProjectResponseFramework.Middleman => "middleman",
                GetProjectResponseFramework.Nestjs => "nestjs",
                GetProjectResponseFramework.Nextjs => "nextjs",
                GetProjectResponseFramework.Nitro => "nitro",
                GetProjectResponseFramework.Node => "node",
                GetProjectResponseFramework.Nuxtjs => "nuxtjs",
                GetProjectResponseFramework.Parcel => "parcel",
                GetProjectResponseFramework.Polymer => "polymer",
                GetProjectResponseFramework.Preact => "preact",
                GetProjectResponseFramework.Python => "python",
                GetProjectResponseFramework.ReactRouter => "react-router",
                GetProjectResponseFramework.Redwoodjs => "redwoodjs",
                GetProjectResponseFramework.Remix => "remix",
                GetProjectResponseFramework.Ruby => "ruby",
                GetProjectResponseFramework.Rust => "rust",
                GetProjectResponseFramework.Saber => "saber",
                GetProjectResponseFramework.Sanity => "sanity",
                GetProjectResponseFramework.SanityV3 => "sanity-v3",
                GetProjectResponseFramework.Sapper => "sapper",
                GetProjectResponseFramework.Scully => "scully",
                GetProjectResponseFramework.Services => "services",
                GetProjectResponseFramework.Solidstart => "solidstart",
                GetProjectResponseFramework.Solidstart1 => "solidstart-1",
                GetProjectResponseFramework.Stencil => "stencil",
                GetProjectResponseFramework.Storybook => "storybook",
                GetProjectResponseFramework.Svelte => "svelte",
                GetProjectResponseFramework.Sveltekit => "sveltekit",
                GetProjectResponseFramework.Sveltekit1 => "sveltekit-1",
                GetProjectResponseFramework.TanstackStart => "tanstack-start",
                GetProjectResponseFramework.Umijs => "umijs",
                GetProjectResponseFramework.Vite => "vite",
                GetProjectResponseFramework.Vitepress => "vitepress",
                GetProjectResponseFramework.Vue => "vue",
                GetProjectResponseFramework.Vuepress => "vuepress",
                GetProjectResponseFramework.Xmcp => "xmcp",
                GetProjectResponseFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseFramework? ToEnum(string value)
        {
            return value switch
            {
                "actix-web" => GetProjectResponseFramework.ActixWeb,
                "angular" => GetProjectResponseFramework.Angular,
                "astro" => GetProjectResponseFramework.Astro,
                "axum" => GetProjectResponseFramework.Axum,
                "blitzjs" => GetProjectResponseFramework.Blitzjs,
                "brunch" => GetProjectResponseFramework.Brunch,
                "create-react-app" => GetProjectResponseFramework.CreateReactApp,
                "django" => GetProjectResponseFramework.Django,
                "docusaurus" => GetProjectResponseFramework.Docusaurus,
                "docusaurus-2" => GetProjectResponseFramework.Docusaurus2,
                "dojo" => GetProjectResponseFramework.Dojo,
                "eleventy" => GetProjectResponseFramework.Eleventy,
                "elysia" => GetProjectResponseFramework.Elysia,
                "ember" => GetProjectResponseFramework.Ember,
                "express" => GetProjectResponseFramework.Express,
                "fastapi" => GetProjectResponseFramework.Fastapi,
                "fasthtml" => GetProjectResponseFramework.Fasthtml,
                "fastify" => GetProjectResponseFramework.Fastify,
                "flask" => GetProjectResponseFramework.Flask,
                "gatsby" => GetProjectResponseFramework.Gatsby,
                "go" => GetProjectResponseFramework.Go,
                "gridsome" => GetProjectResponseFramework.Gridsome,
                "h3" => GetProjectResponseFramework.H3,
                "hexo" => GetProjectResponseFramework.Hexo,
                "hono" => GetProjectResponseFramework.Hono,
                "hugo" => GetProjectResponseFramework.Hugo,
                "hydrogen" => GetProjectResponseFramework.Hydrogen,
                "ionic-angular" => GetProjectResponseFramework.IonicAngular,
                "ionic-react" => GetProjectResponseFramework.IonicReact,
                "jekyll" => GetProjectResponseFramework.Jekyll,
                "koa" => GetProjectResponseFramework.Koa,
                "mastra" => GetProjectResponseFramework.Mastra,
                "middleman" => GetProjectResponseFramework.Middleman,
                "nestjs" => GetProjectResponseFramework.Nestjs,
                "nextjs" => GetProjectResponseFramework.Nextjs,
                "nitro" => GetProjectResponseFramework.Nitro,
                "node" => GetProjectResponseFramework.Node,
                "nuxtjs" => GetProjectResponseFramework.Nuxtjs,
                "parcel" => GetProjectResponseFramework.Parcel,
                "polymer" => GetProjectResponseFramework.Polymer,
                "preact" => GetProjectResponseFramework.Preact,
                "python" => GetProjectResponseFramework.Python,
                "react-router" => GetProjectResponseFramework.ReactRouter,
                "redwoodjs" => GetProjectResponseFramework.Redwoodjs,
                "remix" => GetProjectResponseFramework.Remix,
                "ruby" => GetProjectResponseFramework.Ruby,
                "rust" => GetProjectResponseFramework.Rust,
                "saber" => GetProjectResponseFramework.Saber,
                "sanity" => GetProjectResponseFramework.Sanity,
                "sanity-v3" => GetProjectResponseFramework.SanityV3,
                "sapper" => GetProjectResponseFramework.Sapper,
                "scully" => GetProjectResponseFramework.Scully,
                "services" => GetProjectResponseFramework.Services,
                "solidstart" => GetProjectResponseFramework.Solidstart,
                "solidstart-1" => GetProjectResponseFramework.Solidstart1,
                "stencil" => GetProjectResponseFramework.Stencil,
                "storybook" => GetProjectResponseFramework.Storybook,
                "svelte" => GetProjectResponseFramework.Svelte,
                "sveltekit" => GetProjectResponseFramework.Sveltekit,
                "sveltekit-1" => GetProjectResponseFramework.Sveltekit1,
                "tanstack-start" => GetProjectResponseFramework.TanstackStart,
                "umijs" => GetProjectResponseFramework.Umijs,
                "vite" => GetProjectResponseFramework.Vite,
                "vitepress" => GetProjectResponseFramework.Vitepress,
                "vue" => GetProjectResponseFramework.Vue,
                "vuepress" => GetProjectResponseFramework.Vuepress,
                "xmcp" => GetProjectResponseFramework.Xmcp,
                "zola" => GetProjectResponseFramework.Zola,
                _ => null,
            };
        }
    }
}