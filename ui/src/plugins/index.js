/**
 * plugins/index.js
 *
 * Automatically included in `./src/main.js`
 */
//Plugins
import vuetify from './vuetify'
import router from '@/router'
import VueGoodTablePlugin from 'vue-good-table'
import 'vue-good-table/dist/vue-good-table.css'
import { createPinia } from 'pinia'

export function registerPlugins (app) {
  app
    .use(vuetify)
    .use(router)
    .use(VueGoodTablePlugin)
    .use(createPinia())
}
