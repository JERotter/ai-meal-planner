<template>
  <v-app>
    <v-main>
      <v-container class="d-flex align-center justify-center fill-height bg-primary">
        <v-card class="register-card" elevation="10">
          <v-card-title class="text-center">🌶️ Peri~Peri A.I. Meal Planner 🌶️</v-card-title>
          <v-card-subtitle class="text-center">Create a new account</v-card-subtitle>

          <v-card-text>
            <v-form>
              <v-text-field
                label="Full Name"
                v-model="name"
                prepend-icon="mdi-account"
                color="accent"
                class="input-field"
                required
              ></v-text-field>

              <v-text-field
                label="Email"
                v-model="email"
                prepend-icon="mdi-email"
                color="accent"
                type="email"
                class="input-field"
                required
              ></v-text-field>

              <v-text-field
                label="Password"
                v-model="password"
                prepend-icon="mdi-lock"
                color="accent"
                type="password"
                class="input-field"
                required
              ></v-text-field>

              <v-text-field
                label="Confirm Password"
                v-model="confirmPassword"
                prepend-icon="mdi-lock-check"
                color="accent"
                type="password"
                class="input-field"
                required
              ></v-text-field>

              <v-btn @click="register" :loading="loading" color="accent" block>
                Sign Up
              </v-btn>

              <v-divider class="my-4"></v-divider>

              <v-btn color="accent" outlined block @click="registerWithGoogle">
                <v-icon left>mdi-google</v-icon> Sign Up with Google
              </v-btn>
            </v-form>
          </v-card-text>

          <v-card-actions class="justify-center">
            <small>
              Already have an account?
              <a href="/login" class="text-accent">Log in</a>
            </small>
          </v-card-actions>
        </v-card>
      </v-container>
    </v-main>
  </v-app>
</template>

<script setup>
import { ref } from 'vue';

const name = ref('');
const email = ref('');
const password = ref('');
const confirmPassword = ref('');
const loading = ref(false);

function register() {
  if (password.value !== confirmPassword.value) {
    alert("Passwords don't match");
    return;
  }

  loading.value = true;
  setTimeout(() => {
    loading.value = false;
    alert('Account created successfully');
  }, 1000);
}

function registerWithGoogle() {
  alert('Redirecting to Google registration...');
}
</script>

<style scoped>
.register-card {
  max-width: 400px;
  padding: 24px;
  background-color: var(--v-theme-surface); /* Dark surface color */
}

.input-field {
  background-color: var(--v-theme-background); /* Dark background for inputs */
}

.v-btn {
  background-color: var(--v-theme-accent); /* Bright accent color for buttons */
  color: var(--v-theme-background); /* Text color for contrast */
}
</style>
