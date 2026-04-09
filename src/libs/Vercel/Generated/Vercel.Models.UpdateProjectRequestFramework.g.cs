
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The framework that is being used for this project. When `null` is used no framework is selected
    /// </summary>
    public enum UpdateProjectRequestFramework
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
    public static class UpdateProjectRequestFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestFramework value)
        {
            return value switch
            {
                UpdateProjectRequestFramework.Angular => "angular",
                UpdateProjectRequestFramework.Astro => "astro",
                UpdateProjectRequestFramework.Blitzjs => "blitzjs",
                UpdateProjectRequestFramework.Brunch => "brunch",
                UpdateProjectRequestFramework.CreateReactApp => "create-react-app",
                UpdateProjectRequestFramework.Django => "django",
                UpdateProjectRequestFramework.Docusaurus => "docusaurus",
                UpdateProjectRequestFramework.Docusaurus2 => "docusaurus-2",
                UpdateProjectRequestFramework.Dojo => "dojo",
                UpdateProjectRequestFramework.Eleventy => "eleventy",
                UpdateProjectRequestFramework.Elysia => "elysia",
                UpdateProjectRequestFramework.Ember => "ember",
                UpdateProjectRequestFramework.Express => "express",
                UpdateProjectRequestFramework.Fastapi => "fastapi",
                UpdateProjectRequestFramework.Fasthtml => "fasthtml",
                UpdateProjectRequestFramework.Fastify => "fastify",
                UpdateProjectRequestFramework.Flask => "flask",
                UpdateProjectRequestFramework.Gatsby => "gatsby",
                UpdateProjectRequestFramework.Go => "go",
                UpdateProjectRequestFramework.Gridsome => "gridsome",
                UpdateProjectRequestFramework.H3 => "h3",
                UpdateProjectRequestFramework.Hexo => "hexo",
                UpdateProjectRequestFramework.Hono => "hono",
                UpdateProjectRequestFramework.Hugo => "hugo",
                UpdateProjectRequestFramework.Hydrogen => "hydrogen",
                UpdateProjectRequestFramework.IonicAngular => "ionic-angular",
                UpdateProjectRequestFramework.IonicReact => "ionic-react",
                UpdateProjectRequestFramework.Jekyll => "jekyll",
                UpdateProjectRequestFramework.Koa => "koa",
                UpdateProjectRequestFramework.Mastra => "mastra",
                UpdateProjectRequestFramework.Middleman => "middleman",
                UpdateProjectRequestFramework.Nestjs => "nestjs",
                UpdateProjectRequestFramework.Nextjs => "nextjs",
                UpdateProjectRequestFramework.Nitro => "nitro",
                UpdateProjectRequestFramework.Node => "node",
                UpdateProjectRequestFramework.Nuxtjs => "nuxtjs",
                UpdateProjectRequestFramework.Parcel => "parcel",
                UpdateProjectRequestFramework.Polymer => "polymer",
                UpdateProjectRequestFramework.Preact => "preact",
                UpdateProjectRequestFramework.Python => "python",
                UpdateProjectRequestFramework.ReactRouter => "react-router",
                UpdateProjectRequestFramework.Redwoodjs => "redwoodjs",
                UpdateProjectRequestFramework.Remix => "remix",
                UpdateProjectRequestFramework.Ruby => "ruby",
                UpdateProjectRequestFramework.Rust => "rust",
                UpdateProjectRequestFramework.Saber => "saber",
                UpdateProjectRequestFramework.Sanity => "sanity",
                UpdateProjectRequestFramework.SanityV3 => "sanity-v3",
                UpdateProjectRequestFramework.Sapper => "sapper",
                UpdateProjectRequestFramework.Scully => "scully",
                UpdateProjectRequestFramework.Services => "services",
                UpdateProjectRequestFramework.Solidstart => "solidstart",
                UpdateProjectRequestFramework.Solidstart1 => "solidstart-1",
                UpdateProjectRequestFramework.Stencil => "stencil",
                UpdateProjectRequestFramework.Storybook => "storybook",
                UpdateProjectRequestFramework.Svelte => "svelte",
                UpdateProjectRequestFramework.Sveltekit => "sveltekit",
                UpdateProjectRequestFramework.Sveltekit1 => "sveltekit-1",
                UpdateProjectRequestFramework.TanstackStart => "tanstack-start",
                UpdateProjectRequestFramework.Umijs => "umijs",
                UpdateProjectRequestFramework.Vite => "vite",
                UpdateProjectRequestFramework.Vitepress => "vitepress",
                UpdateProjectRequestFramework.Vue => "vue",
                UpdateProjectRequestFramework.Vuepress => "vuepress",
                UpdateProjectRequestFramework.Xmcp => "xmcp",
                UpdateProjectRequestFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestFramework? ToEnum(string value)
        {
            return value switch
            {
                "angular" => UpdateProjectRequestFramework.Angular,
                "astro" => UpdateProjectRequestFramework.Astro,
                "blitzjs" => UpdateProjectRequestFramework.Blitzjs,
                "brunch" => UpdateProjectRequestFramework.Brunch,
                "create-react-app" => UpdateProjectRequestFramework.CreateReactApp,
                "django" => UpdateProjectRequestFramework.Django,
                "docusaurus" => UpdateProjectRequestFramework.Docusaurus,
                "docusaurus-2" => UpdateProjectRequestFramework.Docusaurus2,
                "dojo" => UpdateProjectRequestFramework.Dojo,
                "eleventy" => UpdateProjectRequestFramework.Eleventy,
                "elysia" => UpdateProjectRequestFramework.Elysia,
                "ember" => UpdateProjectRequestFramework.Ember,
                "express" => UpdateProjectRequestFramework.Express,
                "fastapi" => UpdateProjectRequestFramework.Fastapi,
                "fasthtml" => UpdateProjectRequestFramework.Fasthtml,
                "fastify" => UpdateProjectRequestFramework.Fastify,
                "flask" => UpdateProjectRequestFramework.Flask,
                "gatsby" => UpdateProjectRequestFramework.Gatsby,
                "go" => UpdateProjectRequestFramework.Go,
                "gridsome" => UpdateProjectRequestFramework.Gridsome,
                "h3" => UpdateProjectRequestFramework.H3,
                "hexo" => UpdateProjectRequestFramework.Hexo,
                "hono" => UpdateProjectRequestFramework.Hono,
                "hugo" => UpdateProjectRequestFramework.Hugo,
                "hydrogen" => UpdateProjectRequestFramework.Hydrogen,
                "ionic-angular" => UpdateProjectRequestFramework.IonicAngular,
                "ionic-react" => UpdateProjectRequestFramework.IonicReact,
                "jekyll" => UpdateProjectRequestFramework.Jekyll,
                "koa" => UpdateProjectRequestFramework.Koa,
                "mastra" => UpdateProjectRequestFramework.Mastra,
                "middleman" => UpdateProjectRequestFramework.Middleman,
                "nestjs" => UpdateProjectRequestFramework.Nestjs,
                "nextjs" => UpdateProjectRequestFramework.Nextjs,
                "nitro" => UpdateProjectRequestFramework.Nitro,
                "node" => UpdateProjectRequestFramework.Node,
                "nuxtjs" => UpdateProjectRequestFramework.Nuxtjs,
                "parcel" => UpdateProjectRequestFramework.Parcel,
                "polymer" => UpdateProjectRequestFramework.Polymer,
                "preact" => UpdateProjectRequestFramework.Preact,
                "python" => UpdateProjectRequestFramework.Python,
                "react-router" => UpdateProjectRequestFramework.ReactRouter,
                "redwoodjs" => UpdateProjectRequestFramework.Redwoodjs,
                "remix" => UpdateProjectRequestFramework.Remix,
                "ruby" => UpdateProjectRequestFramework.Ruby,
                "rust" => UpdateProjectRequestFramework.Rust,
                "saber" => UpdateProjectRequestFramework.Saber,
                "sanity" => UpdateProjectRequestFramework.Sanity,
                "sanity-v3" => UpdateProjectRequestFramework.SanityV3,
                "sapper" => UpdateProjectRequestFramework.Sapper,
                "scully" => UpdateProjectRequestFramework.Scully,
                "services" => UpdateProjectRequestFramework.Services,
                "solidstart" => UpdateProjectRequestFramework.Solidstart,
                "solidstart-1" => UpdateProjectRequestFramework.Solidstart1,
                "stencil" => UpdateProjectRequestFramework.Stencil,
                "storybook" => UpdateProjectRequestFramework.Storybook,
                "svelte" => UpdateProjectRequestFramework.Svelte,
                "sveltekit" => UpdateProjectRequestFramework.Sveltekit,
                "sveltekit-1" => UpdateProjectRequestFramework.Sveltekit1,
                "tanstack-start" => UpdateProjectRequestFramework.TanstackStart,
                "umijs" => UpdateProjectRequestFramework.Umijs,
                "vite" => UpdateProjectRequestFramework.Vite,
                "vitepress" => UpdateProjectRequestFramework.Vitepress,
                "vue" => UpdateProjectRequestFramework.Vue,
                "vuepress" => UpdateProjectRequestFramework.Vuepress,
                "xmcp" => UpdateProjectRequestFramework.Xmcp,
                "zola" => UpdateProjectRequestFramework.Zola,
                _ => null,
            };
        }
    }
}