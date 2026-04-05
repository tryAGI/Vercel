
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseFramework
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
    public static class CreateProjectResponseFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseFramework value)
        {
            return value switch
            {
                CreateProjectResponseFramework.Angular => "angular",
                CreateProjectResponseFramework.Astro => "astro",
                CreateProjectResponseFramework.Blitzjs => "blitzjs",
                CreateProjectResponseFramework.Brunch => "brunch",
                CreateProjectResponseFramework.CreateReactApp => "create-react-app",
                CreateProjectResponseFramework.Django => "django",
                CreateProjectResponseFramework.Docusaurus => "docusaurus",
                CreateProjectResponseFramework.Docusaurus2 => "docusaurus-2",
                CreateProjectResponseFramework.Dojo => "dojo",
                CreateProjectResponseFramework.Eleventy => "eleventy",
                CreateProjectResponseFramework.Elysia => "elysia",
                CreateProjectResponseFramework.Ember => "ember",
                CreateProjectResponseFramework.Express => "express",
                CreateProjectResponseFramework.Fastapi => "fastapi",
                CreateProjectResponseFramework.Fasthtml => "fasthtml",
                CreateProjectResponseFramework.Fastify => "fastify",
                CreateProjectResponseFramework.Flask => "flask",
                CreateProjectResponseFramework.Gatsby => "gatsby",
                CreateProjectResponseFramework.Go => "go",
                CreateProjectResponseFramework.Gridsome => "gridsome",
                CreateProjectResponseFramework.H3 => "h3",
                CreateProjectResponseFramework.Hexo => "hexo",
                CreateProjectResponseFramework.Hono => "hono",
                CreateProjectResponseFramework.Hugo => "hugo",
                CreateProjectResponseFramework.Hydrogen => "hydrogen",
                CreateProjectResponseFramework.IonicAngular => "ionic-angular",
                CreateProjectResponseFramework.IonicReact => "ionic-react",
                CreateProjectResponseFramework.Jekyll => "jekyll",
                CreateProjectResponseFramework.Koa => "koa",
                CreateProjectResponseFramework.Middleman => "middleman",
                CreateProjectResponseFramework.Nestjs => "nestjs",
                CreateProjectResponseFramework.Nextjs => "nextjs",
                CreateProjectResponseFramework.Nitro => "nitro",
                CreateProjectResponseFramework.Node => "node",
                CreateProjectResponseFramework.Nuxtjs => "nuxtjs",
                CreateProjectResponseFramework.Parcel => "parcel",
                CreateProjectResponseFramework.Polymer => "polymer",
                CreateProjectResponseFramework.Preact => "preact",
                CreateProjectResponseFramework.Python => "python",
                CreateProjectResponseFramework.ReactRouter => "react-router",
                CreateProjectResponseFramework.Redwoodjs => "redwoodjs",
                CreateProjectResponseFramework.Remix => "remix",
                CreateProjectResponseFramework.Ruby => "ruby",
                CreateProjectResponseFramework.Rust => "rust",
                CreateProjectResponseFramework.Saber => "saber",
                CreateProjectResponseFramework.Sanity => "sanity",
                CreateProjectResponseFramework.SanityV3 => "sanity-v3",
                CreateProjectResponseFramework.Sapper => "sapper",
                CreateProjectResponseFramework.Scully => "scully",
                CreateProjectResponseFramework.Services => "services",
                CreateProjectResponseFramework.Solidstart => "solidstart",
                CreateProjectResponseFramework.Solidstart1 => "solidstart-1",
                CreateProjectResponseFramework.Stencil => "stencil",
                CreateProjectResponseFramework.Storybook => "storybook",
                CreateProjectResponseFramework.Svelte => "svelte",
                CreateProjectResponseFramework.Sveltekit => "sveltekit",
                CreateProjectResponseFramework.Sveltekit1 => "sveltekit-1",
                CreateProjectResponseFramework.TanstackStart => "tanstack-start",
                CreateProjectResponseFramework.Umijs => "umijs",
                CreateProjectResponseFramework.Vite => "vite",
                CreateProjectResponseFramework.Vitepress => "vitepress",
                CreateProjectResponseFramework.Vue => "vue",
                CreateProjectResponseFramework.Vuepress => "vuepress",
                CreateProjectResponseFramework.Xmcp => "xmcp",
                CreateProjectResponseFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseFramework? ToEnum(string value)
        {
            return value switch
            {
                "angular" => CreateProjectResponseFramework.Angular,
                "astro" => CreateProjectResponseFramework.Astro,
                "blitzjs" => CreateProjectResponseFramework.Blitzjs,
                "brunch" => CreateProjectResponseFramework.Brunch,
                "create-react-app" => CreateProjectResponseFramework.CreateReactApp,
                "django" => CreateProjectResponseFramework.Django,
                "docusaurus" => CreateProjectResponseFramework.Docusaurus,
                "docusaurus-2" => CreateProjectResponseFramework.Docusaurus2,
                "dojo" => CreateProjectResponseFramework.Dojo,
                "eleventy" => CreateProjectResponseFramework.Eleventy,
                "elysia" => CreateProjectResponseFramework.Elysia,
                "ember" => CreateProjectResponseFramework.Ember,
                "express" => CreateProjectResponseFramework.Express,
                "fastapi" => CreateProjectResponseFramework.Fastapi,
                "fasthtml" => CreateProjectResponseFramework.Fasthtml,
                "fastify" => CreateProjectResponseFramework.Fastify,
                "flask" => CreateProjectResponseFramework.Flask,
                "gatsby" => CreateProjectResponseFramework.Gatsby,
                "go" => CreateProjectResponseFramework.Go,
                "gridsome" => CreateProjectResponseFramework.Gridsome,
                "h3" => CreateProjectResponseFramework.H3,
                "hexo" => CreateProjectResponseFramework.Hexo,
                "hono" => CreateProjectResponseFramework.Hono,
                "hugo" => CreateProjectResponseFramework.Hugo,
                "hydrogen" => CreateProjectResponseFramework.Hydrogen,
                "ionic-angular" => CreateProjectResponseFramework.IonicAngular,
                "ionic-react" => CreateProjectResponseFramework.IonicReact,
                "jekyll" => CreateProjectResponseFramework.Jekyll,
                "koa" => CreateProjectResponseFramework.Koa,
                "middleman" => CreateProjectResponseFramework.Middleman,
                "nestjs" => CreateProjectResponseFramework.Nestjs,
                "nextjs" => CreateProjectResponseFramework.Nextjs,
                "nitro" => CreateProjectResponseFramework.Nitro,
                "node" => CreateProjectResponseFramework.Node,
                "nuxtjs" => CreateProjectResponseFramework.Nuxtjs,
                "parcel" => CreateProjectResponseFramework.Parcel,
                "polymer" => CreateProjectResponseFramework.Polymer,
                "preact" => CreateProjectResponseFramework.Preact,
                "python" => CreateProjectResponseFramework.Python,
                "react-router" => CreateProjectResponseFramework.ReactRouter,
                "redwoodjs" => CreateProjectResponseFramework.Redwoodjs,
                "remix" => CreateProjectResponseFramework.Remix,
                "ruby" => CreateProjectResponseFramework.Ruby,
                "rust" => CreateProjectResponseFramework.Rust,
                "saber" => CreateProjectResponseFramework.Saber,
                "sanity" => CreateProjectResponseFramework.Sanity,
                "sanity-v3" => CreateProjectResponseFramework.SanityV3,
                "sapper" => CreateProjectResponseFramework.Sapper,
                "scully" => CreateProjectResponseFramework.Scully,
                "services" => CreateProjectResponseFramework.Services,
                "solidstart" => CreateProjectResponseFramework.Solidstart,
                "solidstart-1" => CreateProjectResponseFramework.Solidstart1,
                "stencil" => CreateProjectResponseFramework.Stencil,
                "storybook" => CreateProjectResponseFramework.Storybook,
                "svelte" => CreateProjectResponseFramework.Svelte,
                "sveltekit" => CreateProjectResponseFramework.Sveltekit,
                "sveltekit-1" => CreateProjectResponseFramework.Sveltekit1,
                "tanstack-start" => CreateProjectResponseFramework.TanstackStart,
                "umijs" => CreateProjectResponseFramework.Umijs,
                "vite" => CreateProjectResponseFramework.Vite,
                "vitepress" => CreateProjectResponseFramework.Vitepress,
                "vue" => CreateProjectResponseFramework.Vue,
                "vuepress" => CreateProjectResponseFramework.Vuepress,
                "xmcp" => CreateProjectResponseFramework.Xmcp,
                "zola" => CreateProjectResponseFramework.Zola,
                _ => null,
            };
        }
    }
}