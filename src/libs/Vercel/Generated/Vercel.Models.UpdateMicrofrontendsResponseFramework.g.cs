
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseFramework
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
    public static class UpdateMicrofrontendsResponseFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseFramework value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseFramework.ActixWeb => "actix-web",
                UpdateMicrofrontendsResponseFramework.Angular => "angular",
                UpdateMicrofrontendsResponseFramework.Astro => "astro",
                UpdateMicrofrontendsResponseFramework.Axum => "axum",
                UpdateMicrofrontendsResponseFramework.Blitzjs => "blitzjs",
                UpdateMicrofrontendsResponseFramework.Brunch => "brunch",
                UpdateMicrofrontendsResponseFramework.CreateReactApp => "create-react-app",
                UpdateMicrofrontendsResponseFramework.Django => "django",
                UpdateMicrofrontendsResponseFramework.Docusaurus => "docusaurus",
                UpdateMicrofrontendsResponseFramework.Docusaurus2 => "docusaurus-2",
                UpdateMicrofrontendsResponseFramework.Dojo => "dojo",
                UpdateMicrofrontendsResponseFramework.Eleventy => "eleventy",
                UpdateMicrofrontendsResponseFramework.Elysia => "elysia",
                UpdateMicrofrontendsResponseFramework.Ember => "ember",
                UpdateMicrofrontendsResponseFramework.Express => "express",
                UpdateMicrofrontendsResponseFramework.Fastapi => "fastapi",
                UpdateMicrofrontendsResponseFramework.Fasthtml => "fasthtml",
                UpdateMicrofrontendsResponseFramework.Fastify => "fastify",
                UpdateMicrofrontendsResponseFramework.Flask => "flask",
                UpdateMicrofrontendsResponseFramework.Gatsby => "gatsby",
                UpdateMicrofrontendsResponseFramework.Go => "go",
                UpdateMicrofrontendsResponseFramework.Gridsome => "gridsome",
                UpdateMicrofrontendsResponseFramework.H3 => "h3",
                UpdateMicrofrontendsResponseFramework.Hexo => "hexo",
                UpdateMicrofrontendsResponseFramework.Hono => "hono",
                UpdateMicrofrontendsResponseFramework.Hugo => "hugo",
                UpdateMicrofrontendsResponseFramework.Hydrogen => "hydrogen",
                UpdateMicrofrontendsResponseFramework.IonicAngular => "ionic-angular",
                UpdateMicrofrontendsResponseFramework.IonicReact => "ionic-react",
                UpdateMicrofrontendsResponseFramework.Jekyll => "jekyll",
                UpdateMicrofrontendsResponseFramework.Koa => "koa",
                UpdateMicrofrontendsResponseFramework.Mastra => "mastra",
                UpdateMicrofrontendsResponseFramework.Middleman => "middleman",
                UpdateMicrofrontendsResponseFramework.Nestjs => "nestjs",
                UpdateMicrofrontendsResponseFramework.Nextjs => "nextjs",
                UpdateMicrofrontendsResponseFramework.Nitro => "nitro",
                UpdateMicrofrontendsResponseFramework.Node => "node",
                UpdateMicrofrontendsResponseFramework.Nuxtjs => "nuxtjs",
                UpdateMicrofrontendsResponseFramework.Parcel => "parcel",
                UpdateMicrofrontendsResponseFramework.Polymer => "polymer",
                UpdateMicrofrontendsResponseFramework.Preact => "preact",
                UpdateMicrofrontendsResponseFramework.Python => "python",
                UpdateMicrofrontendsResponseFramework.ReactRouter => "react-router",
                UpdateMicrofrontendsResponseFramework.Redwoodjs => "redwoodjs",
                UpdateMicrofrontendsResponseFramework.Remix => "remix",
                UpdateMicrofrontendsResponseFramework.Ruby => "ruby",
                UpdateMicrofrontendsResponseFramework.Rust => "rust",
                UpdateMicrofrontendsResponseFramework.Saber => "saber",
                UpdateMicrofrontendsResponseFramework.Sanity => "sanity",
                UpdateMicrofrontendsResponseFramework.SanityV3 => "sanity-v3",
                UpdateMicrofrontendsResponseFramework.Sapper => "sapper",
                UpdateMicrofrontendsResponseFramework.Scully => "scully",
                UpdateMicrofrontendsResponseFramework.Services => "services",
                UpdateMicrofrontendsResponseFramework.Solidstart => "solidstart",
                UpdateMicrofrontendsResponseFramework.Solidstart1 => "solidstart-1",
                UpdateMicrofrontendsResponseFramework.Stencil => "stencil",
                UpdateMicrofrontendsResponseFramework.Storybook => "storybook",
                UpdateMicrofrontendsResponseFramework.Svelte => "svelte",
                UpdateMicrofrontendsResponseFramework.Sveltekit => "sveltekit",
                UpdateMicrofrontendsResponseFramework.Sveltekit1 => "sveltekit-1",
                UpdateMicrofrontendsResponseFramework.TanstackStart => "tanstack-start",
                UpdateMicrofrontendsResponseFramework.Umijs => "umijs",
                UpdateMicrofrontendsResponseFramework.Vite => "vite",
                UpdateMicrofrontendsResponseFramework.Vitepress => "vitepress",
                UpdateMicrofrontendsResponseFramework.Vue => "vue",
                UpdateMicrofrontendsResponseFramework.Vuepress => "vuepress",
                UpdateMicrofrontendsResponseFramework.Xmcp => "xmcp",
                UpdateMicrofrontendsResponseFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseFramework? ToEnum(string value)
        {
            return value switch
            {
                "actix-web" => UpdateMicrofrontendsResponseFramework.ActixWeb,
                "angular" => UpdateMicrofrontendsResponseFramework.Angular,
                "astro" => UpdateMicrofrontendsResponseFramework.Astro,
                "axum" => UpdateMicrofrontendsResponseFramework.Axum,
                "blitzjs" => UpdateMicrofrontendsResponseFramework.Blitzjs,
                "brunch" => UpdateMicrofrontendsResponseFramework.Brunch,
                "create-react-app" => UpdateMicrofrontendsResponseFramework.CreateReactApp,
                "django" => UpdateMicrofrontendsResponseFramework.Django,
                "docusaurus" => UpdateMicrofrontendsResponseFramework.Docusaurus,
                "docusaurus-2" => UpdateMicrofrontendsResponseFramework.Docusaurus2,
                "dojo" => UpdateMicrofrontendsResponseFramework.Dojo,
                "eleventy" => UpdateMicrofrontendsResponseFramework.Eleventy,
                "elysia" => UpdateMicrofrontendsResponseFramework.Elysia,
                "ember" => UpdateMicrofrontendsResponseFramework.Ember,
                "express" => UpdateMicrofrontendsResponseFramework.Express,
                "fastapi" => UpdateMicrofrontendsResponseFramework.Fastapi,
                "fasthtml" => UpdateMicrofrontendsResponseFramework.Fasthtml,
                "fastify" => UpdateMicrofrontendsResponseFramework.Fastify,
                "flask" => UpdateMicrofrontendsResponseFramework.Flask,
                "gatsby" => UpdateMicrofrontendsResponseFramework.Gatsby,
                "go" => UpdateMicrofrontendsResponseFramework.Go,
                "gridsome" => UpdateMicrofrontendsResponseFramework.Gridsome,
                "h3" => UpdateMicrofrontendsResponseFramework.H3,
                "hexo" => UpdateMicrofrontendsResponseFramework.Hexo,
                "hono" => UpdateMicrofrontendsResponseFramework.Hono,
                "hugo" => UpdateMicrofrontendsResponseFramework.Hugo,
                "hydrogen" => UpdateMicrofrontendsResponseFramework.Hydrogen,
                "ionic-angular" => UpdateMicrofrontendsResponseFramework.IonicAngular,
                "ionic-react" => UpdateMicrofrontendsResponseFramework.IonicReact,
                "jekyll" => UpdateMicrofrontendsResponseFramework.Jekyll,
                "koa" => UpdateMicrofrontendsResponseFramework.Koa,
                "mastra" => UpdateMicrofrontendsResponseFramework.Mastra,
                "middleman" => UpdateMicrofrontendsResponseFramework.Middleman,
                "nestjs" => UpdateMicrofrontendsResponseFramework.Nestjs,
                "nextjs" => UpdateMicrofrontendsResponseFramework.Nextjs,
                "nitro" => UpdateMicrofrontendsResponseFramework.Nitro,
                "node" => UpdateMicrofrontendsResponseFramework.Node,
                "nuxtjs" => UpdateMicrofrontendsResponseFramework.Nuxtjs,
                "parcel" => UpdateMicrofrontendsResponseFramework.Parcel,
                "polymer" => UpdateMicrofrontendsResponseFramework.Polymer,
                "preact" => UpdateMicrofrontendsResponseFramework.Preact,
                "python" => UpdateMicrofrontendsResponseFramework.Python,
                "react-router" => UpdateMicrofrontendsResponseFramework.ReactRouter,
                "redwoodjs" => UpdateMicrofrontendsResponseFramework.Redwoodjs,
                "remix" => UpdateMicrofrontendsResponseFramework.Remix,
                "ruby" => UpdateMicrofrontendsResponseFramework.Ruby,
                "rust" => UpdateMicrofrontendsResponseFramework.Rust,
                "saber" => UpdateMicrofrontendsResponseFramework.Saber,
                "sanity" => UpdateMicrofrontendsResponseFramework.Sanity,
                "sanity-v3" => UpdateMicrofrontendsResponseFramework.SanityV3,
                "sapper" => UpdateMicrofrontendsResponseFramework.Sapper,
                "scully" => UpdateMicrofrontendsResponseFramework.Scully,
                "services" => UpdateMicrofrontendsResponseFramework.Services,
                "solidstart" => UpdateMicrofrontendsResponseFramework.Solidstart,
                "solidstart-1" => UpdateMicrofrontendsResponseFramework.Solidstart1,
                "stencil" => UpdateMicrofrontendsResponseFramework.Stencil,
                "storybook" => UpdateMicrofrontendsResponseFramework.Storybook,
                "svelte" => UpdateMicrofrontendsResponseFramework.Svelte,
                "sveltekit" => UpdateMicrofrontendsResponseFramework.Sveltekit,
                "sveltekit-1" => UpdateMicrofrontendsResponseFramework.Sveltekit1,
                "tanstack-start" => UpdateMicrofrontendsResponseFramework.TanstackStart,
                "umijs" => UpdateMicrofrontendsResponseFramework.Umijs,
                "vite" => UpdateMicrofrontendsResponseFramework.Vite,
                "vitepress" => UpdateMicrofrontendsResponseFramework.Vitepress,
                "vue" => UpdateMicrofrontendsResponseFramework.Vue,
                "vuepress" => UpdateMicrofrontendsResponseFramework.Vuepress,
                "xmcp" => UpdateMicrofrontendsResponseFramework.Xmcp,
                "zola" => UpdateMicrofrontendsResponseFramework.Zola,
                _ => null,
            };
        }
    }
}