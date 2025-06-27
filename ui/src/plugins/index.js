/**
 * plugins/index.js
 *
 * Automatically included in `./src/main.js`
 */
//Plugins
import vuetify from './vuetify'
import router from '@/router'
import VueGoodTablePlugin from 'vue-good-table-next'
import 'vue-good-table-next/dist/vue-good-table-next.css';
import { createPinia } from 'pinia'

export function registerPlugins (app) {
  app
    .use(vuetify)
    .use(router)
    .use(VueGoodTablePlugin)
    .use(createPinia())
}
