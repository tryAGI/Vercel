
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The framework that is being used for this project. When `null` is used no framework is selected
    /// </summary>
    public enum CreateProjectRequestFramework
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
    public static class CreateProjectRequestFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestFramework value)
        {
            return value switch
            {
                CreateProjectRequestFramework.Angular => "angular",
                CreateProjectRequestFramework.Astro => "astro",
                CreateProjectRequestFramework.Blitzjs => "blitzjs",
                CreateProjectRequestFramework.Brunch => "brunch",
                CreateProjectRequestFramework.CreateReactApp => "create-react-app",
                CreateProjectRequestFramework.Django => "django",
                CreateProjectRequestFramework.Docusaurus => "docusaurus",
                CreateProjectRequestFramework.Docusaurus2 => "docusaurus-2",
                CreateProjectRequestFramework.Dojo => "dojo",
                CreateProjectRequestFramework.Eleventy => "eleventy",
                CreateProjectRequestFramework.Elysia => "elysia",
                CreateProjectRequestFramework.Ember => "ember",
                CreateProjectRequestFramework.Express => "express",
                CreateProjectRequestFramework.Fastapi => "fastapi",
                CreateProjectRequestFramework.Fasthtml => "fasthtml",
                CreateProjectRequestFramework.Fastify => "fastify",
                CreateProjectRequestFramework.Flask => "flask",
                CreateProjectRequestFramework.Gatsby => "gatsby",
                CreateProjectRequestFramework.Go => "go",
                CreateProjectRequestFramework.Gridsome => "gridsome",
                CreateProjectRequestFramework.H3 => "h3",
                CreateProjectRequestFramework.Hexo => "hexo",
                CreateProjectRequestFramework.Hono => "hono",
                CreateProjectRequestFramework.Hugo => "hugo",
                CreateProjectRequestFramework.Hydrogen => "hydrogen",
                CreateProjectRequestFramework.IonicAngular => "ionic-angular",
                CreateProjectRequestFramework.IonicReact => "ionic-react",
                CreateProjectRequestFramework.Jekyll => "jekyll",
                CreateProjectRequestFramework.Koa => "koa",
                CreateProjectRequestFramework.Middleman => "middleman",
                CreateProjectRequestFramework.Nestjs => "nestjs",
                CreateProjectRequestFramework.Nextjs => "nextjs",
                CreateProjectRequestFramework.Nitro => "nitro",
                CreateProjectRequestFramework.Node => "node",
                CreateProjectRequestFramework.Nuxtjs => "nuxtjs",
                CreateProjectRequestFramework.Parcel => "parcel",
                CreateProjectRequestFramework.Polymer => "polymer",
                CreateProjectRequestFramework.Preact => "preact",
                CreateProjectRequestFramework.Python => "python",
                CreateProjectRequestFramework.ReactRouter => "react-router",
                CreateProjectRequestFramework.Redwoodjs => "redwoodjs",
                CreateProjectRequestFramework.Remix => "remix",
                CreateProjectRequestFramework.Ruby => "ruby",
                CreateProjectRequestFramework.Rust => "rust",
                CreateProjectRequestFramework.Saber => "saber",
                CreateProjectRequestFramework.Sanity => "sanity",
                CreateProjectRequestFramework.SanityV3 => "sanity-v3",
                CreateProjectRequestFramework.Sapper => "sapper",
                CreateProjectRequestFramework.Scully => "scully",
                CreateProjectRequestFramework.Services => "services",
                CreateProjectRequestFramework.Solidstart => "solidstart",
                CreateProjectRequestFramework.Solidstart1 => "solidstart-1",
                CreateProjectRequestFramework.Stencil => "stencil",
                CreateProjectRequestFramework.Storybook => "storybook",
                CreateProjectRequestFramework.Svelte => "svelte",
                CreateProjectRequestFramework.Sveltekit => "sveltekit",
                CreateProjectRequestFramework.Sveltekit1 => "sveltekit-1",
                CreateProjectRequestFramework.TanstackStart => "tanstack-start",
                CreateProjectRequestFramework.Umijs => "umijs",
                CreateProjectRequestFramework.Vite => "vite",
                CreateProjectRequestFramework.Vitepress => "vitepress",
                CreateProjectRequestFramework.Vue => "vue",
                CreateProjectRequestFramework.Vuepress => "vuepress",
                CreateProjectRequestFramework.Xmcp => "xmcp",
                CreateProjectRequestFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestFramework? ToEnum(string value)
        {
            return value switch
            {
                "angular" => CreateProjectRequestFramework.Angular,
                "astro" => CreateProjectRequestFramework.Astro,
                "blitzjs" => CreateProjectRequestFramework.Blitzjs,
                "brunch" => CreateProjectRequestFramework.Brunch,
                "create-react-app" => CreateProjectRequestFramework.CreateReactApp,
                "django" => CreateProjectRequestFramework.Django,
                "docusaurus" => CreateProjectRequestFramework.Docusaurus,
                "docusaurus-2" => CreateProjectRequestFramework.Docusaurus2,
                "dojo" => CreateProjectRequestFramework.Dojo,
                "eleventy" => CreateProjectRequestFramework.Eleventy,
                "elysia" => CreateProjectRequestFramework.Elysia,
                "ember" => CreateProjectRequestFramework.Ember,
                "express" => CreateProjectRequestFramework.Express,
                "fastapi" => CreateProjectRequestFramework.Fastapi,
                "fasthtml" => CreateProjectRequestFramework.Fasthtml,
                "fastify" => CreateProjectRequestFramework.Fastify,
                "flask" => CreateProjectRequestFramework.Flask,
                "gatsby" => CreateProjectRequestFramework.Gatsby,
                "go" => CreateProjectRequestFramework.Go,
                "gridsome" => CreateProjectRequestFramework.Gridsome,
                "h3" => CreateProjectRequestFramework.H3,
                "hexo" => CreateProjectRequestFramework.Hexo,
                "hono" => CreateProjectRequestFramework.Hono,
                "hugo" => CreateProjectRequestFramework.Hugo,
                "hydrogen" => CreateProjectRequestFramework.Hydrogen,
                "ionic-angular" => CreateProjectRequestFramework.IonicAngular,
                "ionic-react" => CreateProjectRequestFramework.IonicReact,
                "jekyll" => CreateProjectRequestFramework.Jekyll,
                "koa" => CreateProjectRequestFramework.Koa,
                "middleman" => CreateProjectRequestFramework.Middleman,
                "nestjs" => CreateProjectRequestFramework.Nestjs,
                "nextjs" => CreateProjectRequestFramework.Nextjs,
                "nitro" => CreateProjectRequestFramework.Nitro,
                "node" => CreateProjectRequestFramework.Node,
                "nuxtjs" => CreateProjectRequestFramework.Nuxtjs,
                "parcel" => CreateProjectRequestFramework.Parcel,
                "polymer" => CreateProjectRequestFramework.Polymer,
                "preact" => CreateProjectRequestFramework.Preact,
                "python" => CreateProjectRequestFramework.Python,
                "react-router" => CreateProjectRequestFramework.ReactRouter,
                "redwoodjs" => CreateProjectRequestFramework.Redwoodjs,
                "remix" => CreateProjectRequestFramework.Remix,
                "ruby" => CreateProjectRequestFramework.Ruby,
                "rust" => CreateProjectRequestFramework.Rust,
                "saber" => CreateProjectRequestFramework.Saber,
                "sanity" => CreateProjectRequestFramework.Sanity,
                "sanity-v3" => CreateProjectRequestFramework.SanityV3,
                "sapper" => CreateProjectRequestFramework.Sapper,
                "scully" => CreateProjectRequestFramework.Scully,
                "services" => CreateProjectRequestFramework.Services,
                "solidstart" => CreateProjectRequestFramework.Solidstart,
                "solidstart-1" => CreateProjectRequestFramework.Solidstart1,
                "stencil" => CreateProjectRequestFramework.Stencil,
                "storybook" => CreateProjectRequestFramework.Storybook,
                "svelte" => CreateProjectRequestFramework.Svelte,
                "sveltekit" => CreateProjectRequestFramework.Sveltekit,
                "sveltekit-1" => CreateProjectRequestFramework.Sveltekit1,
                "tanstack-start" => CreateProjectRequestFramework.TanstackStart,
                "umijs" => CreateProjectRequestFramework.Umijs,
                "vite" => CreateProjectRequestFramework.Vite,
                "vitepress" => CreateProjectRequestFramework.Vitepress,
                "vue" => CreateProjectRequestFramework.Vue,
                "vuepress" => CreateProjectRequestFramework.Vuepress,
                "xmcp" => CreateProjectRequestFramework.Xmcp,
                "zola" => CreateProjectRequestFramework.Zola,
                _ => null,
            };
        }
    }
}