<template>
  <v-app>
    <!-- Sticky Navigation Bar -->
    <v-app-bar app color="white" elevate-on-scroll>
      <v-container class="d-flex align-center">
        <v-btn text to="/" class="text-h6 font-weight-bold">A.I. Meal Planner</v-btn>
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

     <!-- ALT Testimonials -->
     <v-container class="py-12 px-6 bg-gray-800 text-white">
      <h2 class="text-2xl font-bold text-center mb-8">What Our Users Say</h2>
      <div class="grid grid-cols-1 md:grid-cols-2 gap-8">
        <div class="flex items-center space-x-4 bg-gray-700 p-6 rounded-md">
          <img src="../assets/images/users/user2.jpg" alt="User 1" class="w-16 h-16 rounded-full" />
          <div>
            <p>"Eat This Much helped me stay on track with my goals!"</p>
            <p class="text-sm mt-2">- Satisfied User</p>
          </div>
        </div>
        <div class="flex items-center space-x-4 bg-gray-700 p-6 rounded-md">
          <img src="../assets/images/users/user1.jpg" alt="User 2" class="w-16 h-16 rounded-full" />
          <div>
            <p>"This app takes the guesswork out of meal planning!"</p>
            <p class="text-sm mt-2">- Another User</p>
          </div>
        </div>
        <div class="flex items-center space-x-4 bg-gray-700 p-6 rounded-md">
          <img src="../assets/images/users/user3.jpg" alt="User 3" class="w-16 h-16 rounded-full" />
          <div>
            <p>"I've saved so much time and money using this app!"</p>
            <p class="text-sm mt-2">- Happy Customer</p>
          </div>
        </div>
        <div class="flex items-center space-x-4 bg-gray-700 p-6 rounded-md">
          <img src="../assets/images/users/user4.jpg" alt="User 4" class="w-16 h-16 rounded-full" />
          <div>
            <p>"It's like having a personal nutritionist in my pocket!"</p>
            <p class="text-sm mt-2">- Fitness Enthusiast</p>
          </div>
        </div>
      </div>
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
    <!-- Footer -->
    <footer class="py-6 bg-gray-900 text-white text-center">
      <p>&copy; 2024 Eat This Much Clone. All rights reserved.</p>
    </footer>
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
  router.push("/app/register");
};
</script>

<style scoped>
.bg-gradient {
  background: linear-gradient(to right, #3f51b5, #673ab7);
}
</style>
