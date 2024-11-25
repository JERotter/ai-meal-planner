<!-- <template>
  <v-app>
    <v-main>
      <v-container class="d-flex align-center justify-center fill-height">
        <v-card class="register-card cozy-card" elevation="10">
          <v-card-title class="text-center">
            <h2 class="text-cozy-primary">AI Meal Planner</h2>
          </v-card-title>
          <v-card-subtitle class="text-center">Create a new account</v-card-subtitle>

          <v-card-text>
            <v-form>
              <v-text-field
                label="Full Name"
                v-model="name"
                prepend-icon="mdi-account"
                color="cozy-input"
                required
              ></v-text-field>

              <v-text-field
                label="Email"
                v-model="email"
                prepend-icon="mdi-email"
                type="email"
                color="cozy-input"
                required
              ></v-text-field>

              <v-text-field
                label="Password"
                v-model="password"
                prepend-icon="mdi-lock"
                type="password"
                color="cozy-input"
                required
              ></v-text-field>

              <v-text-field
                label="Confirm Password"
                v-model="confirmPassword"
                prepend-icon="mdi-lock-check"
                type="password"
                color="cozy-input"
                required
              ></v-text-field>

              <v-btn @click="register" :loading="loading" color="cozy-primary" block>
                Sign Up
              </v-btn>

              <v-divider class="my-4"></v-divider>

              <v-btn color="cozy-secondary" outlined block @click="registerWithGoogle">
                <v-icon left>mdi-google</v-icon> Sign Up with Google
              </v-btn>
            </v-form>
          </v-card-text>

          <v-card-actions class="justify-center">
            <small>
              Already have an account?
              <a href="/login" class="text-cozy-link">Log in</a>
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
}

.v-container {
  min-height: 100vh;
  background: linear-gradient(135deg, #f4eeed, #efd9d1);
}

.cozy-card {
  background-color: #f4eeed; /* Soft, cozy white background */
}

.text-cozy-primary {
  color: #a17f7a; /* Warm, muted brown */
}

.cozy-primary {
  background-color: #999b84; /* Soft green-gray */
  color: #fff;
}

.cozy-secondary {
  border-color: #ddb7ab; /* Muted coral outline for secondary button */
  color: #a17f7a;
}

.text-cozy-link {
  color: #a17f7a; /* Warm brown for link */
}

.cozy-input .v-input__control .v-input__slot {
  background-color: #efd9d1; /* Light peach for input backgrounds */
  border-color: #ddb7ab;
}

.v-btn--cozy-primary:hover {
  background-color: #999b84; /* Slightly darker green-gray for button hover */
}
</style> -->

<template>
  <v-app>
    <v-main>
      <v-container class="d-flex align-center justify-center fill-height bg-primary">
        <v-card class="register-card" elevation="10">
          <v-card-title class="text-center">AI Meal Planner</v-card-title>
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
