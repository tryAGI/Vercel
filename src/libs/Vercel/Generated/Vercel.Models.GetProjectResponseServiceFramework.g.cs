
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Framework slug, when the service has one (omitted otherwise).
    /// </summary>
    public enum GetProjectResponseServiceFramework
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
        Ash,
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
        Bun,
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
        Eve,
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
        SanityV2,
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
    public static class GetProjectResponseServiceFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseServiceFramework value)
        {
            return value switch
            {
                GetProjectResponseServiceFramework.ActixWeb => "actix-web",
                GetProjectResponseServiceFramework.Angular => "angular",
                GetProjectResponseServiceFramework.Ash => "ash",
                GetProjectResponseServiceFramework.Astro => "astro",
                GetProjectResponseServiceFramework.Axum => "axum",
                GetProjectResponseServiceFramework.Blitzjs => "blitzjs",
                GetProjectResponseServiceFramework.Brunch => "brunch",
                GetProjectResponseServiceFramework.Bun => "bun",
                GetProjectResponseServiceFramework.CreateReactApp => "create-react-app",
                GetProjectResponseServiceFramework.Django => "django",
                GetProjectResponseServiceFramework.Docusaurus => "docusaurus",
                GetProjectResponseServiceFramework.Docusaurus2 => "docusaurus-2",
                GetProjectResponseServiceFramework.Dojo => "dojo",
                GetProjectResponseServiceFramework.Eleventy => "eleventy",
                GetProjectResponseServiceFramework.Elysia => "elysia",
                GetProjectResponseServiceFramework.Ember => "ember",
                GetProjectResponseServiceFramework.Eve => "eve",
                GetProjectResponseServiceFramework.Express => "express",
                GetProjectResponseServiceFramework.Fastapi => "fastapi",
                GetProjectResponseServiceFramework.Fasthtml => "fasthtml",
                GetProjectResponseServiceFramework.Fastify => "fastify",
                GetProjectResponseServiceFramework.Flask => "flask",
                GetProjectResponseServiceFramework.Gatsby => "gatsby",
                GetProjectResponseServiceFramework.Go => "go",
                GetProjectResponseServiceFramework.Gridsome => "gridsome",
                GetProjectResponseServiceFramework.H3 => "h3",
                GetProjectResponseServiceFramework.Hexo => "hexo",
                GetProjectResponseServiceFramework.Hono => "hono",
                GetProjectResponseServiceFramework.Hugo => "hugo",
                GetProjectResponseServiceFramework.Hydrogen => "hydrogen",
                GetProjectResponseServiceFramework.IonicAngular => "ionic-angular",
                GetProjectResponseServiceFramework.IonicReact => "ionic-react",
                GetProjectResponseServiceFramework.Jekyll => "jekyll",
                GetProjectResponseServiceFramework.Koa => "koa",
                GetProjectResponseServiceFramework.Mastra => "mastra",
                GetProjectResponseServiceFramework.Middleman => "middleman",
                GetProjectResponseServiceFramework.Nestjs => "nestjs",
                GetProjectResponseServiceFramework.Nextjs => "nextjs",
                GetProjectResponseServiceFramework.Nitro => "nitro",
                GetProjectResponseServiceFramework.Node => "node",
                GetProjectResponseServiceFramework.Nuxtjs => "nuxtjs",
                GetProjectResponseServiceFramework.Parcel => "parcel",
                GetProjectResponseServiceFramework.Polymer => "polymer",
                GetProjectResponseServiceFramework.Preact => "preact",
                GetProjectResponseServiceFramework.Python => "python",
                GetProjectResponseServiceFramework.ReactRouter => "react-router",
                GetProjectResponseServiceFramework.Redwoodjs => "redwoodjs",
                GetProjectResponseServiceFramework.Remix => "remix",
                GetProjectResponseServiceFramework.Ruby => "ruby",
                GetProjectResponseServiceFramework.Rust => "rust",
                GetProjectResponseServiceFramework.Saber => "saber",
                GetProjectResponseServiceFramework.Sanity => "sanity",
                GetProjectResponseServiceFramework.SanityV2 => "sanity-v2",
                GetProjectResponseServiceFramework.Sapper => "sapper",
                GetProjectResponseServiceFramework.Scully => "scully",
                GetProjectResponseServiceFramework.Services => "services",
                GetProjectResponseServiceFramework.Solidstart => "solidstart",
                GetProjectResponseServiceFramework.Solidstart1 => "solidstart-1",
                GetProjectResponseServiceFramework.Stencil => "stencil",
                GetProjectResponseServiceFramework.Storybook => "storybook",
                GetProjectResponseServiceFramework.Svelte => "svelte",
                GetProjectResponseServiceFramework.Sveltekit => "sveltekit",
                GetProjectResponseServiceFramework.Sveltekit1 => "sveltekit-1",
                GetProjectResponseServiceFramework.TanstackStart => "tanstack-start",
                GetProjectResponseServiceFramework.Umijs => "umijs",
                GetProjectResponseServiceFramework.Vite => "vite",
                GetProjectResponseServiceFramework.Vitepress => "vitepress",
                GetProjectResponseServiceFramework.Vue => "vue",
                GetProjectResponseServiceFramework.Vuepress => "vuepress",
                GetProjectResponseServiceFramework.Xmcp => "xmcp",
                GetProjectResponseServiceFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseServiceFramework? ToEnum(string value)
        {
            return value switch
            {
                "actix-web" => GetProjectResponseServiceFramework.ActixWeb,
                "angular" => GetProjectResponseServiceFramework.Angular,
                "ash" => GetProjectResponseServiceFramework.Ash,
                "astro" => GetProjectResponseServiceFramework.Astro,
                "axum" => GetProjectResponseServiceFramework.Axum,
                "blitzjs" => GetProjectResponseServiceFramework.Blitzjs,
                "brunch" => GetProjectResponseServiceFramework.Brunch,
                "bun" => GetProjectResponseServiceFramework.Bun,
                "create-react-app" => GetProjectResponseServiceFramework.CreateReactApp,
                "django" => GetProjectResponseServiceFramework.Django,
                "docusaurus" => GetProjectResponseServiceFramework.Docusaurus,
                "docusaurus-2" => GetProjectResponseServiceFramework.Docusaurus2,
                "dojo" => GetProjectResponseServiceFramework.Dojo,
                "eleventy" => GetProjectResponseServiceFramework.Eleventy,
                "elysia" => GetProjectResponseServiceFramework.Elysia,
                "ember" => GetProjectResponseServiceFramework.Ember,
                "eve" => GetProjectResponseServiceFramework.Eve,
                "express" => GetProjectResponseServiceFramework.Express,
                "fastapi" => GetProjectResponseServiceFramework.Fastapi,
                "fasthtml" => GetProjectResponseServiceFramework.Fasthtml,
                "fastify" => GetProjectResponseServiceFramework.Fastify,
                "flask" => GetProjectResponseServiceFramework.Flask,
                "gatsby" => GetProjectResponseServiceFramework.Gatsby,
                "go" => GetProjectResponseServiceFramework.Go,
                "gridsome" => GetProjectResponseServiceFramework.Gridsome,
                "h3" => GetProjectResponseServiceFramework.H3,
                "hexo" => GetProjectResponseServiceFramework.Hexo,
                "hono" => GetProjectResponseServiceFramework.Hono,
                "hugo" => GetProjectResponseServiceFramework.Hugo,
                "hydrogen" => GetProjectResponseServiceFramework.Hydrogen,
                "ionic-angular" => GetProjectResponseServiceFramework.IonicAngular,
                "ionic-react" => GetProjectResponseServiceFramework.IonicReact,
                "jekyll" => GetProjectResponseServiceFramework.Jekyll,
                "koa" => GetProjectResponseServiceFramework.Koa,
                "mastra" => GetProjectResponseServiceFramework.Mastra,
                "middleman" => GetProjectResponseServiceFramework.Middleman,
                "nestjs" => GetProjectResponseServiceFramework.Nestjs,
                "nextjs" => GetProjectResponseServiceFramework.Nextjs,
                "nitro" => GetProjectResponseServiceFramework.Nitro,
                "node" => GetProjectResponseServiceFramework.Node,
                "nuxtjs" => GetProjectResponseServiceFramework.Nuxtjs,
                "parcel" => GetProjectResponseServiceFramework.Parcel,
                "polymer" => GetProjectResponseServiceFramework.Polymer,
                "preact" => GetProjectResponseServiceFramework.Preact,
                "python" => GetProjectResponseServiceFramework.Python,
                "react-router" => GetProjectResponseServiceFramework.ReactRouter,
                "redwoodjs" => GetProjectResponseServiceFramework.Redwoodjs,
                "remix" => GetProjectResponseServiceFramework.Remix,
                "ruby" => GetProjectResponseServiceFramework.Ruby,
                "rust" => GetProjectResponseServiceFramework.Rust,
                "saber" => GetProjectResponseServiceFramework.Saber,
                "sanity" => GetProjectResponseServiceFramework.Sanity,
                "sanity-v2" => GetProjectResponseServiceFramework.SanityV2,
                "sapper" => GetProjectResponseServiceFramework.Sapper,
                "scully" => GetProjectResponseServiceFramework.Scully,
                "services" => GetProjectResponseServiceFramework.Services,
                "solidstart" => GetProjectResponseServiceFramework.Solidstart,
                "solidstart-1" => GetProjectResponseServiceFramework.Solidstart1,
                "stencil" => GetProjectResponseServiceFramework.Stencil,
                "storybook" => GetProjectResponseServiceFramework.Storybook,
                "svelte" => GetProjectResponseServiceFramework.Svelte,
                "sveltekit" => GetProjectResponseServiceFramework.Sveltekit,
                "sveltekit-1" => GetProjectResponseServiceFramework.Sveltekit1,
                "tanstack-start" => GetProjectResponseServiceFramework.TanstackStart,
                "umijs" => GetProjectResponseServiceFramework.Umijs,
                "vite" => GetProjectResponseServiceFramework.Vite,
                "vitepress" => GetProjectResponseServiceFramework.Vitepress,
                "vue" => GetProjectResponseServiceFramework.Vue,
                "vuepress" => GetProjectResponseServiceFramework.Vuepress,
                "xmcp" => GetProjectResponseServiceFramework.Xmcp,
                "zola" => GetProjectResponseServiceFramework.Zola,
                _ => null,
            };
        }
    }
}