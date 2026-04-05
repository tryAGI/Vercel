
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseFramework
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
    public static class UpdateProjectResponseFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseFramework value)
        {
            return value switch
            {
                UpdateProjectResponseFramework.Angular => "angular",
                UpdateProjectResponseFramework.Astro => "astro",
                UpdateProjectResponseFramework.Blitzjs => "blitzjs",
                UpdateProjectResponseFramework.Brunch => "brunch",
                UpdateProjectResponseFramework.CreateReactApp => "create-react-app",
                UpdateProjectResponseFramework.Django => "django",
                UpdateProjectResponseFramework.Docusaurus => "docusaurus",
                UpdateProjectResponseFramework.Docusaurus2 => "docusaurus-2",
                UpdateProjectResponseFramework.Dojo => "dojo",
                UpdateProjectResponseFramework.Eleventy => "eleventy",
                UpdateProjectResponseFramework.Elysia => "elysia",
                UpdateProjectResponseFramework.Ember => "ember",
                UpdateProjectResponseFramework.Express => "express",
                UpdateProjectResponseFramework.Fastapi => "fastapi",
                UpdateProjectResponseFramework.Fasthtml => "fasthtml",
                UpdateProjectResponseFramework.Fastify => "fastify",
                UpdateProjectResponseFramework.Flask => "flask",
                UpdateProjectResponseFramework.Gatsby => "gatsby",
                UpdateProjectResponseFramework.Go => "go",
                UpdateProjectResponseFramework.Gridsome => "gridsome",
                UpdateProjectResponseFramework.H3 => "h3",
                UpdateProjectResponseFramework.Hexo => "hexo",
                UpdateProjectResponseFramework.Hono => "hono",
                UpdateProjectResponseFramework.Hugo => "hugo",
                UpdateProjectResponseFramework.Hydrogen => "hydrogen",
                UpdateProjectResponseFramework.IonicAngular => "ionic-angular",
                UpdateProjectResponseFramework.IonicReact => "ionic-react",
                UpdateProjectResponseFramework.Jekyll => "jekyll",
                UpdateProjectResponseFramework.Koa => "koa",
                UpdateProjectResponseFramework.Middleman => "middleman",
                UpdateProjectResponseFramework.Nestjs => "nestjs",
                UpdateProjectResponseFramework.Nextjs => "nextjs",
                UpdateProjectResponseFramework.Nitro => "nitro",
                UpdateProjectResponseFramework.Node => "node",
                UpdateProjectResponseFramework.Nuxtjs => "nuxtjs",
                UpdateProjectResponseFramework.Parcel => "parcel",
                UpdateProjectResponseFramework.Polymer => "polymer",
                UpdateProjectResponseFramework.Preact => "preact",
                UpdateProjectResponseFramework.Python => "python",
                UpdateProjectResponseFramework.ReactRouter => "react-router",
                UpdateProjectResponseFramework.Redwoodjs => "redwoodjs",
                UpdateProjectResponseFramework.Remix => "remix",
                UpdateProjectResponseFramework.Ruby => "ruby",
                UpdateProjectResponseFramework.Rust => "rust",
                UpdateProjectResponseFramework.Saber => "saber",
                UpdateProjectResponseFramework.Sanity => "sanity",
                UpdateProjectResponseFramework.SanityV3 => "sanity-v3",
                UpdateProjectResponseFramework.Sapper => "sapper",
                UpdateProjectResponseFramework.Scully => "scully",
                UpdateProjectResponseFramework.Services => "services",
                UpdateProjectResponseFramework.Solidstart => "solidstart",
                UpdateProjectResponseFramework.Solidstart1 => "solidstart-1",
                UpdateProjectResponseFramework.Stencil => "stencil",
                UpdateProjectResponseFramework.Storybook => "storybook",
                UpdateProjectResponseFramework.Svelte => "svelte",
                UpdateProjectResponseFramework.Sveltekit => "sveltekit",
                UpdateProjectResponseFramework.Sveltekit1 => "sveltekit-1",
                UpdateProjectResponseFramework.TanstackStart => "tanstack-start",
                UpdateProjectResponseFramework.Umijs => "umijs",
                UpdateProjectResponseFramework.Vite => "vite",
                UpdateProjectResponseFramework.Vitepress => "vitepress",
                UpdateProjectResponseFramework.Vue => "vue",
                UpdateProjectResponseFramework.Vuepress => "vuepress",
                UpdateProjectResponseFramework.Xmcp => "xmcp",
                UpdateProjectResponseFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseFramework? ToEnum(string value)
        {
            return value switch
            {
                "angular" => UpdateProjectResponseFramework.Angular,
                "astro" => UpdateProjectResponseFramework.Astro,
                "blitzjs" => UpdateProjectResponseFramework.Blitzjs,
                "brunch" => UpdateProjectResponseFramework.Brunch,
                "create-react-app" => UpdateProjectResponseFramework.CreateReactApp,
                "django" => UpdateProjectResponseFramework.Django,
                "docusaurus" => UpdateProjectResponseFramework.Docusaurus,
                "docusaurus-2" => UpdateProjectResponseFramework.Docusaurus2,
                "dojo" => UpdateProjectResponseFramework.Dojo,
                "eleventy" => UpdateProjectResponseFramework.Eleventy,
                "elysia" => UpdateProjectResponseFramework.Elysia,
                "ember" => UpdateProjectResponseFramework.Ember,
                "express" => UpdateProjectResponseFramework.Express,
                "fastapi" => UpdateProjectResponseFramework.Fastapi,
                "fasthtml" => UpdateProjectResponseFramework.Fasthtml,
                "fastify" => UpdateProjectResponseFramework.Fastify,
                "flask" => UpdateProjectResponseFramework.Flask,
                "gatsby" => UpdateProjectResponseFramework.Gatsby,
                "go" => UpdateProjectResponseFramework.Go,
                "gridsome" => UpdateProjectResponseFramework.Gridsome,
                "h3" => UpdateProjectResponseFramework.H3,
                "hexo" => UpdateProjectResponseFramework.Hexo,
                "hono" => UpdateProjectResponseFramework.Hono,
                "hugo" => UpdateProjectResponseFramework.Hugo,
                "hydrogen" => UpdateProjectResponseFramework.Hydrogen,
                "ionic-angular" => UpdateProjectResponseFramework.IonicAngular,
                "ionic-react" => UpdateProjectResponseFramework.IonicReact,
                "jekyll" => UpdateProjectResponseFramework.Jekyll,
                "koa" => UpdateProjectResponseFramework.Koa,
                "middleman" => UpdateProjectResponseFramework.Middleman,
                "nestjs" => UpdateProjectResponseFramework.Nestjs,
                "nextjs" => UpdateProjectResponseFramework.Nextjs,
                "nitro" => UpdateProjectResponseFramework.Nitro,
                "node" => UpdateProjectResponseFramework.Node,
                "nuxtjs" => UpdateProjectResponseFramework.Nuxtjs,
                "parcel" => UpdateProjectResponseFramework.Parcel,
                "polymer" => UpdateProjectResponseFramework.Polymer,
                "preact" => UpdateProjectResponseFramework.Preact,
                "python" => UpdateProjectResponseFramework.Python,
                "react-router" => UpdateProjectResponseFramework.ReactRouter,
                "redwoodjs" => UpdateProjectResponseFramework.Redwoodjs,
                "remix" => UpdateProjectResponseFramework.Remix,
                "ruby" => UpdateProjectResponseFramework.Ruby,
                "rust" => UpdateProjectResponseFramework.Rust,
                "saber" => UpdateProjectResponseFramework.Saber,
                "sanity" => UpdateProjectResponseFramework.Sanity,
                "sanity-v3" => UpdateProjectResponseFramework.SanityV3,
                "sapper" => UpdateProjectResponseFramework.Sapper,
                "scully" => UpdateProjectResponseFramework.Scully,
                "services" => UpdateProjectResponseFramework.Services,
                "solidstart" => UpdateProjectResponseFramework.Solidstart,
                "solidstart-1" => UpdateProjectResponseFramework.Solidstart1,
                "stencil" => UpdateProjectResponseFramework.Stencil,
                "storybook" => UpdateProjectResponseFramework.Storybook,
                "svelte" => UpdateProjectResponseFramework.Svelte,
                "sveltekit" => UpdateProjectResponseFramework.Sveltekit,
                "sveltekit-1" => UpdateProjectResponseFramework.Sveltekit1,
                "tanstack-start" => UpdateProjectResponseFramework.TanstackStart,
                "umijs" => UpdateProjectResponseFramework.Umijs,
                "vite" => UpdateProjectResponseFramework.Vite,
                "vitepress" => UpdateProjectResponseFramework.Vitepress,
                "vue" => UpdateProjectResponseFramework.Vue,
                "vuepress" => UpdateProjectResponseFramework.Vuepress,
                "xmcp" => UpdateProjectResponseFramework.Xmcp,
                "zola" => UpdateProjectResponseFramework.Zola,
                _ => null,
            };
        }
    }
}