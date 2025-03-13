<template>
  <div>
    <!-- Sticky Navigation Bar -->
    <v-app-bar app color="white" elevate-on-scroll>
      <v-container class="d-flex align-center">
        <v-btn to="/" class="pa-0" height= "150" width="150" style="color:white">
          <v-img src="@/assets/logo-black.png" alt="A.I. Meal Planner Logo" contain />
        </v-btn>

        <v-spacer></v-spacer>
        <v-btn text @click="scrollTo('how-it-works')">How It Works</v-btn>
        <v-btn text @click="scrollTo('testimonials')">Testimonials</v-btn>
        <v-btn text to="/pricing">Pricing</v-btn>
        <v-btn text to="/about">About</v-btn>
        <v-btn color="primary" to="/app/register" class="ml-3">Sign Up</v-btn>
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
            <p class="text-body-2">Get customized A.I.-generated meal plans in seconds.</p>
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

    <!-- ALT Testimonials -->
    <v-container class="py-12 px-6 bg-gray-800 text-white">
      <h2 class="text-2xl font-bold text-center mb-8">What Our Users Say</h2>
      <v-row class="gap-6">
        <v-col cols="12" md="6" v-for="(testimonial, index) in testimonials" :key="index">
          <v-card class="bg-gray-700 p-6 rounded-md d-flex align-center">
            <v-avatar size="256">
              <img :src="testimonial.image" :alt="testimonial.name" />
            </v-avatar>
            <div class="ml-4">
              <p class="text-white">{{ testimonial.quote }}</p>
              <p class="text-sm mt-2 text-gray-300">- {{ testimonial.name }}</p>
            </div>
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
    <v-footer class="bg-grey-darken-4 text-white justify-center py-3">
      <p>&copy; 2025 Per~Peri. All rights reserved.</p>
    </v-footer>
    <footer class="py-6 bg-gray-900 text-white text-center">
    </footer>
  </div>
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
  router.push("/app/register");
};

const testimonials = [
  {
    image: new URL("../assets/images/users/user1.jpg", import.meta.url),
    quote: "Eat This Much helped me stay on track with my goals!",
    name: "Satisfied User",
  },
  {
    image: new URL("../assets/images/users/user2.jpg", import.meta.url),
    quote: "This app takes the guesswork out of meal planning!",
    name: "Another User",
  },
  {
    image: new URL("../assets/images/users/user3.jpg", import.meta.url),
    quote: "I've saved so much time and money using this app!",
    name: "Happy Customer",
  },
  {
    image: new URL("../assets/images/users/user4.jpg", import.meta.url),
    quote: "It's like having a personal nutritionist in my pocket!",
    name: "Fitness Enthusiast",
  },
];
</script>

<style scoped>
.bg-gradient {
  background: linear-gradient(to right, #3f51b5, #673ab7);
}

.v- {
  width: 256px; /* Increased size for a more rectangular shape */
  height: 160px;
  object-fit: cover;
  border-radius: 8px;
}
.v-img {
  width: 256px; /* Increased size for a more rectangular shape */
  height: 160px;
  object-fit: cover;
  border-radius: 8px;
}
</style>
