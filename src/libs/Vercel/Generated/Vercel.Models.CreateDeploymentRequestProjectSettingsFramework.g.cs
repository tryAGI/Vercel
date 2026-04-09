
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The framework that is being used for this project. When `null` is used no framework is selected
    /// </summary>
    public enum CreateDeploymentRequestProjectSettingsFramework
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
    public static class CreateDeploymentRequestProjectSettingsFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestProjectSettingsFramework value)
        {
            return value switch
            {
                CreateDeploymentRequestProjectSettingsFramework.Angular => "angular",
                CreateDeploymentRequestProjectSettingsFramework.Astro => "astro",
                CreateDeploymentRequestProjectSettingsFramework.Blitzjs => "blitzjs",
                CreateDeploymentRequestProjectSettingsFramework.Brunch => "brunch",
                CreateDeploymentRequestProjectSettingsFramework.CreateReactApp => "create-react-app",
                CreateDeploymentRequestProjectSettingsFramework.Django => "django",
                CreateDeploymentRequestProjectSettingsFramework.Docusaurus => "docusaurus",
                CreateDeploymentRequestProjectSettingsFramework.Docusaurus2 => "docusaurus-2",
                CreateDeploymentRequestProjectSettingsFramework.Dojo => "dojo",
                CreateDeploymentRequestProjectSettingsFramework.Eleventy => "eleventy",
                CreateDeploymentRequestProjectSettingsFramework.Elysia => "elysia",
                CreateDeploymentRequestProjectSettingsFramework.Ember => "ember",
                CreateDeploymentRequestProjectSettingsFramework.Express => "express",
                CreateDeploymentRequestProjectSettingsFramework.Fastapi => "fastapi",
                CreateDeploymentRequestProjectSettingsFramework.Fasthtml => "fasthtml",
                CreateDeploymentRequestProjectSettingsFramework.Fastify => "fastify",
                CreateDeploymentRequestProjectSettingsFramework.Flask => "flask",
                CreateDeploymentRequestProjectSettingsFramework.Gatsby => "gatsby",
                CreateDeploymentRequestProjectSettingsFramework.Go => "go",
                CreateDeploymentRequestProjectSettingsFramework.Gridsome => "gridsome",
                CreateDeploymentRequestProjectSettingsFramework.H3 => "h3",
                CreateDeploymentRequestProjectSettingsFramework.Hexo => "hexo",
                CreateDeploymentRequestProjectSettingsFramework.Hono => "hono",
                CreateDeploymentRequestProjectSettingsFramework.Hugo => "hugo",
                CreateDeploymentRequestProjectSettingsFramework.Hydrogen => "hydrogen",
                CreateDeploymentRequestProjectSettingsFramework.IonicAngular => "ionic-angular",
                CreateDeploymentRequestProjectSettingsFramework.IonicReact => "ionic-react",
                CreateDeploymentRequestProjectSettingsFramework.Jekyll => "jekyll",
                CreateDeploymentRequestProjectSettingsFramework.Koa => "koa",
                CreateDeploymentRequestProjectSettingsFramework.Mastra => "mastra",
                CreateDeploymentRequestProjectSettingsFramework.Middleman => "middleman",
                CreateDeploymentRequestProjectSettingsFramework.Nestjs => "nestjs",
                CreateDeploymentRequestProjectSettingsFramework.Nextjs => "nextjs",
                CreateDeploymentRequestProjectSettingsFramework.Nitro => "nitro",
                CreateDeploymentRequestProjectSettingsFramework.Node => "node",
                CreateDeploymentRequestProjectSettingsFramework.Nuxtjs => "nuxtjs",
                CreateDeploymentRequestProjectSettingsFramework.Parcel => "parcel",
                CreateDeploymentRequestProjectSettingsFramework.Polymer => "polymer",
                CreateDeploymentRequestProjectSettingsFramework.Preact => "preact",
                CreateDeploymentRequestProjectSettingsFramework.Python => "python",
                CreateDeploymentRequestProjectSettingsFramework.ReactRouter => "react-router",
                CreateDeploymentRequestProjectSettingsFramework.Redwoodjs => "redwoodjs",
                CreateDeploymentRequestProjectSettingsFramework.Remix => "remix",
                CreateDeploymentRequestProjectSettingsFramework.Ruby => "ruby",
                CreateDeploymentRequestProjectSettingsFramework.Rust => "rust",
                CreateDeploymentRequestProjectSettingsFramework.Saber => "saber",
                CreateDeploymentRequestProjectSettingsFramework.Sanity => "sanity",
                CreateDeploymentRequestProjectSettingsFramework.SanityV3 => "sanity-v3",
                CreateDeploymentRequestProjectSettingsFramework.Sapper => "sapper",
                CreateDeploymentRequestProjectSettingsFramework.Scully => "scully",
                CreateDeploymentRequestProjectSettingsFramework.Services => "services",
                CreateDeploymentRequestProjectSettingsFramework.Solidstart => "solidstart",
                CreateDeploymentRequestProjectSettingsFramework.Solidstart1 => "solidstart-1",
                CreateDeploymentRequestProjectSettingsFramework.Stencil => "stencil",
                CreateDeploymentRequestProjectSettingsFramework.Storybook => "storybook",
                CreateDeploymentRequestProjectSettingsFramework.Svelte => "svelte",
                CreateDeploymentRequestProjectSettingsFramework.Sveltekit => "sveltekit",
                CreateDeploymentRequestProjectSettingsFramework.Sveltekit1 => "sveltekit-1",
                CreateDeploymentRequestProjectSettingsFramework.TanstackStart => "tanstack-start",
                CreateDeploymentRequestProjectSettingsFramework.Umijs => "umijs",
                CreateDeploymentRequestProjectSettingsFramework.Vite => "vite",
                CreateDeploymentRequestProjectSettingsFramework.Vitepress => "vitepress",
                CreateDeploymentRequestProjectSettingsFramework.Vue => "vue",
                CreateDeploymentRequestProjectSettingsFramework.Vuepress => "vuepress",
                CreateDeploymentRequestProjectSettingsFramework.Xmcp => "xmcp",
                CreateDeploymentRequestProjectSettingsFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestProjectSettingsFramework? ToEnum(string value)
        {
            return value switch
            {
                "angular" => CreateDeploymentRequestProjectSettingsFramework.Angular,
                "astro" => CreateDeploymentRequestProjectSettingsFramework.Astro,
                "blitzjs" => CreateDeploymentRequestProjectSettingsFramework.Blitzjs,
                "brunch" => CreateDeploymentRequestProjectSettingsFramework.Brunch,
                "create-react-app" => CreateDeploymentRequestProjectSettingsFramework.CreateReactApp,
                "django" => CreateDeploymentRequestProjectSettingsFramework.Django,
                "docusaurus" => CreateDeploymentRequestProjectSettingsFramework.Docusaurus,
                "docusaurus-2" => CreateDeploymentRequestProjectSettingsFramework.Docusaurus2,
                "dojo" => CreateDeploymentRequestProjectSettingsFramework.Dojo,
                "eleventy" => CreateDeploymentRequestProjectSettingsFramework.Eleventy,
                "elysia" => CreateDeploymentRequestProjectSettingsFramework.Elysia,
                "ember" => CreateDeploymentRequestProjectSettingsFramework.Ember,
                "express" => CreateDeploymentRequestProjectSettingsFramework.Express,
                "fastapi" => CreateDeploymentRequestProjectSettingsFramework.Fastapi,
                "fasthtml" => CreateDeploymentRequestProjectSettingsFramework.Fasthtml,
                "fastify" => CreateDeploymentRequestProjectSettingsFramework.Fastify,
                "flask" => CreateDeploymentRequestProjectSettingsFramework.Flask,
                "gatsby" => CreateDeploymentRequestProjectSettingsFramework.Gatsby,
                "go" => CreateDeploymentRequestProjectSettingsFramework.Go,
                "gridsome" => CreateDeploymentRequestProjectSettingsFramework.Gridsome,
                "h3" => CreateDeploymentRequestProjectSettingsFramework.H3,
                "hexo" => CreateDeploymentRequestProjectSettingsFramework.Hexo,
                "hono" => CreateDeploymentRequestProjectSettingsFramework.Hono,
                "hugo" => CreateDeploymentRequestProjectSettingsFramework.Hugo,
                "hydrogen" => CreateDeploymentRequestProjectSettingsFramework.Hydrogen,
                "ionic-angular" => CreateDeploymentRequestProjectSettingsFramework.IonicAngular,
                "ionic-react" => CreateDeploymentRequestProjectSettingsFramework.IonicReact,
                "jekyll" => CreateDeploymentRequestProjectSettingsFramework.Jekyll,
                "koa" => CreateDeploymentRequestProjectSettingsFramework.Koa,
                "mastra" => CreateDeploymentRequestProjectSettingsFramework.Mastra,
                "middleman" => CreateDeploymentRequestProjectSettingsFramework.Middleman,
                "nestjs" => CreateDeploymentRequestProjectSettingsFramework.Nestjs,
                "nextjs" => CreateDeploymentRequestProjectSettingsFramework.Nextjs,
                "nitro" => CreateDeploymentRequestProjectSettingsFramework.Nitro,
                "node" => CreateDeploymentRequestProjectSettingsFramework.Node,
                "nuxtjs" => CreateDeploymentRequestProjectSettingsFramework.Nuxtjs,
                "parcel" => CreateDeploymentRequestProjectSettingsFramework.Parcel,
                "polymer" => CreateDeploymentRequestProjectSettingsFramework.Polymer,
                "preact" => CreateDeploymentRequestProjectSettingsFramework.Preact,
                "python" => CreateDeploymentRequestProjectSettingsFramework.Python,
                "react-router" => CreateDeploymentRequestProjectSettingsFramework.ReactRouter,
                "redwoodjs" => CreateDeploymentRequestProjectSettingsFramework.Redwoodjs,
                "remix" => CreateDeploymentRequestProjectSettingsFramework.Remix,
                "ruby" => CreateDeploymentRequestProjectSettingsFramework.Ruby,
                "rust" => CreateDeploymentRequestProjectSettingsFramework.Rust,
                "saber" => CreateDeploymentRequestProjectSettingsFramework.Saber,
                "sanity" => CreateDeploymentRequestProjectSettingsFramework.Sanity,
                "sanity-v3" => CreateDeploymentRequestProjectSettingsFramework.SanityV3,
                "sapper" => CreateDeploymentRequestProjectSettingsFramework.Sapper,
                "scully" => CreateDeploymentRequestProjectSettingsFramework.Scully,
                "services" => CreateDeploymentRequestProjectSettingsFramework.Services,
                "solidstart" => CreateDeploymentRequestProjectSettingsFramework.Solidstart,
                "solidstart-1" => CreateDeploymentRequestProjectSettingsFramework.Solidstart1,
                "stencil" => CreateDeploymentRequestProjectSettingsFramework.Stencil,
                "storybook" => CreateDeploymentRequestProjectSettingsFramework.Storybook,
                "svelte" => CreateDeploymentRequestProjectSettingsFramework.Svelte,
                "sveltekit" => CreateDeploymentRequestProjectSettingsFramework.Sveltekit,
                "sveltekit-1" => CreateDeploymentRequestProjectSettingsFramework.Sveltekit1,
                "tanstack-start" => CreateDeploymentRequestProjectSettingsFramework.TanstackStart,
                "umijs" => CreateDeploymentRequestProjectSettingsFramework.Umijs,
                "vite" => CreateDeploymentRequestProjectSettingsFramework.Vite,
                "vitepress" => CreateDeploymentRequestProjectSettingsFramework.Vitepress,
                "vue" => CreateDeploymentRequestProjectSettingsFramework.Vue,
                "vuepress" => CreateDeploymentRequestProjectSettingsFramework.Vuepress,
                "xmcp" => CreateDeploymentRequestProjectSettingsFramework.Xmcp,
                "zola" => CreateDeploymentRequestProjectSettingsFramework.Zola,
                _ => null,
            };
        }
    }
}