
/**
 * router/index.ts
 *
 * Automatic routes for `./src/pages/*.vue`
 */

// Composables
//TODO:import { useAuth } from '@/store/auth'; // Import your auth store or use `localStorage`
import { createRouter, createWebHistory } from 'vue-router/auto'
import { routes } from 'vue-router/auto-routes'
// import { isAuthenticated } from '@/stores/auth'; // Tracks auth state

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes,
})

// Workaround for https://github.com/vitejs/vite/issues/11804
router.onError((err, to) => {
  if (err?.message?.includes?.('Failed to fetch dynamically imported module')) {
    if (!localStorage.getItem('vuetify:dynamic-reload')) {
      console.log('Reloading page to fix dynamic import error')
      localStorage.setItem('vuetify:dynamic-reload', 'true')
      location.assign(to.fullPath)
    } else {
      console.error('Dynamic import error, reloading page did not fix it', err)
    }
  } else {
    console.error(err)
  }
})

router.isReady().then(() => {
  localStorage.removeItem('vuetify:dynamic-reload')
})

//idk
// // Global Navigation Guard
// router.beforeEach((to, from, next) => {
//   // Check if the route requires authentication
//   if (to.meta.requiresAuth && !isAuthenticated.value) {
//     next('/login'); // Redirect to login page
//   } else {
//     next(); // Allow navigation
//   }
// });
//idk

// Global guard to handle login redirection
router.beforeEach((to, from, next) => {
  //const auth = useAuth(); // Or use localStorage: Boolean(localStorage.getItem('user'))
  //const isAuthenticated = auth.isLoggedIn || Boolean(localStorage.getItem('user'));
  const isAuthenticated = false; //until Auth has been implemented

  // Redirect if trying to access a restricted page without authentication
  if (to.path === '/dashboard' && !isAuthenticated) {
    next('/login');
  } else if (to.path === '/' && !isAuthenticated) {
    next('/login');
  } else if (to.path === '/login' && isAuthenticated) { //when navigating abck but still logged in
    next('/dashboard');
  }
  else {
    next();
  }
});

export default router
