module.exports = {
  content: [
    '!**/{bin,obj,node_modules}/**',
    '**/*.{html,cshtml}',
    "../../**/*.{html,cshtml}"
  ],
  theme: {
    extend: {},
  },
  corePlugins: {
    preflight: false,
  },
  plugins: [],
}