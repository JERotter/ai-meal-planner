<template>
  <v-app>
    <v-main>
      <v-container class="d-flex align-center justify-center fill-height bg-primary">
        <v-card class="login-card" elevation="10">
          <v-card-title class="text-center">🌶️ Peri~Peri A.I. Meal Planner 🌶️</v-card-title>
          <v-card-subtitle class="text-center">Log in to your account</v-card-subtitle>

          <v-card-text>
            <v-form @submit.prevent="handleSubmit" ref="form">
              <v-text-field
                v-model="email"
                label="Email"
                prepend-icon="mdi-email"
                color="accent"
                type="email"
                class="input-field"
                :rules="[validateEmail]"
                required
              ></v-text-field>

              <v-text-field
                v-model="password"
                label="Password"
                prepend-icon="mdi-lock"
                color="accent"
                type="password"
                class="input-field"
                :rules="[validatePassword]"
                required
              ></v-text-field>

              <v-btn @click="handleSubmit" :loading="loading" color="accent" block>
                Log In
              </v-btn>

              <v-divider class="my-4"></v-divider>

              <v-btn color="accent" outlined block @click="loginWithGoogle">
                <v-icon left>mdi-google</v-icon> Log In with Google
              </v-btn>
            </v-form>
          </v-card-text>

          <v-card-actions class="justify-center">
            <small class="text-primary2">
              Don't have an account?
              <a href="/register" class="text-accent">Sign up</a>
            </small>
          </v-card-actions>
        </v-card>
      </v-container>
    </v-main>
  </v-app>
</template>

<script setup>
import { ref } from 'vue';
import { useRouter } from 'vue-router';
import { useAuthStore } from '@/stores/auth';

const email = ref('');
const password = ref('');
const loading = ref(false);
const form = ref(null);
const router = useRouter();

// Hardcoded credentials for comparison
const validEmail = 'user@example.com';
const validAdminEmail = 'admin@example.com';
const validPassword = 'securepassword';

// Validation rules
const validateEmail = (value) => {
  const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  return emailPattern.test(value) || 'Invalid email format';
};

const validatePassword = (value) => {
  return value.length > 0 || 'Password cannot be empty';
};

function handleSubmit() {
  if (form.value.validate()) {
    loading.value = true;
    setTimeout(() => {
      loading.value = false;
      if (email.value === validEmail && password.value === validPassword) {
        alert('Logged in successfully');
        const authStore = useAuthStore();
        authStore.logIn();
        router.push('/dashboard'); // Redirect to /dashboard upon success for all non admin users
      } else if (email.value === validAdminEmail && password.value === validPassword) {
        alert('Logged in successfully');
        const authStore = useAuthStore();
        authStore.logIn();
        router.push('/admin'); // Redirect to /admin
      }else {
        alert('Invalid email or password. Please try again.');
      }
    }, 1000);
  } else {
    alert('Please fix the validation errors before proceeding.');
  }
}

function loginWithGoogle() {
  alert('Redirecting to Google login...');
}
</script>

<style scoped>
.login-card {
  max-width: 400px;
  padding: 24px;
  background-color: var(--v-theme-surface);
}

.input-field {
  background-color: var(--v-theme-background);
}

.text-primary {
  color: var(--v-theme-textPrimary);
}

.text-secondary {
  color: var(--v-theme-textSecondary);
}

.text-accent {
  color: var(--v-theme-accent);
}

.v-btn {
  background-color: var(--v-theme-accent);
  color: var(--v-theme-background);
}
</style>
