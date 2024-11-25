<template>
  <v-app>
    <v-main>
      <router-view />
    </v-main>
  </v-app>
</template>

<script setup>
  //
</script>

<!-- needs halp to use stores-->
<!-- <template>
  <v-app>
    <v-main>
      <v-container>
        <h1>Welcome to My Vuetify Project with Pinia!</h1>
        <v-btn @click="incrementCounter" color="primary">Increment Counter</v-btn>
        <p>Counter: {{ counter }}</p>
      </v-container>
    </v-main>
  </v-app>
</template>

<script setup>
import { useUsersStore } from './stores/users.js';
import { computed } from 'vue';

const store = useUsersStore();
const counter = computed(() => store.counter);

function incrementCounter() {
  store.increment();
}
</script> -->
