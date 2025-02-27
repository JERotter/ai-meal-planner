<template>
  <v-app>
    <!-- Sticky Navigation Bar -->
    <v-app-bar app color="white" elevate-on-scroll>
      <v-container class="d-flex align-center">
        <v-btn text to="/" class="text-h6 font-weight-bold">SmartMealPlanner</v-btn>
        <v-spacer></v-spacer>
        <v-btn text @click="scrollTo('how-it-works')">How It Works</v-btn>
        <v-btn text @click="scrollTo('testimonials')">Testimonials</v-btn>
        <v-btn text to="/pricing">Pricing</v-btn>
        <v-btn text to="/about">About</v-btn>
        <v-btn color="primary" to="/signup" class="ml-3">Sign Up</v-btn>
      </v-container>
    </v-app-bar>

    <!-- Hero Section -->
    <v-container fluid class="text-center bg-gradient" id="hero">
      <v-row justify="center">
        <v-col cols="12" md="8">
          <h1 class="text-h3 font-weight-bold text-white">Effortless Meal Planning</h1>
          <p class="text-h6 text-white mt-3">
            Automatically generate meal plans tailored to your goals
          </p>
          <v-btn color="white" class="mt-5" @click="generateMeals">
            Generate a Meal Plan
          </v-btn>
        </v-col>
      </v-row>
    </v-container>

    <!-- How It Works Section -->
    <v-container class="py-12" id="how-it-works">
      <h2 class="text-center text-h4 font-weight-bold mb-6">How It Works</h2>
      <v-row justify="center">
        <v-col cols="12" md="4">
          <v-card class="pa-5 text-center">
            <v-icon size="50" color="primary">mdi-bullseye-arrow</v-icon>
            <h3 class="text-h6 font-weight-bold mt-3">Set Your Goals</h3>
            <p class="text-body-2">Choose your calorie intake, diet type, and preferences.</p>
          </v-card>
        </v-col>
        <v-col cols="12" md="4">
          <v-card class="pa-5 text-center">
            <v-icon size="50" color="primary">mdi-food</v-icon>
            <h3 class="text-h6 font-weight-bold mt-3">Generate Meals</h3>
            <p class="text-body-2">Get customized meal plans in seconds.</p>
          </v-card>
        </v-col>
        <v-col cols="12" md="4">
          <v-card class="pa-5 text-center">
            <v-icon size="50" color="primary">mdi-check-circle</v-icon>
            <h3 class="text-h6 font-weight-bold mt-3">Enjoy & Track</h3>
            <p class="text-body-2">Follow your plan, save favorites, and tweak as needed.</p>
          </v-card>
        </v-col>
      </v-row>
    </v-container>

    <!-- Testimonials Section -->
    <v-container class="py-12 bg-grey-lighten-3" id="testimonials">
      <h2 class="text-center text-h4 font-weight-bold mb-6">What Our Users Say</h2>
      <v-row justify="center">
        <v-col cols="12" md="5">
          <v-card class="pa-5">
            <p class="text-body-1 font-italic">
              "This made meal planning so much easier!"
            </p>
            <v-divider class="my-4"></v-divider>
            <p class="text-caption text-grey-darken-1">— Alex, Fitness Enthusiast</p>
          </v-card>
        </v-col>
        <v-col cols="12" md="5">
          <v-card class="pa-5">
            <p class="text-body-1 font-italic">
              "Saved me time and money. Highly recommend!"
            </p>
            <v-divider class="my-4"></v-divider>
            <p class="text-caption text-grey-darken-1">— Jordan, Busy Professional</p>
          </v-card>
        </v-col>
      </v-row>
    </v-container>

    <!-- Call to Action -->
    <v-container class="text-center py-12">
      <h2 class="text-h4 font-weight-bold">Ready to Eat Smarter?</h2>
      <v-btn color="primary" class="mt-4" @click="generateMeals">Get Started</v-btn>
    </v-container>

    <!-- Footer -->
    <v-footer class="bg-grey-darken-4 text-white text-center py-3">
      <p>&copy; 2024 SmartMealPlanner. All rights reserved.</p>
    </v-footer>
  </v-app>
</template>

<script setup>
import { useRouter } from "vue-router";

const router = useRouter();

// Scroll to a specific section smoothly
const scrollTo = (id) => {
  const section = document.getElementById(id);
  if (section) {
    section.scrollIntoView({ behavior: "smooth" });
  }
};

// Navigate to the meal planner page
const generateMeals = () => {
  router.push("/meal-planner");
};
</script>

<style scoped>
.bg-gradient {
  background: linear-gradient(to right, #3f51b5, #673ab7);
}
</style>
