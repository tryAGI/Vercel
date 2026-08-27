
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Framework slug, when the service has one (omitted otherwise).
    /// </summary>
    public enum CreateProjectResponseServiceFramework
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
    public static class CreateProjectResponseServiceFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseServiceFramework value)
        {
            return value switch
            {
                CreateProjectResponseServiceFramework.ActixWeb => "actix-web",
                CreateProjectResponseServiceFramework.Angular => "angular",
                CreateProjectResponseServiceFramework.Ash => "ash",
                CreateProjectResponseServiceFramework.Astro => "astro",
                CreateProjectResponseServiceFramework.Axum => "axum",
                CreateProjectResponseServiceFramework.Blitzjs => "blitzjs",
                CreateProjectResponseServiceFramework.Brunch => "brunch",
                CreateProjectResponseServiceFramework.Bun => "bun",
                CreateProjectResponseServiceFramework.Container => "container",
                CreateProjectResponseServiceFramework.CreateReactApp => "create-react-app",
                CreateProjectResponseServiceFramework.Django => "django",
                CreateProjectResponseServiceFramework.Docusaurus => "docusaurus",
                CreateProjectResponseServiceFramework.Docusaurus2 => "docusaurus-2",
                CreateProjectResponseServiceFramework.Dojo => "dojo",
                CreateProjectResponseServiceFramework.Eleventy => "eleventy",
                CreateProjectResponseServiceFramework.Elysia => "elysia",
                CreateProjectResponseServiceFramework.Ember => "ember",
                CreateProjectResponseServiceFramework.Eve => "eve",
                CreateProjectResponseServiceFramework.Express => "express",
                CreateProjectResponseServiceFramework.Fastapi => "fastapi",
                CreateProjectResponseServiceFramework.Fasthtml => "fasthtml",
                CreateProjectResponseServiceFramework.Fastify => "fastify",
                CreateProjectResponseServiceFramework.Flask => "flask",
                CreateProjectResponseServiceFramework.Gatsby => "gatsby",
                CreateProjectResponseServiceFramework.Go => "go",
                CreateProjectResponseServiceFramework.Gridsome => "gridsome",
                CreateProjectResponseServiceFramework.H3 => "h3",
                CreateProjectResponseServiceFramework.Hexo => "hexo",
                CreateProjectResponseServiceFramework.Hono => "hono",
                CreateProjectResponseServiceFramework.Hugo => "hugo",
                CreateProjectResponseServiceFramework.Hydrogen => "hydrogen",
                CreateProjectResponseServiceFramework.IonicAngular => "ionic-angular",
                CreateProjectResponseServiceFramework.IonicReact => "ionic-react",
                CreateProjectResponseServiceFramework.Jekyll => "jekyll",
                CreateProjectResponseServiceFramework.Koa => "koa",
                CreateProjectResponseServiceFramework.Mastra => "mastra",
                CreateProjectResponseServiceFramework.Middleman => "middleman",
                CreateProjectResponseServiceFramework.Nestjs => "nestjs",
                CreateProjectResponseServiceFramework.Nextjs => "nextjs",
                CreateProjectResponseServiceFramework.Nitro => "nitro",
                CreateProjectResponseServiceFramework.Node => "node",
                CreateProjectResponseServiceFramework.Nuxtjs => "nuxtjs",
                CreateProjectResponseServiceFramework.Parcel => "parcel",
                CreateProjectResponseServiceFramework.Polymer => "polymer",
                CreateProjectResponseServiceFramework.Preact => "preact",
                CreateProjectResponseServiceFramework.Python => "python",
                CreateProjectResponseServiceFramework.ReactRouter => "react-router",
                CreateProjectResponseServiceFramework.Redwoodjs => "redwoodjs",
                CreateProjectResponseServiceFramework.Remix => "remix",
                CreateProjectResponseServiceFramework.Ruby => "ruby",
                CreateProjectResponseServiceFramework.Rust => "rust",
                CreateProjectResponseServiceFramework.Saber => "saber",
                CreateProjectResponseServiceFramework.Sanity => "sanity",
                CreateProjectResponseServiceFramework.SanityV2 => "sanity-v2",
                CreateProjectResponseServiceFramework.Sapper => "sapper",
                CreateProjectResponseServiceFramework.Scully => "scully",
                CreateProjectResponseServiceFramework.Services => "services",
                CreateProjectResponseServiceFramework.Solidstart => "solidstart",
                CreateProjectResponseServiceFramework.Solidstart1 => "solidstart-1",
                CreateProjectResponseServiceFramework.Stencil => "stencil",
                CreateProjectResponseServiceFramework.Storybook => "storybook",
                CreateProjectResponseServiceFramework.Svelte => "svelte",
                CreateProjectResponseServiceFramework.Sveltekit => "sveltekit",
                CreateProjectResponseServiceFramework.Sveltekit1 => "sveltekit-1",
                CreateProjectResponseServiceFramework.TanstackStart => "tanstack-start",
                CreateProjectResponseServiceFramework.TanstackStartLovable => "tanstack-start-lovable",
                CreateProjectResponseServiceFramework.Umijs => "umijs",
                CreateProjectResponseServiceFramework.Vite => "vite",
                CreateProjectResponseServiceFramework.Vitepress => "vitepress",
                CreateProjectResponseServiceFramework.Vue => "vue",
                CreateProjectResponseServiceFramework.Vuepress => "vuepress",
                CreateProjectResponseServiceFramework.Xmcp => "xmcp",
                CreateProjectResponseServiceFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseServiceFramework? ToEnum(string value)
        {
            return value switch
            {
                "actix-web" => CreateProjectResponseServiceFramework.ActixWeb,
                "angular" => CreateProjectResponseServiceFramework.Angular,
                "ash" => CreateProjectResponseServiceFramework.Ash,
                "astro" => CreateProjectResponseServiceFramework.Astro,
                "axum" => CreateProjectResponseServiceFramework.Axum,
                "blitzjs" => CreateProjectResponseServiceFramework.Blitzjs,
                "brunch" => CreateProjectResponseServiceFramework.Brunch,
                "bun" => CreateProjectResponseServiceFramework.Bun,
                "container" => CreateProjectResponseServiceFramework.Container,
                "create-react-app" => CreateProjectResponseServiceFramework.CreateReactApp,
                "django" => CreateProjectResponseServiceFramework.Django,
                "docusaurus" => CreateProjectResponseServiceFramework.Docusaurus,
                "docusaurus-2" => CreateProjectResponseServiceFramework.Docusaurus2,
                "dojo" => CreateProjectResponseServiceFramework.Dojo,
                "eleventy" => CreateProjectResponseServiceFramework.Eleventy,
                "elysia" => CreateProjectResponseServiceFramework.Elysia,
                "ember" => CreateProjectResponseServiceFramework.Ember,
                "eve" => CreateProjectResponseServiceFramework.Eve,
                "express" => CreateProjectResponseServiceFramework.Express,
                "fastapi" => CreateProjectResponseServiceFramework.Fastapi,
                "fasthtml" => CreateProjectResponseServiceFramework.Fasthtml,
                "fastify" => CreateProjectResponseServiceFramework.Fastify,
                "flask" => CreateProjectResponseServiceFramework.Flask,
                "gatsby" => CreateProjectResponseServiceFramework.Gatsby,
                "go" => CreateProjectResponseServiceFramework.Go,
                "gridsome" => CreateProjectResponseServiceFramework.Gridsome,
                "h3" => CreateProjectResponseServiceFramework.H3,
                "hexo" => CreateProjectResponseServiceFramework.Hexo,
                "hono" => CreateProjectResponseServiceFramework.Hono,
                "hugo" => CreateProjectResponseServiceFramework.Hugo,
                "hydrogen" => CreateProjectResponseServiceFramework.Hydrogen,
                "ionic-angular" => CreateProjectResponseServiceFramework.IonicAngular,
                "ionic-react" => CreateProjectResponseServiceFramework.IonicReact,
                "jekyll" => CreateProjectResponseServiceFramework.Jekyll,
                "koa" => CreateProjectResponseServiceFramework.Koa,
                "mastra" => CreateProjectResponseServiceFramework.Mastra,
                "middleman" => CreateProjectResponseServiceFramework.Middleman,
                "nestjs" => CreateProjectResponseServiceFramework.Nestjs,
                "nextjs" => CreateProjectResponseServiceFramework.Nextjs,
                "nitro" => CreateProjectResponseServiceFramework.Nitro,
                "node" => CreateProjectResponseServiceFramework.Node,
                "nuxtjs" => CreateProjectResponseServiceFramework.Nuxtjs,
                "parcel" => CreateProjectResponseServiceFramework.Parcel,
                "polymer" => CreateProjectResponseServiceFramework.Polymer,
                "preact" => CreateProjectResponseServiceFramework.Preact,
                "python" => CreateProjectResponseServiceFramework.Python,
                "react-router" => CreateProjectResponseServiceFramework.ReactRouter,
                "redwoodjs" => CreateProjectResponseServiceFramework.Redwoodjs,
                "remix" => CreateProjectResponseServiceFramework.Remix,
                "ruby" => CreateProjectResponseServiceFramework.Ruby,
                "rust" => CreateProjectResponseServiceFramework.Rust,
                "saber" => CreateProjectResponseServiceFramework.Saber,
                "sanity" => CreateProjectResponseServiceFramework.Sanity,
                "sanity-v2" => CreateProjectResponseServiceFramework.SanityV2,
                "sapper" => CreateProjectResponseServiceFramework.Sapper,
                "scully" => CreateProjectResponseServiceFramework.Scully,
                "services" => CreateProjectResponseServiceFramework.Services,
                "solidstart" => CreateProjectResponseServiceFramework.Solidstart,
                "solidstart-1" => CreateProjectResponseServiceFramework.Solidstart1,
                "stencil" => CreateProjectResponseServiceFramework.Stencil,
                "storybook" => CreateProjectResponseServiceFramework.Storybook,
                "svelte" => CreateProjectResponseServiceFramework.Svelte,
                "sveltekit" => CreateProjectResponseServiceFramework.Sveltekit,
                "sveltekit-1" => CreateProjectResponseServiceFramework.Sveltekit1,
                "tanstack-start" => CreateProjectResponseServiceFramework.TanstackStart,
                "tanstack-start-lovable" => CreateProjectResponseServiceFramework.TanstackStartLovable,
                "umijs" => CreateProjectResponseServiceFramework.Umijs,
                "vite" => CreateProjectResponseServiceFramework.Vite,
                "vitepress" => CreateProjectResponseServiceFramework.Vitepress,
                "vue" => CreateProjectResponseServiceFramework.Vue,
                "vuepress" => CreateProjectResponseServiceFramework.Vuepress,
                "xmcp" => CreateProjectResponseServiceFramework.Xmcp,
                "zola" => CreateProjectResponseServiceFramework.Zola,
                _ => null,
            };
        }
    }
}