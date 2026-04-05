
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseProjectSettingsFramework
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
    public static class CreateDeploymentResponseProjectSettingsFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseProjectSettingsFramework value)
        {
            return value switch
            {
                CreateDeploymentResponseProjectSettingsFramework.Angular => "angular",
                CreateDeploymentResponseProjectSettingsFramework.Astro => "astro",
                CreateDeploymentResponseProjectSettingsFramework.Blitzjs => "blitzjs",
                CreateDeploymentResponseProjectSettingsFramework.Brunch => "brunch",
                CreateDeploymentResponseProjectSettingsFramework.CreateReactApp => "create-react-app",
                CreateDeploymentResponseProjectSettingsFramework.Django => "django",
                CreateDeploymentResponseProjectSettingsFramework.Docusaurus => "docusaurus",
                CreateDeploymentResponseProjectSettingsFramework.Docusaurus2 => "docusaurus-2",
                CreateDeploymentResponseProjectSettingsFramework.Dojo => "dojo",
                CreateDeploymentResponseProjectSettingsFramework.Eleventy => "eleventy",
                CreateDeploymentResponseProjectSettingsFramework.Elysia => "elysia",
                CreateDeploymentResponseProjectSettingsFramework.Ember => "ember",
                CreateDeploymentResponseProjectSettingsFramework.Express => "express",
                CreateDeploymentResponseProjectSettingsFramework.Fastapi => "fastapi",
                CreateDeploymentResponseProjectSettingsFramework.Fasthtml => "fasthtml",
                CreateDeploymentResponseProjectSettingsFramework.Fastify => "fastify",
                CreateDeploymentResponseProjectSettingsFramework.Flask => "flask",
                CreateDeploymentResponseProjectSettingsFramework.Gatsby => "gatsby",
                CreateDeploymentResponseProjectSettingsFramework.Go => "go",
                CreateDeploymentResponseProjectSettingsFramework.Gridsome => "gridsome",
                CreateDeploymentResponseProjectSettingsFramework.H3 => "h3",
                CreateDeploymentResponseProjectSettingsFramework.Hexo => "hexo",
                CreateDeploymentResponseProjectSettingsFramework.Hono => "hono",
                CreateDeploymentResponseProjectSettingsFramework.Hugo => "hugo",
                CreateDeploymentResponseProjectSettingsFramework.Hydrogen => "hydrogen",
                CreateDeploymentResponseProjectSettingsFramework.IonicAngular => "ionic-angular",
                CreateDeploymentResponseProjectSettingsFramework.IonicReact => "ionic-react",
                CreateDeploymentResponseProjectSettingsFramework.Jekyll => "jekyll",
                CreateDeploymentResponseProjectSettingsFramework.Koa => "koa",
                CreateDeploymentResponseProjectSettingsFramework.Middleman => "middleman",
                CreateDeploymentResponseProjectSettingsFramework.Nestjs => "nestjs",
                CreateDeploymentResponseProjectSettingsFramework.Nextjs => "nextjs",
                CreateDeploymentResponseProjectSettingsFramework.Nitro => "nitro",
                CreateDeploymentResponseProjectSettingsFramework.Node => "node",
                CreateDeploymentResponseProjectSettingsFramework.Nuxtjs => "nuxtjs",
                CreateDeploymentResponseProjectSettingsFramework.Parcel => "parcel",
                CreateDeploymentResponseProjectSettingsFramework.Polymer => "polymer",
                CreateDeploymentResponseProjectSettingsFramework.Preact => "preact",
                CreateDeploymentResponseProjectSettingsFramework.Python => "python",
                CreateDeploymentResponseProjectSettingsFramework.ReactRouter => "react-router",
                CreateDeploymentResponseProjectSettingsFramework.Redwoodjs => "redwoodjs",
                CreateDeploymentResponseProjectSettingsFramework.Remix => "remix",
                CreateDeploymentResponseProjectSettingsFramework.Ruby => "ruby",
                CreateDeploymentResponseProjectSettingsFramework.Rust => "rust",
                CreateDeploymentResponseProjectSettingsFramework.Saber => "saber",
                CreateDeploymentResponseProjectSettingsFramework.Sanity => "sanity",
                CreateDeploymentResponseProjectSettingsFramework.SanityV3 => "sanity-v3",
                CreateDeploymentResponseProjectSettingsFramework.Sapper => "sapper",
                CreateDeploymentResponseProjectSettingsFramework.Scully => "scully",
                CreateDeploymentResponseProjectSettingsFramework.Services => "services",
                CreateDeploymentResponseProjectSettingsFramework.Solidstart => "solidstart",
                CreateDeploymentResponseProjectSettingsFramework.Solidstart1 => "solidstart-1",
                CreateDeploymentResponseProjectSettingsFramework.Stencil => "stencil",
                CreateDeploymentResponseProjectSettingsFramework.Storybook => "storybook",
                CreateDeploymentResponseProjectSettingsFramework.Svelte => "svelte",
                CreateDeploymentResponseProjectSettingsFramework.Sveltekit => "sveltekit",
                CreateDeploymentResponseProjectSettingsFramework.Sveltekit1 => "sveltekit-1",
                CreateDeploymentResponseProjectSettingsFramework.TanstackStart => "tanstack-start",
                CreateDeploymentResponseProjectSettingsFramework.Umijs => "umijs",
                CreateDeploymentResponseProjectSettingsFramework.Vite => "vite",
                CreateDeploymentResponseProjectSettingsFramework.Vitepress => "vitepress",
                CreateDeploymentResponseProjectSettingsFramework.Vue => "vue",
                CreateDeploymentResponseProjectSettingsFramework.Vuepress => "vuepress",
                CreateDeploymentResponseProjectSettingsFramework.Xmcp => "xmcp",
                CreateDeploymentResponseProjectSettingsFramework.Zola => "zola",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseProjectSettingsFramework? ToEnum(string value)
        {
            return value switch
            {
                "angular" => CreateDeploymentResponseProjectSettingsFramework.Angular,
                "astro" => CreateDeploymentResponseProjectSettingsFramework.Astro,
                "blitzjs" => CreateDeploymentResponseProjectSettingsFramework.Blitzjs,
                "brunch" => CreateDeploymentResponseProjectSettingsFramework.Brunch,
                "create-react-app" => CreateDeploymentResponseProjectSettingsFramework.CreateReactApp,
                "django" => CreateDeploymentResponseProjectSettingsFramework.Django,
                "docusaurus" => CreateDeploymentResponseProjectSettingsFramework.Docusaurus,
                "docusaurus-2" => CreateDeploymentResponseProjectSettingsFramework.Docusaurus2,
                "dojo" => CreateDeploymentResponseProjectSettingsFramework.Dojo,
                "eleventy" => CreateDeploymentResponseProjectSettingsFramework.Eleventy,
                "elysia" => CreateDeploymentResponseProjectSettingsFramework.Elysia,
                "ember" => CreateDeploymentResponseProjectSettingsFramework.Ember,
                "express" => CreateDeploymentResponseProjectSettingsFramework.Express,
                "fastapi" => CreateDeploymentResponseProjectSettingsFramework.Fastapi,
                "fasthtml" => CreateDeploymentResponseProjectSettingsFramework.Fasthtml,
                "fastify" => CreateDeploymentResponseProjectSettingsFramework.Fastify,
                "flask" => CreateDeploymentResponseProjectSettingsFramework.Flask,
                "gatsby" => CreateDeploymentResponseProjectSettingsFramework.Gatsby,
                "go" => CreateDeploymentResponseProjectSettingsFramework.Go,
                "gridsome" => CreateDeploymentResponseProjectSettingsFramework.Gridsome,
                "h3" => CreateDeploymentResponseProjectSettingsFramework.H3,
                "hexo" => CreateDeploymentResponseProjectSettingsFramework.Hexo,
                "hono" => CreateDeploymentResponseProjectSettingsFramework.Hono,
                "hugo" => CreateDeploymentResponseProjectSettingsFramework.Hugo,
                "hydrogen" => CreateDeploymentResponseProjectSettingsFramework.Hydrogen,
                "ionic-angular" => CreateDeploymentResponseProjectSettingsFramework.IonicAngular,
                "ionic-react" => CreateDeploymentResponseProjectSettingsFramework.IonicReact,
                "jekyll" => CreateDeploymentResponseProjectSettingsFramework.Jekyll,
                "koa" => CreateDeploymentResponseProjectSettingsFramework.Koa,
                "middleman" => CreateDeploymentResponseProjectSettingsFramework.Middleman,
                "nestjs" => CreateDeploymentResponseProjectSettingsFramework.Nestjs,
                "nextjs" => CreateDeploymentResponseProjectSettingsFramework.Nextjs,
                "nitro" => CreateDeploymentResponseProjectSettingsFramework.Nitro,
                "node" => CreateDeploymentResponseProjectSettingsFramework.Node,
                "nuxtjs" => CreateDeploymentResponseProjectSettingsFramework.Nuxtjs,
                "parcel" => CreateDeploymentResponseProjectSettingsFramework.Parcel,
                "polymer" => CreateDeploymentResponseProjectSettingsFramework.Polymer,
                "preact" => CreateDeploymentResponseProjectSettingsFramework.Preact,
                "python" => CreateDeploymentResponseProjectSettingsFramework.Python,
                "react-router" => CreateDeploymentResponseProjectSettingsFramework.ReactRouter,
                "redwoodjs" => CreateDeploymentResponseProjectSettingsFramework.Redwoodjs,
                "remix" => CreateDeploymentResponseProjectSettingsFramework.Remix,
                "ruby" => CreateDeploymentResponseProjectSettingsFramework.Ruby,
                "rust" => CreateDeploymentResponseProjectSettingsFramework.Rust,
                "saber" => CreateDeploymentResponseProjectSettingsFramework.Saber,
                "sanity" => CreateDeploymentResponseProjectSettingsFramework.Sanity,
                "sanity-v3" => CreateDeploymentResponseProjectSettingsFramework.SanityV3,
                "sapper" => CreateDeploymentResponseProjectSettingsFramework.Sapper,
                "scully" => CreateDeploymentResponseProjectSettingsFramework.Scully,
                "services" => CreateDeploymentResponseProjectSettingsFramework.Services,
                "solidstart" => CreateDeploymentResponseProjectSettingsFramework.Solidstart,
                "solidstart-1" => CreateDeploymentResponseProjectSettingsFramework.Solidstart1,
                "stencil" => CreateDeploymentResponseProjectSettingsFramework.Stencil,
                "storybook" => CreateDeploymentResponseProjectSettingsFramework.Storybook,
                "svelte" => CreateDeploymentResponseProjectSettingsFramework.Svelte,
                "sveltekit" => CreateDeploymentResponseProjectSettingsFramework.Sveltekit,
                "sveltekit-1" => CreateDeploymentResponseProjectSettingsFramework.Sveltekit1,
                "tanstack-start" => CreateDeploymentResponseProjectSettingsFramework.TanstackStart,
                "umijs" => CreateDeploymentResponseProjectSettingsFramework.Umijs,
                "vite" => CreateDeploymentResponseProjectSettingsFramework.Vite,
                "vitepress" => CreateDeploymentResponseProjectSettingsFramework.Vitepress,
                "vue" => CreateDeploymentResponseProjectSettingsFramework.Vue,
                "vuepress" => CreateDeploymentResponseProjectSettingsFramework.Vuepress,
                "xmcp" => CreateDeploymentResponseProjectSettingsFramework.Xmcp,
                "zola" => CreateDeploymentResponseProjectSettingsFramework.Zola,
                _ => null,
            };
        }
    }
}