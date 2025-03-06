import { defineStore } from 'pinia';
import axios from 'axios';

export const useUserStore = defineStore('user', {
  state: () => ({
    users: [],
    loading: false,
    error: null,
  }),
  actions: {
    async fetchUsers() {
      this.loading = true
      try {
        const response = await axios.get('https://localhost:5001/User')
        this.users = response.data
      } catch (err) {
        this.error = err.message
      } finally {
        this.loading = false
      }
    }
  }
})

// export const useUsersStore = defineStore('users', {
//   state: () => ({
//     counter: 0,
//   }),
//   actions: {
//     increment() {
//       this.counter++;
//     },
//   },
// });
