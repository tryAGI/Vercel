
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Framework slug, when the service has one (omitted otherwise).
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectServiceFramework
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
        Container,
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
        TanstackStartLovable,
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
    public static class GetProjectsResponseVariant3ProjectServiceFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectServiceFramework value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectServiceFramework.ActixWeb => "actix-web",
                GetProjectsResponseVariant3ProjectServiceFramework.Angular => "angular",
                GetProjectsResponseVariant3ProjectServiceFramework.Ash => "ash",
                GetProjectsResponseVariant3ProjectServiceFramework.Astro => "astro",
                GetProjectsResponseVariant3ProjectServiceFramework.Axum => "axum",
                GetProjectsResponseVariant3ProjectServiceFramework.Blitzjs => "blitzjs",
                GetProjectsResponseVariant3ProjectServiceFramework.Brunch => "brunch",
                GetProjectsResponseVariant3ProjectServiceFramework.Bun => "bun",
                GetProjectsResponseVariant3ProjectServiceFramework.Container => "container",
                GetProjectsResponseVariant3ProjectServiceFramework.CreateReactApp => "create-react-app",
                GetProjectsResponseVariant3ProjectServiceFramework.Django => "django",
                GetProjectsResponseVariant3ProjectServiceFramework.Docusaurus => "docusaurus",
                GetProjectsResponseVariant3ProjectServiceFramework.Docusaurus2 => "docusaurus-2",
                GetProjectsResponseVariant3ProjectServiceFramework.Dojo => "dojo",
                GetProjectsResponseVariant3ProjectServiceFramework.Eleventy => "eleventy",
                GetProjectsResponseVariant3ProjectServiceFramework.Elysia => "elysia",
                GetProjectsResponseVariant3ProjectServiceFramework.Ember => "ember",
                GetProjectsResponseVariant3ProjectServiceFramework.Eve => "eve",
                GetProjectsResponseVariant3ProjectServiceFramework.Express => "express",
                GetProjectsResponseVariant3ProjectServiceFramework.Fastapi => "fastapi",
                GetProjectsResponseVariant3ProjectServiceFramework.Fasthtml => "fasthtml",
                GetProjectsResponseVariant3ProjectServiceFramework.Fastify => "fastify",
                GetProjectsResponseVariant3ProjectServiceFramework.Flask => "flask",
                GetProjectsResponseVariant3ProjectServiceFramework.Gatsby => "gatsby",
                GetProjectsResponseVariant3ProjectServiceFramework.Go => "go",
                GetProjectsResponseVariant3ProjectServiceFramework.Gridsome => "gridsome",
                GetProjectsResponseVariant3ProjectServiceFramework.H3 => "h3",
                GetProjectsResponseVariant3ProjectServiceFramework.Hexo => "hexo",
                GetProjectsResponseVariant3ProjectServiceFramework.Hono => "hono",
                GetProjectsResponseVariant3ProjectServiceFramework.Hugo => "hugo",
                GetProjectsResponseVariant3ProjectServiceFramework.Hydrogen => "hydrogen",
                GetProjectsResponseVariant3ProjectServiceFramework.IonicAngular => "ionic-angular",
                GetProjectsResponseVariant3ProjectServiceFramework.IonicReact => "ionic-react",
                GetProjectsResponseVariant3ProjectServiceFramework.Jekyll => "jekyll",
                GetProjectsResponseVariant3ProjectServiceFramework.Koa => "koa",
                GetProjectsResponseVariant3ProjectServiceFramework.Mastra => "mastra",
                GetProjectsResponseVariant3ProjectServiceFramework.Middleman => "middleman",
                GetProjectsResponseVariant3ProjectServiceFramework.Nestjs => "nestjs",
                GetProjectsResponseVariant3ProjectServiceFramework.Nextjs => "nextjs",
                GetProjectsResponseVariant3ProjectServiceFramework.Nitro => "nitro",
                GetProjectsResponseVariant3ProjectServiceFramework.Node => "node",
                GetProjectsResponseVariant3ProjectServiceFramework.Nuxtjs => "nuxtjs",
                GetProjectsResponseVariant3ProjectServiceFramework.Parcel => "parcel",
                GetProjectsResponseVariant3ProjectServiceFramework.Polymer => "polymer",
                GetProjectsResponseVariant3ProjectServiceFramework.Preact => "preact",
                GetProjectsResponseVariant3ProjectServiceFramework.Python => "python",
                GetProjectsResponseVariant3ProjectServiceFramework.ReactRouter => "react-router",
                GetProjectsResponseVariant3ProjectServiceFramework.Redwoodjs => "redwoodjs",
                GetProjectsResponseVariant3ProjectServiceFramework.Remix => "remix",
                GetProjectsResponseVariant3ProjectServiceFramework.Ruby => "ruby",
                GetProjectsResponseVariant3ProjectServiceFramework.Rust => "rust",
                GetProjectsResponseVariant3ProjectServiceFramework.Saber => "saber",
                GetProjectsResponseVariant3ProjectServiceFramework.Sanity => "sanity",
                GetProjectsResponseVariant3ProjectServiceFramework.SanityV2 => "sanity-v2",
                GetProjectsResponseVariant3ProjectServiceFramework.Sapper => "sapper",
                GetProjectsResponseVariant3ProjectServiceFramework.Scully => "scully",
                GetProjectsResponseVariant3ProjectServiceFramework.Services => "services",
                GetProjectsResponseVariant3ProjectServiceFramework.Solidstart => "solidstart",
                GetProjectsResponseVariant3ProjectServiceFramework.Solidstart1 => "solidstart-1",
                GetProjectsResponseVariant3ProjectServiceFramework.Stencil => "stencil",
                GetProjectsResponseVariant3ProjectServiceFramework.Storybook => "storybook",
                GetProjectsResponseVariant3ProjectServiceFramework.Svelte => "svelte",
                GetProjectsResponseVariant3ProjectServiceFramework.Sveltekit => "sveltekit",
                GetProjectsResponseVariant3ProjectServiceFramework.Sveltekit1 => "sveltekit-1",
                GetProjectsResponseVariant3ProjectServiceFramework.TanstackStart => "tanstack-start",
                GetProjectsResponseVariant3ProjectServiceFramework.TanstackStartLovable => "tanstack-start-lovable",
                GetProjectsResponseVariant3ProjectServiceFramework.Umijs => "umijs",
                GetProjectsResponseVariant3ProjectServiceFramework.Vite => "vite",
                GetProjectsResponseVariant3ProjectServiceFramework.Vitepress => "vitepress",
                GetProjectsResponseVariant3ProjectServiceFramework.Vue => "vue",
                GetProjectsResponseVariant3ProjectServiceFramework.Vuepress => "vuepress",
                GetProjectsResponseVariant3ProjectServiceFramework.Xmcp => "xmcp",
                GetProjectsResponseVariant3ProjectServiceFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectServiceFramework? ToEnum(string value)
        {
            return value switch
            {
                "actix-web" => GetProjectsResponseVariant3ProjectServiceFramework.ActixWeb,
                "angular" => GetProjectsResponseVariant3ProjectServiceFramework.Angular,
                "ash" => GetProjectsResponseVariant3ProjectServiceFramework.Ash,
                "astro" => GetProjectsResponseVariant3ProjectServiceFramework.Astro,
                "axum" => GetProjectsResponseVariant3ProjectServiceFramework.Axum,
                "blitzjs" => GetProjectsResponseVariant3ProjectServiceFramework.Blitzjs,
                "brunch" => GetProjectsResponseVariant3ProjectServiceFramework.Brunch,
                "bun" => GetProjectsResponseVariant3ProjectServiceFramework.Bun,
                "container" => GetProjectsResponseVariant3ProjectServiceFramework.Container,
                "create-react-app" => GetProjectsResponseVariant3ProjectServiceFramework.CreateReactApp,
                "django" => GetProjectsResponseVariant3ProjectServiceFramework.Django,
                "docusaurus" => GetProjectsResponseVariant3ProjectServiceFramework.Docusaurus,
                "docusaurus-2" => GetProjectsResponseVariant3ProjectServiceFramework.Docusaurus2,
                "dojo" => GetProjectsResponseVariant3ProjectServiceFramework.Dojo,
                "eleventy" => GetProjectsResponseVariant3ProjectServiceFramework.Eleventy,
                "elysia" => GetProjectsResponseVariant3ProjectServiceFramework.Elysia,
                "ember" => GetProjectsResponseVariant3ProjectServiceFramework.Ember,
                "eve" => GetProjectsResponseVariant3ProjectServiceFramework.Eve,
                "express" => GetProjectsResponseVariant3ProjectServiceFramework.Express,
                "fastapi" => GetProjectsResponseVariant3ProjectServiceFramework.Fastapi,
                "fasthtml" => GetProjectsResponseVariant3ProjectServiceFramework.Fasthtml,
                "fastify" => GetProjectsResponseVariant3ProjectServiceFramework.Fastify,
                "flask" => GetProjectsResponseVariant3ProjectServiceFramework.Flask,
                "gatsby" => GetProjectsResponseVariant3ProjectServiceFramework.Gatsby,
                "go" => GetProjectsResponseVariant3ProjectServiceFramework.Go,
                "gridsome" => GetProjectsResponseVariant3ProjectServiceFramework.Gridsome,
                "h3" => GetProjectsResponseVariant3ProjectServiceFramework.H3,
                "hexo" => GetProjectsResponseVariant3ProjectServiceFramework.Hexo,
                "hono" => GetProjectsResponseVariant3ProjectServiceFramework.Hono,
                "hugo" => GetProjectsResponseVariant3ProjectServiceFramework.Hugo,
                "hydrogen" => GetProjectsResponseVariant3ProjectServiceFramework.Hydrogen,
                "ionic-angular" => GetProjectsResponseVariant3ProjectServiceFramework.IonicAngular,
                "ionic-react" => GetProjectsResponseVariant3ProjectServiceFramework.IonicReact,
                "jekyll" => GetProjectsResponseVariant3ProjectServiceFramework.Jekyll,
                "koa" => GetProjectsResponseVariant3ProjectServiceFramework.Koa,
                "mastra" => GetProjectsResponseVariant3ProjectServiceFramework.Mastra,
                "middleman" => GetProjectsResponseVariant3ProjectServiceFramework.Middleman,
                "nestjs" => GetProjectsResponseVariant3ProjectServiceFramework.Nestjs,
                "nextjs" => GetProjectsResponseVariant3ProjectServiceFramework.Nextjs,
                "nitro" => GetProjectsResponseVariant3ProjectServiceFramework.Nitro,
                "node" => GetProjectsResponseVariant3ProjectServiceFramework.Node,
                "nuxtjs" => GetProjectsResponseVariant3ProjectServiceFramework.Nuxtjs,
                "parcel" => GetProjectsResponseVariant3ProjectServiceFramework.Parcel,
                "polymer" => GetProjectsResponseVariant3ProjectServiceFramework.Polymer,
                "preact" => GetProjectsResponseVariant3ProjectServiceFramework.Preact,
                "python" => GetProjectsResponseVariant3ProjectServiceFramework.Python,
                "react-router" => GetProjectsResponseVariant3ProjectServiceFramework.ReactRouter,
                "redwoodjs" => GetProjectsResponseVariant3ProjectServiceFramework.Redwoodjs,
                "remix" => GetProjectsResponseVariant3ProjectServiceFramework.Remix,
                "ruby" => GetProjectsResponseVariant3ProjectServiceFramework.Ruby,
                "rust" => GetProjectsResponseVariant3ProjectServiceFramework.Rust,
                "saber" => GetProjectsResponseVariant3ProjectServiceFramework.Saber,
                "sanity" => GetProjectsResponseVariant3ProjectServiceFramework.Sanity,
                "sanity-v2" => GetProjectsResponseVariant3ProjectServiceFramework.SanityV2,
                "sapper" => GetProjectsResponseVariant3ProjectServiceFramework.Sapper,
                "scully" => GetProjectsResponseVariant3ProjectServiceFramework.Scully,
                "services" => GetProjectsResponseVariant3ProjectServiceFramework.Services,
                "solidstart" => GetProjectsResponseVariant3ProjectServiceFramework.Solidstart,
                "solidstart-1" => GetProjectsResponseVariant3ProjectServiceFramework.Solidstart1,
                "stencil" => GetProjectsResponseVariant3ProjectServiceFramework.Stencil,
                "storybook" => GetProjectsResponseVariant3ProjectServiceFramework.Storybook,
                "svelte" => GetProjectsResponseVariant3ProjectServiceFramework.Svelte,
                "sveltekit" => GetProjectsResponseVariant3ProjectServiceFramework.Sveltekit,
                "sveltekit-1" => GetProjectsResponseVariant3ProjectServiceFramework.Sveltekit1,
                "tanstack-start" => GetProjectsResponseVariant3ProjectServiceFramework.TanstackStart,
                "tanstack-start-lovable" => GetProjectsResponseVariant3ProjectServiceFramework.TanstackStartLovable,
                "umijs" => GetProjectsResponseVariant3ProjectServiceFramework.Umijs,
                "vite" => GetProjectsResponseVariant3ProjectServiceFramework.Vite,
                "vitepress" => GetProjectsResponseVariant3ProjectServiceFramework.Vitepress,
                "vue" => GetProjectsResponseVariant3ProjectServiceFramework.Vue,
                "vuepress" => GetProjectsResponseVariant3ProjectServiceFramework.Vuepress,
                "xmcp" => GetProjectsResponseVariant3ProjectServiceFramework.Xmcp,
                "zola" => GetProjectsResponseVariant3ProjectServiceFramework.Zola,
                _ => null,
            };
        }
    }
}