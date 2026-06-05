
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Framework slug, when the service has one (omitted otherwise).
    /// </summary>
    public enum UploadProjectAvatarResponseServiceFramework
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
    public static class UploadProjectAvatarResponseServiceFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseServiceFramework value)
        {
            return value switch
            {
                UploadProjectAvatarResponseServiceFramework.ActixWeb => "actix-web",
                UploadProjectAvatarResponseServiceFramework.Angular => "angular",
                UploadProjectAvatarResponseServiceFramework.Ash => "ash",
                UploadProjectAvatarResponseServiceFramework.Astro => "astro",
                UploadProjectAvatarResponseServiceFramework.Axum => "axum",
                UploadProjectAvatarResponseServiceFramework.Blitzjs => "blitzjs",
                UploadProjectAvatarResponseServiceFramework.Brunch => "brunch",
                UploadProjectAvatarResponseServiceFramework.CreateReactApp => "create-react-app",
                UploadProjectAvatarResponseServiceFramework.Django => "django",
                UploadProjectAvatarResponseServiceFramework.Docusaurus => "docusaurus",
                UploadProjectAvatarResponseServiceFramework.Docusaurus2 => "docusaurus-2",
                UploadProjectAvatarResponseServiceFramework.Dojo => "dojo",
                UploadProjectAvatarResponseServiceFramework.Eleventy => "eleventy",
                UploadProjectAvatarResponseServiceFramework.Elysia => "elysia",
                UploadProjectAvatarResponseServiceFramework.Ember => "ember",
                UploadProjectAvatarResponseServiceFramework.Express => "express",
                UploadProjectAvatarResponseServiceFramework.Fastapi => "fastapi",
                UploadProjectAvatarResponseServiceFramework.Fasthtml => "fasthtml",
                UploadProjectAvatarResponseServiceFramework.Fastify => "fastify",
                UploadProjectAvatarResponseServiceFramework.Flask => "flask",
                UploadProjectAvatarResponseServiceFramework.Gatsby => "gatsby",
                UploadProjectAvatarResponseServiceFramework.Go => "go",
                UploadProjectAvatarResponseServiceFramework.Gridsome => "gridsome",
                UploadProjectAvatarResponseServiceFramework.H3 => "h3",
                UploadProjectAvatarResponseServiceFramework.Hexo => "hexo",
                UploadProjectAvatarResponseServiceFramework.Hono => "hono",
                UploadProjectAvatarResponseServiceFramework.Hugo => "hugo",
                UploadProjectAvatarResponseServiceFramework.Hydrogen => "hydrogen",
                UploadProjectAvatarResponseServiceFramework.IonicAngular => "ionic-angular",
                UploadProjectAvatarResponseServiceFramework.IonicReact => "ionic-react",
                UploadProjectAvatarResponseServiceFramework.Jekyll => "jekyll",
                UploadProjectAvatarResponseServiceFramework.Koa => "koa",
                UploadProjectAvatarResponseServiceFramework.Mastra => "mastra",
                UploadProjectAvatarResponseServiceFramework.Middleman => "middleman",
                UploadProjectAvatarResponseServiceFramework.Nestjs => "nestjs",
                UploadProjectAvatarResponseServiceFramework.Nextjs => "nextjs",
                UploadProjectAvatarResponseServiceFramework.Nitro => "nitro",
                UploadProjectAvatarResponseServiceFramework.Node => "node",
                UploadProjectAvatarResponseServiceFramework.Nuxtjs => "nuxtjs",
                UploadProjectAvatarResponseServiceFramework.Parcel => "parcel",
                UploadProjectAvatarResponseServiceFramework.Polymer => "polymer",
                UploadProjectAvatarResponseServiceFramework.Preact => "preact",
                UploadProjectAvatarResponseServiceFramework.Python => "python",
                UploadProjectAvatarResponseServiceFramework.ReactRouter => "react-router",
                UploadProjectAvatarResponseServiceFramework.Redwoodjs => "redwoodjs",
                UploadProjectAvatarResponseServiceFramework.Remix => "remix",
                UploadProjectAvatarResponseServiceFramework.Ruby => "ruby",
                UploadProjectAvatarResponseServiceFramework.Rust => "rust",
                UploadProjectAvatarResponseServiceFramework.Saber => "saber",
                UploadProjectAvatarResponseServiceFramework.Sanity => "sanity",
                UploadProjectAvatarResponseServiceFramework.SanityV2 => "sanity-v2",
                UploadProjectAvatarResponseServiceFramework.Sapper => "sapper",
                UploadProjectAvatarResponseServiceFramework.Scully => "scully",
                UploadProjectAvatarResponseServiceFramework.Services => "services",
                UploadProjectAvatarResponseServiceFramework.Solidstart => "solidstart",
                UploadProjectAvatarResponseServiceFramework.Solidstart1 => "solidstart-1",
                UploadProjectAvatarResponseServiceFramework.Stencil => "stencil",
                UploadProjectAvatarResponseServiceFramework.Storybook => "storybook",
                UploadProjectAvatarResponseServiceFramework.Svelte => "svelte",
                UploadProjectAvatarResponseServiceFramework.Sveltekit => "sveltekit",
                UploadProjectAvatarResponseServiceFramework.Sveltekit1 => "sveltekit-1",
                UploadProjectAvatarResponseServiceFramework.TanstackStart => "tanstack-start",
                UploadProjectAvatarResponseServiceFramework.Umijs => "umijs",
                UploadProjectAvatarResponseServiceFramework.Vite => "vite",
                UploadProjectAvatarResponseServiceFramework.Vitepress => "vitepress",
                UploadProjectAvatarResponseServiceFramework.Vue => "vue",
                UploadProjectAvatarResponseServiceFramework.Vuepress => "vuepress",
                UploadProjectAvatarResponseServiceFramework.Xmcp => "xmcp",
                UploadProjectAvatarResponseServiceFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseServiceFramework? ToEnum(string value)
        {
            return value switch
            {
                "actix-web" => UploadProjectAvatarResponseServiceFramework.ActixWeb,
                "angular" => UploadProjectAvatarResponseServiceFramework.Angular,
                "ash" => UploadProjectAvatarResponseServiceFramework.Ash,
                "astro" => UploadProjectAvatarResponseServiceFramework.Astro,
                "axum" => UploadProjectAvatarResponseServiceFramework.Axum,
                "blitzjs" => UploadProjectAvatarResponseServiceFramework.Blitzjs,
                "brunch" => UploadProjectAvatarResponseServiceFramework.Brunch,
                "create-react-app" => UploadProjectAvatarResponseServiceFramework.CreateReactApp,
                "django" => UploadProjectAvatarResponseServiceFramework.Django,
                "docusaurus" => UploadProjectAvatarResponseServiceFramework.Docusaurus,
                "docusaurus-2" => UploadProjectAvatarResponseServiceFramework.Docusaurus2,
                "dojo" => UploadProjectAvatarResponseServiceFramework.Dojo,
                "eleventy" => UploadProjectAvatarResponseServiceFramework.Eleventy,
                "elysia" => UploadProjectAvatarResponseServiceFramework.Elysia,
                "ember" => UploadProjectAvatarResponseServiceFramework.Ember,
                "express" => UploadProjectAvatarResponseServiceFramework.Express,
                "fastapi" => UploadProjectAvatarResponseServiceFramework.Fastapi,
                "fasthtml" => UploadProjectAvatarResponseServiceFramework.Fasthtml,
                "fastify" => UploadProjectAvatarResponseServiceFramework.Fastify,
                "flask" => UploadProjectAvatarResponseServiceFramework.Flask,
                "gatsby" => UploadProjectAvatarResponseServiceFramework.Gatsby,
                "go" => UploadProjectAvatarResponseServiceFramework.Go,
                "gridsome" => UploadProjectAvatarResponseServiceFramework.Gridsome,
                "h3" => UploadProjectAvatarResponseServiceFramework.H3,
                "hexo" => UploadProjectAvatarResponseServiceFramework.Hexo,
                "hono" => UploadProjectAvatarResponseServiceFramework.Hono,
                "hugo" => UploadProjectAvatarResponseServiceFramework.Hugo,
                "hydrogen" => UploadProjectAvatarResponseServiceFramework.Hydrogen,
                "ionic-angular" => UploadProjectAvatarResponseServiceFramework.IonicAngular,
                "ionic-react" => UploadProjectAvatarResponseServiceFramework.IonicReact,
                "jekyll" => UploadProjectAvatarResponseServiceFramework.Jekyll,
                "koa" => UploadProjectAvatarResponseServiceFramework.Koa,
                "mastra" => UploadProjectAvatarResponseServiceFramework.Mastra,
                "middleman" => UploadProjectAvatarResponseServiceFramework.Middleman,
                "nestjs" => UploadProjectAvatarResponseServiceFramework.Nestjs,
                "nextjs" => UploadProjectAvatarResponseServiceFramework.Nextjs,
                "nitro" => UploadProjectAvatarResponseServiceFramework.Nitro,
                "node" => UploadProjectAvatarResponseServiceFramework.Node,
                "nuxtjs" => UploadProjectAvatarResponseServiceFramework.Nuxtjs,
                "parcel" => UploadProjectAvatarResponseServiceFramework.Parcel,
                "polymer" => UploadProjectAvatarResponseServiceFramework.Polymer,
                "preact" => UploadProjectAvatarResponseServiceFramework.Preact,
                "python" => UploadProjectAvatarResponseServiceFramework.Python,
                "react-router" => UploadProjectAvatarResponseServiceFramework.ReactRouter,
                "redwoodjs" => UploadProjectAvatarResponseServiceFramework.Redwoodjs,
                "remix" => UploadProjectAvatarResponseServiceFramework.Remix,
                "ruby" => UploadProjectAvatarResponseServiceFramework.Ruby,
                "rust" => UploadProjectAvatarResponseServiceFramework.Rust,
                "saber" => UploadProjectAvatarResponseServiceFramework.Saber,
                "sanity" => UploadProjectAvatarResponseServiceFramework.Sanity,
                "sanity-v2" => UploadProjectAvatarResponseServiceFramework.SanityV2,
                "sapper" => UploadProjectAvatarResponseServiceFramework.Sapper,
                "scully" => UploadProjectAvatarResponseServiceFramework.Scully,
                "services" => UploadProjectAvatarResponseServiceFramework.Services,
                "solidstart" => UploadProjectAvatarResponseServiceFramework.Solidstart,
                "solidstart-1" => UploadProjectAvatarResponseServiceFramework.Solidstart1,
                "stencil" => UploadProjectAvatarResponseServiceFramework.Stencil,
                "storybook" => UploadProjectAvatarResponseServiceFramework.Storybook,
                "svelte" => UploadProjectAvatarResponseServiceFramework.Svelte,
                "sveltekit" => UploadProjectAvatarResponseServiceFramework.Sveltekit,
                "sveltekit-1" => UploadProjectAvatarResponseServiceFramework.Sveltekit1,
                "tanstack-start" => UploadProjectAvatarResponseServiceFramework.TanstackStart,
                "umijs" => UploadProjectAvatarResponseServiceFramework.Umijs,
                "vite" => UploadProjectAvatarResponseServiceFramework.Vite,
                "vitepress" => UploadProjectAvatarResponseServiceFramework.Vitepress,
                "vue" => UploadProjectAvatarResponseServiceFramework.Vue,
                "vuepress" => UploadProjectAvatarResponseServiceFramework.Vuepress,
                "xmcp" => UploadProjectAvatarResponseServiceFramework.Xmcp,
                "zola" => UploadProjectAvatarResponseServiceFramework.Zola,
                _ => null,
            };
        }
    }
}