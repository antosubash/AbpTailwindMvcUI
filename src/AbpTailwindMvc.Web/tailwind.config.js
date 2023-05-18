module.exports = {
  content: [
    '!**/{bin,obj,node_modules}/**',
    '**/*.{html,cshtml}',
    "./../../modules/Volo.BasicTheme/src/Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic/Themes/Basic/Components/**/*.cshtml",
    "./../../modules/Volo.BasicTheme/src/Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic/Themes/Basic/Layouts/*.cshtml",
  ],
  important: true,
  theme: {
    extend: {},
  },
  corePlugins: {
    preflight: false,
  },
  plugins: [],
}