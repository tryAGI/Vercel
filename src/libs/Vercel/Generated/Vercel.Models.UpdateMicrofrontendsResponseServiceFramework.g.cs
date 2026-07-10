
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Framework slug, when the service has one (omitted otherwise).
    /// </summary>
    public enum UpdateMicrofrontendsResponseServiceFramework
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
    public static class UpdateMicrofrontendsResponseServiceFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseServiceFramework value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseServiceFramework.ActixWeb => "actix-web",
                UpdateMicrofrontendsResponseServiceFramework.Angular => "angular",
                UpdateMicrofrontendsResponseServiceFramework.Ash => "ash",
                UpdateMicrofrontendsResponseServiceFramework.Astro => "astro",
                UpdateMicrofrontendsResponseServiceFramework.Axum => "axum",
                UpdateMicrofrontendsResponseServiceFramework.Blitzjs => "blitzjs",
                UpdateMicrofrontendsResponseServiceFramework.Brunch => "brunch",
                UpdateMicrofrontendsResponseServiceFramework.Bun => "bun",
                UpdateMicrofrontendsResponseServiceFramework.Container => "container",
                UpdateMicrofrontendsResponseServiceFramework.CreateReactApp => "create-react-app",
                UpdateMicrofrontendsResponseServiceFramework.Django => "django",
                UpdateMicrofrontendsResponseServiceFramework.Docusaurus => "docusaurus",
                UpdateMicrofrontendsResponseServiceFramework.Docusaurus2 => "docusaurus-2",
                UpdateMicrofrontendsResponseServiceFramework.Dojo => "dojo",
                UpdateMicrofrontendsResponseServiceFramework.Eleventy => "eleventy",
                UpdateMicrofrontendsResponseServiceFramework.Elysia => "elysia",
                UpdateMicrofrontendsResponseServiceFramework.Ember => "ember",
                UpdateMicrofrontendsResponseServiceFramework.Eve => "eve",
                UpdateMicrofrontendsResponseServiceFramework.Express => "express",
                UpdateMicrofrontendsResponseServiceFramework.Fastapi => "fastapi",
                UpdateMicrofrontendsResponseServiceFramework.Fasthtml => "fasthtml",
                UpdateMicrofrontendsResponseServiceFramework.Fastify => "fastify",
                UpdateMicrofrontendsResponseServiceFramework.Flask => "flask",
                UpdateMicrofrontendsResponseServiceFramework.Gatsby => "gatsby",
                UpdateMicrofrontendsResponseServiceFramework.Go => "go",
                UpdateMicrofrontendsResponseServiceFramework.Gridsome => "gridsome",
                UpdateMicrofrontendsResponseServiceFramework.H3 => "h3",
                UpdateMicrofrontendsResponseServiceFramework.Hexo => "hexo",
                UpdateMicrofrontendsResponseServiceFramework.Hono => "hono",
                UpdateMicrofrontendsResponseServiceFramework.Hugo => "hugo",
                UpdateMicrofrontendsResponseServiceFramework.Hydrogen => "hydrogen",
                UpdateMicrofrontendsResponseServiceFramework.IonicAngular => "ionic-angular",
                UpdateMicrofrontendsResponseServiceFramework.IonicReact => "ionic-react",
                UpdateMicrofrontendsResponseServiceFramework.Jekyll => "jekyll",
                UpdateMicrofrontendsResponseServiceFramework.Koa => "koa",
                UpdateMicrofrontendsResponseServiceFramework.Mastra => "mastra",
                UpdateMicrofrontendsResponseServiceFramework.Middleman => "middleman",
                UpdateMicrofrontendsResponseServiceFramework.Nestjs => "nestjs",
                UpdateMicrofrontendsResponseServiceFramework.Nextjs => "nextjs",
                UpdateMicrofrontendsResponseServiceFramework.Nitro => "nitro",
                UpdateMicrofrontendsResponseServiceFramework.Node => "node",
                UpdateMicrofrontendsResponseServiceFramework.Nuxtjs => "nuxtjs",
                UpdateMicrofrontendsResponseServiceFramework.Parcel => "parcel",
                UpdateMicrofrontendsResponseServiceFramework.Polymer => "polymer",
                UpdateMicrofrontendsResponseServiceFramework.Preact => "preact",
                UpdateMicrofrontendsResponseServiceFramework.Python => "python",
                UpdateMicrofrontendsResponseServiceFramework.ReactRouter => "react-router",
                UpdateMicrofrontendsResponseServiceFramework.Redwoodjs => "redwoodjs",
                UpdateMicrofrontendsResponseServiceFramework.Remix => "remix",
                UpdateMicrofrontendsResponseServiceFramework.Ruby => "ruby",
                UpdateMicrofrontendsResponseServiceFramework.Rust => "rust",
                UpdateMicrofrontendsResponseServiceFramework.Saber => "saber",
                UpdateMicrofrontendsResponseServiceFramework.Sanity => "sanity",
                UpdateMicrofrontendsResponseServiceFramework.SanityV2 => "sanity-v2",
                UpdateMicrofrontendsResponseServiceFramework.Sapper => "sapper",
                UpdateMicrofrontendsResponseServiceFramework.Scully => "scully",
                UpdateMicrofrontendsResponseServiceFramework.Services => "services",
                UpdateMicrofrontendsResponseServiceFramework.Solidstart => "solidstart",
                UpdateMicrofrontendsResponseServiceFramework.Solidstart1 => "solidstart-1",
                UpdateMicrofrontendsResponseServiceFramework.Stencil => "stencil",
                UpdateMicrofrontendsResponseServiceFramework.Storybook => "storybook",
                UpdateMicrofrontendsResponseServiceFramework.Svelte => "svelte",
                UpdateMicrofrontendsResponseServiceFramework.Sveltekit => "sveltekit",
                UpdateMicrofrontendsResponseServiceFramework.Sveltekit1 => "sveltekit-1",
                UpdateMicrofrontendsResponseServiceFramework.TanstackStart => "tanstack-start",
                UpdateMicrofrontendsResponseServiceFramework.TanstackStartLovable => "tanstack-start-lovable",
                UpdateMicrofrontendsResponseServiceFramework.Umijs => "umijs",
                UpdateMicrofrontendsResponseServiceFramework.Vite => "vite",
                UpdateMicrofrontendsResponseServiceFramework.Vitepress => "vitepress",
                UpdateMicrofrontendsResponseServiceFramework.Vue => "vue",
                UpdateMicrofrontendsResponseServiceFramework.Vuepress => "vuepress",
                UpdateMicrofrontendsResponseServiceFramework.Xmcp => "xmcp",
                UpdateMicrofrontendsResponseServiceFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseServiceFramework? ToEnum(string value)
        {
            return value switch
            {
                "actix-web" => UpdateMicrofrontendsResponseServiceFramework.ActixWeb,
                "angular" => UpdateMicrofrontendsResponseServiceFramework.Angular,
                "ash" => UpdateMicrofrontendsResponseServiceFramework.Ash,
                "astro" => UpdateMicrofrontendsResponseServiceFramework.Astro,
                "axum" => UpdateMicrofrontendsResponseServiceFramework.Axum,
                "blitzjs" => UpdateMicrofrontendsResponseServiceFramework.Blitzjs,
                "brunch" => UpdateMicrofrontendsResponseServiceFramework.Brunch,
                "bun" => UpdateMicrofrontendsResponseServiceFramework.Bun,
                "container" => UpdateMicrofrontendsResponseServiceFramework.Container,
                "create-react-app" => UpdateMicrofrontendsResponseServiceFramework.CreateReactApp,
                "django" => UpdateMicrofrontendsResponseServiceFramework.Django,
                "docusaurus" => UpdateMicrofrontendsResponseServiceFramework.Docusaurus,
                "docusaurus-2" => UpdateMicrofrontendsResponseServiceFramework.Docusaurus2,
                "dojo" => UpdateMicrofrontendsResponseServiceFramework.Dojo,
                "eleventy" => UpdateMicrofrontendsResponseServiceFramework.Eleventy,
                "elysia" => UpdateMicrofrontendsResponseServiceFramework.Elysia,
                "ember" => UpdateMicrofrontendsResponseServiceFramework.Ember,
                "eve" => UpdateMicrofrontendsResponseServiceFramework.Eve,
                "express" => UpdateMicrofrontendsResponseServiceFramework.Express,
                "fastapi" => UpdateMicrofrontendsResponseServiceFramework.Fastapi,
                "fasthtml" => UpdateMicrofrontendsResponseServiceFramework.Fasthtml,
                "fastify" => UpdateMicrofrontendsResponseServiceFramework.Fastify,
                "flask" => UpdateMicrofrontendsResponseServiceFramework.Flask,
                "gatsby" => UpdateMicrofrontendsResponseServiceFramework.Gatsby,
                "go" => UpdateMicrofrontendsResponseServiceFramework.Go,
                "gridsome" => UpdateMicrofrontendsResponseServiceFramework.Gridsome,
                "h3" => UpdateMicrofrontendsResponseServiceFramework.H3,
                "hexo" => UpdateMicrofrontendsResponseServiceFramework.Hexo,
                "hono" => UpdateMicrofrontendsResponseServiceFramework.Hono,
                "hugo" => UpdateMicrofrontendsResponseServiceFramework.Hugo,
                "hydrogen" => UpdateMicrofrontendsResponseServiceFramework.Hydrogen,
                "ionic-angular" => UpdateMicrofrontendsResponseServiceFramework.IonicAngular,
                "ionic-react" => UpdateMicrofrontendsResponseServiceFramework.IonicReact,
                "jekyll" => UpdateMicrofrontendsResponseServiceFramework.Jekyll,
                "koa" => UpdateMicrofrontendsResponseServiceFramework.Koa,
                "mastra" => UpdateMicrofrontendsResponseServiceFramework.Mastra,
                "middleman" => UpdateMicrofrontendsResponseServiceFramework.Middleman,
                "nestjs" => UpdateMicrofrontendsResponseServiceFramework.Nestjs,
                "nextjs" => UpdateMicrofrontendsResponseServiceFramework.Nextjs,
                "nitro" => UpdateMicrofrontendsResponseServiceFramework.Nitro,
                "node" => UpdateMicrofrontendsResponseServiceFramework.Node,
                "nuxtjs" => UpdateMicrofrontendsResponseServiceFramework.Nuxtjs,
                "parcel" => UpdateMicrofrontendsResponseServiceFramework.Parcel,
                "polymer" => UpdateMicrofrontendsResponseServiceFramework.Polymer,
                "preact" => UpdateMicrofrontendsResponseServiceFramework.Preact,
                "python" => UpdateMicrofrontendsResponseServiceFramework.Python,
                "react-router" => UpdateMicrofrontendsResponseServiceFramework.ReactRouter,
                "redwoodjs" => UpdateMicrofrontendsResponseServiceFramework.Redwoodjs,
                "remix" => UpdateMicrofrontendsResponseServiceFramework.Remix,
                "ruby" => UpdateMicrofrontendsResponseServiceFramework.Ruby,
                "rust" => UpdateMicrofrontendsResponseServiceFramework.Rust,
                "saber" => UpdateMicrofrontendsResponseServiceFramework.Saber,
                "sanity" => UpdateMicrofrontendsResponseServiceFramework.Sanity,
                "sanity-v2" => UpdateMicrofrontendsResponseServiceFramework.SanityV2,
                "sapper" => UpdateMicrofrontendsResponseServiceFramework.Sapper,
                "scully" => UpdateMicrofrontendsResponseServiceFramework.Scully,
                "services" => UpdateMicrofrontendsResponseServiceFramework.Services,
                "solidstart" => UpdateMicrofrontendsResponseServiceFramework.Solidstart,
                "solidstart-1" => UpdateMicrofrontendsResponseServiceFramework.Solidstart1,
                "stencil" => UpdateMicrofrontendsResponseServiceFramework.Stencil,
                "storybook" => UpdateMicrofrontendsResponseServiceFramework.Storybook,
                "svelte" => UpdateMicrofrontendsResponseServiceFramework.Svelte,
                "sveltekit" => UpdateMicrofrontendsResponseServiceFramework.Sveltekit,
                "sveltekit-1" => UpdateMicrofrontendsResponseServiceFramework.Sveltekit1,
                "tanstack-start" => UpdateMicrofrontendsResponseServiceFramework.TanstackStart,
                "tanstack-start-lovable" => UpdateMicrofrontendsResponseServiceFramework.TanstackStartLovable,
                "umijs" => UpdateMicrofrontendsResponseServiceFramework.Umijs,
                "vite" => UpdateMicrofrontendsResponseServiceFramework.Vite,
                "vitepress" => UpdateMicrofrontendsResponseServiceFramework.Vitepress,
                "vue" => UpdateMicrofrontendsResponseServiceFramework.Vue,
                "vuepress" => UpdateMicrofrontendsResponseServiceFramework.Vuepress,
                "xmcp" => UpdateMicrofrontendsResponseServiceFramework.Xmcp,
                "zola" => UpdateMicrofrontendsResponseServiceFramework.Zola,
                _ => null,
            };
        }
    }
}