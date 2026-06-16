
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Framework slug, when the service has one (omitted otherwise).
    /// </summary>
    public enum UpdateProjectResponseServiceFramework
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
    public static class UpdateProjectResponseServiceFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseServiceFramework value)
        {
            return value switch
            {
                UpdateProjectResponseServiceFramework.ActixWeb => "actix-web",
                UpdateProjectResponseServiceFramework.Angular => "angular",
                UpdateProjectResponseServiceFramework.Ash => "ash",
                UpdateProjectResponseServiceFramework.Astro => "astro",
                UpdateProjectResponseServiceFramework.Axum => "axum",
                UpdateProjectResponseServiceFramework.Blitzjs => "blitzjs",
                UpdateProjectResponseServiceFramework.Brunch => "brunch",
                UpdateProjectResponseServiceFramework.Bun => "bun",
                UpdateProjectResponseServiceFramework.CreateReactApp => "create-react-app",
                UpdateProjectResponseServiceFramework.Django => "django",
                UpdateProjectResponseServiceFramework.Docusaurus => "docusaurus",
                UpdateProjectResponseServiceFramework.Docusaurus2 => "docusaurus-2",
                UpdateProjectResponseServiceFramework.Dojo => "dojo",
                UpdateProjectResponseServiceFramework.Eleventy => "eleventy",
                UpdateProjectResponseServiceFramework.Elysia => "elysia",
                UpdateProjectResponseServiceFramework.Ember => "ember",
                UpdateProjectResponseServiceFramework.Eve => "eve",
                UpdateProjectResponseServiceFramework.Express => "express",
                UpdateProjectResponseServiceFramework.Fastapi => "fastapi",
                UpdateProjectResponseServiceFramework.Fasthtml => "fasthtml",
                UpdateProjectResponseServiceFramework.Fastify => "fastify",
                UpdateProjectResponseServiceFramework.Flask => "flask",
                UpdateProjectResponseServiceFramework.Gatsby => "gatsby",
                UpdateProjectResponseServiceFramework.Go => "go",
                UpdateProjectResponseServiceFramework.Gridsome => "gridsome",
                UpdateProjectResponseServiceFramework.H3 => "h3",
                UpdateProjectResponseServiceFramework.Hexo => "hexo",
                UpdateProjectResponseServiceFramework.Hono => "hono",
                UpdateProjectResponseServiceFramework.Hugo => "hugo",
                UpdateProjectResponseServiceFramework.Hydrogen => "hydrogen",
                UpdateProjectResponseServiceFramework.IonicAngular => "ionic-angular",
                UpdateProjectResponseServiceFramework.IonicReact => "ionic-react",
                UpdateProjectResponseServiceFramework.Jekyll => "jekyll",
                UpdateProjectResponseServiceFramework.Koa => "koa",
                UpdateProjectResponseServiceFramework.Mastra => "mastra",
                UpdateProjectResponseServiceFramework.Middleman => "middleman",
                UpdateProjectResponseServiceFramework.Nestjs => "nestjs",
                UpdateProjectResponseServiceFramework.Nextjs => "nextjs",
                UpdateProjectResponseServiceFramework.Nitro => "nitro",
                UpdateProjectResponseServiceFramework.Node => "node",
                UpdateProjectResponseServiceFramework.Nuxtjs => "nuxtjs",
                UpdateProjectResponseServiceFramework.Parcel => "parcel",
                UpdateProjectResponseServiceFramework.Polymer => "polymer",
                UpdateProjectResponseServiceFramework.Preact => "preact",
                UpdateProjectResponseServiceFramework.Python => "python",
                UpdateProjectResponseServiceFramework.ReactRouter => "react-router",
                UpdateProjectResponseServiceFramework.Redwoodjs => "redwoodjs",
                UpdateProjectResponseServiceFramework.Remix => "remix",
                UpdateProjectResponseServiceFramework.Ruby => "ruby",
                UpdateProjectResponseServiceFramework.Rust => "rust",
                UpdateProjectResponseServiceFramework.Saber => "saber",
                UpdateProjectResponseServiceFramework.Sanity => "sanity",
                UpdateProjectResponseServiceFramework.SanityV2 => "sanity-v2",
                UpdateProjectResponseServiceFramework.Sapper => "sapper",
                UpdateProjectResponseServiceFramework.Scully => "scully",
                UpdateProjectResponseServiceFramework.Services => "services",
                UpdateProjectResponseServiceFramework.Solidstart => "solidstart",
                UpdateProjectResponseServiceFramework.Solidstart1 => "solidstart-1",
                UpdateProjectResponseServiceFramework.Stencil => "stencil",
                UpdateProjectResponseServiceFramework.Storybook => "storybook",
                UpdateProjectResponseServiceFramework.Svelte => "svelte",
                UpdateProjectResponseServiceFramework.Sveltekit => "sveltekit",
                UpdateProjectResponseServiceFramework.Sveltekit1 => "sveltekit-1",
                UpdateProjectResponseServiceFramework.TanstackStart => "tanstack-start",
                UpdateProjectResponseServiceFramework.Umijs => "umijs",
                UpdateProjectResponseServiceFramework.Vite => "vite",
                UpdateProjectResponseServiceFramework.Vitepress => "vitepress",
                UpdateProjectResponseServiceFramework.Vue => "vue",
                UpdateProjectResponseServiceFramework.Vuepress => "vuepress",
                UpdateProjectResponseServiceFramework.Xmcp => "xmcp",
                UpdateProjectResponseServiceFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseServiceFramework? ToEnum(string value)
        {
            return value switch
            {
                "actix-web" => UpdateProjectResponseServiceFramework.ActixWeb,
                "angular" => UpdateProjectResponseServiceFramework.Angular,
                "ash" => UpdateProjectResponseServiceFramework.Ash,
                "astro" => UpdateProjectResponseServiceFramework.Astro,
                "axum" => UpdateProjectResponseServiceFramework.Axum,
                "blitzjs" => UpdateProjectResponseServiceFramework.Blitzjs,
                "brunch" => UpdateProjectResponseServiceFramework.Brunch,
                "bun" => UpdateProjectResponseServiceFramework.Bun,
                "create-react-app" => UpdateProjectResponseServiceFramework.CreateReactApp,
                "django" => UpdateProjectResponseServiceFramework.Django,
                "docusaurus" => UpdateProjectResponseServiceFramework.Docusaurus,
                "docusaurus-2" => UpdateProjectResponseServiceFramework.Docusaurus2,
                "dojo" => UpdateProjectResponseServiceFramework.Dojo,
                "eleventy" => UpdateProjectResponseServiceFramework.Eleventy,
                "elysia" => UpdateProjectResponseServiceFramework.Elysia,
                "ember" => UpdateProjectResponseServiceFramework.Ember,
                "eve" => UpdateProjectResponseServiceFramework.Eve,
                "express" => UpdateProjectResponseServiceFramework.Express,
                "fastapi" => UpdateProjectResponseServiceFramework.Fastapi,
                "fasthtml" => UpdateProjectResponseServiceFramework.Fasthtml,
                "fastify" => UpdateProjectResponseServiceFramework.Fastify,
                "flask" => UpdateProjectResponseServiceFramework.Flask,
                "gatsby" => UpdateProjectResponseServiceFramework.Gatsby,
                "go" => UpdateProjectResponseServiceFramework.Go,
                "gridsome" => UpdateProjectResponseServiceFramework.Gridsome,
                "h3" => UpdateProjectResponseServiceFramework.H3,
                "hexo" => UpdateProjectResponseServiceFramework.Hexo,
                "hono" => UpdateProjectResponseServiceFramework.Hono,
                "hugo" => UpdateProjectResponseServiceFramework.Hugo,
                "hydrogen" => UpdateProjectResponseServiceFramework.Hydrogen,
                "ionic-angular" => UpdateProjectResponseServiceFramework.IonicAngular,
                "ionic-react" => UpdateProjectResponseServiceFramework.IonicReact,
                "jekyll" => UpdateProjectResponseServiceFramework.Jekyll,
                "koa" => UpdateProjectResponseServiceFramework.Koa,
                "mastra" => UpdateProjectResponseServiceFramework.Mastra,
                "middleman" => UpdateProjectResponseServiceFramework.Middleman,
                "nestjs" => UpdateProjectResponseServiceFramework.Nestjs,
                "nextjs" => UpdateProjectResponseServiceFramework.Nextjs,
                "nitro" => UpdateProjectResponseServiceFramework.Nitro,
                "node" => UpdateProjectResponseServiceFramework.Node,
                "nuxtjs" => UpdateProjectResponseServiceFramework.Nuxtjs,
                "parcel" => UpdateProjectResponseServiceFramework.Parcel,
                "polymer" => UpdateProjectResponseServiceFramework.Polymer,
                "preact" => UpdateProjectResponseServiceFramework.Preact,
                "python" => UpdateProjectResponseServiceFramework.Python,
                "react-router" => UpdateProjectResponseServiceFramework.ReactRouter,
                "redwoodjs" => UpdateProjectResponseServiceFramework.Redwoodjs,
                "remix" => UpdateProjectResponseServiceFramework.Remix,
                "ruby" => UpdateProjectResponseServiceFramework.Ruby,
                "rust" => UpdateProjectResponseServiceFramework.Rust,
                "saber" => UpdateProjectResponseServiceFramework.Saber,
                "sanity" => UpdateProjectResponseServiceFramework.Sanity,
                "sanity-v2" => UpdateProjectResponseServiceFramework.SanityV2,
                "sapper" => UpdateProjectResponseServiceFramework.Sapper,
                "scully" => UpdateProjectResponseServiceFramework.Scully,
                "services" => UpdateProjectResponseServiceFramework.Services,
                "solidstart" => UpdateProjectResponseServiceFramework.Solidstart,
                "solidstart-1" => UpdateProjectResponseServiceFramework.Solidstart1,
                "stencil" => UpdateProjectResponseServiceFramework.Stencil,
                "storybook" => UpdateProjectResponseServiceFramework.Storybook,
                "svelte" => UpdateProjectResponseServiceFramework.Svelte,
                "sveltekit" => UpdateProjectResponseServiceFramework.Sveltekit,
                "sveltekit-1" => UpdateProjectResponseServiceFramework.Sveltekit1,
                "tanstack-start" => UpdateProjectResponseServiceFramework.TanstackStart,
                "umijs" => UpdateProjectResponseServiceFramework.Umijs,
                "vite" => UpdateProjectResponseServiceFramework.Vite,
                "vitepress" => UpdateProjectResponseServiceFramework.Vitepress,
                "vue" => UpdateProjectResponseServiceFramework.Vue,
                "vuepress" => UpdateProjectResponseServiceFramework.Vuepress,
                "xmcp" => UpdateProjectResponseServiceFramework.Xmcp,
                "zola" => UpdateProjectResponseServiceFramework.Zola,
                _ => null,
            };
        }
    }
}