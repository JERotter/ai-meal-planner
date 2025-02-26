import { defineStore } from 'pinia';

export const useUsersStore = defineStore('users', {
  state: () => ({
    counter: 0,
  }),
  actions: {
    increment() {
      this.counter++;
    },
  },
});
